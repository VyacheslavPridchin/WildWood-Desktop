using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WildWood_Desktop.Controls
{
    public partial class MapSet : UserControl
    {
        public Image mapImage;
        public string url;
        public int sens;
        public string name;

        public MapSet(Image image)
        {
            InitializeComponent();

            (this.Controls.Find("icon", true)[0] as PictureBox).BackgroundImage = image;
            mapImage = image;
        }

        private void wwLabel2_Click(object sender, EventArgs e)
        {
            ((Main)this.ParentForm).mapSets.Remove(this);
            Parent.Controls.Remove(this);
        }

        private void MapSet_Click(object sender, EventArgs e)
        {
            ((Main)this.ParentForm).LoadMapSet(url, sens);
        }
    }
}
