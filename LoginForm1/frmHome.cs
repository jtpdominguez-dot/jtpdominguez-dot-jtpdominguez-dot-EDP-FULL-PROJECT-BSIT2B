using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm1
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register frm = new Register();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             StoreStatus frm = new StoreStatus();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            TimeClock frm = new TimeClock();
            frm.Show();
        }

        private void btnPb_Click(object sender, EventArgs e)
        {
            Pricebook frm = new Pricebook();
            frm.Show();
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            Vendors frm = new Vendors();
            frm.Show();
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            User frm = new User();
            frm.Show();
        }
    }
}
