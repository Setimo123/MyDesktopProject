namespace Consultation.App.Views
{
    partial class LogInView
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
            panel1 = new Panel();
            ErrorPassLabel = new Label();
            resultlabel1 = new Label();
            ShowPassButton = new Button();
            ForgotPasswordButton = new Button();
            label3 = new Label();
            GoogleSignInButton = new Button();
            buttonLogIn = new Button();
            RememberMeCheckBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            label2 = new Label();
            PasswordTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label1 = new Label();
            EmailTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            pictureBox1 = new PictureBox();
            dockingClientPanel1 = new Syncfusion.Windows.Forms.Tools.DockingClientPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RememberMeCheckBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PasswordTextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmailTextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            dockingClientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(ErrorPassLabel);
            panel1.Controls.Add(resultlabel1);
            panel1.Controls.Add(ShowPassButton);
            panel1.Controls.Add(ForgotPasswordButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(GoogleSignInButton);
            panel1.Controls.Add(buttonLogIn);
            panel1.Controls.Add(RememberMeCheckBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(PasswordTextBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(EmailTextBox);
            panel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            panel1.Location = new Point(1132, 171);
            panel1.Name = "panel1";
            panel1.Size = new Size(563, 618);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // ErrorPassLabel
            // 
            ErrorPassLabel.AutoSize = true;
            ErrorPassLabel.Location = new Point(69, 283);
            ErrorPassLabel.Name = "ErrorPassLabel";
            ErrorPassLabel.Size = new Size(0, 20);
            ErrorPassLabel.TabIndex = 17;
            // 
            // resultlabel1
            // 
            resultlabel1.AutoSize = true;
            resultlabel1.BackColor = Color.Transparent;
            resultlabel1.Location = new Point(69, 151);
            resultlabel1.Name = "resultlabel1";
            resultlabel1.Size = new Size(0, 20);
            resultlabel1.TabIndex = 16;
            // 
            // ShowPassButton
            // 
            ShowPassButton.Image = Properties.Icons.Untitled_design;
            ShowPassButton.Location = new Point(494, 268);
            ShowPassButton.Name = "ShowPassButton";
            ShowPassButton.Size = new Size(32, 23);
            ShowPassButton.TabIndex = 15;
            ShowPassButton.UseVisualStyleBackColor = true;
            ShowPassButton.Click += ShowPassButton_Click;
            // 
            // ForgotPasswordButton
            // 
            ForgotPasswordButton.BackColor = Color.Transparent;
            ForgotPasswordButton.FlatAppearance.BorderSize = 0;
            ForgotPasswordButton.FlatStyle = FlatStyle.Flat;
            ForgotPasswordButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            ForgotPasswordButton.ForeColor = Color.Red;
            ForgotPasswordButton.Location = new Point(411, 331);
            ForgotPasswordButton.Name = "ForgotPasswordButton";
            ForgotPasswordButton.Size = new Size(117, 23);
            ForgotPasswordButton.TabIndex = 14;
            ForgotPasswordButton.Text = "Forgot Password?";
            ForgotPasswordButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F);
            label3.Location = new Point(162, 453);
            label3.Name = "label3";
            label3.Size = new Size(162, 13);
            label3.TabIndex = 7;
            label3.Text = "------------------------Or------------------------";
            // 
            // GoogleSignInButton
            // 
            GoogleSignInButton.BackColor = Color.Brown;
            GoogleSignInButton.FlatStyle = FlatStyle.Flat;
            GoogleSignInButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            GoogleSignInButton.ForeColor = Color.White;
            GoogleSignInButton.Location = new Point(97, 509);
            GoogleSignInButton.Name = "GoogleSignInButton";
            GoogleSignInButton.Size = new Size(411, 40);
            GoogleSignInButton.TabIndex = 6;
            GoogleSignInButton.Text = "Log In with Google";
            GoogleSignInButton.UseVisualStyleBackColor = false;
            // 
            // buttonLogIn
            // 
            buttonLogIn.BackColor = Color.Brown;
            buttonLogIn.FlatStyle = FlatStyle.Flat;
            buttonLogIn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonLogIn.ForeColor = Color.White;
            buttonLogIn.Location = new Point(162, 396);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(197, 40);
            buttonLogIn.TabIndex = 5;
            buttonLogIn.Text = "Log In";
            buttonLogIn.UseVisualStyleBackColor = false;
            // 
            // RememberMeCheckBox
            // 
            RememberMeCheckBox.AccessibilityEnabled = true;
            RememberMeCheckBox.Font = new Font("Microsoft Sans Serif", 8.25F);
            RememberMeCheckBox.Location = new Point(58, 331);
            RememberMeCheckBox.Name = "RememberMeCheckBox";
            RememberMeCheckBox.Size = new Size(150, 21);
            RememberMeCheckBox.TabIndex = 4;
            RememberMeCheckBox.Text = "Remember Me?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(58, 226);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = Color.Transparent;
            PasswordTextBox.BeforeTouchSize = new Size(470, 29);
            PasswordTextBox.Font = new Font("Microsoft Sans Serif", 14.25F);
            PasswordTextBox.Location = new Point(58, 266);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '●';
            PasswordTextBox.Size = new Size(470, 29);
            PasswordTextBox.TabIndex = 2;
            PasswordTextBox.TextChanged += PasswordTextBoxV2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(58, 103);
            label1.Name = "label1";
            label1.Size = new Size(278, 25);
            label1.TabIndex = 1;
            label1.Text = "Umindanao E-mail Address:";
            // 
            // EmailTextBox
            // 
            EmailTextBox.BackColor = Color.Transparent;
            EmailTextBox.BeforeTouchSize = new Size(470, 29);
            EmailTextBox.Font = new Font("Microsoft Sans Serif", 14.25F);
            EmailTextBox.Location = new Point(58, 136);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(470, 29);
            EmailTextBox.TabIndex = 0;
            EmailTextBox.TextChanged += SignInTextBox_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Icons.Untitled__Logo_;
            pictureBox1.Location = new Point(201, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(843, 656);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dockingClientPanel1
            // 
            dockingClientPanel1.BackgroundImage = Properties.Icons.RedBg_1_;
            dockingClientPanel1.Controls.Add(pictureBox1);
            dockingClientPanel1.Controls.Add(panel1);
            dockingClientPanel1.Location = new Point(-23, 0);
            dockingClientPanel1.Name = "dockingClientPanel1";
            dockingClientPanel1.Size = new Size(1940, 1080);
            dockingClientPanel1.TabIndex = 0;
            dockingClientPanel1.Paint += dockingClientPanel1_Paint;
            // 
            // LogInView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1832, 854);
            Controls.Add(dockingClientPanel1);
            Name = "LogInView";
            Text = "LogIn";
            Load += LogIn_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RememberMeCheckBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PasswordTextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmailTextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            dockingClientPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt PasswordTextBox;
        private Label label1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt EmailTextBox;
        private Label label2;
        private Button buttonLogIn;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv RememberMeCheckBox;
        private Button GoogleSignInButton;
        private Label label3;
        private Button ForgotPasswordButton;
        private Button ShowPassButton;
        private Label ErrorPassLabel;
        private Label resultlabel1;
        private PictureBox pictureBox1;
        private Syncfusion.Windows.Forms.Tools.DockingClientPanel dockingClientPanel1;
    }
}