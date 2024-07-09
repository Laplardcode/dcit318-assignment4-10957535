namespace LoginScreenImplementation
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();

            this.usernameTextBox.Location = new System.Drawing.Point(50, 70);
            this.passwordTextBox.Location = new System.Drawing.Point(50, 120);
            this.loginButton.Location = new System.Drawing.Point(50, 170);
            this.usernameLabel.Location = new System.Drawing.Point(50, 50);
            this.passwordLabel.Location = new System.Drawing.Point(50, 100);

            this.usernameLabel.Text = "Username";
            this.passwordLabel.Text = "Password";

            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordLabel);

            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Login Screen";
        }
    }

}


