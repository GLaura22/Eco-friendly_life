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

            // Set to no text.
            newPasswordTextBox.Text = "";
            // The password character is an asterisk.
            newPasswordTextBox.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            newPasswordTextBox.MaxLength = 14;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string newUsername = newUsernameTextBox.Text;
            string newPassword = newPasswordTextBox.Text;

            // hashing
            string hashPassword = "";
            PersonController personController = new PersonController();
            hashPassword = personController.Hash(newPassword);


            Person user = new Person {UserName = newUsername, Password = hashPassword };

            PersonController personContorller = new PersonController();
            int userId = personContorller.AddPerson(user);

            // check if the insertion was successful
            if (userId == 0)
            {
                MessageBox.Show("Insertion failed!");
            }

            this.Close();

            var loginForm = new Login();
            loginForm.ShowDialog();
        }

        
    }
}
