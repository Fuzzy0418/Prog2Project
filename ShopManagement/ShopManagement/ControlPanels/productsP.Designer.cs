namespace ShopManagement.ControlPanels
{
    partial class productsP
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
            this.products_grid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_name = new System.Windows.Forms.Label();
            this.input_pName = new System.Windows.Forms.TextBox();
            this.label_category = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.input_pPrice = new System.Windows.Forms.TextBox();
            this.label_discount = new System.Windows.Forms.Label();
            this.input_pDiscount = new System.Windows.Forms.TextBox();
            this.label_db = new System.Windows.Forms.Label();
            this.input_pDb = new System.Windows.Forms.TextBox();
            this.button_pSave = new System.Windows.Forms.Button();
            this.button_pDelete = new System.Windows.Forms.Button();
            this.input_pCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.products_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // products_grid
            // 

            this.products_grid.AllowUserToAddRows = false;
            this.products_grid.AllowUserToDeleteRows = false;
            this.products_grid.AllowUserToResizeColumns = false;
            this.products_grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.NavajoWhite;
            this.products_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.products_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.products_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.products_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.products_grid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.products_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.products_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.products_grid.ColumnHeadersHeight = 35;
            this.products_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.products_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.cID,
            this.price,
            this.discount,
            this.count});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.products_grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.products_grid.EnableHeadersVisualStyles = false;
            this.products_grid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.products_grid.Location = new System.Drawing.Point(0, 0);
            this.products_grid.MultiSelect = false;
            this.products_grid.Name = "transactions_grid";
            this.products_grid.ReadOnly = true;
            this.products_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.products_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.products_grid.RowHeadersWidth = 5;
            this.products_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.products_grid.RowTemplate.Height = 24;
            this.products_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.products_grid.Size = new System.Drawing.Size(488, 518);
            this.products_grid.TabIndex = 0;
            this.products_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.products_grid_CellClick);
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
            this.name.MinimumWidth = 125;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // cID
            // 
            this.cID.Frozen = true;
            this.cID.HeaderText = "Kategória";
            this.cID.MinimumWidth = 125;
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            this.cID.Width = 125;
            // 
            // price
            // 
            this.price.Frozen = true;
            this.price.HeaderText = "Ár";
            this.price.MinimumWidth = 100;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 100;
            // 
            // discount
            // 
            this.discount.Frozen = true;
            this.discount.HeaderText = "Akció";
            this.discount.MinimumWidth = 80;
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            this.discount.Width = 80;
            // 
            // count
            // 
            this.count.Frozen = true;
            this.count.HeaderText = "db";
            this.count.MinimumWidth = 80;
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Width = 80;
            // 
            // label_name
            // 
            this.label_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this.label_name.Location = new System.Drawing.Point(820, 72);
            this.label_name.Margin = new System.Windows.Forms.Padding(0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(107, 18);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Megnevezés:";
            // 
            // input_pName
            // 
            this.input_pName.Location = new System.Drawing.Point(833, 93);
            this.input_pName.Name = "input_pName";
            this.input_pName.Size = new System.Drawing.Size(254, 22);
            this.input_pName.TabIndex = 2;
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this.label_category.Location = new System.Drawing.Point(820, 129);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(85, 18);
            this.label_category.TabIndex = 3;
            this.label_category.Text = "Kategória:";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this.label_price.Location = new System.Drawing.Point(820, 189);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(29, 18);
            this.label_price.TabIndex = 5;
            this.label_price.Text = "Ár:";
            // 
            // input_pPrice
            // 
            this.input_pPrice.Location = new System.Drawing.Point(833, 210);
            this.input_pPrice.Name = "input_pPrice";
            this.input_pPrice.Size = new System.Drawing.Size(104, 22);
            this.input_pPrice.TabIndex = 6;
            this.input_pPrice.Text = "0";
            // 
            // label_discount
            // 
            this.label_discount.AutoSize = true;
            this.label_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_discount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this.label_discount.Location = new System.Drawing.Point(946, 189);
            this.label_discount.Name = "label_discount";
            this.label_discount.Size = new System.Drawing.Size(55, 18);
            this.label_discount.TabIndex = 7;
            this.label_discount.Text = "Akció:";
            // 
            // input_pDiscount
            // 
            this.input_pDiscount.Location = new System.Drawing.Point(981, 210);
            this.input_pDiscount.Name = "input_pDiscount";
            this.input_pDiscount.Size = new System.Drawing.Size(106, 22);
            this.input_pDiscount.TabIndex = 8;
            this.input_pDiscount.Text = "0";
            // 
            // label_db
            // 
            this.label_db.AutoSize = true;
            this.label_db.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_db.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this.label_db.Location = new System.Drawing.Point(820, 251);
            this.label_db.Name = "label_db";
            this.label_db.Size = new System.Drawing.Size(99, 18);
            this.label_db.TabIndex = 9;
            this.label_db.Text = "Darabszám:";
            // 
            // input_pDb
            // 
            this.input_pDb.Location = new System.Drawing.Point(833, 272);
            this.input_pDb.Name = "input_pDb";
            this.input_pDb.Size = new System.Drawing.Size(104, 22);
            this.input_pDb.TabIndex = 10;
            this.input_pDb.Text = "0";
            // 
            // button_pSave
            // 
            this.button_pSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_pSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_pSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_pSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pSave.Location = new System.Drawing.Point(900, 331);
            this.button_pSave.Name = "button_pSave";
            this.button_pSave.Size = new System.Drawing.Size(120, 43);
            this.button_pSave.TabIndex = 11;
            this.button_pSave.Text = "Mentés";
            this.button_pSave.UseVisualStyleBackColor = true;
            this.button_pSave.Click += new System.EventHandler(this.button_pSave_Click);
            // 
            // button_pDelete
            // 
            this.button_pDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_pDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_pDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_pDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pDelete.Location = new System.Drawing.Point(900, 394);
            this.button_pDelete.Name = "button_pDelete";
            this.button_pDelete.Size = new System.Drawing.Size(120, 43);
            this.button_pDelete.TabIndex = 11;
            this.button_pDelete.Text = "Törlés";
            this.button_pDelete.UseVisualStyleBackColor = true;
            this.button_pDelete.Click += new System.EventHandler(this.button_pDelete_Click);
            // 
            // input_pCategory
            // 
            this.input_pCategory.FormattingEnabled = true;
            this.input_pCategory.Location = new System.Drawing.Point(833, 150);
            this.input_pCategory.Name = "input_pCategory";
            this.input_pCategory.Size = new System.Drawing.Size(254, 24);
            this.input_pCategory.TabIndex = 12;
            // 
            // productsP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.input_pCategory);
            this.Controls.Add(this.button_pSave);
            this.Controls.Add(this.button_pDelete);
            this.Controls.Add(this.input_pDb);
            this.Controls.Add(this.label_db);
            this.Controls.Add(this.input_pDiscount);
            this.Controls.Add(this.label_discount);
            this.Controls.Add(this.input_pPrice);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_category);
            this.Controls.Add(this.input_pName);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.products_grid);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "productsP";
            this.Size = new System.Drawing.Size(868, 530);
            ((System.ComponentModel.ISupportInitialize)(this.products_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView products_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox input_pName;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.TextBox input_pPrice;
        private System.Windows.Forms.Label label_discount;
        private System.Windows.Forms.TextBox input_pDiscount;
        private System.Windows.Forms.Label label_db;
        private System.Windows.Forms.TextBox input_pDb;
        private System.Windows.Forms.Button button_pSave;
        private System.Windows.Forms.Button button_pDelete;
        private System.Windows.Forms.ComboBox input_pCategory;
    }
}
