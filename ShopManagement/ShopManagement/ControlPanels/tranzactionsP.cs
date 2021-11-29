using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ShopManagement.ControlPanels
{
    public partial class tranzactionsP : UserControl
    {
        public tranzactionsP()
        {
            InitializeComponent();

            List<Dictionary<String, Object>> result = Program.CONNECTION.Select($"SELECT * FROM {Program.CONFIG.Get("transactionDB")}");

            transaction field = new transaction();

            for (int i = 0; i < result.Count; i++)
            {
                field.id = int.Parse(result[i]["id"].ToString());
                field.employee = result[i]["employee"].ToString();
                field.description = result[i]["description"].ToString();
                field.price = int.Parse(result[i]["price"].ToString());

                transactions_grid.Rows.Add(field.id, field.employee, field.description, $"{field.price} Ft");
               

                if (field.price >= 0)
                {
                    transactions_grid.Rows[field.id-1].HeaderCell.Style.BackColor = Color.Green;
                    transactions_grid.Rows[field.id - 1].HeaderCell.Style.SelectionBackColor = Color.Green;
                } else if (field.price < 0)
                {
                    transactions_grid.Rows[field.id-1].HeaderCell.Style.BackColor = Color.Red;
                    transactions_grid.Rows[field.id-1].HeaderCell.Style.SelectionBackColor = Color.Red;
                }
            }

            //disable sortable func
            foreach (DataGridViewColumn column in transactions_grid.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

            transactions_grid.ClearSelection();
            transactions_grid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            transactions_grid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void transactions_grid_VisibleChanged(object sender, EventArgs e)
        {
            List<Dictionary<String, Object>> result = Program.CONNECTION.Select($"SELECT * FROM {Program.CONFIG.Get("transactionDB")}");

            transactions_grid.Rows.Clear();
            transaction field = new transaction();

            for (int i = 0; i < result.Count; i++)
            {
                field.id = int.Parse(result[i]["id"].ToString());
                field.employee = result[i]["employee"].ToString();
                field.description = result[i]["description"].ToString();
                field.price = int.Parse(result[i]["price"].ToString());

                transactions_grid.Rows.Add(field.id, field.employee, field.description, $"{field.price} Ft");


                if (field.price >= 0)
                {
                    transactions_grid.Rows[field.id - 1].HeaderCell.Style.BackColor = Color.Green;
                    transactions_grid.Rows[field.id - 1].HeaderCell.Style.SelectionBackColor = Color.Green;
                }
                else if (field.price < 0)
                {
                    transactions_grid.Rows[field.id - 1].HeaderCell.Style.BackColor = Color.Red;
                    transactions_grid.Rows[field.id - 1].HeaderCell.Style.SelectionBackColor = Color.Red;
                }
            }

        }
    }
}
