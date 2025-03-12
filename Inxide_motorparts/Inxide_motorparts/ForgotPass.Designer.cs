namespace Inxide_motorparts
{
    partial class ForgotPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPass));
            pbReturn = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblLogin = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            btnlogin = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            cbShowPass = new CheckBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbReturn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
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
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.loginbg4;
            pictureBox1.Location = new Point(96, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1152, 615);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Location = new Point(96, 153);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1152, 548);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Black;
            lblLogin.Font = new Font("Consolas", 25F, FontStyle.Bold);
            lblLogin.ForeColor = SystemColors.ButtonHighlight;
            lblLogin.Location = new Point(446, 196);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(430, 59);
            lblLogin.TabIndex = 23;
            lblLogin.Text = "FORGOT PASSWORD";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Gainsboro;
            textBox3.Font = new Font("Consolas", 18F);
            textBox3.Location = new Point(163, 352);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(464, 46);
            textBox3.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Consolas", 18F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(163, 286);
            label4.Name = "label4";
            label4.Size = new Size(198, 42);
            label4.TabIndex = 32;
            label4.Text = "Username*";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.White;
            btnlogin.Font = new Font("Consolas", 11F, FontStyle.Bold);
            btnlogin.ForeColor = Color.Black;
            btnlogin.Location = new Point(652, 353);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(186, 42);
            btnlogin.TabIndex = 34;
            btnlogin.Text = "Find Username";
            btnlogin.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.Font = new Font("Consolas", 18F);
            textBox1.Location = new Point(163, 501);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(464, 46);
            textBox1.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Consolas", 18F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(163, 435);
            label1.Name = "label1";
            label1.Size = new Size(278, 42);
            label1.TabIndex = 35;
            label1.Text = "New Password*";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Gainsboro;
            textBox2.Font = new Font("Consolas", 18F);
            textBox2.Location = new Point(715, 501);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(464, 46);
            textBox2.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Consolas", 18F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(715, 435);
            label2.Name = "label2";
            label2.Size = new Size(438, 42);
            label2.TabIndex = 37;
            label2.Text = "Confirm New Password*";
            // 
            // cbShowPass
            // 
            cbShowPass.AutoSize = true;
            cbShowPass.BackColor = Color.Black;
            cbShowPass.ForeColor = SystemColors.ButtonHighlight;
            cbShowPass.Location = new Point(163, 568);
            cbShowPass.Name = "cbShowPass";
            cbShowPass.Size = new Size(162, 29);
            cbShowPass.TabIndex = 39;
            cbShowPass.Text = "Show Password";
            cbShowPass.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Consolas", 15F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(535, 608);
            button1.Name = "button1";
            button1.Size = new Size(260, 63);
            button1.TabIndex = 40;
            button1.Text = "Reset Password";
            button1.UseVisualStyleBackColor = false;
            // 
            // ForgotPass
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            BackgroundImage = Properties.Resources.loginbg3;
            ClientSize = new Size(1349, 771);
            Controls.Add(button1);
            Controls.Add(cbShowPass);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btnlogin);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(lblLogin);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pbReturn);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "ForgotPass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgot Password";
            FormClosing += LoginForm_FormClosing;
            Load += ForgotPass_Load;
            ((System.ComponentModel.ISupportInitialize)pbReturn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbReturn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblLogin;
        private TextBox textBox3;
        private Label label4;
        private Button btnlogin;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private CheckBox cbShowPass;
        private Button button1;
    }
}