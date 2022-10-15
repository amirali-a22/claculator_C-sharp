namespace Calculator
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.num2 = new System.Windows.Forms.NumericUpDown();
            this.Plus = new System.Windows.Forms.Button();
            this.Multiple = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(62, 7);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(119, 22);
            this.num1.TabIndex = 2;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(62, 35);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(119, 22);
            this.num2.TabIndex = 3;
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(188, 5);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(35, 23);
            this.Plus.TabIndex = 4;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // Multiple
            // 
            this.Multiple.Location = new System.Drawing.Point(188, 33);
            this.Multiple.Name = "Multiple";
            this.Multiple.Size = new System.Drawing.Size(35, 23);
            this.Multiple.TabIndex = 5;
            this.Multiple.Text = "*";
            this.Multiple.UseVisualStyleBackColor = true;
            this.Multiple.Click += new System.EventHandler(this.Multiple_Click);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(229, 33);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(35, 23);
            this.Divide.TabIndex = 6;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divid_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(229, 6);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(35, 23);
            this.Minus.TabIndex = 7;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 83);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiple);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num1;
        private System.Windows.Forms.NumericUpDown num2;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Multiple;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Minus;
    }
}

