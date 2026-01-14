using shoes.AppModels;
using shoes.AppServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
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

        public CreateUpdateProductForm(Product product)
        {
            InitializeComponent();
            _product = product;
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
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Исправьте ошибки в форме перед сохранением.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string newFileName = SaveImage();
                photoTextBox.Text = newFileName;
                DeleteOldPhoto();
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

        /// <summary>
        /// PKGH
        /// Старый файл удаляем.
        /// Ситуация возможна в случае изменения товара.
        /// </summary>
        private void DeleteOldPhoto()
        {
            if (!string.IsNullOrEmpty(_product.Photo))
            {
                FileManager.DeleteFile(_product.Photo);
            }
        }

        private string SaveImage()
        {
            // PKGH Файл не выбирали, но нажали кнопку "Сохранить".
            if (string.IsNullOrEmpty(openFileDialog1.FileName) || openFileDialog1.FileName == "openFileDialog1")
            {
                return "";
            }
            Image originalImage = Image.FromFile(openFileDialog1.FileName);
            Dictionary<string, int> newImageSize = GetNewImageSize(originalImage);

            // PKGH Создаем изображение не более максимальных размеров.
            Bitmap resizedImage = new Bitmap(originalImage, newImageSize["width"], newImageSize["height"]);

            string fileName = Guid.NewGuid().ToString().Substring(0, 8) + ".jpg"; // PKGH Генерация уникального имени файла. Длина - 8 символов.

            string savePath = FileManager.GetImgPath(fileName);

            // PKGH Сохраняем изображение
            resizedImage.Save(savePath);

            // PKGH Освобождаем ресурсы
            originalImage.Dispose();
            resizedImage.Dispose();

            return fileName;
        }

        /// <summary>
        /// PKGH
        /// Файл будет сохраняться с размером не более 300 х 200.
        /// Получить размеры нового файла.
        /// </summary>
        /// <param name="originalImage"></param>
        /// <returns></returns>

        private Dictionary<string, int> GetNewImageSize(Image originalImage)
        {
            int maxWidth = 300;
            int maxHeight = 200;

            float ratioX = (float)maxWidth / originalImage.Width;
            float ratioY = (float)maxHeight / originalImage.Height;
            float ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(originalImage.Width * ratio);
            int newHeight = (int)(originalImage.Height * ratio);

            Dictionary<string, int> result = new Dictionary<string, int>();
            result.Add("width", newWidth);
            result.Add("height", newHeight);

            return result;
        }

        private void openFileDialogButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Изображения (*.jpg;*.jpeg)|*.jpg;*.jpeg";

            DialogResult dialogResult = openFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                photoTextBox.Text = Path.GetFileName(openFileDialog1.FileName);
            }
        }

        private void ValidateGeneral(object sender, System.ComponentModel.CancelEventArgs e)
        {
            FormManager.ValidateGeneral(sender, e);
        }

        private void priceTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            FormManager.ValidateGeneral(sender, e);

            Regex regex = new Regex(@"^\d+(\.\d{1,2})?$");

            CultureInfo culture = CultureInfo.InvariantCulture; // PKGH '.' - десятичный разделитель.
            float val;

            if (!regex.IsMatch(priceTextBox.Text))
            {
                e.Cancel = true; // PKGH Предотвратить потерю фокуса.
                FormManager.ErrorProvider.SetError(priceTextBox, "Допустимо неотрицательное число. Не более двух знаков после запятой. Десятичный разделитель - точка."); // PKGH показать подсказку.
            }
            else if (float.TryParse(priceTextBox.Text, NumberStyles.Float, culture, out val) && val == 0f)
            {
                e.Cancel = true; // PKGH Предотвратить потерю фокуса.
                FormManager.ErrorProvider.SetError(priceTextBox, "Вы бесплатно раздаете?"); // PKGH показать подсказку.                
            }
        }

        private void saveProductButton_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Исправьте ошибки в форме перед сохранением.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string newFileName = SaveImage();
                photoTextBox.Text = newFileName;
                DeleteOldPhoto();
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
