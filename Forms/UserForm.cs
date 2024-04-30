using LoginAndRegister.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginAndRegister.Forms
{
    public partial class UserForm : Form
    {
        public UserForm(int ID)
        {
            InitializeComponent();

            string path = @"../../../DataBase/Users.json";

            List<Users> users = new List<Users>();

            if (File.Exists(path))
            {
                var existingUsersJson = File.ReadAllText(path);
                users = System.Text.Json.JsonSerializer.Deserialize<List<Users>>(existingUsersJson);
            }

            var user = users.FirstOrDefault(u => u.Id == ID);
            fullname.Text = "Salom, " + user.FullName;
            
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
