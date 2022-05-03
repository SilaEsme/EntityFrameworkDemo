namespace EntityFrameworkDemo
{
    partial class Main
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
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.gbAddProduct = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtStockAdd = new System.Windows.Forms.TextBox();
            this.txtPriceAdd = new System.Windows.Forms.TextBox();
            this.txtNameAdd = new System.Windows.Forms.TextBox();
            this.lblStockAdd = new System.Windows.Forms.Label();
            this.lblPriceAdd = new System.Windows.Forms.Label();
            this.lblNameAdd = new System.Windows.Forms.Label();
            this.gbUpdateProduct = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtStockUpdate = new System.Windows.Forms.TextBox();
            this.txtPriceUpdate = new System.Windows.Forms.TextBox();
            this.txtNameUpdate = new System.Windows.Forms.TextBox();
            this.lblStockUpdate = new System.Windows.Forms.Label();
            this.lblPriceUpdate = new System.Windows.Forms.Label();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.gbAddProduct.SuspendLayout();
            this.gbUpdateProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(193, 45);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(567, 216);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // gbAddProduct
            // 
            this.gbAddProduct.Controls.Add(this.btnAdd);
            this.gbAddProduct.Controls.Add(this.txtStockAdd);
            this.gbAddProduct.Controls.Add(this.txtPriceAdd);
            this.gbAddProduct.Controls.Add(this.txtNameAdd);
            this.gbAddProduct.Controls.Add(this.lblStockAdd);
            this.gbAddProduct.Controls.Add(this.lblPriceAdd);
            this.gbAddProduct.Controls.Add(this.lblNameAdd);
            this.gbAddProduct.Location = new System.Drawing.Point(98, 279);
            this.gbAddProduct.Name = "gbAddProduct";
            this.gbAddProduct.Size = new System.Drawing.Size(308, 212);
            this.gbAddProduct.TabIndex = 1;
            this.gbAddProduct.TabStop = false;
            this.gbAddProduct.Text = "Add a Products";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(203, 174);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtStockAdd
            // 
            this.txtStockAdd.Location = new System.Drawing.Point(79, 138);
            this.txtStockAdd.Name = "txtStockAdd";
            this.txtStockAdd.Size = new System.Drawing.Size(161, 20);
            this.txtStockAdd.TabIndex = 5;
            // 
            // txtPriceAdd
            // 
            this.txtPriceAdd.Location = new System.Drawing.Point(79, 93);
            this.txtPriceAdd.Name = "txtPriceAdd";
            this.txtPriceAdd.Size = new System.Drawing.Size(161, 20);
            this.txtPriceAdd.TabIndex = 4;
            // 
            // txtNameAdd
            // 
            this.txtNameAdd.Location = new System.Drawing.Point(79, 48);
            this.txtNameAdd.Name = "txtNameAdd";
            this.txtNameAdd.Size = new System.Drawing.Size(161, 20);
            this.txtNameAdd.TabIndex = 3;
            // 
            // lblStockAdd
            // 
            this.lblStockAdd.AutoSize = true;
            this.lblStockAdd.Location = new System.Drawing.Point(38, 141);
            this.lblStockAdd.Name = "lblStockAdd";
            this.lblStockAdd.Size = new System.Drawing.Size(35, 13);
            this.lblStockAdd.TabIndex = 2;
            this.lblStockAdd.Text = "Stock";
            // 
            // lblPriceAdd
            // 
            this.lblPriceAdd.AutoSize = true;
            this.lblPriceAdd.Location = new System.Drawing.Point(20, 96);
            this.lblPriceAdd.Name = "lblPriceAdd";
            this.lblPriceAdd.Size = new System.Drawing.Size(53, 13);
            this.lblPriceAdd.TabIndex = 1;
            this.lblPriceAdd.Text = "Unit Price";
            // 
            // lblNameAdd
            // 
            this.lblNameAdd.AutoSize = true;
            this.lblNameAdd.Location = new System.Drawing.Point(38, 51);
            this.lblNameAdd.Name = "lblNameAdd";
            this.lblNameAdd.Size = new System.Drawing.Size(35, 13);
            this.lblNameAdd.TabIndex = 0;
            this.lblNameAdd.Text = "Name";
            // 
            // gbUpdateProduct
            // 
            this.gbUpdateProduct.Controls.Add(this.btnUpdate);
            this.gbUpdateProduct.Controls.Add(this.txtStockUpdate);
            this.gbUpdateProduct.Controls.Add(this.txtPriceUpdate);
            this.gbUpdateProduct.Controls.Add(this.txtNameUpdate);
            this.gbUpdateProduct.Controls.Add(this.lblStockUpdate);
            this.gbUpdateProduct.Controls.Add(this.lblPriceUpdate);
            this.gbUpdateProduct.Controls.Add(this.lblNameUpdate);
            this.gbUpdateProduct.Location = new System.Drawing.Point(547, 279);
            this.gbUpdateProduct.Name = "gbUpdateProduct";
            this.gbUpdateProduct.Size = new System.Drawing.Size(308, 212);
            this.gbUpdateProduct.TabIndex = 6;
            this.gbUpdateProduct.TabStop = false;
            this.gbUpdateProduct.Text = "Update a Products";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(209, 174);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtStockUpdate
            // 
            this.txtStockUpdate.Location = new System.Drawing.Point(79, 138);
            this.txtStockUpdate.Name = "txtStockUpdate";
            this.txtStockUpdate.Size = new System.Drawing.Size(161, 20);
            this.txtStockUpdate.TabIndex = 5;
            // 
            // txtPriceUpdate
            // 
            this.txtPriceUpdate.Location = new System.Drawing.Point(79, 93);
            this.txtPriceUpdate.Name = "txtPriceUpdate";
            this.txtPriceUpdate.Size = new System.Drawing.Size(161, 20);
            this.txtPriceUpdate.TabIndex = 4;
            // 
            // txtNameUpdate
            // 
            this.txtNameUpdate.Location = new System.Drawing.Point(79, 48);
            this.txtNameUpdate.Name = "txtNameUpdate";
            this.txtNameUpdate.Size = new System.Drawing.Size(161, 20);
            this.txtNameUpdate.TabIndex = 3;
            // 
            // lblStockUpdate
            // 
            this.lblStockUpdate.AutoSize = true;
            this.lblStockUpdate.Location = new System.Drawing.Point(38, 141);
            this.lblStockUpdate.Name = "lblStockUpdate";
            this.lblStockUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblStockUpdate.TabIndex = 2;
            this.lblStockUpdate.Text = "Stock";
            // 
            // lblPriceUpdate
            // 
            this.lblPriceUpdate.AutoSize = true;
            this.lblPriceUpdate.Location = new System.Drawing.Point(20, 96);
            this.lblPriceUpdate.Name = "lblPriceUpdate";
            this.lblPriceUpdate.Size = new System.Drawing.Size(53, 13);
            this.lblPriceUpdate.TabIndex = 1;
            this.lblPriceUpdate.Text = "Unit Price";
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(38, 51);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblNameUpdate.TabIndex = 0;
            this.lblNameUpdate.Text = "Name";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(426, 453);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(103, 32);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(369, 20);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 8;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(416, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(167, 20);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 503);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbUpdateProduct);
            this.Controls.Add(this.gbAddProduct);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Main";
            this.Text = "EntityDemo";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.gbAddProduct.ResumeLayout(false);
            this.gbAddProduct.PerformLayout();
            this.gbUpdateProduct.ResumeLayout(false);
            this.gbUpdateProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.GroupBox gbAddProduct;
        private System.Windows.Forms.TextBox txtStockAdd;
        private System.Windows.Forms.TextBox txtPriceAdd;
        private System.Windows.Forms.TextBox txtNameAdd;
        private System.Windows.Forms.Label lblStockAdd;
        private System.Windows.Forms.Label lblPriceAdd;
        private System.Windows.Forms.Label lblNameAdd;
        private System.Windows.Forms.GroupBox gbUpdateProduct;
        private System.Windows.Forms.TextBox txtStockUpdate;
        private System.Windows.Forms.TextBox txtPriceUpdate;
        private System.Windows.Forms.TextBox txtNameUpdate;
        private System.Windows.Forms.Label lblStockUpdate;
        private System.Windows.Forms.Label lblPriceUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

