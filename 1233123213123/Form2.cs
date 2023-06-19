using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1233123213123
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void валютаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.валютаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Microsoft_Access_База_данных__2_DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Microsoft_Access_База_данных__2_DataSet.валюта". При необходимости она может быть перемещена или удалена.
            this.валютаTableAdapter.Fill(this._Microsoft_Access_База_данных__2_DataSet.валюта);

        }
    }
}
