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

namespace SasattoQR
{
    public partial class SasattoQR : Form
    {
        private string randomStrings = "23456789abcdefghijkmnpqrstuvwxyzABCDEFGHJKLMNPQRSTUVWXYZ!#$%&'()=~|{}<>*+-/[]?@";

        private Size pictureBoxQRSize;
        private Size pictureBoxQRMinimumSize;
        private Size formSize;
        private Size formMinimumSize;
        private int infoTipClearTimerCount = 6;
        private TextLib.IniFile iniFile = new TextLib.IniFile();
        private bool isModeChange;
        private bool kidouji = true;
        //モード確認
        private bool isMakeMode => radioButtonMaker.Checked;
        private bool isReadMode => !radioButtonMaker.Checked;

        public SasattoQR()
        {
            InitializeComponent();
            Icon = Properties.Resources.sasattoqr;

            pictureBoxQRSize = pictureBoxQR.Size;
            pictureBoxQRMinimumSize = pictureBoxQR.MinimumSize;
            formSize = Size;
            formMinimumSize = new Size(325, 170);
            MinimumSize = formSize;

            toolStripStatusLabelInfo.Font
            = labelQRCode.Font = labelText.Font = labelExplain.Font = labelTrans.Font
            = buttonCopyText.Font = buttonCopyQR.Font = buttonMakeRandomString.Font = buttonReading.Font = buttonClearText.Font
            = radioButtonReader.Font = radioButtonMaker.Font
            = SystemInformation.MenuFont;

            pictureBoxArrow.Image = Properties.Resources.arrow;
            pictureBoxArrow.SendToBack();

            //設定読み込み
            ToolStripMenuItem_DisplayRandomButton.Checked = iniFile.GetKeyValueBool("make", "Random", false, true);
            ToolStripMenuItem_AutoReadQR.Checked = iniFile.GetKeyValueBool("read", "AutoRead", false, true);
            ToolStripMenuItem_ClipboardMonitoring.Checked = iniFile.GetKeyValueBool("read", "ClipboardMonitoring", false, true);
            ToolStripMenuItem_BootbyReadMode.Checked = iniFile.GetKeyValueBool("setting", "InitialMode", false, true);

            //設定変更
            radioButtonMaker.Checked = !ToolStripMenuItem_BootbyReadMode.Checked;
            radioButtonReader.Checked = !radioButtonMaker.Checked;
            isModeChange = true;
            SettingReflect();
        }

        //フォーム
        private void SasattoQR_Load(object sender, EventArgs e)
        {
            ActiveControl = textBox1;
            textBox1.Focus();
            kidouji = false;

            if (ToolStripMenuItem_DisplayRandomButton.Checked)
            {
                buttonMakeRandomString.Visible = true;
            }
        }

        private void SasattoQR_SizeChanged(object sender, EventArgs e)
        {
            MakeQR();
        }

        //メニュー
        private void 閉じるToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripMenuItem_DisplayRandomButton_Click(object sender, EventArgs e)
        {
            buttonMakeRandomString.Visible = ToolStripMenuItem_DisplayRandomButton.Checked = !ToolStripMenuItem_DisplayRandomButton.Checked;
            iniFile.SetKeyValueBool("make", "Random", ToolStripMenuItem_DisplayRandomButton.Checked);
        }

        private void ToolStripMenuItem_AutoReadQR_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem_AutoReadQR.Checked = !ToolStripMenuItem_AutoReadQR.Checked;
            iniFile.SetKeyValueBool("read", "AutoRead", ToolStripMenuItem_AutoReadQR.Checked);
            SettingReflect();
        }

        private void ToolStripMenuItem_ClipboardMonitoring_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem_ClipboardMonitoring.Checked = !ToolStripMenuItem_ClipboardMonitoring.Checked;
            iniFile.SetKeyValueBool("read", "ClipboardMonitoring", ToolStripMenuItem_ClipboardMonitoring.Checked);
            SettingReflect();
        }

        private void ToolStripMenuItem_BootbyReadMode_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem_BootbyReadMode.Checked = !ToolStripMenuItem_BootbyReadMode.Checked;
            iniFile.SetKeyValueBool("setting", "InitialMode", ToolStripMenuItem_BootbyReadMode.Checked);
        }

        private void 本ソフトウェアについてToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAboutThisApp form = new FormAboutThisApp
            {
                Owner = this,
                TopMost = TopMost,
                StartPosition = FormStartPosition.CenterParent
            };

            form.ShowDialog();
            form.Dispose();
        }

        //ラジオボタン
        private void radioButtonMaker_CheckedChanged(object sender, EventArgs e)
        {
            if (!kidouji)
            {
                isModeChange = true;
                SettingReflect();
            }
        }

        //テキストが入力されたらQRコードを作成する。
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MakeQR();
        }

        //ボタン
        private void buttonCopyText_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Clipboard.SetText(textBox1.Text);
                toolStripStatusLabelInfo.TextAlign = ContentAlignment.MiddleLeft;
                setToolstripText("文字列をクリップボードにコピーしました。");
            }
        }

        private void buttonClearText_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void buttonMakeRandomString_Click(object sender, EventArgs e)
        {
            MakeRandomStrings();
        }

        private void buttonCopyQR_Click(object sender, EventArgs e)
        {
            CopyQR();
        }
        private void buttonReading_Click(object sender, EventArgs e)
        {
            if (!nowReading)
            {
                ReadQR();
            }
        }

        //QRコード作成
        private void MakeQR()
        {
            if (radioButtonMaker.Checked && textBox1.Text != "")
            {
                try
                {
                    int h = pictureBoxQR.Height;
                    int w = pictureBoxQR.Width;
                    int size = h < w ? h : w;
                    size = size - size % 50;
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

                    var bmp = qrCode.Write(textBox1.Text);

                    if (pictureBoxQR.Image != null)
                    {
                        pictureBoxQR.Image.Dispose();
                        pictureBoxQR.Image = null;
                    }

                    pictureBoxQR.Image = bmp;
                }
                catch (Exception)
                {
                    ;
                }
            }
            else
            {
                pictureBoxQR.Image = null;
            }
        }

        //クリップボード監視
        private bool nowMonitoring = false;
        private void timerClipboardMonitoring_Tick(object sender, EventArgs e)
        {
            if (!nowMonitoring && ToolStripMenuItem_ClipboardMonitoring.Checked && isReadMode)
            {
                nowMonitoring = true;
                SetTextFromClipboardQR();
                nowMonitoring = false;
            }
        }
        //自動読み取り
        private void timerAutoReadQR_Tick(object sender, EventArgs e)
        {
            if (!nowReading && ToolStripMenuItem_AutoReadQR.Checked && isReadMode)
            {
                ReadQR(true);
            }
        }

        //クリップボードのQRコードをテキストに変換
        private string resultTextCurrent = "";
        private void SetTextFromClipboardQR()
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

                    if (result != null && resultTextCurrent != result.Text)
                    {
                        textBox1.Text = result.Text;
                        resultTextCurrent = result.Text;
                        toolStripStatusLabelInfo.TextAlign = ContentAlignment.MiddleLeft;
                        setToolstripText("クリップボードのQRコード画像をテキストに変換しました。");
                    }
                }
            }
        }

        //ランダム文字列作成
        private void MakeRandomStrings()
        {
            Random r1 = new Random();
            Random r2 = new Random();

            string s = "";
            int imax = r2.Next(20, 33);

            for (int i = 0; i < imax; i++)
            {
                s += randomStrings.Substring(r1.Next(0, randomStrings.Length), 1);
            }

            textBox1.Text = s;
        }

        //読み取り
        Rectangle desktopBounds = new Rectangle();
        bool zenkaiNG = true;
        bool nowReading = false;
        private void ReadQR(bool autoread = false)
        {
            nowReading = true;

            try
            {
                //フォームの範囲を読み取り
                using (Bitmap bitmap = new Bitmap(Width, Height))
                {
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        graphics.CopyFromScreen(PointToScreen(new Point(0, 0)), new Point(0, 0), bitmap.Size);
                    }

                    //コントロール部分切り取り
                    Rectangle rect = new Rectangle(pictureBoxQR.Location.X, pictureBoxQR.Location.Y, pictureBoxQR.Width, pictureBoxQR.Height);
                    using (Bitmap bitmapQR = bitmap.Clone(rect, bitmap.PixelFormat))
                    {
                        ZXing.BarcodeReader barcodeReader = new ZXing.BarcodeReader();
                        ZXing.Result result = barcodeReader.Decode(bitmapQR);

                        if (!autoread)
                        {
                            textBox1.Text = result == null ? "" : result.Text;
                            toolStripStatusLabelInfo.TextAlign = ContentAlignment.MiddleRight;
                            setToolstripText(result != null ? "読み取り成功" : "読み取りできませんでした。");
                        }
                        else
                        {
                            if (result != null)
                            {
                                if (textBox1.Text != result.Text || desktopBounds != DesktopBounds || zenkaiNG)
                                {
                                    textBox1.Text = result.Text;
                                    toolStripStatusLabelInfo.TextAlign = ContentAlignment.MiddleRight;
                                    setToolstripText("読み取り成功");
                                    desktopBounds = DesktopBounds;
                                }
                                zenkaiNG = false;
                            }
                            else
                            {
                                zenkaiNG = true;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }

            nowReading = false;
        }

        //画像コピー
        private void CopyQR()
        {
            if ((radioButtonMaker.Checked && textBox1.Text != "") || !radioButtonMaker.Checked)
            {
                try
                {
                    if (pictureBoxQR.Width >= 10 && pictureBoxQR.Height >= 10)
                    {
                        //フォームの範囲を読み取り
                        using (Bitmap bitmap = new Bitmap(Width, Height))
                        {
                            using (Graphics graphics = Graphics.FromImage(bitmap))
                            {
                                graphics.CopyFromScreen(PointToScreen(new Point(0, 0)), new Point(0, 0), bitmap.Size);
                            }

                            //コントロール部分切り取り
                            Rectangle rect = new Rectangle();
                            if (radioButtonMaker.Checked)
                            {
                                rect = new Rectangle(pictureBoxQR.Location.X + 1, pictureBoxQR.Location.Y + 1, pictureBoxQR.Image.Width, pictureBoxQR.Image.Height);
                            }
                            else
                            {
                                rect = new Rectangle(pictureBoxQR.Location.X + 1, pictureBoxQR.Location.Y + 1, pictureBoxQR.Width - 2, pictureBoxQR.Height - 2);
                            }

                            using (Bitmap bitmapQR = bitmap.Clone(rect, bitmap.PixelFormat))
                            {
                                //クリップボードへコピー
                                Clipboard.SetImage(bitmapQR);
                            }
                        }

                        toolStripStatusLabelInfo.TextAlign = ContentAlignment.MiddleLeft;
                        if (radioButtonMaker.Checked)
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
                    toolStripStatusLabelInfo.TextAlign = ContentAlignment.MiddleLeft;
                    setToolstripText("コピーに失敗しました。");
                }
            }
        }

        private void SettingReflect()
        {
            if (isModeChange)
            {
                isModeChange = false;

                //テキスト初期化
                textBox1.Text = "";

                if (isMakeMode)
                {
                    //ピクチャボックス初期化
                    pictureBoxQR.BackColor = Color.White;

                    //サイズ変更
                    Size = formSize;
                    MinimumSize = formSize;

                    pictureBoxQR.Size = pictureBoxQRSize;
                    pictureBoxQR.MinimumSize = pictureBoxQRMinimumSize;

                    //テキストボックスにフォーカスをあてる
                    ActiveControl = textBox1;
                    textBox1.Focus();

                    //表示変更
                    if (!kidouji)
                    {
                        pictureBoxArrow.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    }
                    pictureBoxArrow.Refresh();
                    labelExplain.Text = "文字列を\r\nQRコードに";
                    labelText.Text = "QRコードにしたい文字列";
                    labelQRCode.Text = "QRコード";
                    labelTrans.Visible = false;
                }
                else
                {
                    //ピクチャボックスを透過させる
                    pictureBoxQR.Image = null;
                    pictureBoxQR.BackColor = Color.DarkGoldenrod;
                    TransparencyKey = Color.DarkGoldenrod;

                    //サイズ変更
                    MinimumSize = formMinimumSize;
                    pictureBoxQR.MinimumSize = new Size(0, 0);

                    //表示変更
                    pictureBoxArrow.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    pictureBoxArrow.Refresh();
                    labelExplain.Text = "QRコードを\r\n文字列に";
                    labelText.Text = "QRコードから読み取った文字列";
                    labelQRCode.Text = "下の枠内にQRコードを収めて読み取りボタンを押す。";
                    labelTrans.Visible = true;

                    //クリップボード監視初期化
                    resultTextCurrent = "";
                }

                //最前面表示
                TopMost = isReadMode;

                //コントロールの有効無効切り替え
                buttonMakeRandomString.Enabled = isMakeMode;
                buttonReading.Enabled = isReadMode;

                timerClipboardMonitoring.Enabled = ToolStripMenuItem_ClipboardMonitoring.Checked && isReadMode;
                timerAutoReadQR.Enabled = ToolStripMenuItem_AutoReadQR.Checked && isReadMode;
            }

            timerAutoReadQR.Enabled = ToolStripMenuItem_AutoReadQR.Checked && isReadMode;
            timerClipboardMonitoring.Enabled = ToolStripMenuItem_ClipboardMonitoring.Checked && isReadMode;
        }

        private void setToolstripText(string str)
        {
            toolStripStatusLabelInfo.Text = str;
            infoTipClearTimerCount = 6;
            timerInfoTipClear.Enabled = true;
        }

        private void timerInfoTipClear_Tick(object sender, EventArgs e)
        {
            if (infoTipClearTimerCount >= 1)
            {
                infoTipClearTimerCount--;
            }

            if (infoTipClearTimerCount == 0)
            {
                timerInfoTipClear.Enabled = false;
                toolStripStatusLabelInfo.TextAlign = ContentAlignment.MiddleLeft;
                toolStripStatusLabelInfo.Text = "";
            }
        }
    }
}
