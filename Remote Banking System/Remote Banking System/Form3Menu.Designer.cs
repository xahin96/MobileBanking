namespace Remote_Banking_System
{
    partial class Form3Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3Menu));
            this.button1Balance = new System.Windows.Forms.Button();
            this.button3withdraw = new System.Windows.Forms.Button();
            this.button4Deposit = new System.Windows.Forms.Button();
            this.button5Transfer = new System.Windows.Forms.Button();
            this.button6RequestLoan = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelWelcomeMessage = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1Balance
            // 
            this.button1Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Balance.Location = new System.Drawing.Point(92, 33);
            this.button1Balance.Name = "button1Balance";
            this.button1Balance.Size = new System.Drawing.Size(155, 23);
            this.button1Balance.TabIndex = 0;
            this.button1Balance.Text = "Balance Details";
            this.button1Balance.UseVisualStyleBackColor = true;
            this.button1Balance.Click += new System.EventHandler(this.button1Balance_Click);
            // 
            // button3withdraw
            // 
            this.button3withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3withdraw.Location = new System.Drawing.Point(92, 62);
            this.button3withdraw.Name = "button3withdraw";
            this.button3withdraw.Size = new System.Drawing.Size(155, 23);
            this.button3withdraw.TabIndex = 2;
            this.button3withdraw.Text = "Withdraw";
            this.button3withdraw.UseVisualStyleBackColor = true;
            this.button3withdraw.Click += new System.EventHandler(this.button3withdraw_Click);
            // 
            // button4Deposit
            // 
            this.button4Deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4Deposit.Location = new System.Drawing.Point(92, 91);
            this.button4Deposit.Name = "button4Deposit";
            this.button4Deposit.Size = new System.Drawing.Size(155, 23);
            this.button4Deposit.TabIndex = 3;
            this.button4Deposit.Text = "Deposit";
            this.button4Deposit.UseVisualStyleBackColor = true;
            this.button4Deposit.Click += new System.EventHandler(this.button4Deposit_Click);
            // 
            // button5Transfer
            // 
            this.button5Transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5Transfer.Location = new System.Drawing.Point(92, 120);
            this.button5Transfer.Name = "button5Transfer";
            this.button5Transfer.Size = new System.Drawing.Size(155, 23);
            this.button5Transfer.TabIndex = 4;
            this.button5Transfer.Text = "Transfer";
            this.button5Transfer.UseVisualStyleBackColor = true;
            this.button5Transfer.Click += new System.EventHandler(this.button5Transfer_Click);
            // 
            // button6RequestLoan
            // 
            this.button6RequestLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6RequestLoan.Location = new System.Drawing.Point(92, 149);
            this.button6RequestLoan.Name = "button6RequestLoan";
            this.button6RequestLoan.Size = new System.Drawing.Size(155, 23);
            this.button6RequestLoan.TabIndex = 5;
            this.button6RequestLoan.Text = "Request Loan";
            this.button6RequestLoan.UseVisualStyleBackColor = true;
            this.button6RequestLoan.Click += new System.EventHandler(this.button6RequestLoan_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(268, 241);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(88, 30);
            this.buttonLogout.TabIndex = 7;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelWelcomeMessage
            // 
            this.labelWelcomeMessage.AutoSize = true;
            this.labelWelcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeMessage.Location = new System.Drawing.Point(146, 6);
            this.labelWelcomeMessage.Name = "labelWelcomeMessage";
            this.labelWelcomeMessage.Size = new System.Drawing.Size(51, 16);
            this.labelWelcomeMessage.TabIndex = 7;
            this.labelWelcomeMessage.Text = "label1";
            this.labelWelcomeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(92, 178);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(155, 50);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Update Name Password";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // Form3Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 283);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelWelcomeMessage);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.button6RequestLoan);
            this.Controls.Add(this.button5Transfer);
            this.Controls.Add(this.button4Deposit);
            this.Controls.Add(this.button3withdraw);
            this.Controls.Add(this.button1Balance);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Banking System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3Menu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Balance;
        private System.Windows.Forms.Button button3withdraw;
        private System.Windows.Forms.Button button4Deposit;
        private System.Windows.Forms.Button button5Transfer;
        private System.Windows.Forms.Button button6RequestLoan;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelWelcomeMessage;
        private System.Windows.Forms.Button buttonUpdate;
    }
}