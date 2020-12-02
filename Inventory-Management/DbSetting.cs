using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class DbSetting : Form
    {
        public DbSetting()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
        }

        private void DbSetting_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtsevername.Text == "")
            {

                MessageBox.Show("Server field is empty!!","EMPTY",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (txtuser.Text == "")
            {
                MessageBox.Show("Username Field is empty", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtpass.Text == "")
            {
                MessageBox.Show("Passsword Field is empty","EMPTY",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                using (StreamWriter sw = new StreamWriter("setting.sys"))
                {
                    sw.WriteLine("server=" + txtsevername.Text);
                    sw.WriteLine("Username=" + txtuser.Text);
                    sw.WriteLine("password=" + txtpass.Text);

                }
            }
        }
    }
}
