using System;
using System.Linq;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            using (TradeContext context = new TradeContext())
            {
                dgwProducts.DataSource = context.Products.ToList();
            }
        }
    }
}
