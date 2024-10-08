namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Add = new Button();
            Multiply = new Button();
            Divide = new Button();
            Subtract = new Button();
            Result = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(187, 25);
            label1.Name = "label1";
            label1.Size = new Size(413, 39);
            label1.TabIndex = 0;
            label1.Text = "Calculator Application";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(106, 116);
            label2.Name = "label2";
            label2.Size = new Size(223, 29);
            label2.TabIndex = 1;
            label2.Text = "Enter First Integer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(106, 160);
            label3.Name = "label3";
            label3.Size = new Size(245, 29);
            label3.TabIndex = 2;
            label3.Text = "Enter Second Intger";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(418, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(418, 164);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(230, 27);
            textBox2.TabIndex = 4;
            // 
            // Add
            // 
            Add.BackColor = Color.IndianRed;
            Add.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add.Location = new Point(106, 227);
            Add.Name = "Add";
            Add.Size = new Size(120, 61);
            Add.TabIndex = 5;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // Multiply
            // 
            Multiply.BackColor = Color.IndianRed;
            Multiply.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Multiply.Location = new Point(379, 227);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(141, 61);
            Multiply.TabIndex = 6;
            Multiply.Text = "Multiply";
            Multiply.UseVisualStyleBackColor = false;
            Multiply.Click += button2_Click;
            // 
            // Divide
            // 
            Divide.BackColor = Color.IndianRed;
            Divide.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Divide.Location = new Point(526, 227);
            Divide.Name = "Divide";
            Divide.Size = new Size(122, 61);
            Divide.TabIndex = 7;
            Divide.Text = "Divide";
            Divide.UseVisualStyleBackColor = false;
            Divide.Click += Divide_Click;
            // 
            // Subtract
            // 
            Subtract.BackColor = Color.IndianRed;
            Subtract.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Subtract.Location = new Point(232, 227);
            Subtract.Name = "Subtract";
            Subtract.Size = new Size(141, 61);
            Subtract.TabIndex = 8;
            Subtract.Text = "Subtract";
            Subtract.UseVisualStyleBackColor = false;
            Subtract.Click += Subtract_Click;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.BackColor = Color.Maroon;
            Result.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Result.Location = new Point(318, 332);
            Result.Name = "Result";
            Result.Size = new Size(103, 41);
            Result.TabIndex = 9;
            Result.Text = "Result";
            Result.TextAlign = ContentAlignment.BottomRight;
            Result.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(106, 164);
            label5.Name = "label5";
            label5.Size = new Size(260, 29);
            label5.TabIndex = 11;
            label5.Text = "Enter Second Integer";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(Result);
            Controls.Add(Subtract);
            Controls.Add(Divide);
            Controls.Add(Multiply);
            Controls.Add(Add);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Calculator App";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button Add;
        private Button Multiply;
        private Button Divide;
        private Button Subtract;
        private Label Result;
        private Label label5;
    }
}
