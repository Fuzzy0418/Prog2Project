namespace ShopManagement.ControlPanels
{
    partial class categoriesP
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
            this.category_grid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_name = new System.Windows.Forms.Label();
            this.input_cName = new System.Windows.Forms.TextBox();
            this.button_cSave = new System.Windows.Forms.Button();
            this.button_cDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.category_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // category_grid
            // 
            this.category_grid.AllowUserToAddRows = false;
            this.category_grid.AllowUserToDeleteRows = false;
            this.category_grid.AllowUserToResizeColumns = false;
            this.category_grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.NavajoWhite;
            this.category_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.category_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.category_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.category_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.category_grid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.category_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.category_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.category_grid.ColumnHeadersHeight = 35;
            this.category_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.category_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.category_grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.category_grid.EnableHeadersVisualStyles = false;
            this.category_grid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.category_grid.Location = new System.Drawing.Point(0, 0);
            this.category_grid.MultiSelect = false;
            this.category_grid.Name = "category_grid";
            this.category_grid.ReadOnly = true;
            this.category_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.category_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.category_grid.RowHeadersWidth = 5;
            this.category_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.category_grid.RowTemplate.Height = 24;
            this.category_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.category_grid.Size = new System.Drawing.Size(11, 518);
            this.category_grid.TabIndex = 0;
            this.category_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.category_grid_CellClick);
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "#";
            this.id.MinimumWidth = 40;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // name
            // 
            this.name.Frozen = true;
            this.name.HeaderText = "Név";
            this.name.MinimumWidth = 180;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 180;
            // 
            // label_name
            // 
            this.label_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this.label_name.Location = new System.Drawing.Point(800, 72);
            this.label_name.Margin = new System.Windows.Forms.Padding(0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(107, 18);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Megnevezés:";
            // 
            // input_cName
            // 
            this.input_cName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.input_cName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_cName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.input_cName.ForeColor = System.Drawing.Color.White;
            this.input_cName.Location = new System.Drawing.Point(813, 93);
            this.input_cName.Name = "input_cName";
            this.input_cName.Size = new System.Drawing.Size(254, 21);
            this.input_cName.TabIndex = 2;
            // 
            // button_cSave
            // 
            this.button_cSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_cSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_cSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cSave.Location = new System.Drawing.Point(880, 135);
            this.button_cSave.Name = "button_cSave";
            this.button_cSave.Size = new System.Drawing.Size(120, 43);
            this.button_cSave.TabIndex = 11;
            this.button_cSave.Text = "Mentés";
            this.button_cSave.UseVisualStyleBackColor = true;
            this.button_cSave.Click += new System.EventHandler(this.button_cSave_Click);
            // 
            // button_cDelete
            // 
            this.button_cDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_cDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_cDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cDelete.Location = new System.Drawing.Point(880, 198);
            this.button_cDelete.Name = "button_cDelete";
            this.button_cDelete.Size = new System.Drawing.Size(120, 43);
            this.button_cDelete.TabIndex = 12;
            this.button_cDelete.Text = "Törlés";
            this.button_cDelete.UseVisualStyleBackColor = true;
            this.button_cDelete.Click += new System.EventHandler(this.button_cDelete_Click);
            // 
            // categoriesP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.button_cSave);
            this.Controls.Add(this.button_cDelete);
            this.Controls.Add(this.input_cName);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.category_grid);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "categoriesP";
            this.Size = new System.Drawing.Size(868, 530);
            ((System.ComponentModel.ISupportInitialize)(this.category_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView category_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox input_cName;
        private System.Windows.Forms.Button button_cSave;
        private System.Windows.Forms.Button button_cDelete;
    }
}
