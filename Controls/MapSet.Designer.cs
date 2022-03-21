
namespace WildWood_Desktop.Controls
{
    partial class MapSet
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
            this.wwLabel2 = new WWLabel();
            this.icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Roboto Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label.Location = new System.Drawing.Point(146, 6);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(286, 25);
            this.label.TabIndex = 1;
            this.label.Text = "Название карты";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // wwLabel2
            // 
            this.wwLabel2.CustomFont = Painter.Fonts.FontsName.Roboto_Light;
            this.wwLabel2.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Pixel);
            this.wwLabel2.ForeColor = System.Drawing.Color.Gray;
            this.wwLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.wwLabel2.Location = new System.Drawing.Point(146, 31);
            this.wwLabel2.Name = "wwLabel2";
            this.wwLabel2.Size = new System.Drawing.Size(46, 20);
            this.wwLabel2.TabIndex = 11;
            this.wwLabel2.Text = "Удалить";
            this.wwLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wwLabel2.Click += new System.EventHandler(this.wwLabel2_Click);
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.SystemColors.Control;
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icon.Location = new System.Drawing.Point(0, 0);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(140, 60);
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // MapSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.wwLabel2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.icon);
            this.Name = "MapSet";
            this.Size = new System.Drawing.Size(630, 60);
            this.Click += new System.EventHandler(this.MapSet_Click);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox icon;
        private WWLabel label;
        private WWLabel wwLabel2;
    }
}
