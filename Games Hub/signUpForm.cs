using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games_Hub
{
    public partial class signUpForm : Form
    {
        public signUpForm()
        {
            InitializeComponent();
        }

        private void signInForm_Load(object sender, EventArgs e)
        {
            signInPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

 
        private void accountsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
                string Name = null;
                if (usernameSignUp.Text != string.Empty)
                {
                    Name = usernameSignUp.Text;
                try
                    {
                    accountsTableAdapter.InsertQuery(Name, passwordSignUp.Text, emailSignUp.Text);
                    loogInForm login = new loogInForm();
                        MessageBox.Show("Success! You can now sign in.");
                        login.Show();
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("This username is taken. Please, choose another one.");
                    }
                }
                else
                {
                    MessageBox.Show("Please, enter your name");
                }
        
        }

    }
}
