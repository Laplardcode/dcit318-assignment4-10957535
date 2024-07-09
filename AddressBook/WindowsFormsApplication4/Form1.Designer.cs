namespace AddressBook
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneNumberLabel;

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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();

            this.nameTextBox.Location = new System.Drawing.Point(50, 70);
            this.emailTextBox.Location = new System.Drawing.Point(50, 120);
            this.phoneNumberTextBox.Location = new System.Drawing.Point(50, 170);
            this.saveButton.Location = new System.Drawing.Point(50, 220);
            this.nameLabel.Location = new System.Drawing.Point(50, 50);
            this.emailLabel.Location = new System.Drawing.Point(50, 100);
            this.phoneNumberLabel.Location = new System.Drawing.Point(50, 150);

            this.nameLabel.Text = "Name";
            this.emailLabel.Text = "Email";
            this.phoneNumberLabel.Text = "Phone Number";

            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneNumberLabel);

            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Address Book";
        }
    }
}
