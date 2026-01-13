using shoes.AppExceptions;
using shoes.AppServices;
using System;
using System.Windows.Forms;

namespace shoes.AppForms
{
    public partial class ProductForm : ParentForm
    {
        public ProductForm()
        {
            InitializeComponent();
            ContextManager.parentForm = this;
        }

        private void ProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ProductForm_Shown(object sender, EventArgs e)
        {
            FormManager.PrepareForm("Товары");
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shapkin_practice_shoesDataSet);

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_practice_shoesDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.shapkin_practice_shoesDataSet.Product);

        }
    }
}
