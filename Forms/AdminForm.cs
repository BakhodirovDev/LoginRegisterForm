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
    public partial class AdminForm : Form
    {
        public AdminForm(int ID)
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


            var filteredUsers = users.Where(u => u.Role != "SuperAdmin" && u.Role != "Admin").ToList();
            dataGridView1.DataSource = filteredUsers;

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void fullname_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
