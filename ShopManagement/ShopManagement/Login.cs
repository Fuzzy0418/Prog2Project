using System;
using System.Linq;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ShopManagement
{
    public partial class loginBG : Form
    {
        public loginBG() {
            InitializeComponent();

            radio_employee.Hide();
            radio_admin.Hide();

            ControlExtension.Draggable(this, true);
        }

        //Close button 'click' event
        private void closeButton_text_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Close button 'hover' effect
        private void closeButton_text_Hover(object sender, EventArgs e)
        {
            this.closeButton.BackColor = System.Drawing.Color.IndianRed;
        }
        private void closeButton_text_HoverEnd(object sender, EventArgs e)
        {
            this.closeButton.BackColor = System.Drawing.Color.Maroon;
        }

        //Login button 'click' event
        private void button_login_Click(object sender, EventArgs e)
        {
            if (input_username.Text != "" || input_password.Text != "" || input_username.Text == "username" || input_password.Text == "password")
                login(input_username.Text, input_password.Text);
            else
                MessageBox.Show("Minden mező kitöltése kötelező!");
        }

        //Login function
        private void login(string username, string password)
        {

            List<Dictionary<String, Object>> result = Program.CONNECTION.Select($"SELECT * FROM {Program.CONFIG.Get("usersDB")} WHERE username = '{username}'");

            if (result.Count > 0) {
                if (ComparePasswords(result[0]["password"].ToString(), password)){
                    this.Hide();
                    management mForm = new management();
                    mForm.Show();

                    return;
                } else
                {
                    MessageBox.Show("Hibás felhasználónév és/vagy jelszó!");
                    return;
                }
            } else
            {
                MessageBox.Show("Hibás felhasználónév és/vagy jelszó!");
                return;
            }
        }

        private static string GenerateKeyHash(string Password)
        {
            if (string.IsNullOrEmpty(Password)) return null;
            if (Password.Length < 1) return null;

            byte[] salt = new byte[20];
            byte[] key = new byte[20];
            byte[] ret = new byte[40];

            try
            {
                using (RNGCryptoServiceProvider randomBytes = new RNGCryptoServiceProvider())
                {
                    randomBytes.GetBytes(salt);

                    using (var hashBytes = new Rfc2898DeriveBytes(Password, salt, 10000))
                    {
                        key = hashBytes.GetBytes(20);
                        Buffer.BlockCopy(salt, 0, ret, 0, 20);
                        Buffer.BlockCopy(key, 0, ret, 20, 20);
                    }
                }
                // returns salt/key pair
                return Convert.ToBase64String(ret);
            }
            finally
            {
                if (salt != null)
                    Array.Clear(salt, 0, salt.Length);
                if (key != null)
                    Array.Clear(key, 0, key.Length);
                if (ret != null)
                    Array.Clear(ret, 0, ret.Length);
            }
        }

        private static bool ComparePasswords(string PasswordHash, string Password)
        {
            if (string.IsNullOrEmpty(PasswordHash) || string.IsNullOrEmpty(Password)) return false;
            if (PasswordHash.Length < 40 || Password.Length < 1) return false;

            byte[] salt = new byte[20];
            byte[] key = new byte[20];
            byte[] hash = Convert.FromBase64String(PasswordHash);

            try
            {
                Buffer.BlockCopy(hash, 0, salt, 0, 20);
                Buffer.BlockCopy(hash, 20, key, 0, 20);

                using (var hashBytes = new Rfc2898DeriveBytes(Password, salt, 10000))
                {
                    byte[] newKey = hashBytes.GetBytes(20);

                    if (newKey != null)
                        if (newKey.SequenceEqual(key))
                            return true;
                }
                return false;
            }
            finally
            {
                if (salt != null)
                    Array.Clear(salt, 0, salt.Length);
                if (key != null)
                    Array.Clear(key, 0, key.Length);
                if (hash != null)
                    Array.Clear(hash, 0, hash.Length);
            }
        }
    }
}