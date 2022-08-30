using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityAssistant
{
    public class InfoDisplay
    {
        public Form Display = new Form();

        public InfoDisplay()
        {
            Display.TopMost = true;
            Display.LostFocus += new EventHandler(ActivateForm);

            //MessageBox.Show("ttttttt");
        }

        public void PictureDisplay(string path)
        {
            System.IO.FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            var picture = System.Drawing.Image.FromStream(fs);
            Display.BackgroundImage = picture;
            Display.BackgroundImageLayout = ImageLayout.Stretch;
            Display.Width = picture.Width;
            Display.Height = picture.Height;
            Display.ShowDialog();
        }


        private void ActivateForm(object sender, EventArgs e)
        {
            Display.Activate();
            Display.Focus();

            Display.BringToFront();
        }
    }
}
