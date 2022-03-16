using Tesseract;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;


namespace LVLUP_
{
    public partial class Overlay : Form
    {
        public Overlay()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
/*            while (true)
            {*/

                int xSize = 300;
                int ySize = 35;
                Bitmap bitmap = new Bitmap(xSize, ySize);
                Graphics g = Graphics.FromImage(bitmap as Image);
                g.CopyFromScreen(new Point((Screen.PrimaryScreen.Bounds.Width - xSize) / 2, Screen.PrimaryScreen.Bounds.Height - 205), new Point(0, 0), new Size(xSize, ySize));
                bitmap.Save("C:/Users/admin/source/repos/LVLUP!/TEMP/temp.jpg");
                var Result = new IronOcr.IronTesseract().Read("C:/Users/admin/source/repos/LVLUP!/TEMP/temp.jpg");
                string currentSubText = Result.Text;

                label2.Text = currentSubText;

                if (currentSubText.Contains("Coast"))
                {
                    label1.Text = "Go to waypoint and enter The Mud Flats";
                }
                if (currentSubText.Contains("Lion"))
                {
                    label1.Text = "Talk to Nessa";
                }
                
/*            }
            Thread.Sleep(3000);*/



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}