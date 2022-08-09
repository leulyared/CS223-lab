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
    public partial class Form3 : Form
    {
        string uname;
        public Form3(String name)
        {
            InitializeComponent();
            uname = name;
        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
           var activescreen = ActiveMdiChild;
            if (activescreen != null)
            {
                activescreen.Close();
            }
            Form3 screen = new Form3(uname);
            screen.MdiParent = this;
            screen.Show();
        }

        private void newStudentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(uname);
            f1.Show();
            this.Hide();
        }
    }
}
