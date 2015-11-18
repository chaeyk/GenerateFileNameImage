using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GenerateFileNameImage
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if (dlgSelectFolder.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = dlgSelectFolder.SelectedPath;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (tbPath.Text.Length == 0)
                return;

            foreach (string filepath in Directory.EnumerateFiles(tbPath.Text))
            {
                GenerateImage(filepath);
            }
        }

        private void GenerateImage(string filepath)
        {
            string path = Path.GetDirectoryName(filepath);
            string filename = Path.GetFileName(filepath);

            Font font = new Font("맑은 고딕", 15);
            Color textColor = Color.White;
            Color backColor = Color.Black;

            SizeF textSize = new SizeF(320, 200);

            //create a new image of the right size
            Image img = new Bitmap((int)textSize.Width, (int)textSize.Height);

            Graphics drawing = Graphics.FromImage(img);

            //paint the background
            drawing.Clear(backColor);

            //create a brush for the text
            Brush textBrush = new SolidBrush(textColor);

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            drawing.DrawString(filename, font, textBrush, new RectangleF(new PointF(0, 0), textSize), stringFormat);

            drawing.Save();

            textBrush.Dispose();
            drawing.Dispose();

            img.Save(path + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(filename) + ".png");
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string filepath in s)
            {
                GenerateImage(filepath);
            }
        }
    }
}
