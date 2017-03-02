using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCutter4CAH
{
    public partial class FrmCAHCreator : Form
    {
        private FolderBrowserDialog Directory = new FolderBrowserDialog();

        public FrmCAHCreator()
        {
            InitializeComponent();
            Directory.SelectedPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
        }

        private void BtnDir_Click(object sender, EventArgs e)
        {
            DialogResult Result = Directory.ShowDialog();

            if (!string.IsNullOrWhiteSpace(Directory.SelectedPath))
            {
                TxtDir.Text = Directory.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Page = Convert.ToInt32(PageNumberSelector.Value);

            for (int card = 1; card < 21; card++)
            {
                CropImage(Page, card);
            }

        }

        public void CropImage(int PageNumber, int CardNumber)
        {
            int PointX = 81 + (((CardNumber % 4) - 1) * 598);
            int PointY = 158 + (((CardNumber / 4)) * 598);

            if ((CardNumber % 4) == 0)
            {
                PointX = 81 + (3 * 598);
                PointY -= 598;
            }

            try
            {
                Rectangle cropRect = new Rectangle(PointX, PointY, 598, 598);
                Bitmap src = Image.FromFile(Directory.SelectedPath + "\\CAH_MainGame-" + intTo2CharString(PageNumber) + ".png") as Bitmap;
                Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);

                using (Graphics g = Graphics.FromImage(target))
                {
                    g.DrawImage(src, new Rectangle(0, 0, target.Width, target.Height),
                                     cropRect,
                                     GraphicsUnit.Pixel);
                }

                target.Save(Directory.SelectedPath + "\\C#Cards\\Card" + intTo3CharString(CardNumber + (PageNumber * 20) - 20) + ".png", ImageFormat.Png);
                //target.Save("C:\\Users\\kurtl\\Desktop\\Card" + intTo3CharString(CardNumber) + ".png", ImageFormat.Png);

                src = null;
                target = null;
            }
            catch (OutOfMemoryException)
            {
            }
        }

        public string intTo3CharString(int Number)
        {
            string Result = "";
            if (Number < 100)
            {
                Result += "0";
            }

            if (Number < 10)
            {
                Result += "0";
            }

            Result += Number;

            return Result;
        }

        public string intTo2CharString(int Number)
        {
            string Result = "";

            if (Number < 10)
            {
                Result += "0";
            }

            Result += Number;

            return Result;
        }
    }
}
