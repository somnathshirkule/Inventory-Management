using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class Main : Form
    {
        Thread t1;
        public Main()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            timer1.Start();
            //t1 = new Thread(new ThreadStart(timeChanger));
            //t1.Start();
        }
        private void timeChanger()
        {
            while (true)
            {
                //label1.Text = DateTime.Now.ToString("HH:mm:ss tt");
                
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            position(button9);

        }
         private void position (Button b)
        {
            p1.Location = new Point(b.Location.X - p1.Width, b.Location.Y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.ShowDialog();
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
          

        }

        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlfpurchase_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Hide();
            m.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Hide();
            m.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Hide();
            m.ShowDialog();
            this.Close();
        }

        private void restockpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contextMenuStrip3_Opening(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

      

        private void label7_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl31.Hide();
            panel2.Hide();
           // pnlftsold.Hide();
            //pnlfpurchase.Hide();
            //pnlfRestock.Hide();
            userControl21.Show();
            userControl21.BringToFront();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            panel2.Hide();
            //pnlftsold.Hide();
            //pnlfpurchase.Hide();
            //pnlfRestock.Hide();
            userControl31.Show();
            userControl31.BringToFront();
        }

       

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void userControl31_Load(object sender, EventArgs e)
        {

        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl31.Hide();
            panel2.Hide();
            // pnlftsold.Hide();
            //pnlfpurchase.Hide();
            // pnlfRestock.Hide();
            userControl21.Show();
            userControl21.BringToFront();
        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            position(button9);
            panel2.Show();
            
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            position(button1);
            
            
            userControl21.Hide();
            userControl31.Hide();
            panel2.Hide();
            // pnlftsold.Hide();
            //pnlfpurchase.Hide();
            // pnlfRestock.Hide();
            userControl11.Show();
            userControl11.BringToFront();
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            position(button2);
            userControl11.Hide();
            userControl31.Hide();
            panel2.Hide();
            // pnlftsold.Hide();
            //pnlfpurchase.Hide();
            // pnlfRestock.Hide();
            userControl21.Show();
            userControl21.BringToFront();
            
        }

       

        private void userControl31_Load_1(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            position(button10);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            position(button7);
            string messege = "Do you want to logout?";
            string title = "Logout";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(messege, title, buttons);
            if (result == DialogResult.OK)
            {

                Login lg = new Login();
                this.Hide();
                lg.ShowDialog();
                this.Close();

            }
            else
            {
                //this.Show();
            }
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            position(button4);
            userControl11.Hide();
            userControl21.Hide();
            panel2.Hide();
            //pnlftsold.Hide();
            //pnlfpurchase.Hide();
            //pnlfRestock.Hide();
            userControl31.Show();
            userControl31.BringToFront();
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            position(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            position(button6);
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            UserForm f1 = new UserForm();
            //f1.Visible=true;
            f1.ShowDialog();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string dateTime = DateTime.Now.ToString("HH:mm:ss tt");
            string username = CurrentUser.username;
            button3.Text = username + " | " + dateTime;
        }
    }
    }
