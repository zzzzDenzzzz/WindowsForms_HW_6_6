using System;
using System.IO;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Clipboard.Clear();
            Text = "";
        }

        void Open()
        {
            using (var open = new OpenFileDialog())
            {
                open.Filter = "All Files(*.*)|*.*| Text Files(*.txt)|*.txt";
                open.FilterIndex = 2;

                if (open.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader reader = File.OpenText(open.FileName))
                    {
                        Text = Path.GetFullPath(open.FileName);
                        textBox.Text = reader.ReadToEnd();
                    }
                }
            }
        }

        void Save()
        {
            if (Text != "")
            {
                using (var stream = new StreamWriter(Path.GetFullPath(Text), false))
                {
                    stream.WriteLine(textBox.Text);
                    MessageBox.Show($"Файл сохранен по адресу {Text}");
                }
                Clipboard.Clear();
            }
            else
            {
                MessageBox.Show("Сначала откройте файл");
            }
        }

        void NewDocument()
        {
            var form = new Form1();
            form.Show();
        }

        void Copy()
        {
            if (textBox.SelectedText == "")
            {
                MessageBox.Show("Текст не выделен");
            }
            else
            {
                textBox.Copy();
                MessageBox.Show("Текст скопирован в буфер");
            }
        }

        void Cut()
        {
            if (textBox.SelectedText == "")
            {
                MessageBox.Show("Текст не выделен");
            }
            else
            {
                textBox.Cut();
            }
        }

        void Insert()
        {
            if (Clipboard.ContainsText())
            {
                textBox.Paste();
            }
            else
            {
                MessageBox.Show("Буфер пуст");
            }
        }

        void Cancel()
        {
            textBox.Undo();
            textBox.ClearUndo();
        }

        void FontColor()
        {
            using (var fontColor = new ColorDialog())
            {
                if (fontColor.ShowDialog() == DialogResult.OK)
                {
                    textBox.ForeColor = fontColor.Color;
                }
            }
        }

        void BackgroundColor()
        {
            using (var background = new ColorDialog())
            {
                if (background.ShowDialog() == DialogResult.OK)
                {
                    textBox.BackColor = background.Color;
                }
            }
        }

        new void Font()
        {
            using (var font = new FontDialog())
            {
                if (font.ShowDialog() == DialogResult.OK)
                {
                    textBox.Font = font.Font;
                }
            }
        }

        void SelectAll()
        {
            textBox.Focus();
            textBox.SelectAll();
        }

        void SaveAs()
        {
            using (var save = new SaveFileDialog())
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    using (var writer = new StreamWriter(save.FileName))
                    {
                        writer.Write(textBox.Text);
                    }
                }
            }
        }

        private void toolStripLabelOpen_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void toolStripLabelSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void toolStripLabelNewDocument_Click(object sender, EventArgs e)
        {
            NewDocument();
        }

        private void toolStripLabelCopy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void toolStripLabelCut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void toolStripLabelInsert_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void toolStripLabelCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void panelFont_Click(object sender, EventArgs e)
        {
            Font();
        }

        private void panelBackgroundColor_Click(object sender, EventArgs e)
        {
            BackgroundColor();
        }

        private void panelFontColor_Click(object sender, EventArgs e)
        {
            FontColor();
        }

        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void toolStripMenuItemNewDocument_Click(object sender, EventArgs e)
        {
            NewDocument();
        }

        private void toolStripMenuItemCopy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void toolStripMenuItemCut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void toolStripMenuItemInsert_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void toolStripMenuItemCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void ToolStripMenuItemFontColor_Click(object sender, EventArgs e)
        {
            FontColor();
        }

        private void toolStripMenuItemBackgroundColor_Click(object sender, EventArgs e)
        {
            BackgroundColor();
        }

        private void toolStripMenuItemFont_Click(object sender, EventArgs e)
        {
            Font();
        }

        private void toolStripMenuItemSelectAll_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void toolStripMenuItemSaveAs_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void ContextMenuItemCopy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void ContextMenuItemCut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void ContextMenuItemInsert_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void ContextMenuItemCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }
    }
}
