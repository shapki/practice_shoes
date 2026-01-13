using shoes.AppModels;
using shoes.AppServices;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace shoes.AppForms
{
    public partial class CreateUpdateProductForm : ParentForm
    {
        private Product _product;
        private Product product;
        public CreateUpdateProductForm()
        {
            InitializeComponent();
            _product = new Product();
        }

        private void FillForm()
        {
            skuTextBox.Text = _product.Sku;
            productNameComboBox.Text = _product.ProductName;
            unitOfMeasurementListBox.Text = _product.UnitOfMeasurement;
            priceTextBox.Text = _product.Price.ToString("F2", CultureInfo.InvariantCulture);
            supplierIdComboBox.SelectedValue = _product.SupplierId;
            manufacturerIdComboBox.SelectedValue = _product.ManufacturerId;
            categoryComboBox.Text = _product.Category;
            discountNumericUpDown.Value = (decimal)_product.Discount;
            stockNumericUpDown.Value = _product.Stock;
            descriptionTextBox.Text = _product.Description;
            photoTextBox.Text = _product.Photo;
        }

        private void FillModelFields()
        {
            product.Sku = skuTextBox.Text;
            product.ProductName = productNameComboBox.Text;
            product.UnitOfMeasurement = unitOfMeasurementListBox.Text;
            float.TryParse(priceTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out float val);
            product.Price = Math.Round(val, 2);
            product.SupplierId = (int)supplierIdComboBox.SelectedValue;
            product.ManufacturerId = (int)manufacturerIdComboBox.SelectedValue;
            product.Category = categoryComboBox.Text;
            product.Discount = (float)(discountNumericUpDown.Value);
            product.Stock = (int)(stockNumericUpDown.Value);
            product.Description = descriptionTextBox.Text;
            product.Photo = photoTextBox.Text;
        }


        private void CreateUpdateProductForm_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_practice_shoesDataSet.Manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.shapkin_practice_shoesDataSet.Manufacturer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_practice_shoesDataSet.Supplier". При необходимости она может быть перемещена или удалена.
            this.supplierTableAdapter.Fill(this.shapkin_practice_shoesDataSet.Supplier);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_practice_shoesDataSet.Product". При необходимости она может быть перемещена или удалена.
            
            // this.productTableAdapter.Fill(this.shapkin_practice_shoesDataSet.Product);
            FillForm();
        }

        private void CreateUpdateProductForm_Shown(object sender, EventArgs e)
        {
            FormManager.PrepareForm("Добавить/редактировать товар", false);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                product = new Product();
                FillModelFields();
                Program.context.Product.Add(product);
                Program.context.SaveChangesAsync();
                MessageBox.Show("Данные сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
