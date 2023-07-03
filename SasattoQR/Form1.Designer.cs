
namespace SasattoQR
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer_clip = new System.Windows.Forms.Timer(this.components);
            this.label_code = new System.Windows.Forms.Label();
            this.label_mojiretu = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_clr = new System.Windows.Forms.Button();
            this.button_copy = new System.Windows.Forms.Button();
            this.button_rand = new System.Windows.Forms.Button();
            this.radioButton_maker = new System.Windows.Forms.RadioButton();
            this.radioButton_reader = new System.Windows.Forms.RadioButton();
            this.timer_clear = new System.Windows.Forms.Timer(this.components);
            this.button_copyqr = new System.Windows.Forms.Button();
            this.button_reading = new System.Windows.Forms.Button();
            this.label_explain = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer_autoread = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.閉じるToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_autoread = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_clipcheck = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_other = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_bootread = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_random = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.本ソフトウェアについてToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_touka = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(371, 108);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(200, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 231);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            // timer_clip
            // 
            this.timer_clip.Interval = 500;
            this.timer_clip.Tick += new System.EventHandler(this.timer_clip_Tick);
            // 
            // label_code
            // 
            this.label_code.AutoSize = true;
            this.label_code.Location = new System.Drawing.Point(369, 53);
            this.label_code.Name = "label_code";
            this.label_code.Size = new System.Drawing.Size(48, 12);
            this.label_code.TabIndex = 5;
            this.label_code.Text = "QRコード";
            // 
            // label_mojiretu
            // 
            this.label_mojiretu.AutoSize = true;
            this.label_mojiretu.Location = new System.Drawing.Point(10, 53);
            this.label_mojiretu.Name = "label_mojiretu";
            this.label_mojiretu.Size = new System.Drawing.Size(121, 12);
            this.label_mojiretu.TabIndex = 5;
            this.label_mojiretu.Text = "QRコードにしたい文字列";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1});
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
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(416, 19);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_clr
            // 
            this.button_clr.Location = new System.Drawing.Point(93, 79);
            this.button_clr.Name = "button_clr";
            this.button_clr.Size = new System.Drawing.Size(75, 23);
            this.button_clr.TabIndex = 7;
            this.button_clr.Text = "クリア";
            this.button_clr.UseVisualStyleBackColor = true;
            this.button_clr.Click += new System.EventHandler(this.button_clr_Click);
            // 
            // button_copy
            // 
            this.button_copy.Location = new System.Drawing.Point(12, 79);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(75, 23);
            this.button_copy.TabIndex = 7;
            this.button_copy.Text = "コピー";
            this.button_copy.UseVisualStyleBackColor = true;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // button_rand
            // 
            this.button_rand.Enabled = false;
            this.button_rand.Location = new System.Drawing.Point(174, 79);
            this.button_rand.Name = "button_rand";
            this.button_rand.Size = new System.Drawing.Size(126, 23);
            this.button_rand.TabIndex = 8;
            this.button_rand.Text = "ランダム文字列を入力";
            this.button_rand.UseVisualStyleBackColor = true;
            this.button_rand.Visible = false;
            this.button_rand.Click += new System.EventHandler(this.button_rand_Click);
            // 
            // radioButton_maker
            // 
            this.radioButton_maker.AutoSize = true;
            this.radioButton_maker.Checked = true;
            this.radioButton_maker.Location = new System.Drawing.Point(12, 27);
            this.radioButton_maker.Name = "radioButton_maker";
            this.radioButton_maker.Size = new System.Drawing.Size(75, 16);
            this.radioButton_maker.TabIndex = 9;
            this.radioButton_maker.TabStop = true;
            this.radioButton_maker.Text = "作成モード";
            this.radioButton_maker.UseVisualStyleBackColor = true;
            this.radioButton_maker.CheckedChanged += new System.EventHandler(this.radioButton_maker_CheckedChanged);
            // 
            // radioButton_reader
            // 
            this.radioButton_reader.AutoSize = true;
            this.radioButton_reader.Location = new System.Drawing.Point(93, 27);
            this.radioButton_reader.Name = "radioButton_reader";
            this.radioButton_reader.Size = new System.Drawing.Size(94, 16);
            this.radioButton_reader.TabIndex = 9;
            this.radioButton_reader.Text = "読み取りモード";
            this.radioButton_reader.UseVisualStyleBackColor = true;
            // 
            // timer_clear
            // 
            this.timer_clear.Interval = 500;
            this.timer_clear.Tick += new System.EventHandler(this.timer_clear_Tick);
            // 
            // button_copyqr
            // 
            this.button_copyqr.Location = new System.Drawing.Point(371, 79);
            this.button_copyqr.Name = "button_copyqr";
            this.button_copyqr.Size = new System.Drawing.Size(75, 23);
            this.button_copyqr.TabIndex = 7;
            this.button_copyqr.Text = "コピー";
            this.button_copyqr.UseVisualStyleBackColor = true;
            this.button_copyqr.Click += new System.EventHandler(this.button_copyqr_Click);
            // 
            // button_reading
            // 
            this.button_reading.Enabled = false;
            this.button_reading.Location = new System.Drawing.Point(452, 79);
            this.button_reading.Name = "button_reading";
            this.button_reading.Size = new System.Drawing.Size(75, 23);
            this.button_reading.TabIndex = 7;
            this.button_reading.Text = "読み取り";
            this.button_reading.UseVisualStyleBackColor = true;
            this.button_reading.Click += new System.EventHandler(this.button_reading_Click);
            // 
            // label_explain
            // 
            this.label_explain.AutoSize = true;
            this.label_explain.Location = new System.Drawing.Point(306, 170);
            this.label_explain.Name = "label_explain";
            this.label_explain.Size = new System.Drawing.Size(57, 24);
            this.label_explain.TabIndex = 5;
            this.label_explain.Text = "文字列を\r\nQRコードに";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(315, 210);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // timer_autoread
            // 
            this.timer_autoread.Interval = 500;
            this.timer_autoread.Tick += new System.EventHandler(this.timer_autoread_Tick);
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
            this.ToolStripMenuItem_autoread,
            this.ToolStripMenuItem_clipcheck,
            this.toolStripSeparator2,
            this.ToolStripMenuItem_other});
            this.設定SToolStripMenuItem.Name = "設定SToolStripMenuItem";
            this.設定SToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.設定SToolStripMenuItem.Text = "設定(&S)";
            // 
            // ToolStripMenuItem_autoread
            // 
            this.ToolStripMenuItem_autoread.Name = "ToolStripMenuItem_autoread";
            this.ToolStripMenuItem_autoread.Size = new System.Drawing.Size(337, 22);
            this.ToolStripMenuItem_autoread.Text = "枠内にQRコードが入ったら自動で読み取りを行う";
            this.ToolStripMenuItem_autoread.Click += new System.EventHandler(this.ToolStripMenuItem_autoread_Click);
            // 
            // ToolStripMenuItem_clipcheck
            // 
            this.ToolStripMenuItem_clipcheck.Name = "ToolStripMenuItem_clipcheck";
            this.ToolStripMenuItem_clipcheck.Size = new System.Drawing.Size(337, 22);
            this.ToolStripMenuItem_clipcheck.Text = "クリップボードにQRコードが入ったら自動で読み取りを行う";
            this.ToolStripMenuItem_clipcheck.Click += new System.EventHandler(this.ToolStripMenuItem_clipcheck_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(334, 6);
            // 
            // ToolStripMenuItem_other
            // 
            this.ToolStripMenuItem_other.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_bootread,
            this.ToolStripMenuItem_random});
            this.ToolStripMenuItem_other.Name = "ToolStripMenuItem_other";
            this.ToolStripMenuItem_other.Size = new System.Drawing.Size(337, 22);
            this.ToolStripMenuItem_other.Text = "その他";
            // 
            // ToolStripMenuItem_bootread
            // 
            this.ToolStripMenuItem_bootread.Name = "ToolStripMenuItem_bootread";
            this.ToolStripMenuItem_bootread.Size = new System.Drawing.Size(287, 22);
            this.ToolStripMenuItem_bootread.Text = "読み取りモードで起動する";
            this.ToolStripMenuItem_bootread.Click += new System.EventHandler(this.ToolStripMenuItem_bootread_Click);
            // 
            // ToolStripMenuItem_random
            // 
            this.ToolStripMenuItem_random.Name = "ToolStripMenuItem_random";
            this.ToolStripMenuItem_random.Size = new System.Drawing.Size(287, 22);
            this.ToolStripMenuItem_random.Text = "ランダムな文字列を入力するボタンを表示する";
            this.ToolStripMenuItem_random.Click += new System.EventHandler(this.ToolStripMenuItem_random_Click);
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
            // label_touka
            // 
            this.label_touka.AutoSize = true;
            this.label_touka.Location = new System.Drawing.Point(550, 84);
            this.label_touka.Name = "label_touka";
            this.label_touka.Size = new System.Drawing.Size(73, 12);
            this.label_touka.TabIndex = 13;
            this.label_touka.Text = "(枠内透過中)";
            this.label_touka.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 375);
            this.Controls.Add(this.label_touka);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.radioButton_reader);
            this.Controls.Add(this.radioButton_maker);
            this.Controls.Add(this.button_rand);
            this.Controls.Add(this.button_reading);
            this.Controls.Add(this.button_copyqr);
            this.Controls.Add(this.button_copy);
            this.Controls.Add(this.button_clr);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label_mojiretu);
            this.Controls.Add(this.label_explain);
            this.Controls.Add(this.label_code);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SasattoQR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer_clip;
        private System.Windows.Forms.Label label_code;
        private System.Windows.Forms.Label label_mojiretu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button_clr;
        private System.Windows.Forms.Button button_copy;
        private System.Windows.Forms.Button button_rand;
        private System.Windows.Forms.RadioButton radioButton_maker;
        private System.Windows.Forms.RadioButton radioButton_reader;
        private System.Windows.Forms.Timer timer_clear;
        private System.Windows.Forms.Button button_copyqr;
        private System.Windows.Forms.Button button_reading;
        private System.Windows.Forms.Label label_explain;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer_autoread;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 閉じるToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_other;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_bootread;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_autoread;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_clipcheck;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_random;
        private System.Windows.Forms.ToolStripMenuItem 本ソフトウェアについてToolStripMenuItem;
        private System.Windows.Forms.Label label_touka;
    }
}

