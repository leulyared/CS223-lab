using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _5th_july.NewFolder1;
namespace _5th_july
{
    public partial class Form1 : Form
    {
        public Form1(string user)
        {
            InitializeComponent();
            label9.Text = user;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = num.Text;
          

            MessageBox.Show(text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            es em = new es();
            em.num1 = Convert.ToInt32(num.Text);
            em.date = d2.Value;
            em.invname = t5.Text;
            em.objname = t9.Text;
            em.count = textBox5.Text;
            em.price = textBox7.Text;
            em.isAvailable= checkbox1.Checked;
            

            if (num.Text.Length < 5)
            {
                errorProvider1.SetError(num, "Number  must be 5 digits!");
            }

            else if (t5.Text.Length < 2)
            {
                errorProvider1.SetError(t5, "Inventory Number must be 2 digits!");
            }

            else if (string.IsNullOrEmpty(t9.Text))
            {
                errorProvider1.SetError(t9, "Object name is required!");
            }

            else if (textBox5.Text.Length < 1)
            {
                errorProvider1.SetError(textBox5, "Count is required!");
            }
            else
            {
                errorProvider1.Clear();
                em.save();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = es.getallproduct();
                MessageBox.Show(" Items has been Successfully Added!!!");
            }
        }

        private void avialable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (rdbtn1.Checked)
                MessageBox.Show("simple");
            else if (rdbtn2.Checked)
                MessageBox.Show("variable");
            else
                Console.WriteLine("");
            string message = " ";
            foreach( var item in checkedListBox1.CheckedItems )
            {
                message += item.ToString();

            }
            MessageBox.Show(message);      
        }
    }
}
