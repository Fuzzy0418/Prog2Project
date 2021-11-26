using System;
using System.Windows.Forms;

namespace ShopManagement
{
    public partial class management : Form
    {
        public management()
        {
            InitializeComponent();
            hideAll();
            home1.Show();
            ControlExtension.Draggable(this, true);
        }

        private void hideAll()
        {
            home1.Hide();
            userP1.Hide();
            productsP1.Hide();
            categoriesP1.Hide();
            tranzactionsP1.Hide();
            sellP1.Hide();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            hideAll();
            home1.Show();
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            hideAll();
            userP1.Show();
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            hideAll();
            productsP1.Show();
        }

        private void categoriesBtn_Click(object sender, EventArgs e)
        {
            hideAll();
            categoriesP1.Show();
        }

        private void transactionBtn_Click(object sender, EventArgs e)
        {
            hideAll();
            tranzactionsP1.Show();
        }

        private void sellBtn_Click(object sender, EventArgs e)
        {
            hideAll();
            sellP1.Show();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            hideAll();
            Application.Exit();
        }

        private void logo_Click(object sender, EventArgs e)
        {
            hideAll();
            home1.Show();
        }
    }
}
