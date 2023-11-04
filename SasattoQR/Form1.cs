/*
 * This software includes the work that is distributed in the Apache License 2.0 
 * 
 * Copyright 2017 ZXing.Net authors
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using TextLib;

namespace SasattoQR
{
    public partial class Form1 : Form
    {
        private string randstr = "23456789abcdefghijkmnpqrstuvwxyzABCDEFGHJKLMNPQRSTUVWXYZ!#$%&'()=~|{}<>*+-/[]?@";

        private Size size_pic;
        private Size size_pic_min;
        private Size size_form;
        private Size size_form_min;
        private int clear_timer = 6;

        //設定読み込み
        IniFile iniFile = new IniFile();

        bool mode_change;
        bool kidouji = true;

        public Form1()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.sasattoqr;

            size_pic = this.pictureBox1.Size;
            size_pic_min = this.pictureBox1.MinimumSize;
            size_form = this.Size;
            size_form_min = new Size(325, 170);
            this.MinimumSize = size_form;

            this.toolStripStatusLabel1.Font
            = this.label_code.Font = this.label_mojiretu.Font = this.label_explain.Font = this.label_touka.Font
            = this.button_copy.Font = this.button_copyqr.Font = this.button_rand.Font = this.button_reading.Font = this.button_clr.Font
            = this.radioButton_reader.Font = this.radioButton_maker.Font
            = SystemInformation.MenuFont;

            this.pictureBox2.Image = Properties.Resources.arrow;
            this.pictureBox2.SendToBack();

            //設定ファイル読み込み
            string folder = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            //設定読み込み
            this.ToolStripMenuItem_random.Checked = iniFile.GetKeyValueBool("make", "Random", false, true);
            this.ToolStripMenuItem_autoread.Checked = iniFile.GetKeyValueBool("read", "AutoRead", false, true);
            this.ToolStripMenuItem_clipcheck.Checked = iniFile.GetKeyValueBool("read", "ClipboardMonitoring", false, true);
            this.ToolStripMenuItem_bootread.Checked = iniFile.GetKeyValueBool("setting", "InitialMode", false, true);
            settingSave();

            //設定変更
            this.radioButton_maker.Checked = !this.ToolStripMenuItem_bootread.Checked;
            this.radioButton_reader.Checked = !this.radioButton_maker.Checked;
            mode_change = true;
            settingReflect();
        }

        //フォーム
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.textBox1;
            this.textBox1.Focus();
            kidouji = false;

            if (this.ToolStripMenuItem_random.Checked)
            {
                this.button_rand.Visible = true;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            makeQR();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //settingSave();
        }

        //メニュー
        private void 閉じるToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripMenuItem_random_Click(object sender, EventArgs e)
        {
            this.button_rand.Visible = this.ToolStripMenuItem_random.Checked = !this.ToolStripMenuItem_random.Checked;
            settingSave();
        }

        private void ToolStripMenuItem_autoread_Click(object sender, EventArgs e)
        {
            this.ToolStripMenuItem_autoread.Checked = !this.ToolStripMenuItem_autoread.Checked;
            settingReflect();
            settingSave();
        }

        private void ToolStripMenuItem_clipcheck_Click(object sender, EventArgs e)
        {
            this.ToolStripMenuItem_clipcheck.Checked = !this.ToolStripMenuItem_clipcheck.Checked;
            settingReflect();
            settingSave();
        }

        private void ToolStripMenuItem_bootread_Click(object sender, EventArgs e)
        {
            this.ToolStripMenuItem_bootread.Checked = !this.ToolStripMenuItem_bootread.Checked;
            settingSave();
        }

        private void 本ソフトウェアについてToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ver form = new Form_ver();

            form.Owner = this;
            form.TopMost = this.TopMost;
            form.StartPosition = FormStartPosition.CenterParent;

            form.ShowDialog();
            form.Dispose();
        }

        //ラジオボタン
        private void radioButton_maker_CheckedChanged(object sender, EventArgs e)
        {
            if (!kidouji)
            {
                mode_change = true;
                settingReflect();
            }
        }

        //テキストが入力されたらQRコードを作成する。
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            makeQR();
        }

        //ボタン
        private void button_copy_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "")
            {
                Clipboard.SetText(this.textBox1.Text);
                this.toolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft;
                setToolstripText("文字列をクリップボードにコピーしました。");
            }
        }

        private void button_clr_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
        }

        private void button_rand_Click(object sender, EventArgs e)
        {
            make_random();
        }

        private void button_copyqr_Click(object sender, EventArgs e)
        {
            copyQR();
        }
        private void button_reading_Click(object sender, EventArgs e)
        {
            if (!running_read)
            {
                reading();
            }
        }

        //QRコード作成
        private void makeQR()
        {
            if (this.radioButton_maker.Checked && this.textBox1.Text != "")
            {
                try
                {
                    int h = this.pictureBox1.Height;
                    int w = this.pictureBox1.Width;
                    int size = h < w ? h : w;
                    size = (size - size % 50);
                    size = size < 200 ? 200 : size;

                    var qrCode = new ZXing.BarcodeWriter
                    {
                        //Format
                        Format = ZXing.BarcodeFormat.QR_CODE,

                        //Options
                        Options = new ZXing.QrCode.QrCodeEncodingOptions
                        {
                            ErrorCorrection = ZXing.QrCode.Internal.ErrorCorrectionLevel.M,
                            CharacterSet = "UTF-8",
                            Width = size,
                            Height = size,
                            Margin = 5,
                        },
                    };

                    var bmp = qrCode.Write(this.textBox1.Text);

                    if (pictureBox1.Image != null)
                    {
                        this.pictureBox1.Image.Dispose();
                        this.pictureBox1.Image = null;
                    }

                    this.pictureBox1.Image = bmp;
                }
                catch (Exception)
                {
                    ;
                }
            }
            else
            {
                this.pictureBox1.Image = null;
            }
        }

        //クリップボード監視
        bool running_clip = false;
        private void timer_clip_Tick(object sender, EventArgs e)
        {
            if (!running_clip && this.ToolStripMenuItem_clipcheck.Checked && isReadMode())
            {
                running_clip = true;
                clip_QRcode_to_text();
                running_clip = false;
            }
        }
        //自動読み取り
        private void timer_autoread_Tick(object sender, EventArgs e)
        {
            if (!running_read && this.ToolStripMenuItem_autoread.Checked && isReadMode())
            {
                reading(true);
            }
        }

        //クリップボードのQRコードをテキストに変換
        string pre_result = "";
        private void clip_QRcode_to_text()
        {
            //クリップボードの画像
            if (Clipboard.ContainsImage())
            {
                //画像取得
                Image img = Clipboard.GetImage();
                if (img != null)
                {
                    ZXing.BarcodeReader barcodeReader = new ZXing.BarcodeReader();
                    ZXing.Result result = barcodeReader.Decode(new Bitmap(img));

                    if (result != null && pre_result != result.Text)
                    {
                        this.textBox1.Text = result.Text;
                        pre_result = result.Text;
                        this.toolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft;
                        setToolstripText("クリップボードのQRコード画像をテキストに変換しました。");
                    }
                }
            }
        }

        //ランダム文字列作成
        private void make_random()
        {
            Random r1 = new System.Random();
            Random r2 = new System.Random();

            string s = "";
            int imax = r2.Next(20, 33);

            for (int i = 0; i < imax; i++)
            {
                s += randstr.Substring(r1.Next(0, randstr.Length), 1);
            }

            this.textBox1.Text = s;
        }

        //読み取り
        Rectangle desktopBounds = new Rectangle();
        bool zenkai_ng = true;
        bool running_read = false;
        private void reading(bool autoread = false)
        {
            running_read = true;

            try
            {
                //フォームの範囲を読み取り
                Bitmap bitmap = new Bitmap(this.Width, this.Height);
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.CopyFromScreen(this.PointToScreen(new Point(0, 0)), new Point(0, 0), bitmap.Size);
                graphics.Dispose();

                //コントロール部分切り取り
                Rectangle rect = new Rectangle(this.pictureBox1.Location.X, this.pictureBox1.Location.Y, this.pictureBox1.Width, this.pictureBox1.Height);
                Bitmap bitmapc = bitmap.Clone(rect, bitmap.PixelFormat);

                ZXing.BarcodeReader barcodeReader = new ZXing.BarcodeReader();
                ZXing.Result result = barcodeReader.Decode(bitmapc);

                if (!autoread)
                {
                    this.textBox1.Text = result == null ? "" : result.Text;
                    this.toolStripStatusLabel1.TextAlign = ContentAlignment.MiddleRight;
                    setToolstripText(result != null ? "読み取り成功" : "読み取りできませんでした。");
                }
                else
                {
                    if (result != null)
                    {
                        if (this.textBox1.Text != result.Text || desktopBounds != this.DesktopBounds || zenkai_ng)
                        {
                            this.textBox1.Text = result.Text;
                            this.toolStripStatusLabel1.TextAlign = ContentAlignment.MiddleRight;
                            setToolstripText("読み取り成功");
                            desktopBounds = this.DesktopBounds;
                        }
                        zenkai_ng = false;
                    }
                    else
                    {
                        zenkai_ng = true;
                    }
                }

                //破棄
                bitmapc.Dispose();
                bitmap.Dispose();
            }
            catch (Exception)
            {
            }

            running_read = false;
        }

        //画像コピー
        private void copyQR()
        {
            if ((this.radioButton_maker.Checked && this.textBox1.Text != "") || !this.radioButton_maker.Checked)
            {
                try
                {
                    if (this.pictureBox1.Width >= 10 && this.pictureBox1.Height >= 10)
                    {
                        //フォームの範囲を読み取り
                        Bitmap bitmap = new Bitmap(this.Width, this.Height);
                        Graphics graphics = Graphics.FromImage(bitmap);
                        graphics.CopyFromScreen(this.PointToScreen(new Point(0, 0)), new Point(0, 0), bitmap.Size);
                        graphics.Dispose();

                        //コントロール部分切り取り
                        Rectangle rect = new Rectangle();
                        if (this.radioButton_maker.Checked)
                        {
                            rect = new Rectangle(this.pictureBox1.Location.X + 1, this.pictureBox1.Location.Y + 1, this.pictureBox1.Image.Width, this.pictureBox1.Image.Height);
                        }
                        else
                        {
                            rect = new Rectangle(this.pictureBox1.Location.X + 1, this.pictureBox1.Location.Y + 1, this.pictureBox1.Width - 2, this.pictureBox1.Height - 2);
                        }

                        Bitmap bitmapc = bitmap.Clone(rect, bitmap.PixelFormat);

                        //クリップボードへコピー
                        Clipboard.SetImage(bitmapc);

                        //破棄
                        bitmapc.Dispose();
                        bitmap.Dispose();

                        this.toolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft;
                        if (this.radioButton_maker.Checked)
                        {
                            setToolstripText("QRコードを画像としてクリップボードにコピーしました。");
                        }
                        else
                        {
                            setToolstripText("画像をクリップボードにコピーしました。");
                        }
                    }
                }
                catch (Exception)
                {
                    this.toolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft;
                    setToolstripText("コピーに失敗しました。");
                }
            }
        }

        private void settingReflect()
        {
            if (mode_change)
            {
                mode_change = false;

                //テキスト初期化
                this.textBox1.Text = "";

                if (isMakeMode())
                {
                    //ピクチャボックス初期化
                    this.pictureBox1.BackColor = Color.White;

                    //サイズ変更
                    this.Size = size_form;
                    this.MinimumSize = size_form;

                    this.pictureBox1.Size = size_pic;
                    this.pictureBox1.MinimumSize = size_pic_min;

                    //テキストボックスにフォーカスをあてる
                    this.ActiveControl = this.textBox1;
                    this.textBox1.Focus();

                    //表示変更
                    if (!kidouji)
                    {
                        this.pictureBox2.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    }
                    this.pictureBox2.Refresh();
                    this.label_explain.Text = "文字列を\r\nQRコードに";
                    this.label_mojiretu.Text = "QRコードにしたい文字列";
                    this.label_code.Text = "QRコード";
                    this.label_touka.Visible = false;
                }
                else
                {
                    //ピクチャボックスを透過させる
                    this.pictureBox1.Image = null;
                    this.pictureBox1.BackColor = Color.DarkGoldenrod;
                    this.TransparencyKey = Color.DarkGoldenrod;

                    //サイズ変更
                    this.MinimumSize = size_form_min;
                    this.pictureBox1.MinimumSize = new Size(0, 0);

                    //表示変更
                    this.pictureBox2.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    this.pictureBox2.Refresh();
                    this.label_explain.Text = "QRコードを\r\n文字列に";
                    this.label_mojiretu.Text = "QRコードから読み取った文字列";
                    this.label_code.Text = "下の枠内にQRコードを収めて読み取りボタンを押す。";
                    this.label_touka.Visible = true;

                    //クリップボード監視初期化
                    pre_result = "";
                }

                //最前面表示
                this.TopMost = isReadMode();

                //コントロールの有効無効切り替え
                this.button_rand.Enabled = isMakeMode();
                this.button_reading.Enabled = isReadMode();

                this.timer_clip.Enabled = this.ToolStripMenuItem_clipcheck.Checked && isReadMode();
                this.timer_autoread.Enabled = this.ToolStripMenuItem_autoread.Checked && isReadMode();
            }

            this.timer_autoread.Enabled = this.ToolStripMenuItem_autoread.Checked && isReadMode();
            this.timer_clip.Enabled = this.ToolStripMenuItem_clipcheck.Checked && isReadMode();
        }

        private void setToolstripText(string str)
        {
            this.toolStripStatusLabel1.Text = str;
            clear_timer = 6;
            this.timer_clear.Enabled = true;
        }

        private void timer_clear_Tick(object sender, EventArgs e)
        {
            if (clear_timer >= 1)
            {
                clear_timer--;
            }

            if (clear_timer == 0)
            {
                this.timer_clear.Enabled = false;
                this.toolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft;
                this.toolStripStatusLabel1.Text = "";
            }
        }

        //モード確認
        private bool isMakeMode()
        {
            return this.radioButton_maker.Checked;
        }
        private bool isReadMode()
        {
            return !this.radioButton_maker.Checked;
        }

        private void settingSave()
        {
            iniFile.SetKeyValueBool("make", "Random", this.ToolStripMenuItem_random.Checked);
            iniFile.SetKeyValueBool("read", "AutoRead", this.ToolStripMenuItem_autoread.Checked);
            iniFile.SetKeyValueBool("read", "ClipboardMonitoring", this.ToolStripMenuItem_clipcheck.Checked);
            iniFile.SetKeyValueBool("setting", "InitialMode", this.ToolStripMenuItem_bootread.Checked);
        }
    }
}
