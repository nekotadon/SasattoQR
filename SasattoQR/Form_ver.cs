using System;
using System.Drawing;
using System.Windows.Forms;

namespace SasattoQR
{
    public partial class Form_ver : Form
    {
        public Form_ver()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.sasattoqr;

            //AssemblyProductの取得
            System.Reflection.AssemblyProductAttribute asmprd =
                (System.Reflection.AssemblyProductAttribute)
                Attribute.GetCustomAttribute(
                System.Reflection.Assembly.GetExecutingAssembly(),
                typeof(System.Reflection.AssemblyProductAttribute));

            //自分自身のバージョン情報を取得する
            System.Diagnostics.FileVersionInfo vi = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);

            string crlf = System.Environment.NewLine;
            this.richTextBox1.Font = this.button1.Font = System.Drawing.SystemFonts.MenuFont;
            this.richTextBox1.Text = asmprd.Product + crlf
                + "version" + vi.ProductMajorPart + "." + vi.ProductMinorPart + "." + vi.ProductPrivatePart + crlf
                + crlf
                + Properties.Resources.string_license
                + crlf
                + crlf
                + crlf
                + Properties.Resources.string_license_add;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_ver_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Form_ver_Load(object sender, EventArgs e)
        {
            int pos;
            Font fnt = new Font(SystemFonts.MenuFont.FontFamily, 14, FontStyle.Bold);

            foreach (string word in new string[] { "SasattoQR", "ZXing.Net" })
            {
                pos = 0;
                richTextBox1.Find(word, pos, RichTextBoxFinds.None);
                richTextBox1.SelectionFont = fnt;
            }

            fnt.Dispose();

            this.richTextBox1.SelectionStart = 0;
            this.richTextBox1.SelectionLength = 0;
        }
    }
}
