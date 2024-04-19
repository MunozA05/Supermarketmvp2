namespace Supermarket_mvp.Views
{
    partial class MainView
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
            BtnPayMode = new Button();
            panel1 = new Panel();
            BtnCategory = new Button();
            BtnProduct = new Button();
            BtnExit = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnPayMode
            // 
            BtnPayMode.BackgroundImage = Properties.Resources.buy;
            BtnPayMode.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPayMode.Location = new Point(0, 61);
            BtnPayMode.Name = "BtnPayMode";
            BtnPayMode.Size = new Size(200, 95);
            BtnPayMode.TabIndex = 1;
            BtnPayMode.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnCategory);
            panel1.Controls.Add(BtnProduct);
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(BtnPayMode);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 2;
            // 
            // BtnCategory
            // 
            BtnCategory.BackgroundImage = Properties.Resources.clasificacion;
            BtnCategory.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCategory.Location = new Point(0, 247);
            BtnCategory.Name = "BtnCategory";
            BtnCategory.Size = new Size(200, 95);
            BtnCategory.TabIndex = 5;
            BtnCategory.UseVisualStyleBackColor = true;
            // 
            // BtnProduct
            // 
            BtnProduct.BackgroundImage = Properties.Resources.products;
            BtnProduct.BackgroundImageLayout = ImageLayout.Zoom;
            BtnProduct.Location = new Point(0, 154);
            BtnProduct.Name = "BtnProduct";
            BtnProduct.Size = new Size(200, 95);
            BtnProduct.TabIndex = 4;
            BtnProduct.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            BtnExit.BackgroundImage = Properties.Resources.Exit;
            BtnExit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnExit.Dock = DockStyle.Bottom;
            BtnExit.Location = new Point(0, 355);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(200, 95);
            BtnExit.TabIndex = 3;
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.sell;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "Supermarket";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button BtnPayMode;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button BtnExit;
        private Button BtnProduct;
        private Button BtnCategory;
    }
}