﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class Sold : Form
    {
        public Sold()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            this.Hide();
            mn.ShowDialog();
            this.Close();
        }

        private void Sold_Load(object sender, EventArgs e)
        {

        }
    }
}