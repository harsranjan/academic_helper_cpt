namespace harshbasiccalculator
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
            txtBox = new TextBox();
            btn1 = new Button();
            btnEql = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn0 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btnClr = new Button();
            btnDiv = new Button();
            btnMul = new Button();
            btnSub = new Button();
            btnAdd = new Button();
            btnPoint = new Button();
            SuspendLayout();
            // 
            // txtBox
            // 
            txtBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox.Location = new Point(12, 12);
            txtBox.Multiline = true;
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(359, 67);
            txtBox.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.DialogResult = DialogResult.TryAgain;
            btn1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(12, 95);
            btn1.Name = "btn1";
            btn1.Size = new Size(67, 54);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btnEql
            // 
            btnEql.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEql.Location = new Point(85, 329);
            btnEql.Name = "btnEql";
            btnEql.Size = new Size(285, 55);
            btnEql.TabIndex = 16;
            btnEql.Text = "=";
            btnEql.UseVisualStyleBackColor = true;
            btnEql.Click += btnEql_Click;
            // 
            // btn2
            // 
            btn2.DialogResult = DialogResult.TryAgain;
            btn2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(85, 95);
            btn2.Name = "btn2";
            btn2.Size = new Size(67, 54);
            btn2.TabIndex = 17;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.DialogResult = DialogResult.TryAgain;
            btn3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(158, 95);
            btn3.Name = "btn3";
            btn3.Size = new Size(67, 54);
            btn3.TabIndex = 18;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.DialogResult = DialogResult.TryAgain;
            btn4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(231, 95);
            btn4.Name = "btn4";
            btn4.Size = new Size(67, 54);
            btn4.TabIndex = 19;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.DialogResult = DialogResult.TryAgain;
            btn5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(304, 95);
            btn5.Name = "btn5";
            btn5.Size = new Size(67, 54);
            btn5.TabIndex = 20;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn0
            // 
            btn0.DialogResult = DialogResult.TryAgain;
            btn0.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(303, 171);
            btn0.Name = "btn0";
            btn0.Size = new Size(67, 54);
            btn0.TabIndex = 25;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn9
            // 
            btn9.DialogResult = DialogResult.TryAgain;
            btn9.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(230, 171);
            btn9.Name = "btn9";
            btn9.Size = new Size(67, 54);
            btn9.TabIndex = 24;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.DialogResult = DialogResult.TryAgain;
            btn8.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(157, 171);
            btn8.Name = "btn8";
            btn8.Size = new Size(67, 54);
            btn8.TabIndex = 23;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.DialogResult = DialogResult.TryAgain;
            btn7.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(84, 171);
            btn7.Name = "btn7";
            btn7.Size = new Size(67, 54);
            btn7.TabIndex = 22;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.DialogResult = DialogResult.TryAgain;
            btn6.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(11, 171);
            btn6.Name = "btn6";
            btn6.Size = new Size(67, 54);
            btn6.TabIndex = 21;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btnClr
            // 
            btnClr.DialogResult = DialogResult.TryAgain;
            btnClr.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClr.Location = new Point(304, 248);
            btnClr.Name = "btnClr";
            btnClr.Size = new Size(67, 54);
            btnClr.TabIndex = 30;
            btnClr.Text = "CLEAR";
            btnClr.UseVisualStyleBackColor = true;
            btnClr.Click += btnClr_Click;
            // 
            // btnDiv
            // 
            btnDiv.DialogResult = DialogResult.TryAgain;
            btnDiv.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiv.Location = new Point(231, 248);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(67, 54);
            btnDiv.TabIndex = 29;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnMul
            // 
            btnMul.DialogResult = DialogResult.TryAgain;
            btnMul.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnMul.Location = new Point(158, 248);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(67, 54);
            btnMul.TabIndex = 28;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnMul_Click;
            // 
            // btnSub
            // 
            btnSub.DialogResult = DialogResult.TryAgain;
            btnSub.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnSub.Location = new Point(85, 248);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(67, 54);
            btnSub.TabIndex = 27;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnAdd
            // 
            btnAdd.DialogResult = DialogResult.TryAgain;
            btnAdd.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(12, 248);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(67, 54);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnPoint
            // 
            btnPoint.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPoint.Location = new Point(12, 329);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(67, 55);
            btnPoint.TabIndex = 31;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = true;
            btnPoint.Click += btnPoint_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 396);
            Controls.Add(btnPoint);
            Controls.Add(btnClr);
            Controls.Add(btnDiv);
            Controls.Add(btnMul);
            Controls.Add(btnSub);
            Controls.Add(btnAdd);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btnEql);
            Controls.Add(btn1);
            Controls.Add(txtBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox;
        private Button btn1;
        private Button btnEql;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn0;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btnClr;
        private Button btnDiv;
        private Button btnMul;
        private Button btnSub;
        private Button btnAdd;
        private Button btnPoint;
    }
}