namespace Remote_Banking_System
{
    partial class Form2Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2Login));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBox2Pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1Login = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelErrorID = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelBlocked = new System.Windows.Forms.Label();
            this.labelManager = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(98, 71);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(123, 20);
            this.textBoxId.TabIndex = 1;
            // 
            // textBox2Pass
            // 
            this.textBox2Pass.Location = new System.Drawing.Point(98, 119);
            this.textBox2Pass.Name = "textBox2Pass";
            this.textBox2Pass.Size = new System.Drawing.Size(123, 20);
            this.textBox2Pass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // button1Login
            // 
            this.button1Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Login.Location = new System.Drawing.Point(157, 173);
            this.button1Login.Name = "button1Login";
            this.button1Login.Size = new System.Drawing.Size(75, 30);
            this.button1Login.TabIndex = 4;
            this.button1Login.Text = "Login";
            this.button1Login.UseVisualStyleBackColor = true;
            this.button1Login.Click += new System.EventHandler(this.button1Login_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(157, 219);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 30);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelErrorID
            // 
            this.labelErrorID.AutoSize = true;
            this.labelErrorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorID.ForeColor = System.Drawing.Color.Red;
            this.labelErrorID.Location = new System.Drawing.Point(237, 75);
            this.labelErrorID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErrorID.Name = "labelErrorID";
            this.labelErrorID.Size = new System.Drawing.Size(73, 16);
            this.labelErrorID.TabIndex = 15;
            this.labelErrorID.Text = "Error ID!!!";
            this.labelErrorID.Visible = false;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.Red;
            this.labelPassword.Location = new System.Drawing.Point(237, 121);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(126, 16);
            this.labelPassword.TabIndex = 16;
            this.labelPassword.Text = "Error Password!!!";
            this.labelPassword.Visible = false;
            // 
            // labelBlocked
            // 
            this.labelBlocked.AutoSize = true;
            this.labelBlocked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBlocked.ForeColor = System.Drawing.Color.Red;
            this.labelBlocked.Location = new System.Drawing.Point(95, 9);
            this.labelBlocked.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBlocked.Name = "labelBlocked";
            this.labelBlocked.Size = new System.Drawing.Size(147, 16);
            this.labelBlocked.TabIndex = 17;
            this.labelBlocked.Text = "Your ID is blocked!!!";
            this.labelBlocked.Visible = false;
            // 
            // labelManager
            // 
            this.labelManager.AutoSize = true;
            this.labelManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManager.ForeColor = System.Drawing.Color.Red;
            this.labelManager.Location = new System.Drawing.Point(-1, 38);
            this.labelManager.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelManager.Name = "labelManager";
            this.labelManager.Size = new System.Drawing.Size(368, 16);
            this.labelManager.TabIndex = 18;
            this.labelManager.Text = "Go To Nearest Branch to Consult With The Manager.";
            this.labelManager.Visible = false;
            // 
            // Form2Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 261);
            this.Controls.Add(this.labelManager);
            this.Controls.Add(this.labelBlocked);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelErrorID);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.button1Login);
            this.Controls.Add(this.textBox2Pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Banking System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2Login_FormClosed_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBox2Pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1Login;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelErrorID;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelBlocked;
        private System.Windows.Forms.Label labelManager;
    }
}