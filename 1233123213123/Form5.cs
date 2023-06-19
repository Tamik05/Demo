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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void должностиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.должностиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Microsoft_Access_База_данных__2_DataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Microsoft_Access_База_данных__2_DataSet.должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this._Microsoft_Access_База_данных__2_DataSet.должности);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.должностиBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.должностиBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.должностиBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.должностиBindingSource.MoveLast();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.должностиBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.должностиBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.должностиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Microsoft_Access_База_данных__2_DataSet);
        
        }

        private void button8_Click(object sender, EventArgs e)
        {
         
                Form8 frm = new Form8();
                frm.Show();
           
        }
    }
}
