using System;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        // Username | Password | Role/Name
        string[,] userCredentials =
        {
            {"admin","admin","Admin"},
            {"cashier","password","Cashier"}
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();

            // Validation
            if (username == "")
            {
                MessageBox.Show("Please enter username!");
                tbUsername.Focus();
                return;
            }

            if (password == "")
            {
                MessageBox.Show("Please enter password!");
                tbPassword.Focus();
                return;
            }

            bool isValid = false;

            // Check credentials
            for (int i = 0; i < userCredentials.GetLength(0); i++)
            {
                if (username == userCredentials[i, 0] &&
                    password == userCredentials[i, 1])
                {
                    MessageBox.Show("Welcome " + userCredentials[i, 2]);

                    frmHome home = new frmHome(); // next form
                    this.Hide();
                    home.Show();

                    isValid = true;
                    break;
                }
            }

            if (!isValid)
            {
                MessageBox.Show("Invalid Username/Password");
            }
        }
    }
}