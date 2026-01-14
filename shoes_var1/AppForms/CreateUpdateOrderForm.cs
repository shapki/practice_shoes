using System;
using System.Data;
using System.Linq;

namespace shoes.AppForms
{
    public partial class CreateUpdateOrderForm : shoes.AppForms.ParentForm
    {
        public CreateUpdateOrderForm()
        {
            InitializeComponent();
            statusComboBox.SelectedIndex = 0;
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
    }
}
