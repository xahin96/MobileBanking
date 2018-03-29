namespace Remote_Banking_System
{
    partial class FormTransfer
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
            this.labelReceiverAccNo = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxReceiverAccNo = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.labelErrorAcc = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelShowPreBalance = new System.Windows.Forms.Label();
            this.labelPreBalance = new System.Windows.Forms.Label();
            this.labelCurrentBalance = new System.Windows.Forms.Label();
            this.labelShowPostBalance = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelReceiverAccNo
            // 
            this.labelReceiverAccNo.AutoSize = true;
            this.labelReceiverAccNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReceiverAccNo.Location = new System.Drawing.Point(6, 69);
            this.labelReceiverAccNo.Name = "labelReceiverAccNo";
            this.labelReceiverAccNo.Size = new System.Drawing.Size(165, 16);
            this.labelReceiverAccNo.TabIndex = 0;
            this.labelReceiverAccNo.Text = "Receiver Account Number";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(118, 115);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(53, 16);
            this.labelAmount.TabIndex = 1;
            this.labelAmount.Text = "Amount";
            // 
            // textBoxReceiverAccNo
            // 
            this.textBoxReceiverAccNo.Location = new System.Drawing.Point(177, 65);
            this.textBoxReceiverAccNo.Name = "textBoxReceiverAccNo";
            this.textBoxReceiverAccNo.Size = new System.Drawing.Size(127, 20);
            this.textBoxReceiverAccNo.TabIndex = 2;
            this.textBoxReceiverAccNo.Text = "0";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(177, 114);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(127, 20);
            this.textBoxAmount.TabIndex = 3;
            this.textBoxAmount.Text = "0";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(313, 118);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(109, 16);
            this.labelError.TabIndex = 13;
            this.labelError.Text = "Error Amount!!!";
            this.labelError.Visible = false;
            // 
            // labelErrorAcc
            // 
            this.labelErrorAcc.AutoSize = true;
            this.labelErrorAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorAcc.ForeColor = System.Drawing.Color.Red;
            this.labelErrorAcc.Location = new System.Drawing.Point(311, 69);
            this.labelErrorAcc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErrorAcc.Name = "labelErrorAcc";
            this.labelErrorAcc.Size = new System.Drawing.Size(113, 16);
            this.labelErrorAcc.TabIndex = 14;
            this.labelErrorAcc.Text = "Error Account!!!";
            this.labelErrorAcc.Visible = false;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(270, 208);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(100, 28);
            this.buttonConfirm.TabIndex = 15;
            this.buttonConfirm.Text = "Corfirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(162, 208);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 28);
            this.buttonBack.TabIndex = 16;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelShowPreBalance
            // 
            this.labelShowPreBalance.AutoSize = true;
            this.labelShowPreBalance.Location = new System.Drawing.Point(179, 88);
            this.labelShowPreBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShowPreBalance.Name = "labelShowPreBalance";
            this.labelShowPreBalance.Size = new System.Drawing.Size(13, 13);
            this.labelShowPreBalance.TabIndex = 18;
            this.labelShowPreBalance.Text = "0";
            this.labelShowPreBalance.Visible = false;
            // 
            // labelPreBalance
            // 
            this.labelPreBalance.AutoSize = true;
            this.labelPreBalance.Location = new System.Drawing.Point(78, 88);
            this.labelPreBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPreBalance.Name = "labelPreBalance";
            this.labelPreBalance.Size = new System.Drawing.Size(93, 13);
            this.labelPreBalance.TabIndex = 17;
            this.labelPreBalance.Text = "Previous Balance:";
            this.labelPreBalance.Visible = false;
            // 
            // labelCurrentBalance
            // 
            this.labelCurrentBalance.AutoSize = true;
            this.labelCurrentBalance.Location = new System.Drawing.Point(78, 121);
            this.labelCurrentBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentBalance.Name = "labelCurrentBalance";
            this.labelCurrentBalance.Size = new System.Drawing.Size(89, 13);
            this.labelCurrentBalance.TabIndex = 19;
            this.labelCurrentBalance.Text = "Current  Balance:";
            this.labelCurrentBalance.Visible = false;
            this.labelCurrentBalance.Click += new System.EventHandler(this.v);
            // 
            // labelShowPostBalance
            // 
            this.labelShowPostBalance.AutoSize = true;
            this.labelShowPostBalance.Location = new System.Drawing.Point(179, 121);
            this.labelShowPostBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShowPostBalance.Name = "labelShowPostBalance";
            this.labelShowPostBalance.Size = new System.Drawing.Size(13, 13);
            this.labelShowPostBalance.TabIndex = 20;
            this.labelShowPostBalance.Text = "0";
            this.labelShowPostBalance.Visible = false;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.Location = new System.Drawing.Point(118, 21);
            this.labelMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(192, 16);
            this.labelMessage.TabIndex = 21;
            this.labelMessage.Text = "Successfully Transferred!!!";
            this.labelMessage.Visible = false;
            // 
            // FormTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 261);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelShowPostBalance);
            this.Controls.Add(this.labelCurrentBalance);
            this.Controls.Add(this.labelShowPreBalance);
            this.Controls.Add(this.labelPreBalance);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.labelErrorAcc);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxReceiverAccNo);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelReceiverAccNo);
            this.Name = "FormTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Banking System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTransfer_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReceiverAccNo;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxReceiverAccNo;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelErrorAcc;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelShowPreBalance;
        private System.Windows.Forms.Label labelPreBalance;
        private System.Windows.Forms.Label labelCurrentBalance;
        private System.Windows.Forms.Label labelShowPostBalance;
        private System.Windows.Forms.Label labelMessage;
    }
}