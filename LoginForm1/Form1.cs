using LoginForm1;
using MySql.Data.MySqlClient;
using System;
using System.Data;
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
                DataTable dt = db.ExecuteReturnQuery("SELECT * FROM tblcredentials_login WHERE user_username = @uname AND user_password = @pword",
                    new MySqlParameter("@uname", tbUsername.Text),
                    new MySqlParameter("@pword", tbPassword.Text));
                if (dt.Rows.Count == 1)
                {
                    frmHome frm = new frmHome();
                    this.Hide();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("INVALID USERNAME ");
                }
            }
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
        Class1 db = new Class1();
        private void Form1_Load(object sender, EventArgs e)
        {
            if (db.TestConnection() == true)
            {
                MessageBox.Show("connected succesfully");

            }
            else
            {
                MessageBox.Show("kahit ano");
            }
        }
    }
}