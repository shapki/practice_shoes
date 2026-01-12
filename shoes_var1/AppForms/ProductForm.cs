using shoes.AppExceptions;
using System.Windows.Forms;

namespace shoes.AppForms
{
    public partial class ProductForm : ParentForm
    {
        public ProductForm()
        {
            InitializeComponent();
            ContextManager.parentForm = this;
        }

        private void ProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
