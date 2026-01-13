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
        }
    }
}
