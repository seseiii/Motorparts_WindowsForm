namespace Inxide_motorparts
{
    partial class mainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPage));
            btnProceed = new Button();
            SuspendLayout();
            // 
            // btnProceed
            // 
            btnProceed.BackColor = Color.LightGray;
            btnProceed.FlatStyle = FlatStyle.System;
            btnProceed.Font = new Font("Consolas", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProceed.Location = new Point(879, 605);
            btnProceed.Name = "btnProceed";
            btnProceed.Padding = new Padding(50);
            btnProceed.Size = new Size(260, 76);
            btnProceed.TabIndex = 0;
            btnProceed.Text = "Start";
            btnProceed.UseVisualStyleBackColor = false;
            btnProceed.Click += btnProceed_Click;
            // 
            // mainPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.loadingbg1;
            ClientSize = new Size(1345, 767);
            Controls.Add(btnProceed);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "mainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inxide Decals";
            TopMost = true;
            FormClosing += LoginForm_FormClosing;
            Load += mainPage_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnProceed;
    }
}
