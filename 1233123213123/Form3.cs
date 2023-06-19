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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void вкладчикиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.вкладчикиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Microsoft_Access_База_данных__2_DataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Microsoft_Access_База_данных__2_DataSet.вкладчики". При необходимости она может быть перемещена или удалена.
            this.вкладчикиTableAdapter.Fill(this._Microsoft_Access_База_данных__2_DataSet.вкладчики);

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void id_сотрудникаTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_сотрудникаLabel_Click(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
