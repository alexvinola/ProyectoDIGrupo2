using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGrupo2
{
    public partial class Form6 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8UT0V1G\DI_SQLSERVER;Initial Catalog=GestionPedidos;Persist Security Info=True;User ID=sa;Password=isaac");
        public Form6()
        {
            InitializeComponent();
        }


        private void btnArticulo_Click(object sender, EventArgs e)
        {
            //Limpiamos la tabla para cuando se selecciona un botón distinto
            dataGridView1.ClearSelection();
            //Seleccionamos todos los datos de la tabla articulo 
            string query = "select * from articulo";

            //Se abre la conexión
            conn.Open();

            //Creas una variable de SqlCommand donde le pasamos las consultas y la conexión
            SqlCommand cmd = new SqlCommand(query, conn);

            //Creamos una variable de SqlDataReader que lee todos los datos de la tabla
            SqlDataReader read = cmd.ExecuteReader();

            //Creamos una isntancia de la clase DataTable que carga todos los datos leidos con el metodo Load()
            DataTable dt = new DataTable();
            dt.Load(read);

            //Aqui a partir de lo que ha cargado en la clase DataTable se lo pasamos a nuestra tabla y muestra los datos
            dataGridView1.DataSource = dt;

            //Cierra la conexión
            conn.Close();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            //Limpiamos la tabla para cuando se selecciona un botón distinto
            dataGridView1.ClearSelection();
            //Seleccionamos todos los datos de la tabla cliente
            string query = "select * from cliente";

            //Se abre la conexión
            conn.Open();

            //Creas una variable de SqlCommand donde le pasamos las consultas y la conexión
            SqlCommand cmd = new SqlCommand(query, conn);

            //Creamos una variable de SqlDataReader que lee todos los datos de la tabla
            SqlDataReader read = cmd.ExecuteReader();

            //Creamos una isntancia de la clase DataTable que carga todos los datos leidos con el metodo Load()
            DataTable dt = new DataTable();
            dt.Load(read);

            //Aqui a partir de lo que ha cargado en la clase DataTable se lo pasamos a nuestra tabla y muestra los datos
            dataGridView1.DataSource = dt;

            //Cierra la conexión
            conn.Close();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            //Limpiamos la tabla para cuando se selecciona un botón distinto
            dataGridView1.ClearSelection();
            //Seleccionamos todos los datos de la tabla Pedido
            string query = "select * from Pedido";

            //Se abre la conexión
            conn.Open();

            //Creas una variable de SqlCommand donde le pasamos las consultas y la conexión
            SqlCommand cmd = new SqlCommand(query, conn);

            //Creamos una variable de SqlDataReader que lee todos los datos de la tabla
            SqlDataReader read = cmd.ExecuteReader();

            //Creamos una isntancia de la clase DataTable que carga todos los datos leidos con el metodo Load()
            DataTable dt = new DataTable();
            dt.Load(read);

            //Aqui a partir de lo que ha cargado en la clase DataTable se lo pasamos a nuestra tabla y muestra los datos
            dataGridView1.DataSource = dt;

            //Cierra la conexión
            conn.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}