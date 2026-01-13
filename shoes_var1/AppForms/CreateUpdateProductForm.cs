using shoes.AppServices;
using System;
using System.Windows.Forms;

namespace shoes.AppForms
{
    public partial class CreateUpdateProductForm : ParentForm
    {
        public CreateUpdateProductForm()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shapkin_practice_shoesDataSet);

        }

        private void CreateUpdateProductForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_practice_shoesDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.shapkin_practice_shoesDataSet.Product);

        }

        private void productBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shapkin_practice_shoesDataSet);

        }

        private void productBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shapkin_practice_shoesDataSet);

        }

        private void CreateUpdateProductForm_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_practice_shoesDataSet.Product". При необходимости она может быть перемещена или удалена.
            // this.productTableAdapter.Fill(this.shapkin_practice_shoesDataSet.Product);
        }

        private void CreateUpdateProductForm_Shown(object sender, EventArgs e)
        {
            FormManager.PrepareForm("Добавить/редактировать товар", false);
        }
    }
}
