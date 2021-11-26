namespace ShopManagement
{
    partial class management
    {
        private System.ComponentModel.IContainer components = null;
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(management));
            this.leftSide = new System.Windows.Forms.Panel();
            this.menuBar = new System.Windows.Forms.Panel();
            this.close_button = new System.Windows.Forms.Button();
            this.sellBtn = new System.Windows.Forms.Button();
            this.transactionBtn = new System.Windows.Forms.Button();
            this.categoriesBtn = new System.Windows.Forms.Button();
            this.productsBtn = new System.Windows.Forms.Button();
            this.usersBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.userP1 = new ShopManagement.userP();
            this.home1 = new ShopManagement.home();
            this.categoriesP1 = new ShopManagement.ControlPanels.categoriesP();
            this.productsP1 = new ShopManagement.ControlPanels.productsP();
            this.sellP1 = new ShopManagement.ControlPanels.sellP();
            this.tranzactionsP1 = new ShopManagement.ControlPanels.tranzactionsP();
            this.leftSide.SuspendLayout();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // leftSide
            // 
            this.leftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.leftSide.Controls.Add(this.menuBar);
            this.leftSide.Controls.Add(this.logo);
            this.leftSide.Location = new System.Drawing.Point(0, 0);
            this.leftSide.Name = "leftSide";
            this.leftSide.Size = new System.Drawing.Size(250, 590);
            this.leftSide.TabIndex = 0;
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.menuBar.Controls.Add(this.close_button);
            this.menuBar.Controls.Add(this.sellBtn);
            this.menuBar.Controls.Add(this.transactionBtn);
            this.menuBar.Controls.Add(this.categoriesBtn);
            this.menuBar.Controls.Add(this.productsBtn);
            this.menuBar.Controls.Add(this.usersBtn);
            this.menuBar.Controls.Add(this.homeBtn);
            this.menuBar.Location = new System.Drawing.Point(3, 205);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(244, 382);
            this.menuBar.TabIndex = 1;
            // 
            // close_button
            // 
            this.close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.close_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.close_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(35)))));
            this.close_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(35)))));
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.ForeColor = System.Drawing.Color.White;
            this.close_button.Location = new System.Drawing.Point(3, 330);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(238, 50);
            this.close_button.TabIndex = 6;
            this.close_button.Text = "Kilépés";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // sellBtn
            // 
            this.sellBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sellBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.sellBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sellBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.sellBtn.FlatAppearance.BorderSize = 0;
            this.sellBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(35)))));
            this.sellBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(35)))));
            this.sellBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellBtn.ForeColor = System.Drawing.Color.White;
            this.sellBtn.Location = new System.Drawing.Point(3, 275);
            this.sellBtn.Name = "sellBtn";
            this.sellBtn.Size = new System.Drawing.Size(238, 50);
            this.sellBtn.TabIndex = 5;
            this.sellBtn.Text = "Számlázás";
            this.sellBtn.UseVisualStyleBackColor = false;
            this.sellBtn.Click += new System.EventHandler(this.sellBtn_Click);
            // 
            // transactionBtn
            // 
            this.transactionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.transactionBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.transactionBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.transactionBtn.FlatAppearance.BorderSize = 0;
            this.transactionBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(35)))));
            this.transactionBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(35)))));
            this.transactionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionBtn.ForeColor = System.Drawing.Color.White;
            this.transactionBtn.Location = new System.Drawing.Point(3, 220);
            this.transactionBtn.Name = "transactionBtn";
            this.transactionBtn.Size = new System.Drawing.Size(238, 50);
            this.transactionBtn.TabIndex = 4;
            this.transactionBtn.Text = "Tranzakciók";
            this.transactionBtn.UseVisualStyleBackColor = false;
            this.transactionBtn.Click += new System.EventHandler(this.transactionBtn_Click);
            // 
            // categoriesBtn
            // 
            this.categoriesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoriesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.categoriesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.categoriesBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.categoriesBtn.FlatAppearance.BorderSize = 0;
            this.categoriesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(35)))));
            this.categoriesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(35)))));
            this.categoriesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriesBtn.ForeColor = System.Drawing.Color.White;
            this.categoriesBtn.Location = new System.Drawing.Point(3, 165);
            this.categoriesBtn.Name = "categoriesBtn";
            this.categoriesBtn.Size = new System.Drawing.Size(238, 50);
            this.categoriesBtn.TabIndex = 3;
            this.categoriesBtn.Text = "Kategóriák";
            this.categoriesBtn.UseVisualStyleBackColor = false;
            this.categoriesBtn.Click += new System.EventHandler(this.categoriesBtn_Click);
            // 
            // productsBtn
            // 
            this.productsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.productsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.productsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.productsBtn.FlatAppearance.BorderSize = 0;
            this.productsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(35)))));
            this.productsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(35)))));
            this.productsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsBtn.ForeColor = System.Drawing.Color.White;
            this.productsBtn.Location = new System.Drawing.Point(3, 110);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Size = new System.Drawing.Size(238, 50);
            this.productsBtn.TabIndex = 2;
            this.productsBtn.Text = "Termékek";
            this.productsBtn.UseVisualStyleBackColor = false;
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click);
            // 
            // usersBtn
            // 
            this.usersBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.usersBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.usersBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.usersBtn.FlatAppearance.BorderSize = 0;
            this.usersBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(35)))));
            this.usersBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(35)))));
            this.usersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersBtn.ForeColor = System.Drawing.Color.White;
            this.usersBtn.Location = new System.Drawing.Point(3, 55);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Size = new System.Drawing.Size(238, 50);
            this.usersBtn.TabIndex = 1;
            this.usersBtn.Text = "Alkalmazottak";
            this.usersBtn.UseVisualStyleBackColor = false;
            this.usersBtn.Click += new System.EventHandler(this.usersBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.homeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.homeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(35)))));
            this.homeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(35)))));
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.Location = new System.Drawing.Point(3, 1);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(238, 50);
            this.homeBtn.TabIndex = 0;
            this.homeBtn.Text = "Főoldal";
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.logo.BackgroundImage = global::ShopManagement.Properties.Resources.shop_icon1;
            this.logo.Location = new System.Drawing.Point(30, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(196, 196);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(1098, 0);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(32, 32);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // userP1
            // 
            this.userP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.userP1.Location = new System.Drawing.Point(253, 60);
            this.userP1.Margin = new System.Windows.Forms.Padding(0);
            this.userP1.Name = "userP1";
            this.userP1.Size = new System.Drawing.Size(868, 525);
            this.userP1.TabIndex = 4;
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.home1.Location = new System.Drawing.Point(253, 60);
            this.home1.Margin = new System.Windows.Forms.Padding(0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(868, 525);
            this.home1.TabIndex = 3;
            // 
            // categoriesP1
            // 
            this.categoriesP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.categoriesP1.Location = new System.Drawing.Point(253, 60);
            this.categoriesP1.Margin = new System.Windows.Forms.Padding(0);
            this.categoriesP1.Name = "categoriesP1";
            this.categoriesP1.Size = new System.Drawing.Size(868, 525);
            this.categoriesP1.TabIndex = 6;
            // 
            // productsP1
            // 
            this.productsP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.productsP1.Location = new System.Drawing.Point(253, 60);
            this.productsP1.Margin = new System.Windows.Forms.Padding(0);
            this.productsP1.Name = "productsP1";
            this.productsP1.Size = new System.Drawing.Size(868, 525);
            this.productsP1.TabIndex = 7;
            // 
            // sellP1
            // 
            this.sellP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.sellP1.Location = new System.Drawing.Point(253, 60);
            this.sellP1.Margin = new System.Windows.Forms.Padding(0);
            this.sellP1.Name = "sellP1";
            this.sellP1.Size = new System.Drawing.Size(868, 525);
            this.sellP1.TabIndex = 8;
            // 
            // tranzactionsP1
            // 
            this.tranzactionsP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tranzactionsP1.Location = new System.Drawing.Point(253, 60);
            this.tranzactionsP1.Margin = new System.Windows.Forms.Padding(0);
            this.tranzactionsP1.Name = "tranzactionsP1";
            this.tranzactionsP1.Size = new System.Drawing.Size(868, 525);
            this.tranzactionsP1.TabIndex = 9;
            // 
            // management
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1130, 590);
            this.Controls.Add(this.tranzactionsP1);
            this.Controls.Add(this.sellP1);
            this.Controls.Add(this.productsP1);
            this.Controls.Add(this.categoriesP1);
            this.Controls.Add(this.userP1);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.leftSide);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "management";
            this.leftSide.ResumeLayout(false);
            this.menuBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftSide;
        private System.Windows.Forms.Panel menuBar;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button usersBtn;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button sellBtn;
        private System.Windows.Forms.Button transactionBtn;
        private System.Windows.Forms.Button categoriesBtn;
        private System.Windows.Forms.Button productsBtn;
        private System.Windows.Forms.Button closeBtn;
        private home home1;
        private userP userP1;
        private ControlPanels.categoriesP categoriesP1;
        private ControlPanels.productsP productsP1;
        private ControlPanels.sellP sellP1;
        private ControlPanels.tranzactionsP tranzactionsP1;
    }
}