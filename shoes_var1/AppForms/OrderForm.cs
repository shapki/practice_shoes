using shoes.AppExceptions;
using shoes.AppServices;
using System.Windows.Forms;

namespace shoes.AppForms
{
    public partial class OrderForm : ParentForm
    {
        public OrderForm()
        {
            InitializeComponent();
            ContextManager.orderForm = this;
        }

        private void OrderForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void OrderForm_Shown(object sender, System.EventArgs e)
        {
            FormManager.PrepareForm("Заказы");
        }
    }
}
