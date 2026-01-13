using shoes.AppExceptions;
using shoes.AppModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
        }

        private void ShowDeleteButton()
        {
            throw new NotImplementedException();
            deleteButton.Visible = ContextManager.user.IsAdmin();
        }

        private void ShowProductInfo()
        {
            throw new NotImplementedException();
            categoryProductName.Text = $"{_product.Category} | {_product.ProductName}";
            description.Text = $"Описание товара: {_product.Description}";
            manufacturer.Text = $"Производитель: {_product.Manufacturer.ManufacturerName}";
            supplier.Text = $"Поставщик: {_product.Supplier.SupplierName}";
            price.Text = $"Цена: {_product.Price} руб.";
            unitOfMeasurement.Text = $"Единица измерения: {_product.UnitOfMeasurement}";
            stock.Text = $"Количество на складе: {_product.Stock}";
            id.Text = $"Id: {_product.IdProduct}";
        }

    }
}
