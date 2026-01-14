using shoes.AppModels;
using shoes.AppServices;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace shoes.AppForms
{
    public partial class CreateUpdateOrderForm : shoes.AppForms.ParentForm
    {
        private Order _order;
        public CreateUpdateOrderForm()
        {
            InitializeComponent();
            statusComboBox.SelectedIndex = 0;
            _order = new Order();
        }

        private void CreateUpdateOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_practice_shoesDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.shapkin_practice_shoesDataSet.User);

            string[] excludedValues = { "a", "c", "m", "g" };
            userBindingSource.DataSource = Program.context.User.Where(u => !excludedValues.Contains(u.FullName)).ToList();

            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_practice_shoesDataSet.Office". При необходимости она может быть перемещена или удалена.
            this.officeTableAdapter.Fill(this.shapkin_practice_shoesDataSet.Office);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_practice_shoesDataSet.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.shapkin_practice_shoesDataSet.Order);

        }

        private int GenerateNextReceiptCode()
        {
            Order order = Program.context.Order.OrderByDescending(o => o.ReceiptCode).FirstOrDefault();

            return order.ReceiptCode + 1;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Иправьте ошибки в форме перед сохранением.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FillModelFields();

            try
            {
                if (_order.IsNew())
                {
                    Program.context.Order.Add(_order);
                }
                Program.context.SaveChanges();
                MessageBox.Show("Данные сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillModelFields()
        {
            _order.OfficeId = (int)officeIdComboBox.SelectedValue;
            _order.ClientId = (int)clientIdComboBox.SelectedValue;
            _order.Date = dateDateTimePicker.Value;
            _order.DeliveryDate = deliveryDateDateTimePicker.Value;
            _order.Status = statusComboBox.SelectedItem.ToString();
            _order.ReceiptCode = GenerateNextReceiptCode();
        }

        private void deliveryDateDateTimePicker_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (deliveryDateDateTimePicker.Value.Date < dateDateTimePicker.Value.Date)
            {
                e.Cancel = true; // PKGH Предотвратить потерю фокуса.
                FormManager.ErrorProvider.SetError(deliveryDateDateTimePicker, "Дата выдачи не может быть меньше даты заказа!");
            }
            else
            {
                FormManager.ErrorProvider.SetError(deliveryDateDateTimePicker, null);
            }
        }
    }
}
