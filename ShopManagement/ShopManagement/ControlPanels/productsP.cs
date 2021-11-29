using System;
using System.Windows.Forms;

namespace ShopManagement.ControlPanels
{
    public partial class productsP : UserControl
    {
        public productsP()
        {
            InitializeComponent();

            button_pDelete.Hide();

            foreach (products product in Program.PRODUCTS)
                products_grid.Rows.Add(product.id, product.name, product.cID, $"{product.price} Ft", $"{product.discount} %", $"{product.count} db");

            foreach (categories category in Program.CATEGORIES)
                input_pCategory.Items.Add(category.name);

            foreach (DataGridViewColumn column in products_grid.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

            products_grid.ClearSelection();
            products_grid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            products_grid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            products_grid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            products_grid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            products_grid.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void button_pSave_Click(object sender, EventArgs e)
        {
            if (button_pSave.Text == Program.CONFIG.Get("saveItem"))
            {
                string pName = input_pName.Text;
                string pCategory = input_pCategory.Text;
                int pPrice = 0;
                int pDiscount = 0;
                int pCount = 0;

                try {
                    pPrice = int.Parse(input_pPrice.Text);
                    pDiscount = int.Parse(input_pDiscount.Text);
                    pCount = int.Parse(input_pDb.Text);
                } catch (FormatException)
                {
                    MessageBox.Show("Ár, Kedvezmény, Darabszám helyére csak szám írható!");
                    return;
                }
                

                if (pName.Length <= 0 || pCategory.Length <= 0) { MessageBox.Show("Minden mező kitöltése kötelező"); return; }
                if (pPrice == 0 || pCount == 0) { MessageBox.Show("Az ár és a darabszám nem lehet kisebb 1-nél!"); return; }
                if (pDiscount < 0) { MessageBox.Show("Az akció mértéke nem lehet kisebb 0-nál!"); return; }

                int pcID = -1;

                foreach (categories category in Program.CATEGORIES)
                {
                    if (category.name == pCategory)
                        { pcID = category.id; break; }
                }

                if (pcID == -1)
                    { MessageBox.Show("Nem található ilyen termék kategória!"); return; }

                foreach (products product in Program.PRODUCTS)
                {
                    if (product.name == pName)
                        { MessageBox.Show("Létezik már ilyen termék!"); return; }
                }

                productCreate(pName, pcID, pPrice, pDiscount, pCount);
            } else if (button_pSave.Text == Program.CONFIG.Get("editItem"))
            {
                string pName = input_pName.Text;
                string pCategory = input_pCategory.Text;
                int pPrice = 0;
                int pDiscount = 0;
                int pCount = 0;

                try
                {
                    pPrice = int.Parse(input_pPrice.Text);
                    pDiscount = int.Parse(input_pDiscount.Text);
                    pCount = int.Parse(input_pDb.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ár, Kedvezmény, Darabszám helyére csak szám írható!");
                    return;
                }

                if (pName.Length <= 0 || pCategory.Length <= 0) { MessageBox.Show("Minden mező kitöltése kötelező"); return; }
                if (pPrice == 0 || pCount == 0) { MessageBox.Show("Az ár és a darabszám nem lehet kisebb 1-nél!"); return; }
                if (pDiscount < 0) { MessageBox.Show("Az akció mértéke nem lehet kisebb 0-nál!"); return; }

                int pcID = -1;

                foreach (categories category in Program.CATEGORIES)
                {
                    if (category.name == pCategory)
                        { pcID = category.id; break; }
                }

                if (pcID == -1) { MessageBox.Show("Nem található ilyen termék kategória!"); return; }

                foreach (products product in Program.PRODUCTS)
                {
                    if (product.name == pName && !product.isModify)
                        { MessageBox.Show("Létezik már ilyen termék!"); return; }
                }

                productModify(pName, pcID, pCategory, pPrice, pDiscount, pCount);
            }
        }

        private void button_pDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.PRODUCTS.Count; i++)
            {
                if (Program.PRODUCTS[i].isModify)
                {
                    if (products_grid.CurrentRow.Selected && products_grid.CurrentRow.Index == i) //Currentrow is selected and currentRow isModified
                    {
                        Program.CONNECTION.Delete($"DELETE FROM {Program.CONFIG.Get("productDB")} WHERE id = '{Program.PRODUCTS[i].id}'");
                        products_grid.Rows.Remove(products_grid.Rows[products_grid.CurrentRow.Index]);
                        Program.PRODUCTS.RemoveRange(i, 1);

                        button_pDelete.Hide();
                        button_pSave.Text = Program.CONFIG.Get("saveItem");
                        input_pName.Text = input_pCategory.Text = "";
                        input_pDb.Text = input_pPrice.Text = input_pDiscount.Text = "0";

                        products_grid.ClearSelection();
                    }
                    break;
                }
            }
        }

        private void productModify(string pName, int pCategory, string pCategoryName, int pPrice, int pDiscount, int pCount)
        {
            for (int i = 0; i < Program.PRODUCTS.Count; i++)
            {
                if (Program.PRODUCTS[i].isModify)
                {
                    products product = new products();
                    product.id = Program.PRODUCTS[i].id;
                    product.name = pName;
                    product.cID = pCategoryName;
                    product.price = pPrice;
                    product.discount = pDiscount;
                    product.count = pCount;

                    Program.PRODUCTS[i] = product;

                    for (int j = 0; j < products_grid.Rows.Count; j++)
                    {
                        if (int.Parse(products_grid.Rows[j].Cells[0].Value.ToString()) == product.id)
                        {
                            products_grid.Rows[j].Cells[1].Value = product.name;
                            products_grid.Rows[j].Cells[2].Value = product.cID;
                            products_grid.Rows[j].Cells[3].Value = $"{product.price} Ft";
                            products_grid.Rows[j].Cells[4].Value = $"{product.discount} % ";
                            products_grid.Rows[j].Cells[5].Value = $"{product.count} db";
                        }
                    }

                    button_pSave.Text = Program.CONFIG.Get("saveItem");
                    input_pName.Text = input_pCategory.Text = "";
                    button_pDelete.Hide();
                    input_pDb.Text = input_pPrice.Text = input_pDiscount.Text = "0";

                    Program.CONNECTION.Update($"UPDATE {Program.CONFIG.Get("productDB")} SET name = '{product.name}', cID = '{pCategory}', price = '{product.price}', discount = '{product.discount}', count = '{product.count}' WHERE id='{product.id}'");
                    product = new products();
                    break;
                }
            }
            products_grid.ClearSelection();
            MessageBox.Show("Sikeres módosítás!");
        }

        private void productCreate(string name, int cID, int price, int discount, int count)
        {
            int lastID = Program.CONNECTION.Insert($"INSERT INTO {Program.CONFIG.Get("productDB")} SET name = '{name}', cID = '{cID}', price = '{price}', discount = '{discount}', count = '{count}'");
            
            if (lastID == -1) { MessageBox.Show("Hiba történt a létrehozáskor!"); return; }

            products product = new products();
            product.id = lastID;
            product.name = name;
            product.cID = " - ";

            foreach (categories category in Program.CATEGORIES)
            {
                if (category.id == cID)
                    { product.cID = category.name; break; }
            }

            product.price = price;
            product.discount = discount;
            product.count = count;

            Program.PRODUCTS.Add(product);
            products_grid.Rows.Add(product.id, product.name, product.cID, $"{product.price} Ft", $"{product.discount} %", $"{product.count} db");

            input_pName.Text = input_pCategory.Text = "";
            input_pDb.Text = input_pPrice.Text = input_pDiscount.Text = "0";

            product = new products();
            MessageBox.Show("Sikeresen hozzáadva!");
        }

        private void products_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridView dgv = sender as DataGridView;
            if (e.RowIndex < 0) return;
            if (dgv == null)    return;
            if (!dgv.CurrentRow.Selected) return;

            //Check modify state
            for (int i = 0; i < Program.PRODUCTS.Count; i++)
            {
                if (Program.PRODUCTS[i].isModify)
                {
                    products product1 = Program.PRODUCTS[i];
                    product1.isModify = false;
                    Program.PRODUCTS[i] = product1;
                    product1 = new products();

                    break;
                }
            }

            int index = dgv.CurrentRow.Index;

            DataGridViewRow currentRow = products_grid.Rows[index];
            products product = new products();
            product.id = int.Parse(currentRow.Cells[0].Value.ToString());
            product.name = currentRow.Cells[1].Value.ToString();
            product.cID = currentRow.Cells[2].Value.ToString();
            product.price = int.Parse(currentRow.Cells[3].Value.ToString().Split(' ')[0]);
            product.discount = int.Parse(currentRow.Cells[4].Value.ToString().Split(' ')[0]);
            product.count = int.Parse(currentRow.Cells[5].Value.ToString().Split(' ')[0]);
            product.isModify = true;

            for (int i = 0; i < Program.PRODUCTS.Count; i++)
                if (Program.PRODUCTS[i].id == product.id)
                    Program.PRODUCTS[i] = product;

            input_pName.Text = product.name;
            input_pCategory.Text = product.cID;
            input_pPrice.Text = product.price.ToString();
            input_pDiscount.Text = product.discount.ToString();
            input_pDb.Text = product.count.ToString();
            button_pDelete.Show();
            button_pSave.Text = Program.CONFIG.Get("editItem");
            product = new products();
        }

        private void products_grid_VisibleChanged(object sender, EventArgs e)
        {
            products_grid.Rows.Clear();
            input_pCategory.Items.Clear();

            foreach (products product in Program.PRODUCTS)
                products_grid.Rows.Add(product.id, product.name, product.cID, $"{product.price} Ft", $"{product.discount} %", $"{product.count} db");

            foreach (categories category in Program.CATEGORIES)
                input_pCategory.Items.Add(category.name);
        }
    }
}
