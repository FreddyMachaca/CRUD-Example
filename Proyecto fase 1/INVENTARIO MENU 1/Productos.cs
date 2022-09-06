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
    public partial class Productos : UserControl
    {
        public Productos()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-F1AC5QU; database=Prueba2;integrated security=true");


        public void llenar_tabla()
        {
            string consulta = "select * from producto";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;

        }




        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "select * from producto where codigo=" + TextBox6.Text + "";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            conexion.Close();


        }

        private void Button6_Click(object sender, EventArgs e)
        {
            llenar_tabla();
        }
    }
}
