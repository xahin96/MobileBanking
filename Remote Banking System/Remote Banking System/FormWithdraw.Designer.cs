namespace Remote_Banking_System
{
    partial class FormWithdraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWithdraw));
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelPreBalance = new System.Windows.Forms.Label();
            this.labelCurrentBalance = new System.Windows.Forms.Label();
            this.labelShowPreBalance = new System.Windows.Forms.Label();
            this.labelShowPostBalance = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.Location = new System.Drawing.Point(161, 26);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(213, 20);
            this.labelMessage.TabIndex = 0;
            this.labelMessage.Text = "Withdrawn Successfully!!!";
            this.labelMessage.Visible = false;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(120, 120);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(53, 16);
            this.labelAmount.TabIndex = 2;
            this.labelAmount.Text = "Amount";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(214, 119);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(127, 20);
            this.textBoxAmount.TabIndex = 4;
            this.textBoxAmount.Text = "0";
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(231, 248);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(335, 248);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 6;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // labelPreBalance
            // 
            this.labelPreBalance.AutoSize = true;
            this.labelPreBalance.Location = new System.Drawing.Point(94, 86);
            this.labelPreBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPreBalance.Name = "labelPreBalance";
            this.labelPreBalance.Size = new System.Drawing.Size(93, 13);
            this.labelPreBalance.TabIndex = 7;
            this.labelPreBalance.Text = "Previous Balance:";
            this.labelPreBalance.Visible = false;
            // 
            // labelCurrentBalance
            // 
            this.labelCurrentBalance.AutoSize = true;
            this.labelCurrentBalance.Location = new System.Drawing.Point(94, 148);
            this.labelCurrentBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentBalance.Name = "labelCurrentBalance";
            this.labelCurrentBalance.Size = new System.Drawing.Size(89, 13);
            this.labelCurrentBalance.TabIndex = 8;
            this.labelCurrentBalance.Text = "Current  Balance:";
            this.labelCurrentBalance.Visible = false;
            // 
            // labelShowPreBalance
            // 
            this.labelShowPreBalance.AutoSize = true;
            this.labelShowPreBalance.Location = new System.Drawing.Point(195, 86);
            this.labelShowPreBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShowPreBalance.Name = "labelShowPreBalance";
            this.labelShowPreBalance.Size = new System.Drawing.Size(13, 13);
            this.labelShowPreBalance.TabIndex = 9;
            this.labelShowPreBalance.Text = "0";
            this.labelShowPreBalance.Visible = false;
            // 
            // labelShowPostBalance
            // 
            this.labelShowPostBalance.AutoSize = true;
            this.labelShowPostBalance.Location = new System.Drawing.Point(195, 148);
            this.labelShowPostBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShowPostBalance.Name = "labelShowPostBalance";
            this.labelShowPostBalance.Size = new System.Drawing.Size(13, 13);
            this.labelShowPostBalance.TabIndex = 10;
            this.labelShowPostBalance.Text = "0";
            this.labelShowPostBalance.Visible = false;
            this.labelShowPostBalance.Click += new System.EventHandler(this.c);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(348, 120);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(109, 16);
            this.labelError.TabIndex = 11;
            this.labelError.Text = "Error Amount!!!";
            this.labelError.Visible = false;
            // 
            // FormWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 327);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelShowPostBalance);
            this.Controls.Add(this.labelShowPreBalance);
            this.Controls.Add(this.labelCurrentBalance);
            this.Controls.Add(this.labelPreBalance);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWithdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Banking System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormWithdraw_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelPreBalance;
        private System.Windows.Forms.Label labelCurrentBalance;
        private System.Windows.Forms.Label labelShowPreBalance;
        private System.Windows.Forms.Label labelShowPostBalance;
        private System.Windows.Forms.Label labelError;
    }
}