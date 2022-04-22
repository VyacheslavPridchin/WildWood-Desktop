using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WildWood_Desktop
{
    public partial class Dialog : Form
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

        private void Dialog_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
        }
    }
}
