using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaker
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Messages", typeof(String));

            dataGridView1.DataSource = table;

            dataGridView1.Columns["Messages"].Visible = false;
            dataGridView1.Columns["Title"].Width = 227;
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            titleTxt.Clear();
            msgText.Clear();

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            table.Rows.Add(titleTxt.Text, msgText.Text);

            titleTxt.Clear();
            msgText.Clear();
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if(index > -1)
            {
                titleTxt.Text = table.Rows[index].ItemArray[0].ToString();
                msgText.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
 
}
