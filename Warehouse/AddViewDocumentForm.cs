using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.Models;

namespace Warehouse
{
    public partial class AddViewDocumentForm : Form
    {
        private readonly int viewDocimentId;

        public DataGridViewRowCollection ProductTable { get { return dataGridProduct.Rows; } }
        public string DocumentType { get { return comboBoxDocumentType.Text; } }
        public string DocumentCounterparty { get { return textBoxConterparty.Text; } }
        public int ViewDocumentId { get { return viewDocimentId; } }

        public event Action DisplayDocument;
        public event Action SaveDocument;
        public event Action AddProduct;

        public AddViewDocumentForm()
        {
            InitializeComponent();

            buttonSave.Click += (sender, args) => Invoke(SaveDocument);
            buttonAddProduct.Click += (sender, args) => Invoke(AddProduct);

            comboBoxDocumentType.SelectedIndex = 0;
        }

        public AddViewDocumentForm(int viewDocumentId) 
        {
            InitializeComponent();

            this.viewDocimentId = viewDocumentId;

            this.Load += (sender, args) => Invoke(DisplayDocument);

            buttonSave.Enabled = false;

            buttonAddProduct.Enabled = false;
            buttonAddProduct.Visible = false;

            textBoxConterparty.Enabled = false;

            comboBoxDocumentType.DropDownStyle = ComboBoxStyle.Simple;
            comboBoxDocumentType.Enabled = false;

            labelDateTime.Enabled = true;
            labelDateTime.Visible = true;

            textBoxDateTime.Visible = true;

            dataGridProduct.Columns["ProductCount"].ReadOnly = true;
        }

        public void DisplayDocumentData(string documentType, string documentDateTime, string documentCounterparty)
        {
            comboBoxDocumentType.Text = documentType;
            textBoxDateTime.Text = documentDateTime;
            textBoxConterparty.Text = documentCounterparty;
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
