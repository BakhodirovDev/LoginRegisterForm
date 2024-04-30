namespace LoginAndRegister
{
    partial class Login
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
            linkLabel1 = new LinkLabel();
            UserName = new TextBox();
            Password = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 24F, FontStyle.Bold);
            label1.Location = new Point(163, 31);
            label1.Name = "label1";
            label1.Size = new Size(163, 48);
            label1.TabIndex = 0;
            label1.Text = "Sign In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 10F, FontStyle.Bold);
            label2.Location = new Point(53, 109);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS UI Gothic", 10F, FontStyle.Bold);
            label3.Location = new Point(53, 199);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9F);
            linkLabel1.Location = new Point(163, 366);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(189, 25);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Akkountingiz yo'qmi ?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // UserName
            // 
            UserName.Font = new Font("MS UI Gothic", 14F, FontStyle.Bold);
            UserName.Location = new Point(53, 140);
            UserName.Name = "UserName";
            UserName.Size = new Size(422, 35);
            UserName.TabIndex = 4;
            // 
            // Password
            // 
            Password.Font = new Font("MS UI Gothic", 14F, FontStyle.Bold);
            Password.Location = new Point(53, 227);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(422, 35);
            Password.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold);
            button1.Location = new Point(137, 285);
            button1.Name = "button1";
            button1.Size = new Size(231, 61);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 417);
            Controls.Add(button1);
            Controls.Add(Password);
            Controls.Add(UserName);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
        private TextBox UserName;
        private TextBox Password;
        private Button button1;
    }
}