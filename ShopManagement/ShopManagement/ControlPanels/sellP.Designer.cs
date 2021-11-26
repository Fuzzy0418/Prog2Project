namespace ShopManagement.ControlPanels
{
    partial class sellP
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.input_customerID = new System.Windows.Forms.TextBox();
            this.label_customerID = new System.Windows.Forms.Label();
            this.button_startSell = new System.Windows.Forms.Button();
            this.label_productName = new System.Windows.Forms.Label();
            this.input_productName = new System.Windows.Forms.ComboBox();
            this.label_productCount = new System.Windows.Forms.Label();
            this.button_addItem = new System.Windows.Forms.Button();
            this.input_productCount = new System.Windows.Forms.TextBox();
            this.sell_grid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_total = new System.Windows.Forms.Label();
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_removeItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sell_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // input_customerID
            // 
            this.input_customerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.input_customerID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_customerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.input_customerID.ForeColor = System.Drawing.SystemColors.Window;
            this.input_customerID.Location = new System.Drawing.Point(115, 31);
            this.input_customerID.Name = "input_customerID";
            this.input_customerID.Size = new System.Drawing.Size(165, 23);
            this.input_customerID.TabIndex = 0;
            this.input_customerID.TextChanged += new System.EventHandler(this.input_customerID_TextChanged);
            // 
            // label_customerID
            // 
            this.label_customerID.AutoSize = true;
            this.label_customerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_customerID.ForeColor = System.Drawing.SystemColors.Control;
            this.label_customerID.Location = new System.Drawing.Point(-5, 29);
            this.label_customerID.Name = "label_customerID";
            this.label_customerID.Size = new System.Drawing.Size(108, 24);
            this.label_customerID.TabIndex = 1;
            this.label_customerID.Text = "Azonosító:";
            // 
            // button_startSell
            // 
            this.button_startSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_startSell.FlatAppearance.BorderSize = 0;
            this.button_startSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_startSell.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_startSell.Location = new System.Drawing.Point(306, 24);
            this.button_startSell.Name = "button_startSell";
            this.button_startSell.Size = new System.Drawing.Size(107, 37);
            this.button_startSell.TabIndex = 2;
            this.button_startSell.Text = "Megerősítés";
            this.button_startSell.UseVisualStyleBackColor = false;
            this.button_startSell.Click += new System.EventHandler(this.button_startSell_Click);
            // 
            // label_productName
            // 
            this.label_productName.AutoSize = true;
            this.label_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_productName.ForeColor = System.Drawing.SystemColors.Control;
            this.label_productName.Location = new System.Drawing.Point(15, 126);
            this.label_productName.Name = "label_productName";
            this.label_productName.Size = new System.Drawing.Size(87, 24);
            this.label_productName.TabIndex = 3;
            this.label_productName.Text = "Termék:";
            // 
            // input_productName
            // 
            this.input_productName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.input_productName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.input_productName.DropDownHeight = 142;
            this.input_productName.IntegralHeight = false;
            this.input_productName.Sorted = true;
            this.input_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.input_productName.ForeColor = System.Drawing.Color.White;
            this.input_productName.FormattingEnabled = true;
            this.input_productName.Location = new System.Drawing.Point(115, 121);
            this.input_productName.Name = "input_productName";
            this.input_productName.Size = new System.Drawing.Size(145, 37);
            this.input_productName.TabIndex = 4;
            // 
            // label_productCount
            // 
            this.label_productCount.AutoSize = true;
            this.label_productCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_productCount.ForeColor = System.Drawing.SystemColors.Control;
            this.label_productCount.Location = new System.Drawing.Point(289, 126);
            this.label_productCount.Name = "label_productCount";
            this.label_productCount.Size = new System.Drawing.Size(118, 24);
            this.label_productCount.TabIndex = 5;
            this.label_productCount.Text = "Mennyiség:";
            // 
            // button_addItem
            // 
            this.button_addItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_addItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_addItem.FlatAppearance.BorderSize = 0;
            this.button_addItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addItem.Location = new System.Drawing.Point(526, 118);
            this.button_addItem.Name = "button_addItem";
            this.button_addItem.Size = new System.Drawing.Size(100, 42);
            this.button_addItem.TabIndex = 7;
            this.button_addItem.Text = "Hozzáadás";
            this.button_addItem.UseVisualStyleBackColor = false;
            this.button_addItem.Click += new System.EventHandler(this.button_addItem_Click);
            // 
            // input_productCount
            // 
            this.input_productCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.input_productCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_productCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.input_productCount.ForeColor = System.Drawing.Color.White;
            this.input_productCount.Location = new System.Drawing.Point(413, 128);
            this.input_productCount.Name = "input_productCount";
            this.input_productCount.Size = new System.Drawing.Size(66, 21);
            this.input_productCount.TabIndex = 8;
            // 
            // sell_grid
            // 
            this.sell_grid.AllowUserToAddRows = false;
            this.sell_grid.AllowUserToDeleteRows = false;
            this.sell_grid.AllowUserToResizeColumns = false;
            this.sell_grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.NavajoWhite;
            this.sell_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.sell_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sell_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.sell_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sell_grid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.sell_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sell_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.sell_grid.ColumnHeadersHeight = 35;
            this.sell_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.sell_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.price,
            this.count,
            this.total});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sell_grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.sell_grid.EnableHeadersVisualStyles = false;
            this.sell_grid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sell_grid.Location = new System.Drawing.Point(19, 172);
            this.sell_grid.MultiSelect = false;
            this.sell_grid.Name = "transactions_grid";
            this.sell_grid.ReadOnly = true;
            this.sell_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sell_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.sell_grid.RowHeadersWidth = 5;
            this.sell_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.sell_grid.RowTemplate.Height = 24;
            this.sell_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sell_grid.Size = new System.Drawing.Size(450, 282);
            this.sell_grid.TabIndex = 0;
            this.sell_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sell_grid_CellClick);
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "#";
            this.id.MinimumWidth = 50;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // name
            // 
            this.name.Frozen = true;
            this.name.HeaderText = "Név";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // price
            // 
            this.price.Frozen = true;
            this.price.HeaderText = "Ár/egység";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 125;
            // 
            // count
            // 
            this.count.Frozen = true;
            this.count.HeaderText = "Mennyiség";
            this.count.MinimumWidth = 6;
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Width = 125;
            // 
            // total
            // 
            this.total.Frozen = true;
            this.total.HeaderText = "Összesen";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 125;
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.ForeColor = System.Drawing.SystemColors.Control;
            this.label_total.Location = new System.Drawing.Point(40, 600);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(165, 17);
            this.label_total.TabIndex = 9;
            this.label_total.Text = "Összesen fizetendő: 0 Ft";
            // 
            // button_confirm
            // 
            this.button_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_confirm.FlatAppearance.BorderSize = 0;
            this.button_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_confirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_confirm.Location = new System.Drawing.Point(283, 587);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(110, 48);
            this.button_confirm.TabIndex = 10;
            this.button_confirm.Text = "Véglegesít";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // button_removeItem
            // 
            this.button_removeItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_removeItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_removeItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_removeItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_removeItem.Location = new System.Drawing.Point(836, 285);
            this.button_removeItem.Name = "button_removeItem";
            this.button_removeItem.Size = new System.Drawing.Size(103, 62);
            this.button_removeItem.TabIndex = 11;
            this.button_removeItem.Text = "Visszavonás";
            this.button_removeItem.UseVisualStyleBackColor = false;
            this.button_removeItem.Click += new System.EventHandler(this.button_removeItem_Click);
            // 
            // sellP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.button_removeItem);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.sell_grid);
            this.Controls.Add(this.input_productCount);
            this.Controls.Add(this.button_addItem);
            this.Controls.Add(this.label_productCount);
            this.Controls.Add(this.input_productName);
            this.Controls.Add(this.label_productName);
            this.Controls.Add(this.button_startSell);
            this.Controls.Add(this.label_customerID);
            this.Controls.Add(this.input_customerID);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "sellP";
            this.Size = new System.Drawing.Size(868, 530);
            ((System.ComponentModel.ISupportInitialize)(this.sell_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_customerID;
        private System.Windows.Forms.Label label_customerID;
        private System.Windows.Forms.Button button_startSell;
        private System.Windows.Forms.Label label_productName;
        private System.Windows.Forms.ComboBox input_productName;
        private System.Windows.Forms.Label label_productCount;
        private System.Windows.Forms.Button button_addItem;
        private System.Windows.Forms.TextBox input_productCount;
        private System.Windows.Forms.DataGridView sell_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button button_removeItem;
    }
}
