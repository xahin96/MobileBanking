namespace Remote_Banking_System
{
    partial class FormLoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoan));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.buttonReq = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label5000 = new System.Windows.Forms.Label();
            this.labelZero = new System.Windows.Forms.Label();
            this.label50000 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(182, 78);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(119, 20);
            this.textBoxAmount.TabIndex = 1;
            this.textBoxAmount.Text = "Enter Amount";
            this.textBoxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAmount.Click += new System.EventHandler(this.textBoxAmount_Click);
            // 
            // buttonReq
            // 
            this.buttonReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReq.Location = new System.Drawing.Point(245, 215);
            this.buttonReq.Name = "buttonReq";
            this.buttonReq.Size = new System.Drawing.Size(115, 34);
            this.buttonReq.TabIndex = 2;
            this.buttonReq.Text = "Request Loan";
            this.buttonReq.UseVisualStyleBackColor = true;
            this.buttonReq.Click += new System.EventHandler(this.buttonReq_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(136, 215);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(103, 34);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label5000
            // 
            this.label5000.AutoSize = true;
            this.label5000.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5000.ForeColor = System.Drawing.Color.Red;
            this.label5000.Location = new System.Drawing.Point(28, 118);
            this.label5000.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5000.Name = "label5000";
            this.label5000.Size = new System.Drawing.Size(356, 16);
            this.label5000.TabIndex = 12;
            this.label5000.Text = "You Can Have Loan Only If Your Balance <5000 TK";
            this.label5000.Visible = false;
            // 
            // labelZero
            // 
            this.labelZero.AutoSize = true;
            this.labelZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZero.ForeColor = System.Drawing.Color.Red;
            this.labelZero.Location = new System.Drawing.Point(89, 147);
            this.labelZero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZero.Name = "labelZero";
            this.labelZero.Size = new System.Drawing.Size(228, 16);
            this.labelZero.TabIndex = 13;
            this.labelZero.Text = "And If Your Loan Amount Is Zero";
            this.labelZero.Visible = false;
            // 
            // label50000
            // 
            this.label50000.AutoSize = true;
            this.label50000.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50000.ForeColor = System.Drawing.Color.Red;
            this.label50000.Location = new System.Drawing.Point(47, 176);
            this.label50000.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label50000.Name = "label50000";
            this.label50000.Size = new System.Drawing.Size(313, 16);
            this.label50000.TabIndex = 14;
            this.label50000.Text = "Maximum Amount Of Loan Is Below 50000 TK";
            this.label50000.Visible = false;
            // 
            // FormLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 261);
            this.Controls.Add(this.label50000);
            this.Controls.Add(this.labelZero);
            this.Controls.Add(this.label5000);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonReq);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Banking System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLoan_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button buttonReq;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label5000;
        private System.Windows.Forms.Label labelZero;
        private System.Windows.Forms.Label label50000;
    }
}