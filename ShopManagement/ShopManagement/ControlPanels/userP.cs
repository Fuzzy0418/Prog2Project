using System.Windows.Forms;

namespace ShopManagement
{
    public partial class userP : UserControl
    {
        public userP()
        {
            InitializeComponent();

            foreach (var user in Program.USERS)
                user_grid.Rows.Add(user.id, user.name, user.role, user.username);

            user_grid.ClearSelection();
            user_grid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            user_grid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
