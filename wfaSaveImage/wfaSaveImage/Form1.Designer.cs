namespace wfaSaveImage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            saveFileDialog1 = new SaveFileDialog();
            buOpen = new Button();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ImageWidth = new Label();
            label6 = new Label();
            ImageHeight = new Label();
            label8 = new Label();
            ImageSize = new Label();
            label10 = new Label();
            ImageFormat = new Label();
            buSave = new Button();
            checkBoxLines = new CheckBox();
            checkBoxDiagonals = new CheckBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // buOpen
            // 
            buOpen.Location = new Point(12, 21);
            buOpen.Name = "buOpen";
            buOpen.Size = new Size(153, 42);
            buOpen.TabIndex = 0;
            buOpen.Text = "Открыть...";
            buOpen.UseVisualStyleBackColor = true;
            buOpen.Click += buOpen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 2;
            label1.Text = "Параметры файла:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(ImageWidth, 1, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 2);
            tableLayoutPanel1.Controls.Add(ImageHeight, 1, 2);
            tableLayoutPanel1.Controls.Add(label8, 0, 3);
            tableLayoutPanel1.Controls.Add(ImageSize, 1, 3);
            tableLayoutPanel1.Controls.Add(label10, 0, 4);
            tableLayoutPanel1.Controls.Add(ImageFormat, 1, 4);
            tableLayoutPanel1.Location = new Point(12, 89);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(191, 196);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 39);
            label2.TabIndex = 0;
            label2.Text = "Название";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 1;
            label3.Text = "Значение";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 39);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 2;
            label4.Text = "Ширина:";
            // 
            // ImageWidth
            // 
            ImageWidth.AutoSize = true;
            ImageWidth.Location = new Point(79, 39);
            ImageWidth.Name = "ImageWidth";
            ImageWidth.Size = new Size(17, 20);
            ImageWidth.TabIndex = 3;
            ImageWidth.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 78);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 4;
            label6.Text = "Высота:";
            // 
            // ImageHeight
            // 
            ImageHeight.AutoSize = true;
            ImageHeight.Location = new Point(79, 78);
            ImageHeight.Name = "ImageHeight";
            ImageHeight.Size = new Size(17, 20);
            ImageHeight.TabIndex = 5;
            ImageHeight.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 117);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 6;
            label8.Text = "Размер:";
            // 
            // ImageSize
            // 
            ImageSize.AutoSize = true;
            ImageSize.Location = new Point(79, 117);
            ImageSize.Name = "ImageSize";
            ImageSize.Size = new Size(17, 20);
            ImageSize.TabIndex = 7;
            ImageSize.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 156);
            label10.Name = "label10";
            label10.Size = new Size(66, 20);
            label10.TabIndex = 8;
            label10.Text = "Формат:";
            // 
            // ImageFormat
            // 
            ImageFormat.AutoSize = true;
            ImageFormat.Location = new Point(79, 156);
            ImageFormat.Name = "ImageFormat";
            ImageFormat.Size = new Size(92, 20);
            ImageFormat.TabIndex = 9;
            ImageFormat.Text = "не известен";
            // 
            // buSave
            // 
            buSave.Location = new Point(12, 456);
            buSave.Name = "buSave";
            buSave.Size = new Size(153, 44);
            buSave.TabIndex = 1;
            buSave.Text = "Сохранить все";
            buSave.UseVisualStyleBackColor = true;
            buSave.Click += buSave_Click;
            // 
            // checkBoxLines
            // 
            checkBoxLines.AutoSize = true;
            checkBoxLines.Location = new Point(457, 467);
            checkBoxLines.Name = "checkBoxLines";
            checkBoxLines.Size = new Size(187, 24);
            checkBoxLines.TabIndex = 5;
            checkBoxLines.Text = "направляющие линии";
            checkBoxLines.UseVisualStyleBackColor = true;
            checkBoxLines.CheckedChanged += checkBoxLines_CheckedChanged;
            // 
            // checkBoxDiagonals
            // 
            checkBoxDiagonals.AutoSize = true;
            checkBoxDiagonals.Location = new Point(234, 467);
            checkBoxDiagonals.Name = "checkBoxDiagonals";
            checkBoxDiagonals.Size = new Size(217, 24);
            checkBoxDiagonals.TabIndex = 6;
            checkBoxDiagonals.Text = "направляющие диагонали";
            checkBoxDiagonals.UseVisualStyleBackColor = true;
            checkBoxDiagonals.CheckedChanged += checkBoxDiagonals_CheckedChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(234, 21);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(710, 440);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 291);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.Size = new Size(191, 124);
            listBox1.TabIndex = 11;
            listBox1.SelectedValueChanged += listBox1_SelectedValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(697, 471);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(797, 471);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 512);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(checkBoxDiagonals);
            Controls.Add(checkBoxLines);
            Controls.Add(buSave);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(buOpen);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private SaveFileDialog saveFileDialog1;
        private Button buSave;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label ImageWidth;
        private Label label6;
        private Label ImageHeight;
        private Label label8;
        private Label ImageSize;
        private Label label10;
        private Label ImageFormat;
        private Label label1;
        private Button buOpen;
        private CheckBox checkBoxLines;
        private CheckBox checkBoxDiagonals;
        private FlowLayoutPanel flowLayoutPanel1;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
    }
}