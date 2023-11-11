
namespace SasattoQR
{
    partial class SasattoQR
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxQR = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timerClipboardMonitoring = new System.Windows.Forms.Timer(this.components);
            this.labelQRCode = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonClearText = new System.Windows.Forms.Button();
            this.buttonCopyText = new System.Windows.Forms.Button();
            this.buttonMakeRandomString = new System.Windows.Forms.Button();
            this.radioButtonMaker = new System.Windows.Forms.RadioButton();
            this.radioButtonReader = new System.Windows.Forms.RadioButton();
            this.timerInfoTipClear = new System.Windows.Forms.Timer(this.components);
            this.buttonCopyQR = new System.Windows.Forms.Button();
            this.buttonReading = new System.Windows.Forms.Button();
            this.labelExplain = new System.Windows.Forms.Label();
            this.pictureBoxArrow = new System.Windows.Forms.PictureBox();
            this.timerAutoReadQR = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.閉じるToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_AutoReadQR = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ClipboardMonitoring = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_other = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_BootbyReadMode = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_DisplayRandomButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.本ソフトウェアについてToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTrans = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxQR
            // 
            this.pictureBoxQR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxQR.BackColor = System.Drawing.Color.White;
            this.pictureBoxQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxQR.Location = new System.Drawing.Point(371, 108);
            this.pictureBoxQR.MinimumSize = new System.Drawing.Size(200, 200);
            this.pictureBoxQR.Name = "pictureBoxQR";
            this.pictureBoxQR.Size = new System.Drawing.Size(312, 231);
            this.pictureBoxQR.TabIndex = 2;
            this.pictureBoxQR.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(12, 108);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(288, 231);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timerClipboardMonitoring
            // 
            this.timerClipboardMonitoring.Interval = 500;
            this.timerClipboardMonitoring.Tick += new System.EventHandler(this.timerClipboardMonitoring_Tick);
            // 
            // labelQRCode
            // 
            this.labelQRCode.AutoSize = true;
            this.labelQRCode.Location = new System.Drawing.Point(369, 53);
            this.labelQRCode.Name = "labelQRCode";
            this.labelQRCode.Size = new System.Drawing.Size(48, 12);
            this.labelQRCode.TabIndex = 5;
            this.labelQRCode.Text = "QRコード";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(10, 53);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(121, 12);
            this.labelText.TabIndex = 5;
            this.labelText.Text = "QRコードにしたい文字列";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabelInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 351);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(694, 24);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(263, 19);
            this.toolStripStatusLabel2.Text = "QRコードは株式会社デンソーウェーブの登録商標です。";
            // 
            // toolStripStatusLabelInfo
            // 
            this.toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
            this.toolStripStatusLabelInfo.Size = new System.Drawing.Size(416, 19);
            this.toolStripStatusLabelInfo.Spring = true;
            this.toolStripStatusLabelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonClearText
            // 
            this.buttonClearText.Location = new System.Drawing.Point(93, 79);
            this.buttonClearText.Name = "buttonClearText";
            this.buttonClearText.Size = new System.Drawing.Size(75, 23);
            this.buttonClearText.TabIndex = 7;
            this.buttonClearText.Text = "クリア";
            this.buttonClearText.UseVisualStyleBackColor = true;
            this.buttonClearText.Click += new System.EventHandler(this.buttonClearText_Click);
            // 
            // buttonCopyText
            // 
            this.buttonCopyText.Location = new System.Drawing.Point(12, 79);
            this.buttonCopyText.Name = "buttonCopyText";
            this.buttonCopyText.Size = new System.Drawing.Size(75, 23);
            this.buttonCopyText.TabIndex = 7;
            this.buttonCopyText.Text = "コピー";
            this.buttonCopyText.UseVisualStyleBackColor = true;
            this.buttonCopyText.Click += new System.EventHandler(this.buttonCopyText_Click);
            // 
            // buttonMakeRandomString
            // 
            this.buttonMakeRandomString.Enabled = false;
            this.buttonMakeRandomString.Location = new System.Drawing.Point(174, 79);
            this.buttonMakeRandomString.Name = "buttonMakeRandomString";
            this.buttonMakeRandomString.Size = new System.Drawing.Size(126, 23);
            this.buttonMakeRandomString.TabIndex = 8;
            this.buttonMakeRandomString.Text = "ランダム文字列を入力";
            this.buttonMakeRandomString.UseVisualStyleBackColor = true;
            this.buttonMakeRandomString.Visible = false;
            this.buttonMakeRandomString.Click += new System.EventHandler(this.buttonMakeRandomString_Click);
            // 
            // radioButtonMaker
            // 
            this.radioButtonMaker.AutoSize = true;
            this.radioButtonMaker.Checked = true;
            this.radioButtonMaker.Location = new System.Drawing.Point(12, 27);
            this.radioButtonMaker.Name = "radioButtonMaker";
            this.radioButtonMaker.Size = new System.Drawing.Size(75, 16);
            this.radioButtonMaker.TabIndex = 9;
            this.radioButtonMaker.TabStop = true;
            this.radioButtonMaker.Text = "作成モード";
            this.radioButtonMaker.UseVisualStyleBackColor = true;
            this.radioButtonMaker.CheckedChanged += new System.EventHandler(this.radioButtonMaker_CheckedChanged);
            // 
            // radioButtonReader
            // 
            this.radioButtonReader.AutoSize = true;
            this.radioButtonReader.Location = new System.Drawing.Point(93, 27);
            this.radioButtonReader.Name = "radioButtonReader";
            this.radioButtonReader.Size = new System.Drawing.Size(94, 16);
            this.radioButtonReader.TabIndex = 9;
            this.radioButtonReader.Text = "読み取りモード";
            this.radioButtonReader.UseVisualStyleBackColor = true;
            // 
            // timerInfoTipClear
            // 
            this.timerInfoTipClear.Interval = 500;
            this.timerInfoTipClear.Tick += new System.EventHandler(this.timerInfoTipClear_Tick);
            // 
            // buttonCopyQR
            // 
            this.buttonCopyQR.Location = new System.Drawing.Point(371, 79);
            this.buttonCopyQR.Name = "buttonCopyQR";
            this.buttonCopyQR.Size = new System.Drawing.Size(75, 23);
            this.buttonCopyQR.TabIndex = 7;
            this.buttonCopyQR.Text = "コピー";
            this.buttonCopyQR.UseVisualStyleBackColor = true;
            this.buttonCopyQR.Click += new System.EventHandler(this.buttonCopyQR_Click);
            // 
            // buttonReading
            // 
            this.buttonReading.Enabled = false;
            this.buttonReading.Location = new System.Drawing.Point(452, 79);
            this.buttonReading.Name = "buttonReading";
            this.buttonReading.Size = new System.Drawing.Size(75, 23);
            this.buttonReading.TabIndex = 7;
            this.buttonReading.Text = "読み取り";
            this.buttonReading.UseVisualStyleBackColor = true;
            this.buttonReading.Click += new System.EventHandler(this.buttonReading_Click);
            // 
            // labelExplain
            // 
            this.labelExplain.AutoSize = true;
            this.labelExplain.Location = new System.Drawing.Point(306, 170);
            this.labelExplain.Name = "labelExplain";
            this.labelExplain.Size = new System.Drawing.Size(57, 24);
            this.labelExplain.TabIndex = 5;
            this.labelExplain.Text = "文字列を\r\nQRコードに";
            // 
            // pictureBoxArrow
            // 
            this.pictureBoxArrow.Location = new System.Drawing.Point(315, 210);
            this.pictureBoxArrow.Name = "pictureBoxArrow";
            this.pictureBoxArrow.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxArrow.TabIndex = 10;
            this.pictureBoxArrow.TabStop = false;
            // 
            // timerAutoReadQR
            // 
            this.timerAutoReadQR.Interval = 500;
            this.timerAutoReadQR.Tick += new System.EventHandler(this.timerAutoReadQR_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.設定SToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(694, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.閉じるToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 閉じるToolStripMenuItem
            // 
            this.閉じるToolStripMenuItem.Name = "閉じるToolStripMenuItem";
            this.閉じるToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.閉じるToolStripMenuItem.Text = "閉じる(&C)";
            this.閉じるToolStripMenuItem.Click += new System.EventHandler(this.閉じるToolStripMenuItem_Click);
            // 
            // 設定SToolStripMenuItem
            // 
            this.設定SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_AutoReadQR,
            this.ToolStripMenuItem_ClipboardMonitoring,
            this.toolStripSeparator2,
            this.ToolStripMenuItem_other});
            this.設定SToolStripMenuItem.Name = "設定SToolStripMenuItem";
            this.設定SToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.設定SToolStripMenuItem.Text = "設定(&S)";
            // 
            // ToolStripMenuItem_AutoReadQR
            // 
            this.ToolStripMenuItem_AutoReadQR.Name = "ToolStripMenuItem_AutoReadQR";
            this.ToolStripMenuItem_AutoReadQR.Size = new System.Drawing.Size(337, 22);
            this.ToolStripMenuItem_AutoReadQR.Text = "枠内にQRコードが入ったら自動で読み取りを行う";
            this.ToolStripMenuItem_AutoReadQR.Click += new System.EventHandler(this.ToolStripMenuItem_AutoReadQR_Click);
            // 
            // ToolStripMenuItem_ClipboardMonitoring
            // 
            this.ToolStripMenuItem_ClipboardMonitoring.Name = "ToolStripMenuItem_ClipboardMonitoring";
            this.ToolStripMenuItem_ClipboardMonitoring.Size = new System.Drawing.Size(337, 22);
            this.ToolStripMenuItem_ClipboardMonitoring.Text = "クリップボードにQRコードが入ったら自動で読み取りを行う";
            this.ToolStripMenuItem_ClipboardMonitoring.Click += new System.EventHandler(this.ToolStripMenuItem_ClipboardMonitoring_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(334, 6);
            // 
            // ToolStripMenuItem_other
            // 
            this.ToolStripMenuItem_other.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_BootbyReadMode,
            this.ToolStripMenuItem_DisplayRandomButton});
            this.ToolStripMenuItem_other.Name = "ToolStripMenuItem_other";
            this.ToolStripMenuItem_other.Size = new System.Drawing.Size(337, 22);
            this.ToolStripMenuItem_other.Text = "その他";
            // 
            // ToolStripMenuItem_BootbyReadMode
            // 
            this.ToolStripMenuItem_BootbyReadMode.Name = "ToolStripMenuItem_BootbyReadMode";
            this.ToolStripMenuItem_BootbyReadMode.Size = new System.Drawing.Size(287, 22);
            this.ToolStripMenuItem_BootbyReadMode.Text = "読み取りモードで起動する";
            this.ToolStripMenuItem_BootbyReadMode.Click += new System.EventHandler(this.ToolStripMenuItem_BootbyReadMode_Click);
            // 
            // ToolStripMenuItem_DisplayRandomButton
            // 
            this.ToolStripMenuItem_DisplayRandomButton.Name = "ToolStripMenuItem_DisplayRandomButton";
            this.ToolStripMenuItem_DisplayRandomButton.Size = new System.Drawing.Size(287, 22);
            this.ToolStripMenuItem_DisplayRandomButton.Text = "ランダムな文字列を入力するボタンを表示する";
            this.ToolStripMenuItem_DisplayRandomButton.Click += new System.EventHandler(this.ToolStripMenuItem_DisplayRandomButton_Click);
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.本ソフトウェアについてToolStripMenuItem});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // 本ソフトウェアについてToolStripMenuItem
            // 
            this.本ソフトウェアについてToolStripMenuItem.Name = "本ソフトウェアについてToolStripMenuItem";
            this.本ソフトウェアについてToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.本ソフトウェアについてToolStripMenuItem.Text = "ソフトウェアについて";
            this.本ソフトウェアについてToolStripMenuItem.Click += new System.EventHandler(this.本ソフトウェアについてToolStripMenuItem_Click);
            // 
            // labelTrans
            // 
            this.labelTrans.AutoSize = true;
            this.labelTrans.Location = new System.Drawing.Point(550, 84);
            this.labelTrans.Name = "labelTrans";
            this.labelTrans.Size = new System.Drawing.Size(73, 12);
            this.labelTrans.TabIndex = 13;
            this.labelTrans.Text = "(枠内透過中)";
            this.labelTrans.Visible = false;
            // 
            // SasattoQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 375);
            this.Controls.Add(this.labelTrans);
            this.Controls.Add(this.pictureBoxArrow);
            this.Controls.Add(this.radioButtonReader);
            this.Controls.Add(this.radioButtonMaker);
            this.Controls.Add(this.buttonMakeRandomString);
            this.Controls.Add(this.buttonReading);
            this.Controls.Add(this.buttonCopyQR);
            this.Controls.Add(this.buttonCopyText);
            this.Controls.Add(this.buttonClearText);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelExplain);
            this.Controls.Add(this.labelQRCode);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBoxQR);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SasattoQR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SasattoQR";
            this.Load += new System.EventHandler(this.SasattoQR_Load);
            this.SizeChanged += new System.EventHandler(this.SasattoQR_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxQR;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timerClipboardMonitoring;
        private System.Windows.Forms.Label labelQRCode;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInfo;
        private System.Windows.Forms.Button buttonClearText;
        private System.Windows.Forms.Button buttonCopyText;
        private System.Windows.Forms.Button buttonMakeRandomString;
        private System.Windows.Forms.RadioButton radioButtonMaker;
        private System.Windows.Forms.RadioButton radioButtonReader;
        private System.Windows.Forms.Timer timerInfoTipClear;
        private System.Windows.Forms.Button buttonCopyQR;
        private System.Windows.Forms.Button buttonReading;
        private System.Windows.Forms.Label labelExplain;
        private System.Windows.Forms.PictureBox pictureBoxArrow;
        private System.Windows.Forms.Timer timerAutoReadQR;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 閉じるToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_other;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_BootbyReadMode;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_AutoReadQR;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ClipboardMonitoring;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_DisplayRandomButton;
        private System.Windows.Forms.ToolStripMenuItem 本ソフトウェアについてToolStripMenuItem;
        private System.Windows.Forms.Label labelTrans;
    }
}

