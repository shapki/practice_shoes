using shoes.AppExceptions;
using shoes.AppForms;
using shoes.AppModels;
using shoes.AppServices;
using System;
using System.Data.Entity.Infrastructure;
using System.Linq;
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

            if (ContextManager.user.IsAuthUser() && _order.ClientId != ContextManager.user.IdUser)
            {
                this.Visible = false;
                return;
            }

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

        private void order_Click(object sender, EventArgs e)
        {
            if (!ContextManager.user.IsAdmin())
            {
                return;
            }

            CreateUpdateOrderForm сreateUpdateOrderForm = new CreateUpdateOrderForm(_order);

            DialogResult saved = сreateUpdateOrderForm.ShowDialog();

            if (saved == DialogResult.OK)
            {
                ContextManager.orderForm.RefreshList();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult toBeDeleted = MessageBox.Show("Удалить?", "Удалить?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (toBeDeleted == DialogResult.OK)
            {
                Order order = Program.context.Order.Where(p => p.IdOrder == this._order.IdOrder).FirstOrDefault();

                try
                {
                    Program.context.Order.Remove(_order);
                    Program.context.SaveChanges();
                    ContextManager.orderForm.RefreshList();
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show("Не удалось удалить заказ.", "Не удалось удалить заказ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
