using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd2DataSet.Table_2". При необходимости она может быть перемещена или удалена.
            this.table_2TableAdapter.Fill(this.bd2DataSet.Table_2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd2DataSet.Table_1". При необходимости она может быть перемещена или удалена.
            this.table_1TableAdapter.Fill(this.bd2DataSet.Table_1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table_1TableAdapter.Update(bd2DataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                DataRow nRow = bd2DataSet.Tables[0].NewRow();
                int rc = dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox2.Text;
                nRow[2] = textBox3.Text;
                bd2DataSet.Tables[0].Rows.Add(nRow);
                table_1TableAdapter.Update(bd2DataSet.Table_1);
                bd2DataSet.Tables[0].AcceptChanges();
                dataGridView1.Refresh();
                textBox2.Text = "";
                textBox3.Text = "";
            
        }
    }
}
