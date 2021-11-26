namespace ShopManagement
{
    partial class loginBG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginBG));
            this.shopName = new System.Windows.Forms.Label();
            this.loginTitle = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Panel();
            this.closeButton_text = new System.Windows.Forms.Label();
            this.input_username = new System.Windows.Forms.TextBox();
            this.input_password = new System.Windows.Forms.TextBox();
            this.radio_admin = new System.Windows.Forms.RadioButton();
            this.radio_employee = new System.Windows.Forms.RadioButton();
            this.button_login = new System.Windows.Forms.Button();
            this.closeButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // shopName
            // 
            this.shopName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shopName.BackColor = System.Drawing.Color.Transparent;
            this.shopName.Font = new System.Drawing.Font("Autobus Bold", 26F, System.Drawing.FontStyle.Bold);
            this.shopName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.shopName.Location = new System.Drawing.Point(102, 108);
            this.shopName.Margin = new System.Windows.Forms.Padding(0);
            this.shopName.Name = "shopName";
            this.shopName.Size = new System.Drawing.Size(435, 53);
            this.shopName.TabIndex = 0;
            this.shopName.Text = "XY Shop - Management";
            this.shopName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginTitle
            // 
            this.loginTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginTitle.BackColor = System.Drawing.Color.Transparent;
            this.loginTitle.Font = new System.Drawing.Font("Autobus Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTitle.ForeColor = System.Drawing.Color.Green;
            this.loginTitle.Location = new System.Drawing.Point(631, 97);
            this.loginTitle.Margin = new System.Windows.Forms.Padding(0);
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.Size = new System.Drawing.Size(499, 54);
            this.loginTitle.TabIndex = 1;
            this.loginTitle.Text = "Bejelentkezés";
            this.loginTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Maroon;
            this.closeButton.Controls.Add(this.closeButton_text);
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Location = new System.Drawing.Point(1100, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.TabIndex = 2;
            // 
            // closeButton_text
            // 
            this.closeButton_text.BackColor = System.Drawing.Color.Transparent;
            this.closeButton_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeButton_text.ForeColor = System.Drawing.Color.White;
            this.closeButton_text.Location = new System.Drawing.Point(1, 0);
            this.closeButton_text.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton_text.Name = "closeButton_text";
            this.closeButton_text.Size = new System.Drawing.Size(30, 30);
            this.closeButton_text.TabIndex = 0;
            this.closeButton_text.Text = "X";
            this.closeButton_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeButton_text.Click += new System.EventHandler(this.closeButton_text_Click);
            this.closeButton_text.MouseEnter += new System.EventHandler(this.closeButton_text_Hover);
            this.closeButton_text.MouseLeave += new System.EventHandler(this.closeButton_text_HoverEnd);
            // 
            // input_username
            // 
            this.input_username.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.input_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.input_username.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.input_username.Location = new System.Drawing.Point(803, 218);
            this.input_username.MaxLength = 15;
            this.input_username.Name = "input_username";
            this.input_username.Size = new System.Drawing.Size(166, 23);
            this.input_username.TabIndex = 3;
            this.input_username.Text = "username";
            // 
            // input_password
            // 
            this.input_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.input_password.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.input_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.input_password.ForeColor = System.Drawing.SystemColors.Window;
            this.input_password.Location = new System.Drawing.Point(801, 267);
            this.input_password.Name = "input_password";
            this.input_password.Size = new System.Drawing.Size(168, 23);
            this.input_password.TabIndex = 4;
            this.input_password.Text = "password";
            this.input_password.UseSystemPasswordChar = true;
            // 
            // radio_admin
            // 
            this.radio_admin.AutoSize = true;
            this.radio_admin.BackColor = System.Drawing.Color.Transparent;
            this.radio_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radio_admin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radio_admin.Location = new System.Drawing.Point(764, 164);
            this.radio_admin.Name = "radio_admin";
            this.radio_admin.Size = new System.Drawing.Size(94, 29);
            this.radio_admin.TabIndex = 5;
            this.radio_admin.TabStop = true;
            this.radio_admin.Text = "Admin";
            this.radio_admin.UseVisualStyleBackColor = false;
            // 
            // radio_employee
            // 
            this.radio_employee.AutoSize = true;
            this.radio_employee.BackColor = System.Drawing.Color.Transparent;
            this.radio_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radio_employee.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radio_employee.Location = new System.Drawing.Point(893, 164);
            this.radio_employee.Name = "radio_employee";
            this.radio_employee.Size = new System.Drawing.Size(145, 29);
            this.radio_employee.TabIndex = 6;
            this.radio_employee.TabStop = true;
            this.radio_employee.Text = "Alkalmazott";
            this.radio_employee.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button_login.BackColor = System.Drawing.Color.DarkGray;
            this.button_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login.FlatAppearance.BorderSize = 0;
            this.button_login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_login.Location = new System.Drawing.Point(829, 314);
            this.button_login.Name = "button1";
            this.button_login.Size = new System.Drawing.Size(120, 39);
            this.button_login.TabIndex = 7;
            this.button_login.Text = "Bejelentkezés";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // loginBG
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1130, 590);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.radio_employee);
            this.Controls.Add(this.radio_admin);
            this.Controls.Add(this.input_password);
            this.Controls.Add(this.input_username);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.loginTitle);
            this.Controls.Add(this.shopName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loginBG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopManagement";
            this.closeButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shopName;
        private System.Windows.Forms.Label loginTitle;
        private System.Windows.Forms.Panel closeButton;
        private System.Windows.Forms.Label closeButton_text;
        private System.Windows.Forms.TextBox input_username;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.RadioButton radio_admin;
        private System.Windows.Forms.RadioButton radio_employee;
        private System.Windows.Forms.Button button_login;
    }
}

