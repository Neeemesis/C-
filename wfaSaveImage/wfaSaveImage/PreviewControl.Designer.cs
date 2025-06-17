namespace ImageConverter
{
    partial class PreviewControl
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
            pnlTop = new Panel();
            listBox1 = new Label();
            pnlBottom = new Panel();
            lbSize = new Label();
            pbImage = new PictureBox();
            pnlTop.SuspendLayout();
            pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(listBox1);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(4);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(283, 29);
            pnlTop.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.AutoSize = true;
            listBox1.Location = new Point(4, 7);
            listBox1.Margin = new Padding(4, 0, 4, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(55, 15);
            listBox1.TabIndex = 0;
            listBox1.Text = "lbQuality";
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(lbSize);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 218);
            pnlBottom.Margin = new Padding(4);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(283, 26);
            pnlBottom.TabIndex = 1;
            // 
            // lbSize
            // 
            lbSize.AutoSize = true;
            lbSize.Dock = DockStyle.Right;
            lbSize.Location = new Point(246, 0);
            lbSize.Margin = new Padding(4, 0, 4, 0);
            lbSize.Name = "lbSize";
            lbSize.Size = new Size(37, 15);
            lbSize.TabIndex = 0;
            lbSize.Text = "lbSize";
            // 
            // pbImage
            // 
            pbImage.BackColor = Color.Black;
            pbImage.Dock = DockStyle.Fill;
            pbImage.Location = new Point(0, 29);
            pbImage.Margin = new Padding(4);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(283, 189);
            pbImage.SizeMode = PictureBoxSizeMode.CenterImage;
            pbImage.TabIndex = 2;
            pbImage.TabStop = false;
            // 
            // PreviewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pbImage);
            Controls.Add(pnlBottom);
            Controls.Add(pnlTop);
            Margin = new Padding(4);
            Name = "PreviewControl";
            Size = new Size(283, 244);
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Label listBox1;
        private Panel pnlBottom;
        private Label lbSize;
        private PictureBox pbImage;
    }
}
