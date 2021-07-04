
namespace TextSearcher
{
    partial class frmMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbAllText = new System.Windows.Forms.RichTextBox();
            this.tlpMainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.pnlController = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlTextContent = new System.Windows.Forms.Panel();
            this.rtbSearchedText = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.読込みRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.検索結果の保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpMainContainer.SuspendLayout();
            this.pnlController.SuspendLayout();
            this.pnlTextContent.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbAllText
            // 
            this.rtbAllText.BackColor = System.Drawing.Color.White;
            this.rtbAllText.Location = new System.Drawing.Point(17, 22);
            this.rtbAllText.Name = "rtbAllText";
            this.rtbAllText.Size = new System.Drawing.Size(200, 200);
            this.rtbAllText.TabIndex = 1;
            this.rtbAllText.Text = "";
            // 
            // tlpMainContainer
            // 
            this.tlpMainContainer.ColumnCount = 1;
            this.tlpMainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainContainer.Controls.Add(this.pnlController, 0, 1);
            this.tlpMainContainer.Controls.Add(this.pnlTextContent, 0, 2);
            this.tlpMainContainer.Controls.Add(this.menuStrip1, 0, 0);
            this.tlpMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainContainer.Location = new System.Drawing.Point(0, 0);
            this.tlpMainContainer.Name = "tlpMainContainer";
            this.tlpMainContainer.RowCount = 3;
            this.tlpMainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpMainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainContainer.Size = new System.Drawing.Size(571, 526);
            this.tlpMainContainer.TabIndex = 1;
            // 
            // pnlController
            // 
            this.pnlController.Controls.Add(this.label1);
            this.pnlController.Controls.Add(this.txbSearch);
            this.pnlController.Controls.Add(this.btnClear);
            this.pnlController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlController.Location = new System.Drawing.Point(0, 22);
            this.pnlController.Margin = new System.Windows.Forms.Padding(0);
            this.pnlController.Name = "pnlController";
            this.pnlController.Size = new System.Drawing.Size(571, 30);
            this.pnlController.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "検索";
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Meiryo UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbSearch.Location = new System.Drawing.Point(48, 3);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(322, 24);
            this.txbSearch.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Meiryo UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(373, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(31, 25);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "❌";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // pnlTextContent
            // 
            this.pnlTextContent.Controls.Add(this.rtbSearchedText);
            this.pnlTextContent.Controls.Add(this.rtbAllText);
            this.pnlTextContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTextContent.Location = new System.Drawing.Point(3, 52);
            this.pnlTextContent.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pnlTextContent.Name = "pnlTextContent";
            this.pnlTextContent.Size = new System.Drawing.Size(565, 471);
            this.pnlTextContent.TabIndex = 3;
            // 
            // rtbSearchedText
            // 
            this.rtbSearchedText.BackColor = System.Drawing.Color.White;
            this.rtbSearchedText.Location = new System.Drawing.Point(284, 22);
            this.rtbSearchedText.Name = "rtbSearchedText";
            this.rtbSearchedText.ReadOnly = true;
            this.rtbSearchedText.Size = new System.Drawing.Size(200, 200);
            this.rtbSearchedText.TabIndex = 2;
            this.rtbSearchedText.Text = "";
            this.rtbSearchedText.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(571, 22);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.読込みRToolStripMenuItem,
            this.検索結果の保存SToolStripMenuItem,
            this.toolStripMenuItem1,
            this.終了XToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(67, 18);
            this.ファイルToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 読込みRToolStripMenuItem
            // 
            this.読込みRToolStripMenuItem.Name = "読込みRToolStripMenuItem";
            this.読込みRToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.読込みRToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.読込みRToolStripMenuItem.Text = "読込み(&R)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // 終了XToolStripMenuItem
            // 
            this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
            this.終了XToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.終了XToolStripMenuItem.Text = "終了(&X)";
            // 
            // 検索結果の保存SToolStripMenuItem
            // 
            this.検索結果の保存SToolStripMenuItem.Name = "検索結果の保存SToolStripMenuItem";
            this.検索結果の保存SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.検索結果の保存SToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.検索結果の保存SToolStripMenuItem.Text = "検索結果の保存(&S)";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 526);
            this.Controls.Add(this.tlpMainContainer);
            this.Name = "frmMain";
            this.Text = "テキスト絞り込み検索";
            this.tlpMainContainer.ResumeLayout(false);
            this.tlpMainContainer.PerformLayout();
            this.pnlController.ResumeLayout(false);
            this.pnlController.PerformLayout();
            this.pnlTextContent.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbAllText;
        private System.Windows.Forms.TableLayoutPanel tlpMainContainer;
        private System.Windows.Forms.Panel pnlController;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlTextContent;
        private System.Windows.Forms.RichTextBox rtbSearchedText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 読込みRToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 検索結果の保存SToolStripMenuItem;
    }
}

