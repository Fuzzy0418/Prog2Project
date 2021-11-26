using System;
using System.Windows.Forms;

namespace ShopManagement.ControlPanels
{
    public partial class categoriesP : UserControl
    {
        public categoriesP()
        {
            InitializeComponent();

            button_cDelete.Hide();

            // Add Categories to gridview
            foreach (var item in Program.CATEGORIES)
                category_grid.Rows.Add(item.id, item.name);

            //disable sortable func
            foreach (DataGridViewColumn column in category_grid.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

            category_grid.ClearSelection();
            category_grid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void button_cSave_Click(object sender, EventArgs e)
        {
            if (button_cSave.Text == Program.CONFIG.Get("saveItem"))
            {
                string cName = input_cName.Text;

                if (cName.Length <= 0) { MessageBox.Show("Mező kitöltése kötelező!"); return; }

                foreach (var category in Program.CATEGORIES)
                {
                    if (category.name == cName)
                        { MessageBox.Show("Létezik már ilyen kategória!"); return; }
                }

                categoryCreate(cName);
            } else if (button_cSave.Text == Program.CONFIG.Get("editItem"))
            {
                string cName = input_cName.Text;

                if (cName.Length <= 0) { MessageBox.Show("Mező kitöltése kötelező!"); return; }

                foreach (var category in Program.CATEGORIES)
                {
                    if (category.name == cName && !category.isModify)
                        { MessageBox.Show("Létezik már ilyen kategória!"); return; }
                }

                categoryModify(cName);
            }
        }

        private void button_cDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.CATEGORIES.Count; i++)
            {
                if (Program.CATEGORIES[i].isModify)
                {
                    if (category_grid.CurrentRow.Selected && category_grid.CurrentRow.Index == i) //Currentrow is selected and currentRow isModified
                    {
                        // TODO reset product_grid
                        for (int j = 0; j < Program.PRODUCTS.Count; j++)
                        {
                            if (Program.PRODUCTS[j].cID == Program.CATEGORIES[i].name)
                            {
                                Program.PRODUCTS[j].cID.Replace(Program.PRODUCTS[j].cID, " - ");
                            }
                        }

                        Program.CONNECTION.Delete($"DELETE FROM {Program.CONFIG.Get("categoryDB")} WHERE id = '{Program.CATEGORIES[i].id}'");
                        category_grid.Rows.Remove(category_grid.Rows[category_grid.CurrentRow.Index]);
                        Program.CATEGORIES.RemoveRange(i, 1);

                        button_cSave.Text = Program.CONFIG.Get("saveItem");
                        input_cName.Text = "";

                        category_grid.ClearSelection();
                        button_cDelete.Hide();
                    }
                    break;
                }
            }
        }

        private void categoryCreate(string cName)
        {
            int lastID = Program.CONNECTION.Insert($"INSERT INTO {Program.CONFIG.Get("categoryDB")} SET name = '{cName}'");

            if (lastID == -1) { MessageBox.Show("Hiba történt a létrehozáskor!"); return; }

            categories category = new categories();
            category.id = lastID;
            category.name = cName;
            category.isModify = false;

            Program.CATEGORIES.Add(category);
            category_grid.Rows.Add(category.id, category.name);

            category = new categories();
            MessageBox.Show("Sikeresen hozzáadva!");
        }

        private void categoryModify(string cName)
        {
            for (int i = 0; i < Program.CATEGORIES.Count; i++)
            {
                if (Program.CATEGORIES[i].isModify)
                {
                    Program.CATEGORIES[i].name.Replace(Program.CATEGORIES[i].name, cName);
                    
                    for (int j = 0; j < category_grid.Rows.Count; j++)
                        if (int.Parse(category_grid.Rows[j].Cells[0].Value.ToString()) == Program.CATEGORIES[i].id)
                            category_grid.Rows[j].Cells[1].Value = cName;


                    //update products category
                    for (int j = 0; j < Program.PRODUCTS.Count; j++)
                    {
                        if (Program.PRODUCTS[j].cID == Program.CATEGORIES[i].name)
                        {
                            products product = Program.PRODUCTS[j];
                            product.cID = cName;
                            Program.PRODUCTS[j] = product;
                            product = new products();
                        }
                    }


                    categories category = new categories();
                    category.id = Program.CATEGORIES[i].id;
                    category.name = cName;
                    category.isModify = false;

                    Program.CATEGORIES[i] = category;

                    button_cSave.Text = Program.CONFIG.Get("saveItem");
                    button_cDelete.Hide();
                    input_cName.Text = "";

                    Program.CONNECTION.Update($"UPDATE {Program.CONFIG.Get("categoryDB")} SET name = '{category.name}' WHERE id='{category.id}'");
                    category = new categories();
                    break;
                }
            }
            category_grid.ClearSelection();
            MessageBox.Show("Sikeres módosítás!");
        }

        private void category_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (e.RowIndex < 0) return;
            if (dgv == null) return;
            if (dgv.CurrentRow.Selected)
            {
                //Check modify state
                for (int i = 0; i < Program.CATEGORIES.Count; i++)
                {
                    if (Program.CATEGORIES[i].isModify)
                    {
                        categories category = Program.CATEGORIES[i];
                        category.isModify = false;
                        Program.CATEGORIES[i] = category;

                        break;
                    }
                }

                int index = dgv.CurrentRow.Index;

                DataGridViewRow currentRow =  category_grid.Rows[index];
                categories field = new categories();
                field.id = int.Parse(currentRow.Cells[0].Value.ToString());
                field.name = currentRow.Cells[1].Value.ToString();
                field.isModify = true;

                for (int i = 0; i < Program.CATEGORIES.Count; i++)
                    if (Program.CATEGORIES[i].id == field.id)
                        Program.CATEGORIES[i] = field;

                input_cName.Text = field.name;
                button_cSave.Text = Program.CONFIG.Get("editItem");
                button_cDelete.Show();
                field = new categories();
            }
        }
    }
}
