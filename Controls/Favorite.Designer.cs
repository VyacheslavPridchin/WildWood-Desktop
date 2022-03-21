
namespace WildWood_Desktop.Controls
{
    partial class Favorite
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label = new WWLabel();
            this.icon = new System.Windows.Forms.PictureBox();
            this.wwLabel2 = new WWLabel();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Roboto Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label.Location = new System.Drawing.Point(66, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(191, 25);
            this.label.TabIndex = 0;
            this.label.Text = "Название избранного";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.Gray;
            this.icon.Location = new System.Drawing.Point(0, 0);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(63, 45);
            this.icon.TabIndex = 1;
            this.icon.TabStop = false;
            // 
            // wwLabel2
            // 
            this.wwLabel2.CustomFont = Painter.Fonts.FontsName.Roboto_Light;
            this.wwLabel2.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Pixel);
            this.wwLabel2.ForeColor = System.Drawing.Color.Gray;
            this.wwLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.wwLabel2.Location = new System.Drawing.Point(69, 25);
            this.wwLabel2.Name = "wwLabel2";
            this.wwLabel2.Size = new System.Drawing.Size(46, 20);
            this.wwLabel2.TabIndex = 10;
            this.wwLabel2.Text = "Удалить";
            this.wwLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wwLabel2.Click += new System.EventHandler(this.wwLabel2_Click);
            // 
            // Favorite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.wwLabel2);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.label);
            this.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Name = "Favorite";
            this.Size = new System.Drawing.Size(280, 45);
            this.Click += new System.EventHandler(this.Favorite_Click);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WWLabel label;
        private System.Windows.Forms.PictureBox icon;
        private WWLabel wwLabel2;
    }
}
