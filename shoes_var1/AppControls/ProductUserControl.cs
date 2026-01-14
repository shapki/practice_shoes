using shoes.AppExceptions;
using shoes.AppForms;
using shoes.AppModels;
using shoes.AppServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoes.AppControls
{
    public partial class ProductUserControl : UserControl
    {
        private Product _product;
        public ProductUserControl(Product product)
        {
            InitializeComponent();
            ShowDeleteButton();
            _product = product;
            ShowProductInfo();
            HighlightGreatDiscount();
            HighlightAbsent();
        }

        private void HighlightGreatDiscount()
        {
            if (_product.Discount > 15)
            {
                this.BackColor = ColorTranslator.FromHtml(AppConstants.Color.greatDiscount);
            }
        }

        private void HighlightAbsent()
        {
            Debug.Assert(_product.Stock >= 0); // PKGH Отрицательным запас быть не может.
            if (_product.Stock == 0)
            {
                this.BackColor = System.Drawing.Color.LightBlue;
            }
        }

        private void ShowDeleteButton()
        {
            deleteButton.Visible = ContextManager.user.IsAdmin();
        }

        private void ShowProductInfo()
        {
            categoryProductName.Text = $"{_product.Category} | {_product.ProductName}";
            description.Text = $"Описание товара: {_product.Description}";
            manufacturer.Text = $"Производитель: {_product.Manufacturer.ManufacturerName}";
            supplier.Text = $"Поставщик: {_product.Supplier.SupplierName}";
            oldPrice.Text = GetOldPrice();
            price.Text = GetPrice(); _ = $"Цена: {_product.Price} руб.";
            unitOfMeasurement.Text = $"Единица измерения: {_product.UnitOfMeasurement}";
            stock.Text = $"Количество на складе: {_product.Stock}";
            id.Text = $"Id: {_product.IdProduct}";
            photo.Image = GetImage();
            discount.Text = String.Format("{0} %", _product.Discount);

        }

        private Image GetImage()
        {

            Image img;
            try
            {
                {
                    img = new Bitmap(Image.FromFile(FileManager.GetImgPath(_product.Photo)));
                }

            }
            catch (FileNotFoundException ex)
            {
                img = Image.FromFile(FileManager.GetImgPath(FilePath.defaultPicture));
            }

            return img;
        }

        private string GetOldPrice()
        {
            return _product.Discount > 0 ? $"{_product.Price} руб." : "";
        }

        private string GetPrice()
        {
            double tmpPrice = _product.Price;

            if (_product.Discount > 0)
            {
                tmpPrice = _product.Price * ((100 - _product.Discount) / 100);
            }

            return String.Format("Цена: {0} руб.", tmpPrice.ToString("F2", CultureInfo.InvariantCulture));
        }

        private void product_Click(object sender, EventArgs e)
        {
            if (!ContextManager.user.IsAdmin())
            {
                return;
            }

            CreateUpdateProductForm сreateUpdateProductForm = new CreateUpdateProductForm(_product);

            DialogResult productSaved = сreateUpdateProductForm.ShowDialog();

            if (productSaved == DialogResult.OK)
            {
                ContextManager.productForm.RefreshList();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult toBeDeleted = MessageBox.Show("Удалить?", "Удалить?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (toBeDeleted == DialogResult.OK)
            {
                Product product = Program.context.Product.Where(p => p.IdProduct == this._product.IdProduct).FirstOrDefault();

                try
                {
                    Program.context.Product.Remove(_product);
                    Program.context.SaveChanges();
                    ContextManager.productForm.RefreshList();
                    FileManager.DeleteFile(_product.Photo);
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show("Товар заказан. Его нельзя удалить.", "Товар заказан. Его нельзя удалить.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
