using System;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class AddEditProductForm : Form
    {
        private int currentProductId;

        public int CurrentProductId { get { return currentProductId; } }
        public string CurrentProductName { get { return textBoxName.Text; } }
        public string CurrentProductUnit { get { return textBoxUnit.Text; } }

        public event Action SaveProduct;
        public event Action UpdateProduct;

        public AddEditProductForm()
        {
            InitializeComponent();

            buttonEditSave.Enabled = false;
            buttonEditSave.Visible = false;

            buttonSave.Click += (sender, args) => Invoke(SaveProduct);
        }

        public AddEditProductForm(int productId, string productName, string productUnit)
        {
            InitializeComponent();

            currentProductId = productId;
            textBoxName.Text = productName;
            textBoxUnit.Text = productUnit;

            buttonSave.Enabled = false;
            buttonSave.Visible = false;

            buttonEditSave.Click += (sender, args) => Invoke(UpdateProduct);
        }

        public void ShowError(string errorText)
        {
            MessageBox.Show(errorText, "Ошибка");
        }

        private void Invoke(Action action)
        {
            if (action != null)
                action();
        }
    }
}
