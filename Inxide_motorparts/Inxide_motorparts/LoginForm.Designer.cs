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
            picTime = new System.Windows.Forms.Timer(components);
            lblLogin = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblUser = new Label();
            lblPass = new Label();
            txtuname = new TextBox();
            txtpass = new TextBox();
            btnlogin = new Button();
            lblForgotPass = new Label();
            cbShowPass = new CheckBox();
            lblCreateAcc = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Consolas", 30F, FontStyle.Bold);
            lblLogin.Location = new Point(693, 32);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(195, 70);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "LOGIN";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Consolas", 15F);
            lblUser.Location = new Point(549, 162);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(159, 36);
            lblUser.TabIndex = 2;
            lblUser.Text = "Username:";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Consolas", 15F);
            lblPass.Location = new Point(549, 267);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(159, 36);
            lblPass.TabIndex = 3;
            lblPass.Text = "Password:";
            // 
            // txtuname
            // 
            txtuname.Font = new Font("Consolas", 15F);
            txtuname.Location = new Point(708, 152);
            txtuname.Multiline = true;
            txtuname.Name = "txtuname";
            txtuname.Size = new Size(317, 56);
            txtuname.TabIndex = 4;
            // 
            // txtpass
            // 
            txtpass.Font = new Font("Consolas", 15F);
            txtpass.Location = new Point(708, 257);
            txtpass.Multiline = true;
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(317, 56);
            txtpass.TabIndex = 5;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.Black;
            btnlogin.Font = new Font("Consolas", 20F, FontStyle.Bold);
            btnlogin.ForeColor = SystemColors.ControlLightLight;
            btnlogin.Location = new Point(549, 392);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(474, 63);
            btnlogin.TabIndex = 7;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            // 
            // lblForgotPass
            // 
            lblForgotPass.AutoSize = true;
            lblForgotPass.Font = new Font("Consolas", 10F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblForgotPass.ForeColor = Color.Brown;
            lblForgotPass.Location = new Point(837, 479);
            lblForgotPass.Name = "lblForgotPass";
            lblForgotPass.Size = new Size(186, 23);
            lblForgotPass.TabIndex = 9;
            lblForgotPass.Text = "Forgot Password?";
            // 
            // cbShowPass
            // 
            cbShowPass.AutoSize = true;
            cbShowPass.Location = new Point(708, 332);
            cbShowPass.Name = "cbShowPass";
            cbShowPass.Size = new Size(162, 29);
            cbShowPass.TabIndex = 10;
            cbShowPass.Text = "Show Password";
            cbShowPass.UseVisualStyleBackColor = true;
            // 
            // lblCreateAcc
            // 
            lblCreateAcc.AutoSize = true;
            lblCreateAcc.Font = new Font("Consolas", 10F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblCreateAcc.ForeColor = Color.DimGray;
            lblCreateAcc.Location = new Point(553, 479);
            lblCreateAcc.Name = "lblCreateAcc";
            lblCreateAcc.Size = new Size(197, 23);
            lblCreateAcc.TabIndex = 11;
            lblCreateAcc.Text = "Create an Account";
            lblCreateAcc.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(lblLogin);
            groupBox1.Controls.Add(lblCreateAcc);
            groupBox1.Controls.Add(txtuname);
            groupBox1.Controls.Add(cbShowPass);
            groupBox1.Controls.Add(lblUser);
            groupBox1.Controls.Add(lblForgotPass);
            groupBox1.Controls.Add(lblPass);
            groupBox1.Controls.Add(btnlogin);
            groupBox1.Controls.Add(txtpass);
            groupBox1.Location = new Point(124, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1098, 542);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.loginbg4;
            ClientSize = new Size(1345, 767);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += LoginForm_FormClosing;
            Load += LoginForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer picTime;
        private Label lblLogin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblUser;
        private Label lblPass;
        private TextBox txtuname;
        private TextBox txtpass;
        private Button btnlogin;
        private Label lblForgotPass;
        private CheckBox cbShowPass;
        private Label lblCreateAcc;
        private GroupBox groupBox1;
    }
}