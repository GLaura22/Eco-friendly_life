using eco_friendly_life_winform.Database_Backend.Controllers;
using eco_friendly_life_winform.Database_Backend.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eco_friendly_life_winform
{
    public partial class Registry : Form
    {
        public Registry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO adding the new user to the database

            string newUsername = newUsernameTextBox.Text;
            string newPassword = newPasswordTextBox.Text;

            Person user = new Person {UserName = newUsername, Password = newPassword };

            PersonController personContorller = new PersonController();
            int userId = personContorller.AddPerson(user);

            /* Check if the insertion was successful or not. */
            if (userId == 0)
            {
                /* ERROR occurred! */
                throw new Exception("Register failed!");
            }

            this.Close();

            var loginForm = new Login();
            loginForm.ShowDialog();
        }
    }
}
