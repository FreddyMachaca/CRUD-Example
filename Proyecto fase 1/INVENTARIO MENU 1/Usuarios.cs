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
    public partial class Usuarios : UserControl
    {
        public Usuarios()
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

        
        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {
            string consulta = "select * from producto";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "insert into producto values("+TextBox1.Text+ ",'"+TextBox2.Text+ "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
            SqlCommand comando = new SqlCommand(consulta,conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro agregado");
            llenar_tabla();
            
            conexion.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string consulta = "delete from producto where codigo=" + TextBox1.Text + "";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro eliminado");
            llenar_tabla();

            conexion.Close();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "update producto set codigo=" + TextBox1.Text + ",nombre='" + TextBox2.Text + "',Descripcion='" + TextBox3.Text + "',precio='" + TextBox4.Text + "'where codigo="+TextBox1.Text+"";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            int cant;
            cant=comando.ExecuteNonQuery();
            if (cant > 0)
            {
                MessageBox.Show("Registro modificado");
            }
            llenar_tabla();

            conexion.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBox1.Text = dataGridView1.SelectedCells[0].Value.ToString();
            TextBox2.Text = dataGridView1.SelectedCells[1].Value.ToString();
            TextBox3.Text = dataGridView1.SelectedCells[2].Value.ToString();
            TextBox4.Text = dataGridView1.SelectedCells[3].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
