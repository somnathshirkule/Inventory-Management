using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Inventory_Management
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("username.sys"))
            {
                sw.WriteLine("Server Name="+txtserver.Text);
                sw.WriteLine("User name="+txtserveruser.Text);
                sw.WriteLine("Password="+txtpassword.Text);
            }
            if (txtserver.Text == "")
            {
                MessageBox.Show("server Field is empty", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtserveruser.Text=="")
            {
                MessageBox.Show("Username Field is empty", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtpassword.Text=="")
            {
                MessageBox.Show("password Field is empty", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                Main mn = new Main();
                this.Close();
                mn.ShowDialog();
                this.Hide();
            }
        }

        private void Server_Load(object sender, EventArgs e)
        {

        }
    }
}
