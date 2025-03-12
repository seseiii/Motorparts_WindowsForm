using System.Drawing.Drawing2D;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Inxide_motorparts
{
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
        }

        private void mainPage_Load(object sender, EventArgs e)
        {

        }

        //ensure na magcloclose pagpininfot ung x sa taas. ps dapat nakaselect to sa properties (FormClosing)
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
