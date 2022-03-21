using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WildWood_Desktop
{
    public partial class Login : Form
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

        public static Action onAuth;

        public Login()
        {
            InitializeComponent();
            onAuth += () =>  this.Invoke(new Action(() => LoadMain()));
        }

        void LoadMain()
        {
            Main main = new Main();
            animator.Enabled = true;
            main.Show();
            main.Opacity = 0;
            main.Location = this.Location;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
        }

        private void animator_Tick(object sender, EventArgs e)
        {
            if(this.Opacity > 0)
                this.Opacity -= 0.05f;
            else
                this.Hide();
        }

        private void wwButton1_Click_1(object sender, EventArgs e)
        {
            ClientExtensions.login = wwInput1.Text;
            ClientExtensions.password = wwInput2.Text;

            Program.client.Auth(wwInput1.Text, wwInput2.Text);
        }

        private void wwLabel2_Click(object sender, EventArgs e)
        {
            ClientExtensions.login = wwInput1.Text;
            ClientExtensions.password = wwInput2.Text;

            Program.client.Register(wwInput1.Text, wwInput2.Text);
        }
    }
}
