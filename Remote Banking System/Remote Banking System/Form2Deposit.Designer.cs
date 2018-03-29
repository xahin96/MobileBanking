namespace Remote_Banking_System
{
    partial class Form2Deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2Deposit));
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelPreBalance = new System.Windows.Forms.Label();
            this.labelCurrentBalance = new System.Windows.Forms.Label();
            this.labelShowPreBalance = new System.Windows.Forms.Label();
            this.labelShowPostBalance = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(125, 116);
            this.labelAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(53, 16);
            this.labelAmount.TabIndex = 0;
            this.labelAmount.Text = "Amount";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(236, 116);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(145, 22);
            this.textBoxAmount.TabIndex = 1;
            this.textBoxAmount.Text = "0";
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(283, 263);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 28);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(415, 263);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(100, 28);
            this.buttonConfirm.TabIndex = 3;
            this.buttonConfirm.Text = "Corfirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.Location = new System.Drawing.Point(155, 29);
            this.labelMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(183, 16);
            this.labelMessage.TabIndex = 4;
            this.labelMessage.Text = "Successfully Deposited!!!";
            this.labelMessage.Visible = false;
            // 
            // labelPreBalance
            // 
            this.labelPreBalance.AutoSize = true;
            this.labelPreBalance.Location = new System.Drawing.Point(94, 87);
            this.labelPreBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPreBalance.Name = "labelPreBalance";
            this.labelPreBalance.Size = new System.Drawing.Size(117, 16);
            this.labelPreBalance.TabIndex = 5;
            this.labelPreBalance.Text = "Previous Balance:";
            this.labelPreBalance.Visible = false;
            // 
            // labelCurrentBalance
            // 
            this.labelCurrentBalance.AutoSize = true;
            this.labelCurrentBalance.Location = new System.Drawing.Point(94, 132);
            this.labelCurrentBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentBalance.Name = "labelCurrentBalance";
            this.labelCurrentBalance.Size = new System.Drawing.Size(109, 16);
            this.labelCurrentBalance.TabIndex = 6;
            this.labelCurrentBalance.Text = "Current  Balance:";
            this.labelCurrentBalance.Visible = false;
            // 
            // labelShowPreBalance
            // 
            this.labelShowPreBalance.AutoSize = true;
            this.labelShowPreBalance.Location = new System.Drawing.Point(216, 87);
            this.labelShowPreBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShowPreBalance.Name = "labelShowPreBalance";
            this.labelShowPreBalance.Size = new System.Drawing.Size(15, 16);
            this.labelShowPreBalance.TabIndex = 7;
            this.labelShowPreBalance.Text = "0";
            this.labelShowPreBalance.Visible = false;
            // 
            // labelShowPostBalance
            // 
            this.labelShowPostBalance.AutoSize = true;
            this.labelShowPostBalance.Location = new System.Drawing.Point(216, 132);
            this.labelShowPostBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShowPostBalance.Name = "labelShowPostBalance";
            this.labelShowPostBalance.Size = new System.Drawing.Size(15, 16);
            this.labelShowPostBalance.TabIndex = 8;
            this.labelShowPostBalance.Text = "0";
            this.labelShowPostBalance.Visible = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(406, 116);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(109, 16);
            this.labelError.TabIndex = 12;
            this.labelError.Text = "Error Amount!!!";
            this.labelError.Visible = false;
            // 
            // Form2Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 321);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelShowPostBalance);
            this.Controls.Add(this.labelShowPreBalance);
            this.Controls.Add(this.labelCurrentBalance);
            this.Controls.Add(this.labelPreBalance);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.labelAmount);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2Deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Banking System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2Deposit_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelPreBalance;
        private System.Windows.Forms.Label labelCurrentBalance;
        private System.Windows.Forms.Label labelShowPreBalance;
        private System.Windows.Forms.Label labelShowPostBalance;
        private System.Windows.Forms.Label labelError;
    }
}