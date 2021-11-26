using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ShopManagement.ControlPanels
{
    public partial class sellP : UserControl
    {
        int TOTALCOST = 0;
        List<billing> BILLING = new List<billing>();

        public sellP()
        {
            InitializeComponent();

            button_removeItem.Hide();

            //disable sortable func
            foreach (DataGridViewColumn column in sell_grid.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

            // load combobox
            foreach (products product in Program.PRODUCTS)
                input_productName.Items.Add(product.name);

            billingShowing(false);
            sell_grid.ClearSelection();
            sell_grid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void billingShowing(bool state)
        {
            if (!state)
            {
                input_productName.Hide();
                input_productCount.Hide();
                button_addItem.Hide();
                button_confirm.Hide();
                sell_grid.Hide();
                label_productCount.Hide();
                label_productName.Hide();
                label_total.Hide();
            } else
            {
                input_productName.Show();
                input_productCount.Show();
                button_addItem.Show();
                button_confirm.Show();
                sell_grid.Show();
                label_productCount.Show();
                label_productName.Show();
                label_total.Show();
            }
        }

        private void button_startSell_Click(object sender, EventArgs e)
        {
            string customerID = input_customerID.Text;

            if (customerID.Length <= 0)
                { MessageBox.Show("Mező kitöltése kötelező!"); return; }

            List<Dictionary<String, Object>> result = Program.CONNECTION.Select($"SELECT id FROM {Program.CONFIG.Get("usersDB")} WHERE username = '{customerID}'");

            if (result.Count <= 0) { MessageBox.Show("Nincs ilyen felhasználónév!"); return; }

            billingShowing(true);
        }

        private void button_addItem_Click(object sender, EventArgs e)
        {
            string productName = input_productName.Text;
            int productCount = 0;
            try
            {
                productCount = int.Parse(input_productCount.Text);
            } catch (FormatException)
            {
                MessageBox.Show("Csak szám értéket írhatsz a mennyiséghez!");
                return;
            }
            

            if (productName.Length <= 0 || productCount <= 0) { MessageBox.Show("Mező kitöltése kötelező!"); return; }

            int id = 0;
            string name = productName;
            double price = 0;
            int count = productCount;
            int total = (int)price * count;

            for (int i = 0; i < Program.PRODUCTS.Count; i++)
            {
                if (Program.PRODUCTS[i].name == name)
                {
                    if (Program.PRODUCTS[i].count < count) { MessageBox.Show($"Ebből a termékből csak {Program.PRODUCTS[i].count} db van raktáron!"); return; }

                    if (sell_grid.Rows.Count == 0)
                        id = 1;
                    else
                        id = int.Parse(sell_grid.Rows[sell_grid.Rows.Count-1].Cells[0].Value.ToString())+1;

                    price = Program.PRODUCTS[i].price * (1 - ((double)Program.PRODUCTS[i].discount / 100));
                    total = (int)price * count;

                    products field = new products();
                    field = Program.PRODUCTS[i];
                    field.count = field.count - count;
                    Program.PRODUCTS[i] = field;
                    Program.CONNECTION.Update($"UPDATE {Program.CONFIG.Get("productDB")} SET count='{field.count}' WHERE id='{field.id}'");
                    field = new products();

                    break;
                }
            }
            TOTALCOST += total;

            billing temp = new billing();
            temp.id = id;
            temp.name = name;
            temp.price = (int)price;
            temp.count = count;
            temp.total = total;
            temp.isModify = false;
            BILLING.Add(temp);
            temp = new billing();

            sell_grid.Rows.Add(id, name, (int)price, count, total);
            sell_grid.ClearSelection();
            label_total.Text = $"Összesen fizetendő: {TOTALCOST} Ft";
        }

        private void sell_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (e.RowIndex < 0) return;
            if (dgv == null) return;
            if (!dgv.CurrentRow.Selected) return;

            for (int i = 0; i < BILLING.Count; i++)
            {
                if (BILLING[i].isModify)
                {
                    billing temp = BILLING[i];
                    temp.isModify = false;
                    BILLING[i] = temp;
                    Console.WriteLine( BILLING[i].isModify);
                    break;
                }
            }

            int index = dgv.CurrentRow.Index;

            DataGridViewRow currentRow = sell_grid.Rows[index];
            billing field = new billing();
            field.id = int.Parse(currentRow.Cells[0].Value.ToString());
            field.name = currentRow.Cells[1].Value.ToString();
            field.price =  int.Parse(currentRow.Cells[2].Value.ToString());
            field.count = int.Parse(currentRow.Cells[3].Value.ToString());
            field.total = int.Parse(currentRow.Cells[4].Value.ToString());
            field.isModify = true;

            for (int i = 0; i < BILLING.Count; i++)
                if (BILLING[i].id == field.id)
                    BILLING[i] = field;


            field = new billing();
            button_removeItem.Show();
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            if (sell_grid.Rows.Count <= 0) { return; }

            string reason = "Termék eladás";
            Program.CONNECTION.Insert($"INSERT INTO {Program.CONFIG.Get("transactionDB")} SET employee = '{input_customerID.Text}', description='{reason}', price = '{TOTALCOST}'");

            TOTALCOST = 0;
            sell_grid.Rows.Clear();
            label_total.Text = $"Összesen fizetendő: {TOTALCOST} Ft";
        }

        private void button_removeItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < BILLING.Count; i++)
            {
                if (BILLING[i].isModify)
                {
                    if (sell_grid.CurrentRow.Selected && sell_grid.CurrentRow.Index == i)
                    {
                        TOTALCOST -= BILLING[i].total;
                        label_total.Text = $"Összesen fizetendő: {TOTALCOST} Ft";

                        for (int j = 0; j < Program.PRODUCTS.Count; j++)
                        {
                            if (Program.PRODUCTS[j].name == BILLING[i].name)
                            {
                                products product = Program.PRODUCTS[j];
                                product.count += BILLING[i].count;
                                Program.CONNECTION.Update($"UPDATE {Program.CONFIG.Get("productDB")} SET count='{product.count}' WHERE id='{product.id}'");
                                Program.PRODUCTS[j] = product;
                            }
                        }

                        sell_grid.Rows.Remove(sell_grid.Rows[sell_grid.CurrentRow.Index]);
                        BILLING.RemoveRange(i, 1);

                        button_removeItem.Hide();
                        sell_grid.ClearSelection();
                    }
                    break;
                }
            }
        }

        private void input_customerID_TextChanged(object sender, EventArgs e)
        {
            billingShowing(false);
        }
    }
}
