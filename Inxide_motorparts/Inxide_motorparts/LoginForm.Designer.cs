namespace Inxide_motorparts
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            picTime = new System.Windows.Forms.Timer(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pbReturn = new PictureBox();
            pbbg = new PictureBox();
            pbImage = new PictureBox();
            lblLogin = new Label();
            lblCreateAcc = new Label();
            txtuname = new TextBox();
            txtpass = new TextBox();
            cbShowPass = new CheckBox();
            btnlogin = new Button();
            lblUser = new Label();
            lblPass = new Label();
            lblForgotPass = new Label();
            ((System.ComponentModel.ISupportInitialize)pbReturn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbbg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // pbReturn
            // 
            pbReturn.BackColor = Color.Transparent;
            pbReturn.BackgroundImage = (Image)resources.GetObject("pbReturn.BackgroundImage");
            pbReturn.Location = new Point(-3, -6);
            pbReturn.Name = "pbReturn";
            pbReturn.Size = new Size(106, 86);
            pbReturn.TabIndex = 16;
            pbReturn.TabStop = false;
            pbReturn.Click += pbReturn_Click;
            // 
            // pbbg
            // 
            pbbg.BackColor = Color.White;
            pbbg.Location = new Point(131, 127);
            pbbg.Name = "pbbg";
            pbbg.Size = new Size(1098, 542);
            pbbg.TabIndex = 0;
            pbbg.TabStop = false;
            // 
            // pbImage
            // 
            pbImage.Location = new Point(134, 127);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(505, 542);
            pbImage.TabIndex = 26;
            pbImage.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.White;
            lblLogin.Font = new Font("Consolas", 30F, FontStyle.Bold);
            lblLogin.Location = new Point(827, 157);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(195, 70);
            lblLogin.TabIndex = 17;
            lblLogin.Text = "LOGIN";
            // 
            // lblCreateAcc
            // 
            lblCreateAcc.AutoSize = true;
            lblCreateAcc.BackColor = Color.White;
            lblCreateAcc.Font = new Font("Consolas", 10F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblCreateAcc.ForeColor = Color.DimGray;
            lblCreateAcc.Location = new Point(687, 604);
            lblCreateAcc.Name = "lblCreateAcc";
            lblCreateAcc.Size = new Size(197, 23);
            lblCreateAcc.TabIndex = 25;
            lblCreateAcc.Text = "Create an Account";
            lblCreateAcc.Click += lblCreateAcc_Click;
            // 
            // txtuname
            // 
            txtuname.Font = new Font("Consolas", 15F);
            txtuname.Location = new Point(842, 277);
            txtuname.Multiline = true;
            txtuname.Name = "txtuname";
            txtuname.Size = new Size(317, 56);
            txtuname.TabIndex = 20;
            // 
            // txtpass
            // 
            txtpass.Font = new Font("Consolas", 15F);
            txtpass.Location = new Point(842, 382);
            txtpass.Multiline = true;
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(317, 56);
            txtpass.TabIndex = 21;
            // 
            // cbShowPass
            // 
            cbShowPass.AutoSize = true;
            cbShowPass.BackColor = Color.White;
            cbShowPass.Location = new Point(842, 457);
            cbShowPass.Name = "cbShowPass";
            cbShowPass.Size = new Size(162, 29);
            cbShowPass.TabIndex = 24;
            cbShowPass.Text = "Show Password";
            cbShowPass.UseVisualStyleBackColor = false;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.Black;
            btnlogin.Font = new Font("Consolas", 20F, FontStyle.Bold);
            btnlogin.ForeColor = SystemColors.ControlLightLight;
            btnlogin.Location = new Point(683, 517);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(474, 63);
            btnlogin.TabIndex = 22;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.White;
            lblUser.Font = new Font("Consolas", 15F);
            lblUser.Location = new Point(683, 287);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(159, 36);
            lblUser.TabIndex = 18;
            lblUser.Text = "Username:";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.BackColor = Color.White;
            lblPass.Font = new Font("Consolas", 15F);
            lblPass.Location = new Point(683, 392);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(159, 36);
            lblPass.TabIndex = 19;
            lblPass.Text = "Password:";
            // 
            // lblForgotPass
            // 
            lblForgotPass.AutoSize = true;
            lblForgotPass.BackColor = Color.White;
            lblForgotPass.Font = new Font("Consolas", 10F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblForgotPass.ForeColor = Color.Brown;
            lblForgotPass.Location = new Point(971, 604);
            lblForgotPass.Name = "lblForgotPass";
            lblForgotPass.Size = new Size(186, 23);
            lblForgotPass.TabIndex = 23;
            lblForgotPass.Text = "Forgot Password?";
            lblForgotPass.Click += lblForgotPass_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.loginbg4;
            ClientSize = new Size(1345, 767);
            Controls.Add(pbImage);
            Controls.Add(lblLogin);
            Controls.Add(lblCreateAcc);
            Controls.Add(txtuname);
            Controls.Add(txtpass);
            Controls.Add(cbShowPass);
            Controls.Add(btnlogin);
            Controls.Add(lblUser);
            Controls.Add(lblPass);
            Controls.Add(lblForgotPass);
            Controls.Add(pbbg);
            Controls.Add(pbReturn);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += LoginForm_FormClosing;
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbReturn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbbg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer picTime;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pbReturn;
        private PictureBox pbbg;
        private PictureBox pbImage;
        private Label lblLogin;
        private Label lblCreateAcc;
        private TextBox txtuname;
        private TextBox txtpass;
        private CheckBox cbShowPass;
        private Button btnlogin;
        private Label lblUser;
        private Label lblPass;
        private Label lblForgotPass;
    }
}