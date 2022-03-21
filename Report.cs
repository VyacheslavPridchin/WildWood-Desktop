using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WildWood_Desktop.Controls;

namespace WildWood_Desktop
{
    public partial class Report : Form
    {
        #region --- Для перетаскивания формы ---
        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);

        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool ReleaseCapture();

        const uint WM_SYSCOMMAND = 0x0112;
        const uint DOMOVE = 0xF012;
        const uint DOSIZE = 0xF008;
        #endregion
        List<MapSet> mapSets = new List<MapSet>();
        public Report(List<MapSet> _mapSets)
        {
            ClientExtensions.report = this;

            mapSets.AddRange(_mapSets.ToArray());

            InitializeComponent();
            AddLabel("Данный сет состоит из " + mapSets.Count + " карт.");

            if (mapSets.Count > 0)
            {
                AddLabel("Карта \"" + mapSets[0].name + "\"");
                AddImage(mapSets[0].mapImage);
                Program.client.ProcessMap(mapSets[0].sens, ImageToByteArray(mapSets[0].mapImage), File.ReadAllText("token"));
                mapSets.RemoveAt(0);
            }
        }

        public void AddProcessedPhotos(Image mask, Image border, float fillness)
        {
            this.Invoke(new Action(() => func()));
            void func()
            {
                AddLabel("Маска, отображающая лесной покров");
                AddImage(mask);

                AddLabel("Изображение границ лесов");
                AddImage(border);

                AddLabel("Процентное соотношение лесного прокрова равняется " + fillness + "%");

                if (mapSets.Count > 0)
                {
                    AddLabel("Карта \"" + mapSets[0].name + "\"");
                    AddImage(mapSets[0].mapImage);
                    Program.client.ProcessMap(mapSets[0].sens, ImageToByteArray(mapSets[0].mapImage), File.ReadAllText("token"));
                    mapSets.RemoveAt(0);
                }
            }
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        void AddLabel(string text)
        {
            Label label = new Label();
            label.Text = text;
            label.AutoSize = false;
            label.Dock = DockStyle.Top;
            label.Font = new Font("Roboto", 20, FontStyle.Regular, GraphicsUnit.Point);
            label.Width = 1080;
            label.Height = 40;
            label.TextAlign = ContentAlignment.MiddleCenter;
            flowLayoutPanel1.Controls.Add(label);
        }

        void AddImage(Image image)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Top;
            pictureBox.Height = 250;
            pictureBox.Width = 1080;
            pictureBox.BackgroundImage = image;
            pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            flowLayoutPanel1.Controls.Add(pictureBox);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
        }
    }
}
