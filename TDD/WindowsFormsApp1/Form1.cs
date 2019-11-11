using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDDs;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = string.Empty;

            label7.Text = string.Empty;

            TDD tdd = new TDD();

            int[] res = tdd.Work(Convert.ToInt32(textBox1.Text),
                Convert.ToInt32(textBox2.Text),
                Convert.ToInt32(textBox3.Text));

            if (res != null)
            {
                label6.Text = res[0].ToString();

                label7.Text = res[1].ToString();
            }

            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
