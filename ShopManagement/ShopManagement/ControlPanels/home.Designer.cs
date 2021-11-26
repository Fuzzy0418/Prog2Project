namespace ShopManagement
{
    partial class home
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
            this.text_users = new System.Windows.Forms.Label();
            this.text_products = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.text_categories = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // text_users
            // 
            this.text_users.AutoSize = true;
            this.text_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_users.ForeColor = System.Drawing.Color.Green;
            this.text_users.Location = new System.Drawing.Point(96, 27);
            this.text_users.Name = "text_users";
            this.text_users.Size = new System.Drawing.Size(260, 36);
            this.text_users.TabIndex = 1;
            this.text_users.Text = "Alkalmazott: 0 db";
            // 
            // text_products
            // 
            this.text_products.AutoSize = true;
            this.text_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_products.ForeColor = System.Drawing.Color.Green;
            this.text_products.Location = new System.Drawing.Point(96, 118);
            this.text_products.Name = "text_products";
            this.text_products.Size = new System.Drawing.Size(200, 36);
            this.text_products.TabIndex = 3;
            this.text_products.Text = "Termék: 0 db";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ShopManagement.Properties.Resources.category_icon;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(0, 194);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 81);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ShopManagement.Properties.Resources.product_icon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 89);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ShopManagement.Properties.Resources.users_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 84);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // text_categories
            // 
            this.text_categories.AutoSize = true;
            this.text_categories.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_categories.ForeColor = System.Drawing.Color.Green;
            this.text_categories.Location = new System.Drawing.Point(96, 219);
            this.text_categories.Name = "text_categories";
            this.text_categories.Size = new System.Drawing.Size(232, 36);
            this.text_categories.TabIndex = 5;
            this.text_categories.Text = "Kategória: 0 db";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.text_categories);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.text_products);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.text_users);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "home";
            this.Size = new System.Drawing.Size(868, 530);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label text_users;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label text_products;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label text_categories;
    }
}
