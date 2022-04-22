
namespace WildWood_Desktop
{
    partial class Dialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog));
            this.wwInput1 = new WWInput();
            this.wwLabel1 = new WWLabel();
            this.wwButton3 = new WWButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // wwInput1
            // 
            this.wwInput1.BackColor = System.Drawing.Color.Silver;
            this.wwInput1.CustomBackColor = System.Drawing.Color.Silver;
            this.wwInput1.CustomForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wwInput1.CustomGhostForeColor = System.Drawing.Color.Gray;
            this.wwInput1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.wwInput1.GhostText = "Значение";
            this.wwInput1.Location = new System.Drawing.Point(17, 68);
            this.wwInput1.Name = "wwInput1";
            this.wwInput1.PasswordChar = '\0';
            this.wwInput1.Size = new System.Drawing.Size(335, 37);
            this.wwInput1.TabIndex = 6;
            this.wwInput1.Text = "Значение";
            // 
            // wwLabel1
            // 
            this.wwLabel1.BackColor = System.Drawing.Color.Transparent;
            this.wwLabel1.Font = new System.Drawing.Font("Roboto Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.wwLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wwLabel1.Location = new System.Drawing.Point(12, 19);
            this.wwLabel1.Name = "wwLabel1";
            this.wwLabel1.Size = new System.Drawing.Size(340, 46);
            this.wwLabel1.TabIndex = 7;
            this.wwLabel1.Text = "Введите значение";
            this.wwLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wwButton3
            // 
            this.wwButton3.BackColor = System.Drawing.Color.Silver;
            this.wwButton3.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.wwButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wwButton3.Location = new System.Drawing.Point(64, 127);
            this.wwButton3.Name = "wwButton3";
            this.wwButton3.ShadowColor = System.Drawing.Color.Black;
            this.wwButton3.Size = new System.Drawing.Size(241, 35);
            this.wwButton3.TabIndex = 9;
            this.wwButton3.Text = "Подтвердить";
            this.wwButton3.UseVisualStyleBackColor = false;
            this.wwButton3.Click += new System.EventHandler(this.wwButton3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Location = new System.Drawing.Point(310, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(54, 13);
            this.panel2.TabIndex = 10;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(364, 177);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.wwButton3);
            this.Controls.Add(this.wwLabel1);
            this.Controls.Add(this.wwInput1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ц";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dialog_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dialog_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private WWInput wwInput1;
        private WWLabel wwLabel1;
        private WWButton wwButton3;
        private System.Windows.Forms.Panel panel2;
    }
}