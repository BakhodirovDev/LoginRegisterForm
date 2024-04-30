using LoginAndRegister.Class;
using LoginAndRegister.DataBase;
using System;
using Newtonsoft.Json;
namespace LoginAndRegister
{
    public partial class Register : Form
    {
        public object JsonConvert { get; private set; }

        public Register()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FullName.Text) || string.IsNullOrWhiteSpace(UserName.Text) || string.IsNullOrWhiteSpace(Password.Text) || string.IsNullOrWhiteSpace(ConfirmPassword.Text))
            {
                MessageBox.Show("Ma'lumotlarni to'liq kiritish kerak.");
                return;
            }

            if (Password.Text != ConfirmPassword.Text)
            {
                MessageBox.Show("Parollar bir xil emas. Iltimos, qayta tekshiring.");
                return;
            }

            string path = @"../../../DataBase/Users.json";

            List<Users> users = new List<Users>();

            if (File.Exists(path))
            {
                var existingUsersJson = File.ReadAllText(path);
                users = System.Text.Json.JsonSerializer.Deserialize<List<Users>>(existingUsersJson);
            }

            if (users.Any(u => u.UserName == UserName.Text))
            {
                MessageBox.Show("Foydalanuvchi ro'yxatdan o'tgan");
                return;
            }

            int nextId = users.Count > 0 ? users.Max(u => u.Id) + 1 : 1;

            Users user = new Users
            {
                Id = nextId,
                FullName = FullName.Text,
                Password = Password.Text,
                UserName = UserName.Text,
                Role = "User"
            };

            users.Add(user);

            var options = new System.Text.Json.JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = System.Text.Json.JsonSerializer.Serialize(users, options);

            File.WriteAllText(path, json);
            MessageBox.Show("Siz muvaffaqiyatli ro'yxatdan o'tdingiz");
            // Login formaga o'tish
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
