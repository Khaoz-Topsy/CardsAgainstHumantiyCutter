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
            string tempDir = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            Directory.SelectedPath = tempDir + "\\data\\CAH_MainGame";
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
            //int Page = Convert.ToInt32(PageNumberSelector.Value);
            NumPages.Value++;

            for (int Page = 1; Page < NumPages.Value; Page++)
            {
                for (int card = 1; card < 21; card++)
                {
                    CropImage(Page, card);
                }
            }

            Application.Exit();
        }

        public void CropImage(int PageNumber, int CardNumber)
        {
            int xAdjust = 54;
            int yAdjust = 105;
            int cardSize = 398;

            int PointX = xAdjust + (((CardNumber % 4) - 1) * cardSize);
            int PointY = yAdjust + (((CardNumber / 4)) * cardSize);

            if ((CardNumber % 4) == 0)
            {
                PointX = xAdjust + (3 * cardSize);
                PointY -= cardSize;
            }

            try
            {
                Rectangle cropRect = new Rectangle(PointX, PointY, cardSize, cardSize);
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

                src.Dispose();
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
