
namespace WindowsFormsApp_Calculator
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.rdAdd = new System.Windows.Forms.RadioButton();
            this.rdSubtract = new System.Windows.Forms.RadioButton();
            this.rdMultiply = new System.Windows.Forms.RadioButton();
            this.rdDivide = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.AcceptsTab = true;
            this.txtNum1.Location = new System.Drawing.Point(331, 34);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(300, 26);
            this.txtNum1.TabIndex = 0;
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum2
            // 
            this.txtNum2.AcceptsTab = true;
            this.txtNum2.Location = new System.Drawing.Point(331, 102);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(300, 26);
            this.txtNum2.TabIndex = 1;
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(67, 34);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(167, 20);
            this.lblNum1.TabIndex = 2;
            this.lblNum1.Text = "Enter the first number ";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(67, 102);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(193, 20);
            this.lblNum2.TabIndex = 3;
            this.lblNum2.Text = "Enter the second number ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Coral;
            this.btnCalculate.Location = new System.Drawing.Point(273, 234);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(180, 52);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // rdAdd
            // 
            this.rdAdd.AutoSize = true;
            this.rdAdd.Location = new System.Drawing.Point(160, 177);
            this.rdAdd.Name = "rdAdd";
            this.rdAdd.Size = new System.Drawing.Size(63, 24);
            this.rdAdd.TabIndex = 9;
            this.rdAdd.TabStop = true;
            this.rdAdd.Text = "Add";
            this.rdAdd.UseVisualStyleBackColor = true;
            // 
            // rdSubtract
            // 
            this.rdSubtract.AutoSize = true;
            this.rdSubtract.Location = new System.Drawing.Point(263, 177);
            this.rdSubtract.Name = "rdSubtract";
            this.rdSubtract.Size = new System.Drawing.Size(95, 24);
            this.rdSubtract.TabIndex = 10;
            this.rdSubtract.TabStop = true;
            this.rdSubtract.Text = "Subtract";
            this.rdSubtract.UseVisualStyleBackColor = true;
            // 
            // rdMultiply
            // 
            this.rdMultiply.AutoSize = true;
            this.rdMultiply.Location = new System.Drawing.Point(401, 177);
            this.rdMultiply.Name = "rdMultiply";
            this.rdMultiply.Size = new System.Drawing.Size(86, 24);
            this.rdMultiply.TabIndex = 11;
            this.rdMultiply.TabStop = true;
            this.rdMultiply.Text = "Multiply";
            this.rdMultiply.UseVisualStyleBackColor = true;
            // 
            // rdDivide
            // 
            this.rdDivide.AutoSize = true;
            this.rdDivide.Location = new System.Drawing.Point(517, 177);
            this.rdDivide.Name = "rdDivide";
            this.rdDivide.Size = new System.Drawing.Size(77, 24);
            this.rdDivide.TabIndex = 12;
            this.rdDivide.TabStop = true;
            this.rdDivide.Text = "Divide";
            this.rdDivide.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdDivide);
            this.Controls.Add(this.rdMultiply);
            this.Controls.Add(this.rdSubtract);
            this.Controls.Add(this.rdAdd);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RadioButton rdAdd;
        private System.Windows.Forms.RadioButton rdSubtract;
        private System.Windows.Forms.RadioButton rdMultiply;
        private System.Windows.Forms.RadioButton rdDivide;
    }
}

