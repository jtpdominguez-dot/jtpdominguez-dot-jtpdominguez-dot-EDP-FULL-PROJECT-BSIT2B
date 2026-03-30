using LoginForm1;
using System;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        // Username | Password | Role/Name
        string[,] userCredentials =
        {
            {"Tristan","1234","Tristan"},
            {"Dominguez","1234","Dominguez"}
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                MessageBox.Show("Please enter username!", "Validation");
                tbUsername.Focus();
            }
            else if (tbPassword.Text == "")
            {
                MessageBox.Show("Please enter password!", "Validation");
                tbPassword.Focus();
            }
            else
            {
                for (int x = 0; x < userCredentials.GetLength(0); x++)
                {
                    if (tbUsername.Text == userCredentials[x, 0])
                    {
                        if (tbPassword.Text == userCredentials[x, 1])
                        {
                            frmHome frm = new frmHome();
                            MessageBox.Show("Welcome " + userCredentials[x, 2]);
                            this.Hide();
                            frm.Owner = this;
                            frm.Show();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("invalid Username/Password");
                            break;
                        }
                    }
                }
            }
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
}