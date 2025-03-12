using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Inxide_motorparts
{
    public partial class LoginForm : Form
    {
        private string[] images =
       {
            @"C:\Users\Prissea.MSI\source\repos\Inxide_motorparts\Inxide_motorparts\Images\pic1.png",
            @"C:\Users\Prissea.MSI\source\repos\Inxide_motorparts\Inxide_motorparts\Images\pic2.png",
            @"C:\Users\Prissea.MSI\source\repos\Inxide_motorparts\Inxide_motorparts\Images\pic3.png",
            @"C:\Users\Prissea.MSI\source\repos\Inxide_motorparts\Inxide_motorparts\Images\pic4.png",
            @"C:\Users\Prissea.MSI\source\repos\Inxide_motorparts\Inxide_motorparts\Images\pic5.png"
        }; // Change to full paths
        private int currentIndex = 0;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public LoginForm()
        {
            InitializeComponent();

            // Set PictureBox properties
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.Image = Image.FromFile(images[currentIndex]);

            // Set up the Timer
            picTime.Interval = 1500; //1.5 sec per image
            picTime.Tick += new EventHandler(ChangeImage);
            picTime.Start();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        //ensure na magcloclose pagpininfot ung x sa taas. ps dapat nakaselect to sa properties (FormClosing)
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ChangeImage(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex >= images.Length)
                currentIndex = 0; // Reset to first image

            pbImage.Image = Image.FromFile(images[currentIndex]);
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void lblForgotPass_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPass forgotpass = new ForgotPass();
            forgotpass.Show();

        }

        private void pbReturn_Click(object sender, EventArgs e)
        {
            mainPage main = new mainPage();
            main.Show();
        }

        private void lblCreateAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccount createAcc = new CreateAccount();
            createAcc.Show();
        }
    }
}
