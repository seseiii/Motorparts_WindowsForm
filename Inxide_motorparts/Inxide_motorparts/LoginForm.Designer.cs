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
            pbImage = new PictureBox();
            picTime = new System.Windows.Forms.Timer(components);
            lblLogin = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblUser = new Label();
            lblPass = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnlogin = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // pbImage
            // 
            pbImage.Location = new Point(0, 0);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(704, 769);
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(867, 79);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(312, 112);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "LOGIN";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Consolas", 20F);
            lblUser.Location = new Point(750, 265);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(218, 47);
            lblUser.TabIndex = 2;
            lblUser.Text = "Username:";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Consolas", 20F);
            lblPass.Location = new Point(750, 386);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(218, 47);
            lblPass.TabIndex = 3;
            lblPass.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Consolas", 20F);
            textBox1.Location = new Point(961, 262);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(317, 56);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Consolas", 20F);
            textBox2.Location = new Point(961, 383);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(317, 56);
            textBox2.TabIndex = 5;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.Black;
            btnlogin.Font = new Font("Consolas", 24F, FontStyle.Bold);
            btnlogin.ForeColor = SystemColors.ControlLightLight;
            btnlogin.Location = new Point(759, 499);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(519, 75);
            btnlogin.TabIndex = 7;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 10F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(763, 625);
            label1.Name = "label1";
            label1.Size = new Size(197, 23);
            label1.TabIndex = 8;
            label1.Text = "Create an Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 10F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(1092, 625);
            label2.Name = "label2";
            label2.Size = new Size(186, 23);
            label2.TabIndex = 9;
            label2.Text = "Forgot Password?";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.loginbg2;
            ClientSize = new Size(1345, 767);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnlogin);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblPass);
            Controls.Add(lblUser);
            Controls.Add(lblLogin);
            Controls.Add(pbImage);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += LoginForm_FormClosing;
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImage;
        private System.Windows.Forms.Timer picTime;
        private Label lblLogin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblUser;
        private Label lblPass;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnlogin;
        private Label label1;
        private Label label2;
    }
}