namespace Remote_Banking_System
{
    partial class Deposit
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
            this.label1AcountNumber = new System.Windows.Forms.Label();
            this.label2Amount = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1Back = new System.Windows.Forms.Button();
            this.button2Next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1AcountNumber
            // 
            this.label1AcountNumber.AutoSize = true;
            this.label1AcountNumber.Location = new System.Drawing.Point(32, 34);
            this.label1AcountNumber.Name = "label1AcountNumber";
            this.label1AcountNumber.Size = new System.Drawing.Size(87, 13);
            this.label1AcountNumber.TabIndex = 0;
            this.label1AcountNumber.Text = "Account Number";
            // 
            // label2Amount
            // 
            this.label2Amount.AutoSize = true;
            this.label2Amount.Location = new System.Drawing.Point(32, 95);
            this.label2Amount.Name = "label2Amount";
            this.label2Amount.Size = new System.Drawing.Size(43, 13);
            this.label2Amount.TabIndex = 1;
            this.label2Amount.Text = "Amount";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button1Back
            // 
            this.button1Back.Location = new System.Drawing.Point(84, 264);
            this.button1Back.Name = "button1Back";
            this.button1Back.Size = new System.Drawing.Size(75, 23);
            this.button1Back.TabIndex = 4;
            this.button1Back.Text = "Back";
            this.button1Back.UseVisualStyleBackColor = true;
            // 
            // button2Next
            // 
            this.button2Next.Location = new System.Drawing.Point(297, 258);
            this.button2Next.Name = "button2Next";
            this.button2Next.Size = new System.Drawing.Size(75, 23);
            this.button2Next.TabIndex = 5;
            this.button2Next.Text = "Next";
            this.button2Next.UseVisualStyleBackColor = true;
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 331);
            this.Controls.Add(this.button2Next);
            this.Controls.Add(this.button1Back);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2Amount);
            this.Controls.Add(this.label1AcountNumber);
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1AcountNumber;
        private System.Windows.Forms.Label label2Amount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1Back;
        private System.Windows.Forms.Button button2Next;
    }
}

