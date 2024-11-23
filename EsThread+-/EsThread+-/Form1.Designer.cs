namespace EsThread__
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
            btnThreadmeno = new Button();
            btnThreadPiu = new Button();
            number1 = new Label();
            number3 = new Label();
            number2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            SuspendLayout();
            // 
            // btnThreadmeno
            // 
            btnThreadmeno.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnThreadmeno.Location = new Point(192, 222);
            btnThreadmeno.Name = "btnThreadmeno";
            btnThreadmeno.Size = new Size(126, 70);
            btnThreadmeno.TabIndex = 2;
            btnThreadmeno.Text = "thread -";
            btnThreadmeno.UseVisualStyleBackColor = true;
            btnThreadmeno.Click += btnThreadmeno_Click;
            // 
            // btnThreadPiu
            // 
            btnThreadPiu.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnThreadPiu.Location = new Point(456, 222);
            btnThreadPiu.Name = "btnThreadPiu";
            btnThreadPiu.Size = new Size(126, 70);
            btnThreadPiu.TabIndex = 3;
            btnThreadPiu.Text = "thread +";
            btnThreadPiu.UseVisualStyleBackColor = true;
            btnThreadPiu.Click += btnThreadPiu_Click;
            // 
            // number1
            // 
            number1.AutoSize = true;
            number1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            number1.Location = new Point(139, 91);
            number1.Name = "number1";
            number1.Size = new Size(56, 32);
            number1.TabIndex = 4;
            number1.Text = "100";
            // 
            // number3
            // 
            number3.AutoSize = true;
            number3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            number3.Location = new Point(559, 91);
            number3.Name = "number3";
            number3.Size = new Size(56, 32);
            number3.TabIndex = 5;
            number3.Text = "100";
            // 
            // number2
            // 
            number2.AutoSize = true;
            number2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            number2.Location = new Point(354, 91);
            number2.Name = "number2";
            number2.Size = new Size(56, 32);
            number2.TabIndex = 6;
            number2.Text = "100";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(123, 126);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(336, 126);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(541, 126);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 19);
            radioButton3.TabIndex = 9;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(number2);
            Controls.Add(number3);
            Controls.Add(number1);
            Controls.Add(btnThreadPiu);
            Controls.Add(btnThreadmeno);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnThreadmeno;
        private Button btnThreadPiu;
        private Label number1;
        private Label number3;
        private Label number2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
    }
}