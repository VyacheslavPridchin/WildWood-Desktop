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
    public partial class Favorite : UserControl
    {
        public int id = -1;
        public Favorite()
        {
            InitializeComponent();
        }

        private void wwLabel2_Click(object sender, EventArgs e)
        {
            Program.client.RemoveFavorite(id);
            Parent.Controls.Remove(this);
        }

        private void Favorite_Click(object sender, EventArgs e)
        {
            Program.client.GetFavorite(System.IO.File.ReadAllText("token"), id);
        }
    }
}
