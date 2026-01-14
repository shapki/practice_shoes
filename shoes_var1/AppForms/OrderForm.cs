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
    public partial class OrderForm : ParentForm
    {
        public OrderForm()
        {
            InitializeComponent();
            ContextManager.orderForm = this;
            ShowAddOrderButton();
        }

        private void ShowAddOrderButton()
        {
            addOrderButton.Visible = ContextManager.user.IsAdmin();
        }

        private void OrderForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void OrderForm_Shown(object sender, System.EventArgs e)
        {
            FormManager.PrepareForm("Заказы");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContextManager.productForm.Show();
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            CreateUpdateOrderForm createUpdateOrder = new CreateUpdateOrderForm();
            DialogResult saved = createUpdateOrder.ShowDialog();

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        public void RefreshList()
        {
            ClearOrders();
            ShowOrders();
        }

        private void ShowOrders()
        {
            List<Order> orders = Program.context.Order.OrderBy(o => o.Date).ToList();
            foreach (Order order in orders)
            {
                flowLayoutPanel1.Controls.Add(new OrderUserControl(order));
            }
        }

        private void ClearOrders()
        {
            flowLayoutPanel1.Controls.Clear();
        }
    }
}
