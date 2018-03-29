namespace Remote_Banking_System
{
    partial class FormBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBalance));
            this.labelBalanceName = new System.Windows.Forms.Label();
            this.buttonBalanceBack = new System.Windows.Forms.Button();
            this.dataGridUserDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUserDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBalanceName
            // 
            this.labelBalanceName.AutoSize = true;
            this.labelBalanceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalanceName.Location = new System.Drawing.Point(112, 9);
            this.labelBalanceName.Name = "labelBalanceName";
            this.labelBalanceName.Size = new System.Drawing.Size(235, 31);
            this.labelBalanceName.TabIndex = 1;
            this.labelBalanceName.Text = "Balance Details :";
            // 
            // buttonBalanceBack
            // 
            this.buttonBalanceBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBalanceBack.Location = new System.Drawing.Point(205, 236);
            this.buttonBalanceBack.Name = "buttonBalanceBack";
            this.buttonBalanceBack.Size = new System.Drawing.Size(88, 23);
            this.buttonBalanceBack.TabIndex = 2;
            this.buttonBalanceBack.Text = "Back";
            this.buttonBalanceBack.UseVisualStyleBackColor = true;
            this.buttonBalanceBack.Click += new System.EventHandler(this.buttonBalanceBack_Click);
            // 
            // dataGridUserDetails
            // 
            this.dataGridUserDetails.AllowUserToAddRows = false;
            this.dataGridUserDetails.AllowUserToDeleteRows = false;
            this.dataGridUserDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUserDetails.Location = new System.Drawing.Point(26, 52);
            this.dataGridUserDetails.Name = "dataGridUserDetails";
            this.dataGridUserDetails.ReadOnly = true;
            this.dataGridUserDetails.Size = new System.Drawing.Size(446, 113);
            this.dataGridUserDetails.TabIndex = 7;
            // 
            // FormBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 353);
            this.Controls.Add(this.dataGridUserDetails);
            this.Controls.Add(this.buttonBalanceBack);
            this.Controls.Add(this.labelBalanceName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Banking System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBalance_FormClosing);
            this.Load += new System.EventHandler(this.FormBalance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUserDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBalanceName;
        private System.Windows.Forms.Button buttonBalanceBack;
        private System.Windows.Forms.DataGridView dataGridUserDetails;
    }
}
