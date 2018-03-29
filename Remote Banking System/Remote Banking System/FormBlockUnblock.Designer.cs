namespace Remote_Banking_System
{
    partial class FormBlockUnblock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBlockUnblock));
            this.dataGridViewUserBlockUnblock = new System.Windows.Forms.DataGridView();
            this.labelID = new System.Windows.Forms.Label();
            this.labelShowID = new System.Windows.Forms.Label();
            this.buttonBlock = new System.Windows.Forms.Button();
            this.buttonUnblock = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserBlockUnblock)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUserBlockUnblock
            // 
            this.dataGridViewUserBlockUnblock.AllowUserToAddRows = false;
            this.dataGridViewUserBlockUnblock.AllowUserToDeleteRows = false;
            this.dataGridViewUserBlockUnblock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserBlockUnblock.Location = new System.Drawing.Point(88, 41);
            this.dataGridViewUserBlockUnblock.Name = "dataGridViewUserBlockUnblock";
            this.dataGridViewUserBlockUnblock.ReadOnly = true;
            this.dataGridViewUserBlockUnblock.Size = new System.Drawing.Size(316, 150);
            this.dataGridViewUserBlockUnblock.TabIndex = 0;
            this.dataGridViewUserBlockUnblock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUserBlockUnblock_CellContentClick);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(199, 208);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(43, 13);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "User ID";
            // 
            // labelShowID
            // 
            this.labelShowID.AutoSize = true;
            this.labelShowID.Location = new System.Drawing.Point(248, 208);
            this.labelShowID.Name = "labelShowID";
            this.labelShowID.Size = new System.Drawing.Size(13, 13);
            this.labelShowID.TabIndex = 2;
            this.labelShowID.Text = "0";
            // 
            // buttonBlock
            // 
            this.buttonBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBlock.Location = new System.Drawing.Point(148, 238);
            this.buttonBlock.Name = "buttonBlock";
            this.buttonBlock.Size = new System.Drawing.Size(75, 23);
            this.buttonBlock.TabIndex = 3;
            this.buttonBlock.Text = "Block";
            this.buttonBlock.UseVisualStyleBackColor = true;
            this.buttonBlock.Click += new System.EventHandler(this.buttonBlock_Click);
            // 
            // buttonUnblock
            // 
            this.buttonUnblock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnblock.Location = new System.Drawing.Point(229, 238);
            this.buttonUnblock.Name = "buttonUnblock";
            this.buttonUnblock.Size = new System.Drawing.Size(75, 23);
            this.buttonUnblock.TabIndex = 4;
            this.buttonUnblock.Text = "Unblock";
            this.buttonUnblock.UseVisualStyleBackColor = true;
            this.buttonUnblock.Click += new System.EventHandler(this.buttonUnblock_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(365, 238);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Click The User ID To Select The User ";
            // 
            // FormBlockUnblock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 291);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonUnblock);
            this.Controls.Add(this.buttonBlock);
            this.Controls.Add(this.labelShowID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.dataGridViewUserBlockUnblock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBlockUnblock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Banking System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBlockUnblock_FormClosed);
            this.Load += new System.EventHandler(this.FormBlockUnblock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserBlockUnblock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUserBlockUnblock;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelShowID;
        private System.Windows.Forms.Button buttonBlock;
        private System.Windows.Forms.Button buttonUnblock;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
    }
}