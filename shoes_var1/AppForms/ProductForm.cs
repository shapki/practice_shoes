using shoes.AppControls;
using shoes.AppExceptions;
using shoes.AppModels;
using shoes.AppServices;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_practice_shoesDataSet.Supplier". При необходимости она может быть перемещена или удалена.
            this.supplierTableAdapter.Fill(this.shapkin_practice_shoesDataSet.Supplier);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_practice_shoesDataSet.Supplier". При необходимости она может быть перемещена или удалена.
            this.supplierTableAdapter.Fill(this.shapkin_practice_shoesDataSet.Supplier);
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
            ShowAdvancedPanel();
            ShowAddProductButton();
            ShowOrdersButton();
        }

        /// <summary>
        /// PKGH
        /// Только менеджер и администратор могут сортировать, фильтровать и искать товары.
        /// </summary>
        private void ShowAdvancedPanel()
        {
            advancedPanel.Visible = (ContextManager.user.IsAdmin() || ContextManager.user.IsManager());
        }

        private void ShowAddProductButton()
        {
            addProductButton.Visible = ContextManager.user.IsAdmin();
        }

        private void ShowOrdersButton()
        {
            ordersButton.Visible = (ContextManager.user.IsAdmin() || ContextManager.user.IsManager());
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
            string searchInput = search.Text.Trim();

            bool fewerFirstInput = fewerFirst.Checked;

            int supplierId = GetSupplierId();

            IQueryable<Product> tmpProducts = Program.context.Product;
            _products = tmpProducts.ToList();

            if (!String.IsNullOrEmpty(searchInput))
            {
                tmpProducts = tmpProducts.Where(obj => DbFunctions.Like(obj.Sku, "%" + searchInput + "%")
                || DbFunctions.Like(obj.ProductName, "%" + searchInput + "%")
                || DbFunctions.Like(obj.UnitOfMeasurement, "%" + searchInput + "%")
                || DbFunctions.Like(obj.Category, "%" + searchInput + "%")
                || DbFunctions.Like(obj.Description, "%" + searchInput + "%")
                || DbFunctions.Like(obj.Photo, "%" + searchInput + "%")
                );
            }

            if (fewerFirstInput)
            {
                tmpProducts = tmpProducts.OrderBy(p => p.Stock);
            }
            else
            {
                // PKGH 
                // Кнопки "Больше" и "Меньше" объединены в группу. При этом "Больше" по умолчанию включена.
                // Если бы одна из кнопок не была включена по умолчанию, ситуация была бы иной (изначально у
                // обоих кнопок было бы значение – выключена). Поэтому здесь не может быть значение false.

                // Debug.Assert(moreFirst.Checked);
                tmpProducts = tmpProducts.OrderByDescending(p => p.Stock);
            }

            if (supplierId > 0) // PKGH 0 - "Все поставщики".
            {
                tmpProducts = tmpProducts.Where(p => p.SupplierId == supplierId);
            }

            _products = tmpProducts.ToList();
        }

        private int GetSupplierId()
        {
            int id = 0;
            Supplier selected = (Supplier)supplierComboBox.SelectedItem;

            if (selected != null)
            {
                id = (selected).IdSupplier;
            }

            return id;
        }

        private void fewerFirst_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void moreFirst_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void supplierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            CreateUpdateProductForm CreateUpdateProductForm = new CreateUpdateProductForm();
            DialogResult saved = CreateUpdateProductForm.ShowDialog();
        }

        internal void RefreshList()
        {
            
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
        }
    }
}
