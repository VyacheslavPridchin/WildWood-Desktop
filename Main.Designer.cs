
namespace WildWood_Desktop
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.animator = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.wwButton8 = new WWButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.wwButton7 = new WWButton();
            this.wwButton6 = new WWButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.wwButton5 = new WWButton();
            this.wwButton4 = new WWButton();
            this.wwButton3 = new WWButton();
            this.wwLabel2 = new WWLabel();
            this.wwLabel1 = new WWLabel();
            this.wwButton2 = new WWButton();
            this.wwButton1 = new WWButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // animator
            // 
            this.animator.Enabled = true;
            this.animator.Interval = 1;
            this.animator.Tick += new System.EventHandler(this.animator_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(238)))));
            this.panel1.BackgroundImage = global::WildWood_Desktop.Properties.Resources.MainBackground_Dark;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 13);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::WildWood_Desktop.Properties.Resources.MainBackground;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.wwButton8);
            this.panel3.Controls.Add(this.trackBar1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.chromiumWebBrowser1);
            this.panel3.Controls.Add(this.wwButton7);
            this.panel3.Controls.Add(this.wwButton6);
            this.panel3.Controls.Add(this.flowLayoutPanel3);
            this.panel3.Controls.Add(this.flowLayoutPanel2);
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Controls.Add(this.wwButton5);
            this.panel3.Controls.Add(this.wwButton4);
            this.panel3.Controls.Add(this.wwButton3);
            this.panel3.Controls.Add(this.wwLabel2);
            this.panel3.Controls.Add(this.wwLabel1);
            this.panel3.Controls.Add(this.wwButton2);
            this.panel3.Controls.Add(this.wwButton1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1280, 720);
            this.panel3.TabIndex = 6;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // wwButton8
            // 
            this.wwButton8.BackColor = System.Drawing.Color.Silver;
            this.wwButton8.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.wwButton8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wwButton8.Location = new System.Drawing.Point(74, 300);
            this.wwButton8.Name = "wwButton8";
            this.wwButton8.ShadowColor = System.Drawing.Color.Black;
            this.wwButton8.Size = new System.Drawing.Size(198, 35);
            this.wwButton8.TabIndex = 14;
            this.wwButton8.Text = "Обновить";
            this.wwButton8.UseVisualStyleBackColor = false;
            this.wwButton8.Click += new System.EventHandler(this.wwButton8_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(372, 439);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(859, 45);
            this.trackBar1.TabIndex = 13;
            this.trackBar1.Value = 80;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Location = new System.Drawing.Point(1204, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(76, 13);
            this.panel2.TabIndex = 0;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
// TODO: Код для "" не создан из-за исключения "Недопустимый тип примитива: System.IntPtr. Рекомендуется применить класс CodeObjectCreateExpression.".
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(347, 84);
            this.chromiumWebBrowser1.Margin = new System.Windows.Forms.Padding(0);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(909, 352);
            this.chromiumWebBrowser1.TabIndex = 0;
            // 
            // wwButton7
            // 
            this.wwButton7.BackColor = System.Drawing.Color.Silver;
            this.wwButton7.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.wwButton7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wwButton7.Location = new System.Drawing.Point(74, 650);
            this.wwButton7.Name = "wwButton7";
            this.wwButton7.ShadowColor = System.Drawing.Color.Black;
            this.wwButton7.Size = new System.Drawing.Size(198, 35);
            this.wwButton7.TabIndex = 12;
            this.wwButton7.Text = "Очистить историю";
            this.wwButton7.UseVisualStyleBackColor = false;
            this.wwButton7.Click += new System.EventHandler(this.wwButton7_Click);
            // 
            // wwButton6
            // 
            this.wwButton6.BackColor = System.Drawing.Color.Silver;
            this.wwButton6.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.wwButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wwButton6.Location = new System.Drawing.Point(1045, 584);
            this.wwButton6.Name = "wwButton6";
            this.wwButton6.ShadowColor = System.Drawing.Color.Black;
            this.wwButton6.Size = new System.Drawing.Size(186, 35);
            this.wwButton6.TabIndex = 11;
            this.wwButton6.Text = "В избранное";
            this.wwButton6.UseVisualStyleBackColor = false;
            this.wwButton6.Click += new System.EventHandler(this.wwButton6_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(24, 430);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(299, 214);
            this.flowLayoutPanel3.TabIndex = 10;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(24, 73);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(299, 219);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(370, 508);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(654, 188);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // wwButton5
            // 
            this.wwButton5.BackColor = System.Drawing.Color.Silver;
            this.wwButton5.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.wwButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wwButton5.Location = new System.Drawing.Point(1045, 634);
            this.wwButton5.Name = "wwButton5";
            this.wwButton5.ShadowColor = System.Drawing.Color.Black;
            this.wwButton5.Size = new System.Drawing.Size(186, 35);
            this.wwButton5.TabIndex = 7;
            this.wwButton5.Text = "Стереть всё";
            this.wwButton5.UseVisualStyleBackColor = false;
            this.wwButton5.Click += new System.EventHandler(this.wwButton5_Click);
            // 
            // wwButton4
            // 
            this.wwButton4.BackColor = System.Drawing.Color.Silver;
            this.wwButton4.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.wwButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wwButton4.Location = new System.Drawing.Point(1045, 532);
            this.wwButton4.Name = "wwButton4";
            this.wwButton4.ShadowColor = System.Drawing.Color.Black;
            this.wwButton4.Size = new System.Drawing.Size(186, 35);
            this.wwButton4.TabIndex = 6;
            this.wwButton4.Text = "Составить отчёт";
            this.wwButton4.UseVisualStyleBackColor = false;
            this.wwButton4.Click += new System.EventHandler(this.wwButton4_Click);
            // 
            // wwButton3
            // 
            this.wwButton3.BackColor = System.Drawing.Color.Silver;
            this.wwButton3.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.wwButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wwButton3.Location = new System.Drawing.Point(565, 35);
            this.wwButton3.Name = "wwButton3";
            this.wwButton3.ShadowColor = System.Drawing.Color.Black;
            this.wwButton3.Size = new System.Drawing.Size(243, 35);
            this.wwButton3.TabIndex = 5;
            this.wwButton3.Text = "Загрузить изображение";
            this.wwButton3.UseVisualStyleBackColor = false;
            this.wwButton3.Click += new System.EventHandler(this.wwButton3_Click);
            // 
            // wwLabel2
            // 
            this.wwLabel2.BackColor = System.Drawing.Color.Transparent;
            this.wwLabel2.Font = new System.Drawing.Font("Roboto Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.wwLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wwLabel2.Location = new System.Drawing.Point(25, 381);
            this.wwLabel2.Name = "wwLabel2";
            this.wwLabel2.Size = new System.Drawing.Size(297, 46);
            this.wwLabel2.TabIndex = 4;
            this.wwLabel2.Text = "История";
            this.wwLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wwLabel1
            // 
            this.wwLabel1.BackColor = System.Drawing.Color.Transparent;
            this.wwLabel1.Font = new System.Drawing.Font("Roboto Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.wwLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wwLabel1.Location = new System.Drawing.Point(26, 26);
            this.wwLabel1.Name = "wwLabel1";
            this.wwLabel1.Size = new System.Drawing.Size(295, 46);
            this.wwLabel1.TabIndex = 3;
            this.wwLabel1.Text = "Избранное";
            this.wwLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wwButton2
            // 
            this.wwButton2.BackColor = System.Drawing.Color.Silver;
            this.wwButton2.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.wwButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wwButton2.Location = new System.Drawing.Point(370, 35);
            this.wwButton2.Name = "wwButton2";
            this.wwButton2.ShadowColor = System.Drawing.Color.Black;
            this.wwButton2.Size = new System.Drawing.Size(189, 35);
            this.wwButton2.TabIndex = 2;
            this.wwButton2.Text = "Добавить с карты";
            this.wwButton2.UseVisualStyleBackColor = false;
            this.wwButton2.Click += new System.EventHandler(this.wwButton2_Click);
            // 
            // wwButton1
            // 
            this.wwButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wwButton1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.wwButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wwButton1.Location = new System.Drawing.Point(1034, 35);
            this.wwButton1.Name = "wwButton1";
            this.wwButton1.ShadowColor = System.Drawing.Color.Black;
            this.wwButton1.Size = new System.Drawing.Size(197, 35);
            this.wwButton1.TabIndex = 1;
            this.wwButton1.Text = "Выход из аккаунта";
            this.wwButton1.UseVisualStyleBackColor = false;
            this.wwButton1.Click += new System.EventHandler(this.wwButton1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Изображения|*.jpg;*.jpeg;*.png";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private System.Windows.Forms.Panel panel3;
        private WWButton wwButton2;
        private WWLabel wwLabel1;
        private WWLabel wwLabel2;
        private WWButton wwButton3;
        private WWButton wwButton4;
        private WWButton wwButton5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private WWButton wwButton6;
        private WWButton wwButton7;
        private WWButton wwButton1;
        private System.Windows.Forms.Timer animator;
        private System.Windows.Forms.TrackBar trackBar1;
        private WWButton wwButton8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}