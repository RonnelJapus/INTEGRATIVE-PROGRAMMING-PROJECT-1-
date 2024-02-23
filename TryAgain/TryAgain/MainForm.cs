﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryAgain
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newform = new ViewNotification();
            newform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newform = new ViewCalendar();
            newform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newform = new Form1();
            newform.Show();
            this.Hide();
        }
    }
}
