namespace Task2
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
            numLen = new NumericUpDown();
            numUpper = new NumericUpDown();
            numDigits = new NumericUpDown();
            numSpec = new NumericUpDown();
            numLower = new NumericUpDown();
            btnGen = new Button();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numLen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpper).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDigits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSpec).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLower).BeginInit();
            SuspendLayout();
            // 
            // numLen
            // 
            numLen.Location = new Point(335, 257);
            numLen.Name = "numLen";
            numLen.Size = new Size(252, 27);
            numLen.TabIndex = 0;
            // 
            // numUpper
            // 
            numUpper.Location = new Point(335, 125);
            numUpper.Name = "numUpper";
            numUpper.Size = new Size(252, 27);
            numUpper.TabIndex = 1;
            numUpper.ValueChanged += numUpper_ValueChanged;
            // 
            // numDigits
            // 
            numDigits.Location = new Point(335, 191);
            numDigits.Name = "numDigits";
            numDigits.Size = new Size(252, 27);
            numDigits.TabIndex = 2;
            // 
            // numSpec
            // 
            numSpec.Location = new Point(335, 224);
            numSpec.Name = "numSpec";
            numSpec.Size = new Size(252, 27);
            numSpec.TabIndex = 3;
            // 
            // numLower
            // 
            numLower.Location = new Point(335, 158);
            numLower.Name = "numLower";
            numLower.Size = new Size(252, 27);
            numLower.TabIndex = 4;
            // 
            // btnGen
            // 
            btnGen.Location = new Point(292, 290);
            btnGen.Name = "btnGen";
            btnGen.Size = new Size(295, 29);
            btnGen.TabIndex = 5;
            btnGen.Text = "Генерувати!";
            btnGen.UseVisualStyleBackColor = true;
            btnGen.Click += button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(292, 325);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(295, 27);
            txtPassword.TabIndex = 6;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 328);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 7;
            label1.Text = "Результат:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 259);
            label2.Name = "label2";
            label2.Size = new Size(194, 20);
            label2.TabIndex = 8;
            label2.Text = "Введіть кількість символів:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 127);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 9;
            label3.Text = "Великі літери (%):";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(195, 165);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 10;
            label4.Text = "Малі літери (%):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(228, 198);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 11;
            label5.Text = "Цифри (%):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(180, 231);
            label6.Name = "label6";
            label6.Size = new Size(134, 20);
            label6.TabIndex = 12;
            label6.Text = "Спецсимволи (%):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(378, 89);
            label7.Name = "label7";
            label7.Size = new Size(143, 20);
            label7.TabIndex = 13;
            label7.Text = "Створення паролю";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(btnGen);
            Controls.Add(numLower);
            Controls.Add(numSpec);
            Controls.Add(numDigits);
            Controls.Add(numUpper);
            Controls.Add(numLen);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numLen).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpper).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDigits).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSpec).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLower).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numLen;
        private NumericUpDown numUpper;
        private NumericUpDown numDigits;
        private NumericUpDown numSpec;
        private NumericUpDown numLower;
        private Button btnGen;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
