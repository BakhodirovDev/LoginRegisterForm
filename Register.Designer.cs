namespace LoginAndRegister
{
    partial class Register
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            FullName = new TextBox();
            UserName = new TextBox();
            Password = new TextBox();
            ConfirmPassword = new TextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 24F, FontStyle.Bold);
            label1.Location = new Point(189, 30);
            label1.Name = "label1";
            label1.Size = new Size(182, 48);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 10F, FontStyle.Bold);
            label2.Location = new Point(75, 97);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 1;
            label2.Text = "Full Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS UI Gothic", 10F, FontStyle.Bold);
            label3.Location = new Point(75, 158);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS UI Gothic", 10F, FontStyle.Bold);
            label4.Location = new Point(75, 221);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 3;
            label4.Text = "Passwors";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS UI Gothic", 10F, FontStyle.Bold);
            label5.Location = new Point(75, 285);
            label5.Name = "label5";
            label5.Size = new Size(176, 20);
            label5.TabIndex = 4;
            label5.Text = "Confirm Password";
            // 
            // FullName
            // 
            FullName.Location = new Point(75, 120);
            FullName.Name = "FullName";
            FullName.Size = new Size(416, 31);
            FullName.TabIndex = 5;
            // 
            // UserName
            // 
            UserName.Location = new Point(75, 181);
            UserName.Name = "UserName";
            UserName.Size = new Size(416, 31);
            UserName.TabIndex = 6;
            // 
            // Password
            // 
            Password.Location = new Point(75, 251);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(416, 31);
            Password.TabIndex = 7;
            // 
            // ConfirmPassword
            // 
            ConfirmPassword.Location = new Point(75, 308);
            ConfirmPassword.Name = "ConfirmPassword";
            ConfirmPassword.PasswordChar = '*';
            ConfirmPassword.Size = new Size(416, 31);
            ConfirmPassword.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold);
            button1.Location = new Point(167, 359);
            button1.Name = "button1";
            button1.Size = new Size(231, 61);
            button1.TabIndex = 9;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(191, 443);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(180, 25);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Akkauntingiz bormi ?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 486);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(ConfirmPassword);
            Controls.Add(Password);
            Controls.Add(UserName);
            Controls.Add(FullName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox FullName;
        private TextBox UserName;
        private TextBox Password;
        private TextBox ConfirmPassword;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}