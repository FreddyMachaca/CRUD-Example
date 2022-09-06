using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace INVENTARIO_MENU_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-F1AC5QU; database=Prueba2;integrated security=true");


        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "select * from Persona where usuario='"+TextBox1.Text+ "'and contrasena='"+TextBox2.Text+"'";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            if (lector.HasRows == true)
            {
                Form1 frmbienvenido = new Form1();
                    this.Hide();
                frmbienvenido.Show();

            }
            else 
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
            }
            conexion.Close();

        }
    }
}
