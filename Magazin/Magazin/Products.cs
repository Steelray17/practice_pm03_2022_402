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
    public partial class Products : Form
    {


        public Products()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveFirst();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.computer_ShopDataSet);

        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_ShopDataSet.Catalogs". При необходимости она может быть перемещена или удалена.
            this.catalogsTableAdapter.Fill(this.computer_ShopDataSet.Catalogs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_ShopDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.computer_ShopDataSet.Products);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            productsBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            productsBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            productsBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей
            this.Validate();
            //закрывает подключение с сервером
            this.productsBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.computer_ShopDataSet);
        }
        private Forms forms;
        private void button8_Click(object sender, EventArgs e)
        {
            forms = new Forms();
            forms.Visible = true;
        }
    }
}
