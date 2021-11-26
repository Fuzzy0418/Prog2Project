using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ShopManagement
{
    public partial class home : UserControl
    {
        public home()
        {
            InitializeComponent();

            text_users.Text = $"Alkalmazottak: {Program.USERS.Count} db";
            text_products.Text = $"Termékek: {Program.PRODUCTS.Count} db";
            text_categories.Text = $"Kategóriák: {Program.CATEGORIES.Count} db";
        }
    }
}
