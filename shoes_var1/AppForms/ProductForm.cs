using shoes.AppControls;
using shoes.AppExceptions;
using shoes.AppModels;
using shoes.AppServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace shoes.AppForms
{
    public partial class ProductForm : ParentForm
    {
        private List<Product> _products;
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ProductForm_Shown(object sender, EventArgs e)
        {
            FormManager.PrepareForm("Товары");
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_practice_shoesDataSet.Supplier". При необходимости она может быть перемещена или удалена.
            this.supplierTableAdapter.Fill(this.shapkin_practice_shoesDataSet.Supplier);

            List<Product> products = Program.context.Product.ToList();
            foreach (Product product in products)
            {
                flowLayoutPanel1.Controls.Add(new ProductUserControl(product));
            }

            FillSupplier();
            SelectProducts();
            ShowProducts();
        }

        public void Refresh()
        {
            ClearProducts();
            SelectProducts();
            ShowProducts();
        }

        private void FillSupplier()
        {
            List<Supplier> suppliers = Program.context.Supplier.OrderBy(s => s.SupplierName).ToList();
            Supplier supplier = new Supplier();
            supplier.SupplierName = "Все поставщики";
            suppliers.Insert(0, supplier);

            supplierBindingSource.DataSource = suppliers;
        }

        private void ClearProducts()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void ShowProducts()
        {
            foreach (Product product in _products)
            {
                flowLayoutPanel1.Controls.Add(new ProductUserControl(product));
            }
        }

        private void SelectProducts()
        {
            _products = Program.context.Product.ToList();
        }

        private void fewerFirst_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void moreFirst_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void supplierIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
