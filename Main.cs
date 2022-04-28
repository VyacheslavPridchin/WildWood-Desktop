using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WildWood_Desktop.Controls;
using System.IO;
using System.Drawing.Imaging;
using OMTP;

namespace WildWood_Desktop
{
    public partial class Main : Form
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

        public void LoadMapSet(string url, int sens)
        {
            chromiumWebBrowser1.Load(url);
            trackBar1.Value = sens;
        }

        public void ClearFavorite()
        {
            this.Invoke(new Action(() => func()));
            void func()
            {
                flowLayoutPanel2.Controls.Clear();
            }
        }

        public void SpawnFavorite(int id, string name)
        {
            this.Invoke(new Action(() => func()));
            void func()
            {
                Favorite favorite = new Favorite();
                favorite.id = id;
                (favorite.Controls.Find("label", true)[0] as WWLabel).Text = name;
                flowLayoutPanel2.Controls.Add(favorite);
            }
        }

        public void ClearMapSet()
        {
            this.Invoke(new Action(() => func()));
            void func()
            {
                flowLayoutPanel1.Controls.Clear();
            }
        }

        public void SpawnMapSet(string name, string url, int sens, Image image)
        {
            this.Invoke(new Action(() => func()));
            void func()
            {
                MapSet mapSet = new MapSet(image);
                mapSet.name = name;
                mapSet.url = url;
                mapSet.sens = sens;
                (mapSet.Controls.Find("label", true)[0] as WWLabel).Text = name;
                flowLayoutPanel1.Controls.Add(mapSet);
                mapSets.Add(mapSet);
            }
        }

        public List<MapSet> mapSets = new List<MapSet>();
        public Main()
        {
            InitializeComponent();

            ClientExtensions.main = this;

            chromiumWebBrowser1.LoadUrl("https://yandex.ru/map-widget/v1/-/CCUFyOxVxA");

             
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
        }

        private void wwButton6_Click(object sender, EventArgs e)
        {
            Packet packet = new Packet();

            packet.Write(mapSets.Count);
            foreach (var mapSet in mapSets)
            {
                packet.Write(mapSet.name);
                packet.Write(mapSet.url);
                packet.Write(mapSet.sens);
                byte[] bytes = ImageToByteArray(mapSet.mapImage);
                packet.Write(bytes.Length);
                packet.Write(bytes);
            }

            Dialog dialog = new Dialog("Введите имя избранного сета");
            dialog.ShowDialog();


            Favorite favorite = new Favorite();
            (favorite.Controls.Find("label", true)[0] as WWLabel).Text = Dialog.result == "" ? "Избранный сет" : Dialog.result;

            Program.client.AddFavorite(File.ReadAllText("token"), Dialog.result == "" ? "Избранный сет" : Dialog.result, packet.ToArray());

            flowLayoutPanel2.Controls.Add(favorite);
        }

        private void wwButton4_Click(object sender, EventArgs e)
        {
            Report report = new Report(mapSets);
            report.ShowDialog();
            History history = new History("Отчёт от " + DateTime.Now.ToString());
            flowLayoutPanel3.Controls.Add(history);
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void wwButton7_Click(object sender, EventArgs e)
        {
            flowLayoutPanel3.Controls.Clear();
        }

        private void wwButton2_Click(object sender, EventArgs e)
        {
            Cover cover = new Cover(this);
            cover.Show();
            cover.Owner = this;
            cover.Location = this.Location;
            cover.Focus();
        }

        public void AddMapSet(string name)
        {
            Image img;
            using (var bmpTemp = new Bitmap("screenshot.png"))
            {
                img = new Bitmap(bmpTemp);
            }
            MapSet mapSet = new MapSet(img);
            File.Delete("screenshot.png");
            mapSet.name = name;
            mapSet.url = chromiumWebBrowser1.Address;
            mapSet.sens = trackBar1.Value;
            (mapSet.Controls.Find("label", true)[0] as WWLabel).Text = name;
            flowLayoutPanel1.Controls.Add(mapSet);
            mapSets.Add(mapSet);
        }

        public void AddMapSet(string name, Image image)
        {
            MapSet mapSet = new MapSet(image);
            mapSet.name = name;
            mapSet.url = chromiumWebBrowser1.Address;
            mapSet.sens = trackBar1.Value;
            (mapSet.Controls.Find("label", true)[0] as WWLabel).Text = name;
            flowLayoutPanel1.Controls.Add(mapSet);
            mapSets.Add(mapSet);
        }

        private void wwButton5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            mapSets.Clear();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
        }

        private void animator_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.05f;
            else animator.Enabled = false;
        }

        private void wwButton8_Click(object sender, EventArgs e)
        {
            Program.client.GetFavoriteList(File.ReadAllText("token"));
        }

        private void wwButton1_Click(object sender, EventArgs e)
        {
            File.Delete("token");
            Application.Exit();
        }

        private void wwButton3_Click(object sender, EventArgs e)
        {
            var resultDialog = openFileDialog1.ShowDialog();

            if (resultDialog == DialogResult.OK)
            {
                Dialog dialog = new Dialog("Введите имя карты");
                dialog.ShowDialog();
                AddMapSet(Dialog.result == "" ? "Карта" : Dialog.result, new Bitmap(openFileDialog1.FileName));
            }
        }
    }
}
