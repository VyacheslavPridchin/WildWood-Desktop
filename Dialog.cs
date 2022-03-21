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
    public partial class Dialog : Form
    {
        public static string result = "";
        public Dialog(string title)
        {
            InitializeComponent();

            wwLabel1.Text = title;
        }

        private void wwButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            result = wwInput1.Text == wwInput1.GhostText ? "" : wwInput1.Text;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            wwInput1.Text = "";
            this.Close();
        }
    }
}
