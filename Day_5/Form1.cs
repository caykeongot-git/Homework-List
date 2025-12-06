using System.Drawing.Text;
using System.Security.Cryptography;

namespace Day_5
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                cmbFonts.Items.Add(font.Name);
            }
            cmbFonts.SelectedItem = "Tahoma";

            int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int s in sizes)
            {
                cmbSizes.Items.Add(s);
            }
            cmbSizes.SelectedItem = 14;
        }

        private void systemNewPage_Click(object sender, EventArgs e)
        {
            richText.Clear();
            richText.Font = new Font("Tahoma", 14, FontStyle.Regular);
            cmbFonts.SelectedItem = "Tahoma";
            cmbSizes.SelectedItem = 14;
        }

        private void systemOpenfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Rich Text Format|*.rtf|Text Files|*.txt";

            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    richText.LoadFile(open.FileName, RichTextBoxStreamType.RichText);
                }
                catch
                {
                    richText.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void systemSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Rich Text Format|*.rtf";
            save.DefaultExt = "rtf";

            if (save.ShowDialog() == DialogResult.OK)
            {
                richText.SaveFile(save.FileName, RichTextBoxStreamType.RichText);
                MessageBox.Show("Lưu văn bản thành công!");
            }
        }

        private void systemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            if (richText.SelectionFont != null)
            {
                Font currentFont = richText.SelectionFont;
                FontStyle newStyle;

                if (currentFont.Bold) newStyle = currentFont.Style & ~FontStyle.Bold;
                else newStyle = currentFont.Style | FontStyle.Bold;
                richText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            }
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            if (richText.SelectionFont != null)
            {
                Font currentFont = richText.SelectionFont;
                FontStyle newStyle;

                if (currentFont.Italic) newStyle = currentFont.Style & ~FontStyle.Italic;
                else newStyle = currentFont.Style | FontStyle.Italic;
                richText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            }
        }

        private void btnUnderLine_Click(object sender, EventArgs e)
        {
            if (richText.SelectionFont != null)
            {
                Font currentFont = richText.SelectionFont;
                FontStyle newStyle;

                if (currentFont.Underline) newStyle = currentFont.Style & ~FontStyle.Underline;
                else newStyle = currentFont.Style | FontStyle.Underline;
                richText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            }
        }

        private void cmbFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richText.SelectionFont != null)
            {
                string newFontName = cmbFonts.SelectedItem.ToString();
                float currentSize = richText.SelectionFont.Size;
                FontStyle currentStyle = richText.SelectionFont.Style;
                richText.SelectionFont = new Font(newFontName, currentSize, currentStyle);
            }
        }

        private void cmbSizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richText.SelectionFont != null)
            {
                float newSize = float.Parse(cmbSizes.SelectedItem.ToString());
                FontFamily currentFamily = richText.SelectionFont.FontFamily;
                FontStyle currentStyle = richText.SelectionFont.Style;
                richText.SelectionFont = new Font(currentFamily, newSize, currentStyle);
            }
        }

        private void btnNewPage_Click(object sender, EventArgs e)
        {
            richText.Clear();
            richText.Font = new Font("Tahoma", 14, FontStyle.Regular);
            cmbFonts.SelectedItem = "Tahoma";
            cmbSizes.SelectedItem = 14;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Rich Text Format|*.rtf";
            save.DefaultExt = "rtf";

            if (save.ShowDialog() == DialogResult.OK)
            {
                richText.SaveFile(save.FileName, RichTextBoxStreamType.RichText);
                MessageBox.Show("Lưu văn bản thành công!");
            }
        }
    }
}
