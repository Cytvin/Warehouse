using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.Models;

namespace Warehouse
{
    public partial class AddProductToDocumentForm : Form
    {
        public DataGridViewRowCollection ProductTable { get { return dataGridProducts.Rows; } }
        public DataGridViewRow CurrentProduct { get { return dataGridProducts.CurrentRow; } }

        public event Action DisplayProduct;
        public event Action AddProduct;

        public AddProductToDocumentForm()
        {
            InitializeComponent();

            this.Load += (sender, args) => Invoke(DisplayProduct);
            buttonAdd.Click += (sender, args) => Invoke(AddProduct);
        }

        private void Invoke(Action action)
        {
            if (action != null)
                action();
        }
    }
}
