
namespace WildWood_Desktop.Controls
{
    partial class History
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
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Roboto Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label.Location = new System.Drawing.Point(3, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(254, 25);
            this.label.TabIndex = 1;
            this.label.Text = "Имя запроса";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // wwLabel2
            // 
            this.wwLabel2.CustomFont = Painter.Fonts.FontsName.Roboto_Light;
            this.wwLabel2.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Pixel);
            this.wwLabel2.ForeColor = System.Drawing.Color.Gray;
            this.wwLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.wwLabel2.Location = new System.Drawing.Point(3, 25);
            this.wwLabel2.Name = "wwLabel2";
            this.wwLabel2.Size = new System.Drawing.Size(77, 20);
            this.wwLabel2.TabIndex = 11;
            this.wwLabel2.Text = "Открыть отчёт";
            this.wwLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.wwLabel2);
            this.Controls.Add(this.label);
            this.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Name = "History";
            this.Size = new System.Drawing.Size(280, 45);
            this.ResumeLayout(false);

        }

        #endregion

        private WWLabel label;
        private WWLabel wwLabel2;
    }
}
