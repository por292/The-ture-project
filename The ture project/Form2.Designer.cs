namespace The_ture_project
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.Passtxt1 = new System.Windows.Forms.TextBox();
            this.Passtxt = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirm password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(38, 66);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(55, 13);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username";
            // 
            // Passtxt1
            // 
            this.Passtxt1.Location = new System.Drawing.Point(110, 160);
            this.Passtxt1.Name = "Passtxt1";
            this.Passtxt1.PasswordChar = '*';
            this.Passtxt1.Size = new System.Drawing.Size(239, 20);
            this.Passtxt1.TabIndex = 4;
            // 
            // Passtxt
            // 
            this.Passtxt.Location = new System.Drawing.Point(110, 117);
            this.Passtxt.Name = "Passtxt";
            this.Passtxt.PasswordChar = '*';
            this.Passtxt.Size = new System.Drawing.Size(239, 20);
            this.Passtxt.TabIndex = 5;
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(110, 66);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(239, 20);
            this.User.TabIndex = 6;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(128, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 7;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(111, 208);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(238, 86);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 339);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Passtxt);
            this.Controls.Add(this.Passtxt1);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox Passtxt1;
        private System.Windows.Forms.TextBox Passtxt;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRegister;
    }
}