namespace SimpleCalculator
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonPlus = new Button();
            buttonMin = new Button();
            buttonBagi = new Button();
            buttonKali = new Button();
            buttonClear = new Button();
            menuStrip1 = new MenuStrip();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(155, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(155, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(203, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(155, 183);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(203, 27);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 44);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 3;
            label1.Text = "Nilai 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 111);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 4;
            label2.Text = "Nilai 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 183);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 5;
            label3.Text = "Hasil:";
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(60, 236);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(100, 100);
            buttonPlus.TabIndex = 6;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMin
            // 
            buttonMin.Location = new Point(60, 343);
            buttonMin.Name = "buttonMin";
            buttonMin.Size = new Size(100, 100);
            buttonMin.TabIndex = 7;
            buttonMin.Text = "-";
            buttonMin.UseVisualStyleBackColor = true;
            buttonMin.Click += buttonMin_Click;
            // 
            // buttonBagi
            // 
            buttonBagi.Location = new Point(166, 343);
            buttonBagi.Name = "buttonBagi";
            buttonBagi.Size = new Size(100, 100);
            buttonBagi.TabIndex = 9;
            buttonBagi.Text = "/";
            buttonBagi.UseVisualStyleBackColor = true;
            buttonBagi.Click += buttonBagi_Click;
            // 
            // buttonKali
            // 
            buttonKali.Location = new Point(166, 236);
            buttonKali.Name = "buttonKali";
            buttonKali.Size = new Size(100, 100);
            buttonKali.TabIndex = 8;
            buttonKali.Text = "*";
            buttonKali.UseVisualStyleBackColor = true;
            buttonKali.Click += buttonKali_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(272, 236);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(100, 207);
            buttonClear.TabIndex = 10;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(417, 28);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(47, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 470);
            Controls.Add(buttonClear);
            Controls.Add(buttonBagi);
            Controls.Add(buttonKali);
            Controls.Add(buttonMin);
            Controls.Add(buttonPlus);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "SimpleCalculator";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonPlus;
        private Button buttonMin;
        private Button buttonBagi;
        private Button buttonKali;
        private Button buttonClear;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}