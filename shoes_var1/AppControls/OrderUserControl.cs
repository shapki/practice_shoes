using shoes.AppExceptions;
using shoes.AppModels;
using System;
using System.Windows.Forms;

namespace shoes.AppControls
{
    public partial class OrderUserControl : UserControl
    {
        private Order _order;
        public OrderUserControl(Order order)
        {
            InitializeComponent();
            _order = order;
            ShowData();
            ShowDeleteButton();
        }

        private void ShowDeleteButton()
        {
            deleteButton.Visible = ContextManager.user.IsAdmin();
        }

        private void ShowData()
        {
            orderIdlabel.Text = "ID: " + _order.IdOrder.ToString();
            deliveryDateLabel.Text = string.Format("{0:dd.MM.yyyy}", _order.DeliveryDate); ;
            orderDateLabel.Text = "Дата заказа: " + string.Format("{0:dd.MM.yyyy}", _order.Date);
            officeLabel.Text = "Адрес пункта выдачи: " + _order.Office.Address;
            statusLabel.Text = "Статус заказа: " + _order.Status;
        }
    }
}
