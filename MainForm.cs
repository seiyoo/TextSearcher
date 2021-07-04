using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextSearcher
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            DefineEventHandler();

            rtbAllText.Visible = true;
            rtbSearchedText.Visible = false;
            rtbAllText.Dock = DockStyle.Fill;
            rtbSearchedText.Dock = DockStyle.Fill;
        }

        private void DefineEventHandler()
        {
            // 検索ワードをクリア
            btnClear.Click += (_, e) => { txbSearch.Clear(); };

            // 検索ワードボックスのテキストが変更されたときに検索を始める
            txbSearch.TextChanged += (_, e) => { RaiseSearchThread(); };

            #region メニューバー
            終了XToolStripMenuItem.Click += (_, e) => { this.Close(); };
            読込みRToolStripMenuItem.Click += (_, e) => { ReadTextFileAndShow(); };
            検索結果の保存SToolStripMenuItem.Click += (_, e) => { SaveResultText(); };
            #endregion

        }

        /// <summary>
        /// テキストファイルを読み込んでRichTextBoxに表示
        /// </summary>
        private void ReadTextFileAndShow()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = Environment.ExpandEnvironmentVariables("%userprofile%");
            ofd.Filter = "txtファイル(*.txt)|*.txt|rtfファイル(*.rtf)|*.rtf";
            ofd.Title = "テキストファイルを選択してください";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txbSearch.Clear();
                rtbAllText.Clear();

                using (var sr = new StreamReader(ofd.FileName,Encoding.GetEncoding("shift_jis")))
                {
                    var content = sr.ReadToEnd();

                    var ext = Path.GetExtension(ofd.FileName).ToLower();
                    switch (ext)
                    {
                        case ".txt":
                            rtbAllText.Text = content;
                            break;
                        case ".rtf":
                            rtbAllText.Rtf = content;
                            break;
                    }
                }

            }
        }

        /// <summary>
        /// 検索結果をテキストファイルに保存
        /// </summary>
        private void SaveResultText()
        {
            if (rtbSearchedText.Visible && rtbSearchedText.TextLength > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.FileName = "result.txt";
                sfd.InitialDirectory = Environment.ExpandEnvironmentVariables("%userprofile%");
                sfd.Filter = "txtファイル(*.txt)|*.txt|rtfファイル(*.rtf)|*.rtf";
                sfd.Title = "保存ファイル名を指定してください";
                sfd.RestoreDirectory = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var ext = Path.GetExtension(sfd.FileName).ToLower();
                    switch (ext)
                    {
                        case ".txt":
                            rtbSearchedText.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                            break;
                        case ".rtf":
                            rtbSearchedText.SaveFile(sfd.FileName, RichTextBoxStreamType.RichText);
                            break;
                    }

                }
            }
            else
            {
                MessageBox.Show(
                    "検索結果が存在しません",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// 全テキストから検索ワードを含むテキストのみを絞り込む
        /// </summary>
        private void RaiseSearchThread()
        {
            /* 
             * 全テキストを保持するRichTextBoxから対象のテキストのみを結果表示用RichTextBoxにコピー
             * これらをの表示状態を切り替えることで検索を再現
             */

            rtbSearchedText.Clear();
            var searchWord = txbSearch.Text;
            if (searchWord.Length == 0)
            {
                // 検索欄に文字がない場合は全テキストを表示し検索は中止
                rtbAllText.Visible = true;
                rtbSearchedText.Visible = false;
                return;
            }
            else if (searchWord.Length > 0)
            {
                // 一文字以上存在する場合に表示を切り替えて検索処理を続行
                rtbAllText.Visible = false;
                rtbSearchedText.Visible = true;
            }

            // 半角・全角スペースで検索ワードを区切る
            var searchWordArray =
                searchWord.Split(new string[] { " ", "　" }, StringSplitOptions.RemoveEmptyEntries);

            // コールバックの定義
            Action<IReadOnlyCollection<string>> callback = results =>
            {
                // 検索ワードに合致するテキスト行リストを受け取って検索結果ボックスに表示する
                rtbSearchedText.Invoke((Action)(()=> 
                {
                    rtbSearchedText.Clear();
                    foreach (var line in results)
                    {
                        rtbSearchedText.SelectedRtf = line;
                    }
                }));
            };

            // 検索スレッドの起動
            var tSearch = new SearchThread(rtbAllText.Rtf, searchWordArray, callback);
            Thread t = new Thread(new ThreadStart(tSearch.Worker));
            t.Start();
        }
    }
}
