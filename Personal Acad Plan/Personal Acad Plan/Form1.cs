using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Acad_Plan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var newform = new Form2();
            newform.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newform = new Form3();
            newform.Show();
            this.Hide();
        }
    }
}
