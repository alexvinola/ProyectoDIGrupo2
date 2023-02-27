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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoGrupo2
{
    public partial class Form3 : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8UT0V1G\DI_SQLSERVER;Initial Catalog=GestionPedidos;Persist Security Info=True;User ID=sa;Password=isaac");

        public Form3()
        {
            InitializeComponent();
            
        }

        

        private void cbBox_cCliente()
        {
            cbClientes.Items.Clear();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select cCliente from Pedido";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cbClientes.Items.Add(dr["cCliente"].ToString());
            }
        
            conn.Close();
        }

     

        //Botón cancelar
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        //Botón alta
        private void button2_Click(object sender, EventArgs e)
        {

            if(rbArticulo.Checked == true)
            {
                // Crear una nueva conexión a la base de datos
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8UT0V1G\DI_SQLSERVER;Initial Catalog=GestionPedidos;Persist Security Info=True;User ID=sa;Password=isaac");

                // Abrir la conexión
                conn.Open();

                // Crear una consulta SQL parametrizada para insertar un nuevo pedido
                string query = "INSERT INTO articulo (seccion, nombreArticulo, precio, fecha, paisOrigen) VALUES (@seccion,@nombre, @precio, @fecha, @pais)";

                // Crear un objeto SqlCommand y asignar la consulta y la conexión
                SqlCommand cmd = new SqlCommand(query, conn);

                // Asignar los parámetros de la consulta
                cmd.Parameters.AddWithValue("@seccion", tbSecc.Text);
                cmd.Parameters.AddWithValue("@nombre", tbNomArt.Text);
                cmd.Parameters.AddWithValue("@precio", Int32.Parse(tbPrecio.Text));
                cmd.Parameters.AddWithValue("@fecha", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@pais", tbPais.Text);

                // Ejecutar la consulta
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Articulo insertado");
                }
                else
                {
                    MessageBox.Show("Error al insertado articulo");
                }

                // Cerrar la conexión
                conn.Close();

            }
            else if(rbCliente.Checked == true)
            {
                // Crear una nueva conexión a la base de datos
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8UT0V1G\DI_SQLSERVER;Initial Catalog=GestionPedidos;Persist Security Info=True;User ID=sa;Password=isaac");

                // Abrir la conexión
                conn.Open();

                // Crear una consulta SQL parametrizada para insertar un nuevo pedido
                string query = "INSERT INTO cliente (nombreCliente, direccion, poblacion, telefono) VALUES (@nombre, @direccion, @poblacion, @telefono)";

                // Crear un objeto SqlCommand y asignar la consulta y la conexión
                SqlCommand cmd = new SqlCommand(query, conn);

                // Asignar los parámetros de la consulta
                cmd.Parameters.AddWithValue("@nombre", tbNombreCl.Text);
                cmd.Parameters.AddWithValue("@direccion", tbDireccion.Text);
                cmd.Parameters.AddWithValue("@poblacion", tbPoblacion.Text);
                cmd.Parameters.AddWithValue("@telefono", tbTelefono.Text);

                // Ejecutar la consulta
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cliente insertado");
                }
                else
                {
                    MessageBox.Show("Error al insertado cliente");
                }

                // Cerrar la conexión
                conn.Close();

            }
            else if(rbPedido.Checked == true)
            {
                // Crear una nueva conexión a la base de datos
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8UT0V1G\DI_SQLSERVER;Initial Catalog=GestionPedidos;Persist Security Info=True;User ID=sa;Password=isaac");

                // Abrir la conexión
                conn.Open();

                // Crear una consulta SQL parametrizada para insertar un nuevo pedido
                string query = "INSERT INTO Pedido (cCliente, fecha, formaPago) VALUES (@cCliente, @fecha, @formaPago)";

                // Crear un objeto SqlCommand y asignar la consulta y la conexión
                SqlCommand cmd = new SqlCommand(query, conn);

                // Asignar los parámetros de la consulta
                cmd.Parameters.AddWithValue("@cCliente", cbClientes.Text);
                cmd.Parameters.AddWithValue("@fecha", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@formaPago", tbPago.Text);

                // Ejecutar la consulta
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Pedido insertado");
                }
                else
                {
                    MessageBox.Show("Error al insertado pedido");
                }

                // Cerrar la conexión
                conn.Close();
            }


            cleanTextBoxes();


        }

        private void cleanTextBoxes()
        {
            tbSecc.Text = String.Empty;
            tbNomArt.Text = String.Empty;
            tbPrecio.Text = String.Empty;
            tbPais.Text = String.Empty;
            tbNombreCl.Text = String.Empty;
            tbDireccion.Text = String.Empty;
            tbTelefono.Text = String.Empty;
            tbPoblacion.Text = String.Empty;
            cbClientes.Text = String.Empty;
            tbPago.Text = String.Empty;
            dateTimePicker1.Text = String.Empty;
        }

        private void rbArticulo_CheckedChanged(object sender, EventArgs e)
        {
            etSeccion.Visible = true;
            etNomArt.Visible = true;
            etPrecio.Visible = true;
            etPais.Visible = true;
            dateTimePicker1.Visible = true;
            tbPrecio.Visible = true;
            tbSecc.Visible = true;
            tbNomArt.Visible = true;
            tbPais.Visible = true;

            etCodCl.Visible = false;
            etPago.Visible = false;
            cbClientes.Visible = false;
            tbPago.Visible = false;
            etNomC.Visible = false;
            etDirecc.Visible = false;
            etPobl.Visible = false;
            etTelef.Visible = false;
            tbDireccion.Visible = false;
            tbNombreCl.Visible = false;
            tbPoblacion.Visible = false;
            tbTelefono.Visible = false;
        }

        private void rbCliente_CheckedChanged(object sender, EventArgs e)
        {


            etNomC.Visible = true;
            etDirecc.Visible = true;
            etPobl.Visible = true;
            etTelef.Visible = true;
            tbDireccion.Visible = true;
            tbNombreCl.Visible = true;
            tbPoblacion.Visible = true;
            tbTelefono.Visible = true;

            etCodCl.Visible = false;
            etPago.Visible = false;
            dateTimePicker1.Visible = false;
            cbClientes.Visible = false;
            tbPago.Visible = false;

            etSeccion.Visible = false;
            etNomArt.Visible = false;
            etPrecio.Visible = false;
            etPais.Visible = false;
            dateTimePicker1.Visible = false;
            tbPrecio.Visible = false;
            tbSecc.Visible = false;
            tbNomArt.Visible = false;
            tbPais.Visible = false;
        }

        private void rbPedido_CheckedChanged(object sender, EventArgs e)
        {

            cbBox_cCliente();

            etCodCl.Visible = true;
            etPago.Visible = true;
            dateTimePicker1.Visible = true;
            cbClientes.Visible = true;
            tbPago.Visible = true;

            etNomC.Visible = false;
            etDirecc.Visible = false;
            etPobl.Visible = false;
            etTelef.Visible = false;
            tbDireccion.Visible = false;
            tbNombreCl.Visible = false;
            tbPoblacion.Visible = false;
            tbTelefono.Visible = false;

            etSeccion.Visible = false;
            etNomArt.Visible = false;
            etPrecio.Visible = false;
            etPais.Visible = false;
            tbPrecio.Visible = false;
            tbSecc.Visible = false;
            tbNomArt.Visible = false;
            tbPais.Visible = false;
        }
    }
}
