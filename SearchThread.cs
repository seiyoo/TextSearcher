using System;
using System.Collections.Generic;
using System.Linq;

namespace TextSearcher
{
    /// <summary>
    /// テキスト検索処理スレッド
    /// </summary>
    class SearchThread
    {
        private string[] _searchWordArray;
        private string _baseTextRtf;
        private Action<IReadOnlyCollection<string>> _callback;

        public SearchThread(string baseTextRtf, string[] searchWordArray, Action<IReadOnlyCollection<string>> callback)
        {
            _baseTextRtf = baseTextRtf;
            _searchWordArray = searchWordArray;
            _callback = callback;
        }

        public void Worker()
        {
            /*
             * RichTextBoxの状態の方がrtf形式テキストの切り出しが容易なため、
             * スレッド元からのrtfを埋め込み、元のRichTextBoxを再現する
             */
            var baseTextBox = new System.Windows.Forms.RichTextBox();
            baseTextBox.Rtf = _baseTextRtf;


            // 見つかった検索ワードに対する処理を定義
            Action<System.Windows.Forms.RichTextBox> action = rtb =>
            {
                // 背景色を黄色にする
                rtb.SelectionBackColor = System.Drawing.Color.Yellow;
            };

            // 検索ワードを含むテキスト行を絞り込む
            var foundLines = baseTextBox.Lines.ToList();
            int foundPos; 
            foreach (var searchWord in _searchWordArray)
            {
                // 検索ワードを含むテキスト行のみを次の検索候補にする
                var query = foundLines.Where(line => line.Contains(searchWord)).ToList();
                foundLines = query;

                // 検索ワードに対する処理
                baseTextBox.FindAction(searchWord, action);
            }

            /* 
             * 検索結果自体は上記処理のみで取得できるが、もとのRichTextBoxでの書式を再現するため、
             * 絞り込んだテキスト行を元にRitchTextBox上で再検索を行い、合致するrtf形式のテキストを取得する
             */
            var ret = new List<string>();
            foreach (var line in foundLines)
            {
                var matchedLine = "";
                foundPos = baseTextBox.Find(line);
                if (foundPos > -1)
                {
                    // Findしたテキスト行の文字数分を選択状態にし、抽出
                    baseTextBox.Select(foundPos, line.Length);
                    var matchedRtf = baseTextBox.SelectedRtf;

                    // 上記では改行コードが失われるため、文末に手動で埋め込む
                    int insertIndex = matchedRtf.LastIndexOf('}');
                    matchedLine = matchedRtf.Insert(insertIndex, "\\par");
                }
                ret.Add(matchedLine);
            }

            // ヒットしたテキスト行リストをスレッド元に渡す
            _callback?.Invoke(ret);
        }
    }
}
