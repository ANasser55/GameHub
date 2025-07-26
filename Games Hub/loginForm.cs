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
    public partial class loogInForm : Form
    {
        public static string UserName;
        signUpForm SignUp = new signUpForm();
        public loogInForm()
        {
            InitializeComponent();
        }

        private void loogInForm_Load(object sender, EventArgs e)
        {
            loginPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void createAccountLabel_Click(object sender, EventArgs e)
        {
            SignUp.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            UserName = usernameText.Text;
            if (accountsTableAdapter.GetPassword(UserName) == passwordText.Text)
            {
                menuform m = new menuform();
                this.Hide();
                m.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

    }
}
