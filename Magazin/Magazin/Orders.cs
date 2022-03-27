using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazin
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.computer_ShopDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //класс System.Convert позволяет преобразовывать несовместимые в C# типы данных
            textBox1.Text = Convert.ToString(Convert.ToDouble(pRICETextBox.Text) *
            Convert.ToDouble(nUMBERTextBox.Text));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_ShopDataSet.ViewORDER". При необходимости она может быть перемещена или удалена.
            this.viewORDERTableAdapter.Fill(this.computer_ShopDataSet.ViewORDER);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_ShopDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.computer_ShopDataSet.Orders);
        }
    }
}
