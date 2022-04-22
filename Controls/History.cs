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
    public partial class History : UserControl
    {
        public History(string text)
        {
            InitializeComponent();
            label.Text = text;
        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}
