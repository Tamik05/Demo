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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void вкладыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.вкладыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Microsoft_Access_База_данных__2_DataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Microsoft_Access_База_данных__2_DataSet.вклады". При необходимости она может быть перемещена или удалена.
            this.вкладыTableAdapter.Fill(this._Microsoft_Access_База_данных__2_DataSet.вклады);

        }
    }
}
