namespace DoAn
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quanliButton = new System.Windows.Forms.RadioButton();
            this.tieptanButton = new System.Windows.Forms.RadioButton();
            this.laocongButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(47, 142);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(151, 40);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(232, 142);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(155, 40);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(152, 51);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(235, 22);
            this.usernameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(152, 98);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(235, 22);
            this.passwordTextBox.TabIndex = 3;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(44, 54);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(73, 17);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // quanliButton
            // 
            this.quanliButton.AutoSize = true;
            this.quanliButton.Location = new System.Drawing.Point(47, 19);
            this.quanliButton.Name = "quanliButton";
            this.quanliButton.Size = new System.Drawing.Size(79, 21);
            this.quanliButton.TabIndex = 6;
            this.quanliButton.TabStop = true;
            this.quanliButton.Text = "Quan Li";
            this.quanliButton.UseVisualStyleBackColor = true;
            // 
            // tieptanButton
            // 
            this.tieptanButton.AutoSize = true;
            this.tieptanButton.Location = new System.Drawing.Point(172, 19);
            this.tieptanButton.Name = "tieptanButton";
            this.tieptanButton.Size = new System.Drawing.Size(86, 21);
            this.tieptanButton.TabIndex = 7;
            this.tieptanButton.TabStop = true;
            this.tieptanButton.Text = "Tiep Tan";
            this.tieptanButton.UseVisualStyleBackColor = true;
            // 
            // laocongButton
            // 
            this.laocongButton.AutoSize = true;
            this.laocongButton.Location = new System.Drawing.Point(297, 19);
            this.laocongButton.Name = "laocongButton";
            this.laocongButton.Size = new System.Drawing.Size(90, 21);
            this.laocongButton.TabIndex = 8;
            this.laocongButton.TabStop = true;
            this.laocongButton.Text = "Lao Cong";
            this.laocongButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(439, 215);
            this.Controls.Add(this.laocongButton);
            this.Controls.Add(this.tieptanButton);
            this.Controls.Add(this.quanliButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton quanliButton;
        private System.Windows.Forms.RadioButton tieptanButton;
        private System.Windows.Forms.RadioButton laocongButton;
    }
}

