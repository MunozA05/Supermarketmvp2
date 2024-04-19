namespace Supermarket_mvp.Views
{
    partial class ProductView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageProductList = new TabPage();
            tabPageProductDetail = new TabPage();
            label2 = new Label();
            TxtSearch = new TextBox();
            BtnSearch = new Button();
            DgProduct = new DataGridView();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtProductId = new TextBox();
            TxtProductName = new TextBox();
            TxtProductCategory = new TextBox();
            TxtProductStockQuantity = new TextBox();
            TxtProductPrice = new TextBox();
            TxtProductProvider = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProductList.SuspendLayout();
            tabPageProductDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 111);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.products;
            pictureBox1.Location = new Point(16, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 36);
            label1.Name = "label1";
            label1.Size = new Size(145, 37);
            label1.TabIndex = 0;
            label1.Text = "PRODUCT";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProductList);
            tabControl1.Controls.Add(tabPageProductDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 111);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 339);
            tabControl1.TabIndex = 2;
            // 
            // tabPageProductList
            // 
            tabPageProductList.Controls.Add(BtnClose);
            tabPageProductList.Controls.Add(BtnDelete);
            tabPageProductList.Controls.Add(BtnEdit);
            tabPageProductList.Controls.Add(BtnNew);
            tabPageProductList.Controls.Add(DgProduct);
            tabPageProductList.Controls.Add(BtnSearch);
            tabPageProductList.Controls.Add(TxtSearch);
            tabPageProductList.Controls.Add(label2);
            tabPageProductList.Location = new Point(4, 24);
            tabPageProductList.Name = "tabPageProductList";
            tabPageProductList.Padding = new Padding(3);
            tabPageProductList.Size = new Size(792, 311);
            tabPageProductList.TabIndex = 0;
            tabPageProductList.Text = "Product List";
            tabPageProductList.UseVisualStyleBackColor = true;
            // 
            // tabPageProductDetail
            // 
            tabPageProductDetail.Controls.Add(TxtProductStockQuantity);
            tabPageProductDetail.Controls.Add(TxtProductPrice);
            tabPageProductDetail.Controls.Add(TxtProductProvider);
            tabPageProductDetail.Controls.Add(TxtProductCategory);
            tabPageProductDetail.Controls.Add(TxtProductName);
            tabPageProductDetail.Controls.Add(TxtProductId);
            tabPageProductDetail.Controls.Add(BtnSave);
            tabPageProductDetail.Controls.Add(BtnCancel);
            tabPageProductDetail.Controls.Add(label6);
            tabPageProductDetail.Controls.Add(label7);
            tabPageProductDetail.Controls.Add(label8);
            tabPageProductDetail.Controls.Add(label5);
            tabPageProductDetail.Controls.Add(label4);
            tabPageProductDetail.Controls.Add(label3);
            tabPageProductDetail.Location = new Point(4, 24);
            tabPageProductDetail.Name = "tabPageProductDetail";
            tabPageProductDetail.Padding = new Padding(3);
            tabPageProductDetail.Size = new Size(792, 311);
            tabPageProductDetail.TabIndex = 1;
            tabPageProductDetail.Text = "Product Detail";
            tabPageProductDetail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 13);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 2;
            label2.Text = "Search Product";
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(26, 39);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(541, 23);
            TxtSearch.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(573, 29);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(38, 41);
            BtnSearch.TabIndex = 4;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // DgProduct
            // 
            DgProduct.AllowUserToAddRows = false;
            DgProduct.AllowUserToDeleteRows = false;
            DgProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProduct.Location = new Point(26, 82);
            DgProduct.Name = "DgProduct";
            DgProduct.ReadOnly = true;
            DgProduct.Size = new Size(585, 223);
            DgProduct.TabIndex = 5;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(637, 253);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(133, 51);
            BtnClose.TabIndex = 11;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(637, 196);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(133, 51);
            BtnDelete.TabIndex = 10;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(637, 139);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(133, 51);
            BtnEdit.TabIndex = 9;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(637, 82);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(133, 51);
            BtnNew.TabIndex = 8;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 130);
            label5.Name = "label5";
            label5.Size = new Size(116, 17);
            label5.TabIndex = 10;
            label5.Text = "Product Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(40, 78);
            label4.Name = "label4";
            label4.Size = new Size(96, 17);
            label4.TabIndex = 9;
            label4.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 26);
            label3.Name = "label3";
            label3.Size = new Size(72, 17);
            label3.TabIndex = 8;
            label3.Text = "Product Id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(396, 130);
            label6.Name = "label6";
            label6.Size = new Size(99, 17);
            label6.TabIndex = 13;
            label6.Text = "Stock Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(396, 78);
            label7.Name = "label7";
            label7.Size = new Size(38, 17);
            label7.TabIndex = 12;
            label7.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(396, 26);
            label8.Name = "label8";
            label8.Size = new Size(112, 17);
            label8.TabIndex = 11;
            label8.Text = "Product Provider";
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.search_small;
            BtnCancel.Location = new Point(406, 233);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(99, 60);
            BtnCancel.TabIndex = 14;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(221, 233);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(99, 60);
            BtnSave.TabIndex = 15;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(40, 52);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.Size = new Size(176, 23);
            TxtProductId.TabIndex = 16;
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(40, 101);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(176, 23);
            TxtProductName.TabIndex = 17;
            // 
            // TxtProductCategory
            // 
            TxtProductCategory.Location = new Point(40, 150);
            TxtProductCategory.Name = "TxtProductCategory";
            TxtProductCategory.Size = new Size(176, 23);
            TxtProductCategory.TabIndex = 18;
            // 
            // TxtProductStockQuantity
            // 
            TxtProductStockQuantity.Location = new Point(396, 150);
            TxtProductStockQuantity.Name = "TxtProductStockQuantity";
            TxtProductStockQuantity.Size = new Size(176, 23);
            TxtProductStockQuantity.TabIndex = 21;
            // 
            // TxtProductPrice
            // 
            TxtProductPrice.Location = new Point(396, 101);
            TxtProductPrice.Name = "TxtProductPrice";
            TxtProductPrice.Size = new Size(176, 23);
            TxtProductPrice.TabIndex = 20;
            // 
            // TxtProductProvider
            // 
            TxtProductProvider.Location = new Point(396, 52);
            TxtProductProvider.Name = "TxtProductProvider";
            TxtProductProvider.Size = new Size(176, 23);
            TxtProductProvider.TabIndex = 19;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "Produc Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProductList.ResumeLayout(false);
            tabPageProductList.PerformLayout();
            tabPageProductDetail.ResumeLayout(false);
            tabPageProductDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageProductList;
        private TabPage tabPageProductDetail;
        private Label label2;
        private TextBox TxtSearch;
        private Button BtnSearch;
        private DataGridView DgProduct;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtProductStockQuantity;
        private TextBox TxtProductPrice;
        private TextBox TxtProductProvider;
        private TextBox TxtProductCategory;
        private TextBox TxtProductName;
        private TextBox TxtProductId;
    }
}