using System;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Main : Form
    {
        ProductDal _productDal = new ProductDal();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAllList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product()
            {
                Name = txtNameAdd.Text,
                Price = txtPriceAdd.Text,
                Quantity = Convert.ToInt32(txtStockAdd.Text)
            });
            LoadProducts();
            MessageBox.Show(@"Product Added!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product()
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = txtNameUpdate.Text,
                Price = txtPriceUpdate.Text,
                Quantity = Convert.ToInt32(txtStockUpdate.Text)
            });
            LoadProducts();
            MessageBox.Show("Updated!");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            txtPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            txtStockUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product()
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });
            LoadProducts();
            MessageBox.Show("Deleted!");
        }
    }
}