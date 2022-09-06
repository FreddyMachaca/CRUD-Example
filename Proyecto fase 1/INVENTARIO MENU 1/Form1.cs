using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INVENTARIO_MENU_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            notificaciones1.BringToFront();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            productos1.BringToFront();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            usuarios1.BringToFront();
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void notificaciones1_Load(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void gunaPictureBox2_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
