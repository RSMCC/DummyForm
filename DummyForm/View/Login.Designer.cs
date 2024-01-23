
namespace DummyForm
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            userNameLabel = new Label();
            passowdLabel = new Label();
            userNameInput = new TextBox();
            passwordInput = new TextBox();
            loginButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(369, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 56);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(376, 156);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(235, 195);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(112, 15);
            userNameLabel.TabIndex = 2;
            userNameLabel.Text = "Nombre de usuario:";
            // 
            // passowdLabel
            // 
            passowdLabel.AutoSize = true;
            passowdLabel.Location = new Point(235, 228);
            passowdLabel.Name = "passowdLabel";
            passowdLabel.Size = new Size(70, 15);
            passowdLabel.TabIndex = 3;
            passowdLabel.Text = "Contraseña:";
            // 
            // userNameInput
            // 
            userNameInput.Location = new Point(353, 191);
            userNameInput.Name = "userNameInput";
            userNameInput.Size = new Size(179, 23);
            userNameInput.TabIndex = 4;
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(353, 226);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(179, 23);
            passwordInput.TabIndex = 5;
            passwordInput.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.DodgerBlue;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.ForeColor = SystemColors.ControlLightLight;
            loginButton.Location = new Point(353, 270);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(94, 37);
            loginButton.TabIndex = 6;
            loginButton.Text = "Ingresar";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(769, 450);
            Controls.Add(loginButton);
            Controls.Add(passwordInput);
            Controls.Add(userNameInput);
            Controls.Add(passowdLabel);
            Controls.Add(userNameLabel);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "DummyForm";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Load += new System.EventHandler(this.Login_Load);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label userNameLabel;
        private Label passowdLabel;
        private TextBox userNameInput;
        private TextBox passwordInput;
        private Button loginButton;
    }
}
