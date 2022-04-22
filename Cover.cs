using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WildWood_Desktop
{
    public partial class Cover : Form
    {
        Main mainForm;
        public Cover(Main main)
        {
            InitializeComponent();

            mainForm = main;
        }

        private void Cover_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MakeScreenshot();
                Dialog dialog = new Dialog("Введите имя карты");
                dialog.ShowDialog();
                mainForm.AddMapSet(Dialog.result == "" ? "Карта" : Dialog.result );
                this.Close();
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            mainForm.TopMost = false;
        }

        Bitmap bitmap;
        void MakeScreenshot()
        {
            bitmap = new Bitmap(496, 305);
            Graphics g = Graphics.FromImage(bitmap);
            g.CopyFromScreen(new Point(this.Location.X + 749, this.Location.Y + 137), Point.Empty, new Size(501, 280));
            bitmap.Save("screenshot.png");
            bitmap.Dispose();
        }

        private void empty_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cover_Load(object sender, EventArgs e)
        {

        }
    }
}
