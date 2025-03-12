namespace Inxide_motorparts
{
    partial class CreateAccount
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
            groupBox1 = new GroupBox();
            lblLogin = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            cbShowPass = new CheckBox();
            lblUser = new Label();
            label2 = new Label();
            lblPass = new Label();
            btnlogin = new Button();
            textBox2 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Black;
            groupBox1.Controls.Add(lblLogin);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(cbShowPass);
            groupBox1.Controls.Add(lblUser);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblPass);
            groupBox1.Controls.Add(btnlogin);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(129, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1087, 542);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Consolas", 30F, FontStyle.Bold);
            lblLogin.ForeColor = SystemColors.ButtonHighlight;
            lblLogin.Location = new Point(693, 32);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(195, 70);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "LOGIN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 10F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(553, 479);
            label1.Name = "label1";
            label1.Size = new Size(197, 23);
            label1.TabIndex = 11;
            label1.Text = "Create an Account";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Consolas", 15F);
            textBox1.Location = new Point(708, 152);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(317, 56);
            textBox1.TabIndex = 4;
            // 
            // cbShowPass
            // 
            cbShowPass.AutoSize = true;
            cbShowPass.ForeColor = SystemColors.ButtonHighlight;
            cbShowPass.Location = new Point(708, 332);
            cbShowPass.Name = "cbShowPass";
            cbShowPass.Size = new Size(162, 29);
            cbShowPass.TabIndex = 10;
            cbShowPass.Text = "Show Password";
            cbShowPass.UseVisualStyleBackColor = true;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Consolas", 15F);
            lblUser.ForeColor = SystemColors.ButtonHighlight;
            lblUser.Location = new Point(549, 162);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(159, 36);
            lblUser.TabIndex = 2;
            lblUser.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 10F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(837, 479);
            label2.Name = "label2";
            label2.Size = new Size(186, 23);
            label2.TabIndex = 9;
            label2.Text = "Forgot Password?";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Consolas", 15F);
            lblPass.ForeColor = SystemColors.ButtonHighlight;
            lblPass.Location = new Point(549, 267);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(159, 36);
            lblPass.TabIndex = 3;
            lblPass.Text = "Password:";
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
            // textBox2
            // 
            textBox2.Font = new Font("Consolas", 15F);
            textBox2.Location = new Point(708, 257);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(317, 56);
            textBox2.TabIndex = 5;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 767);
            Controls.Add(groupBox1);
            Name = "CreateAccount";
            Text = "CreateAccount";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblLogin;
        private Label label1;
        private TextBox textBox1;
        private CheckBox cbShowPass;
        private Label lblUser;
        private Label label2;
        private Label lblPass;
        private Button btnlogin;
        private TextBox textBox2;
    }
}