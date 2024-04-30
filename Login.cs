using LoginAndRegister.Class;
using LoginAndRegister.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginAndRegister
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserName.Text) || string.IsNullOrWhiteSpace(Password.Text))
            {
                MessageBox.Show("Ma'lumotlarni to'liq kiritish kerak.");
                return;
            } 

            string path = @"../../../DataBase/Users.json";

            List<Users> users = new List<Users>();

            if (File.Exists(path))
            {
                var existingUsersJson = File.ReadAllText(path);
                users = System.Text.Json.JsonSerializer.Deserialize<List<Users>>(existingUsersJson);
            }

            var user = users.FirstOrDefault(u => u.UserName == UserName.Text && u.Password == Password.Text);

            if (user == null)
            {
                MessageBox.Show("Foydalanuvchi nomi yoki parol noto'g'ri.");
                return;
            }

            // Foydalanuvchining role'iga qarab mos formasiga o'tish
            switch (user.Role)
            {
                case "SuperAdmin":
                    SuperAdminForm superAdminForm = new SuperAdminForm(user.Id);
                    superAdminForm.Show();
                    break;
                case "Admin":
                    AdminForm adminForm = new AdminForm(user.Id);
                    adminForm.Show();
                    break;
                case "User":

                    UserForm userForm = new UserForm(user.Id);
                    userForm.Show();
                    break;
                default:
                    MessageBox.Show("Foydalanuvchining roli noto'g'ri.");
                    break;
            }

            this.Hide();
        }
    }
}
