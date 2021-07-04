using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextSearcher
{
    static class Extensions
    {
        /// <summary>
        /// 検索されたテキストに対して処理を行う（全文検索）
        /// </summary>
        /// <param name="rtb"></param>
        /// <param name="searchWord"></param>
        /// <param name="actionForSearchedWord"></param>
        public static void FindAction(this RichTextBox rtb, string searchWord, Action<RichTextBox> actionForSearchedWord)
        {
            int foundPos = -1;
            // RichTextBox既存のFind関数では最初にヒットした文字列しか返さないためループ化
            do
            {
                // 検索開始位置の設定
                foundPos = rtb.Find(searchWord, foundPos + 1, RichTextBoxFinds.MatchCase);

                // RichTextBoxに検索ワードが存在した場合、文字列を選択状態にし引数のactionを実行する
                if (foundPos >= 0)
                {
                    rtb.Select(foundPos, searchWord.Length);
                    actionForSearchedWord(rtb);
                }
                else
                {
                    // 検索ワードが存在しなかった場合、ループを抜ける
                    break;

                }

            }
            while (true);
        }
    }
}
