
namespace WildWood_Desktop
{
    partial class Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.animator = new System.Windows.Forms.Timer(this.components);
            this.wwLabel2 = new WWLabel();
            this.wwInput2 = new WWInput();
            this.wwInput1 = new WWInput();
            this.wwButton1 = new WWButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WildWood_Desktop.Properties.Resources.LogoMascot_2;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // animator
            // 
            this.animator.Interval = 1;
            this.animator.Tick += new System.EventHandler(this.animator_Tick);
            // 
            // wwLabel2
            // 
            this.wwLabel2.CustomFont = Painter.Fonts.FontsName.Roboto_Light;
            resources.ApplyResources(this.wwLabel2, "wwLabel2");
            this.wwLabel2.ForeColor = System.Drawing.Color.Gray;
            this.wwLabel2.Name = "wwLabel2";
            this.wwLabel2.Click += new System.EventHandler(this.wwLabel2_Click);
            // 
            // wwInput2
            // 
            this.wwInput2.CustomBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(198)))), ((int)(((byte)(170)))));
            this.wwInput2.CustomForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wwInput2.CustomGhostForeColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.wwInput2, "wwInput2");
            this.wwInput2.GhostText = "Пароль";
            this.wwInput2.Name = "wwInput2";
            this.wwInput2.PasswordChar = '●';
            // 
            // wwInput1
            // 
            this.wwInput1.CustomBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(198)))), ((int)(((byte)(170)))));
            this.wwInput1.CustomForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wwInput1.CustomGhostForeColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.wwInput1, "wwInput1");
            this.wwInput1.GhostText = "Логин";
            this.wwInput1.Name = "wwInput1";
            this.wwInput1.PasswordChar = '\0';
            // 
            // wwButton1
            // 
            this.wwButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.wwButton1, "wwButton1");
            this.wwButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wwButton1.Name = "wwButton1";
            this.wwButton1.ShadowColor = System.Drawing.Color.Black;
            this.wwButton1.UseVisualStyleBackColor = false;
            this.wwButton1.Click += new System.EventHandler(this.wwButton1_Click_1);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(238)))));
            this.BackgroundImage = global::WildWood_Desktop.Properties.Resources.LoginBackground;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.wwLabel2);
            this.Controls.Add(this.wwInput2);
            this.Controls.Add(this.wwInput1);
            this.Controls.Add(this.wwButton1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private WWButton wwButton1;
        private WWInput wwInput1;
        private WWInput wwInput2;
        private WWLabel wwLabel2;
        private System.Windows.Forms.Timer animator;
    }
}

