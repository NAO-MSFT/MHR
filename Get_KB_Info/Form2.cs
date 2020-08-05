using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Get_KB_Info
{
    public partial class Form2 : Form
    {
        int __Maximum_lines = 1024 * 1024;

        public Form2(System.Windows.Forms.DataGridView dataGridViewParent)
        {
            InitializeComponent();
            dataGridView = dataGridViewParent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] strUrls = new String[__Maximum_lines];

            strUrls = textBox1.Text.Split('\r', '\t', '\n', '\0');
            foreach (String strUrl in strUrls)
            {
                if (strUrl != "")
                {
                    //Debug.Print(strUrl);
                    dataGridView.Rows.Add(true, strUrl);
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
