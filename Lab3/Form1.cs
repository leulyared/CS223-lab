using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1(string name)
        {
            InitializeComponent();
            lbluName.Text = name; ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //number
            if (String.IsNullOrEmpty(Num.Text))
            {
                errorProviderNum.SetError(Num, "Invalid number.");
            }
            else
                errorProviderNum.Clear();
            //Inventory number
            try
            {
                errorProviderInventorynum.Clear();
                int.Parse(Inventorynum.Text);
            }
            catch (Exception)
            {
                errorProviderInventorynum.SetError(Inventorynum, "Invalid number.");
            }

            //object name
            Regex reg = new Regex(@"^[a-z]{2}$");
            if (reg.IsMatch(Name.Text))
            {
                errorProviderObjectName.SetError(Name, "2 digit name.");
            }
            if (String.IsNullOrEmpty(Name.Text))
            {
                errorProviderObjectName.SetError(Name, "Number not entered or invalid.");
            }
            else if (Name.Text.Length < 5)
            {
                errorProviderObjectName.SetError(Name, "Name should have more than 5 characters.");
            }
            else
                errorProviderObjectName.Clear();

            //count
            if (String.IsNullOrEmpty(Count.Text) || int.Parse(Count.Text) <= 0)
            {
                errorProviderNum.SetError(Count, "Invalid number.");
            }
            else
                errorProviderCount.Clear();

            //price
            try
            {
                errorProviderPrice.Clear();
                double.Parse(Price.Text);
            }
            catch(Exception)
            {
                errorProviderPrice.SetError(Price, "Invalid number.");

            }

            Product m = new Product
            {
                Num = int.Parse(Num.Text),
                Date = Date.Text,
                Inventory_number = int.Parse(Inventorynum.Text),
                Object_name = Name.Text,
                Count = int.Parse(Count.Text),
                Price = double.Parse(Price.Text),
                Available = checkBox1.Checked,

            };
            MessageBox.Show("Saved");
            //fro the check box list
            MessageBox.Show("Added");
            if (radioButton1.Checked)
                MessageBox.Show("Simple product.");
            else if(radioButton2.Checked)
                MessageBox.Show("Variable product.");
            else
                MessageBox.Show("Did not enter a product type choose from 'Simple/Variable'.");
            m.save();
            display_Product.DataSource = null;
            display_Product.DataSource = Product.GetList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}
