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
using eco_friendly_life_winform.Database_Backend.Tables;
using eco_friendly_life_winform.Database_Backend.Controllers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace eco_friendly_life_winform
{
    public partial class Login : Form
    {
        private Person user;

        public Login()
        {
            InitializeComponent();
            user = new Person { UserID = 0, UserName = "", Password = "" };

            // set to no text.
            passwordTextBox.Text = "";
            // the password character is an asterisk.
            passwordTextBox.PasswordChar = '*';
            // the control will allow no more than 14 characters.
            passwordTextBox.MaxLength = 14;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            if(usernameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Please provide your username AND password!");
                return;
            }

            string userName = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            PersonController personController = new PersonController();
            user = personController.LoginHashVersion(userName, password);
            
            // the password is correct and exists a user with this username
            if (user.UserName != "" || user.UserID != 0) 
            {
                var myForm = new Form1(user.UserID);
                myForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username/password is incorrect or you don't have an account yet!");
            }

        }

        private void RegistryButton_Click(object sender, EventArgs e)
        {
            var registryForm = new Registry();
            registryForm.ShowDialog();

            this.Close();
        }
    }
}
