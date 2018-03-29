namespace Remote_Banking_System
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.labelAdmin = new System.Windows.Forms.Label();
            this.buttonViewDetails = new System.Windows.Forms.Button();
            this.buttonAccBlock = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.Location = new System.Drawing.Point(228, 11);
            this.labelAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(92, 16);
            this.labelAdmin.TabIndex = 0;
            this.labelAdmin.Text = "Admin Menu";
            // 
            // buttonViewDetails
            // 
            this.buttonViewDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewDetails.Location = new System.Drawing.Point(186, 72);
            this.buttonViewDetails.Margin = new System.Windows.Forms.Padding(4);
            this.buttonViewDetails.Name = "buttonViewDetails";
            this.buttonViewDetails.Size = new System.Drawing.Size(185, 47);
            this.buttonViewDetails.TabIndex = 1;
            this.buttonViewDetails.Text = "View Account Details";
            this.buttonViewDetails.UseVisualStyleBackColor = true;
            this.buttonViewDetails.Click += new System.EventHandler(this.buttonViewDetails_Click);
            // 
            // buttonAccBlock
            // 
            this.buttonAccBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccBlock.Location = new System.Drawing.Point(186, 127);
            this.buttonAccBlock.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAccBlock.Name = "buttonAccBlock";
            this.buttonAccBlock.Size = new System.Drawing.Size(185, 47);
            this.buttonAccBlock.TabIndex = 2;
            this.buttonAccBlock.Text = "Block Account";
            this.buttonAccBlock.UseVisualStyleBackColor = true;
            this.buttonAccBlock.Click += new System.EventHandler(this.buttonAccBlock_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(231, 253);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(107, 36);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(186, 182);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(185, 47);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete Account";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 321);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonAccBlock);
            this.Controls.Add(this.buttonViewDetails);
            this.Controls.Add(this.labelAdmin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Banking System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Button buttonViewDetails;
        private System.Windows.Forms.Button buttonAccBlock;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonDelete;
    }
}