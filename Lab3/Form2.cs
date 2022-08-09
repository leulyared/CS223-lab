using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( textBox2.Text == "12345")
            {
                Form3 f3 = new Form3(textBox1.Text);
                f3.Show();
                this.Hide();
            }
            else
                MessageBox.Show("wrong user name or password");
        }

    }
}
