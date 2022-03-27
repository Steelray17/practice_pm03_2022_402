﻿using System;
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
    public partial class Catalogs : Form
    {
        public Catalogs()
        {
            InitializeComponent();
        }

        private void catalogsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.catalogsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.computer_ShopDataSet);

        }

        private void Catalogs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_ShopDataSet.Catalogs". При необходимости она может быть перемещена или удалена.
            this.catalogsTableAdapter.Fill(this.computer_ShopDataSet.Catalogs);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            catalogsBindingSource.MoveFirst();
        }
    }
}
