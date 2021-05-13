using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity; 
namespace SchedulingApp3
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private readonly U07wZGEntities dbContext = new U07wZGEntities();

        private void loginButton_Click(object sender, EventArgs e)
        {
            ValidateUser(); 
        }

        private void ValidateUser()
        {
            try
            {
                //Check that the username and password textboxes are filled in
                if (usernameTextBox.Text != string.Empty && passwordTextBox.Text != string.Empty)
                {
                    //Determine if the entered username exits in the user database. 
                    var userExist = dbContext.users.FirstOrDefault(a => a.userName.Equals(usernameTextBox.Text));
                    if (userExist != null)
                    {
                        //Check to see if the password for the given username is correct, if so open main form
                        if (userExist.password.Equals(passwordTextBox.Text))
                        {
                            this.Hide(); 
                            Main main = new Main();
                            main.Show();
                        }
                        else
                        {
                            //Incorrect password
                            MessageBox.Show(Resource1.errorPassword);
                            usernameTextBox.BackColor = Color.Salmon;
                            passwordTextBox.BackColor = Color.Salmon;
                        }
                    }
                    else
                    {
                        //No username found
                        MessageBox.Show(Resource1.errorUsername);
                        usernameTextBox.BackColor = Color.Salmon;
                        passwordTextBox.BackColor = Color.Salmon;
                    }
                }
                else
                {
                    //Fill in all boxes
                    MessageBox.Show(Resource1.errorNoneFound);
                    usernameTextBox.BackColor = Color.Salmon;
                    passwordTextBox.BackColor = Color.Salmon;
                }
            }
            catch
            {
                throw new Exception("Something went wrong.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
