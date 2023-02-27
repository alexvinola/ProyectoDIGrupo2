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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoGrupo2
{
    public partial class Form4 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8UT0V1G\DI_SQLSERVER;Initial Catalog=GestionPedidos;Persist Security Info=True;User ID=sa;Password=isaac");
        public Form4()
        {
            InitializeComponent();
           
        }

        private void itemComboBoxPedidoId()
        {
            //Limpiamos todos los items del ComboBox del Id
            cbId.Items.Clear();
            //Abrimos la conexión
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select id from Pedido";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                cbId.Items.Add(dr["id"].ToString());
            }


            conn.Close();
        }

        private void itemComboBoxArticuloId()
        {
            cbId.Items.Clear();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select id from articulo";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cbId.Items.Add(dr["id"].ToString());
            }


            conn.Close();
        }

        private void itemComboBoxClienteId()
        {
            cbId.Items.Clear();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select id from cliente";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cbId.Items.Add(dr["id"].ToString());
            }


            conn.Close();
        }

        private void itemComboBoxPedidoCod()
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

       

        private void button1_Click(object sender, EventArgs e)
        {

            if (rbPedido.Checked == true)
            {
               
                // Crear una nueva conexión a la base de datos
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8UT0V1G\DI_SQLSERVER;Initial Catalog=GestionPedidos;Persist Security Info=True;User ID=sa;Password=isaac");

                // Abrir la conexión
                conn.Open();

                // Crear una consulta SQL parametrizada para insertar un nuevo pedido
                string query = "UPDATE Pedido SET fecha = @fecha, formaPago = @formaPago, cCliente = @cCliente WHERE id = @id";

                // Crear un objeto SqlCommand y asignar la consulta y la conexión
                SqlCommand cmd = new SqlCommand(query, conn);

                // Asignar los parámetros de la consulta
                cmd.Parameters.AddWithValue("@id", cbId.Text);
                cmd.Parameters.AddWithValue("@cCliente", cbClientes.Text);
                cmd.Parameters.AddWithValue("@fecha", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@formaPago", tbPago.Text);

                // Ejecutar la consulta
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Pedido actualizado");
                }
                else
                {
                    MessageBox.Show("Error al actualizar pedido");
                }

                // Cerrar la conexión
                conn.Close();
            }
            else if (rbCliente.Checked == true)
            {
                // Crear una nueva conexión a la base de datos
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8UT0V1G\DI_SQLSERVER;Initial Catalog=GestionPedidos;Persist Security Info=True;User ID=sa;Password=isaac");

                // Abrir la conexión
                conn.Open();

                // Crear una consulta SQL parametrizada para insertar un nuevo pedido
                string query = "UPDATE cliente SET nombreCliente = @nombre, direccion = @direccion, poblacion = @poblacion, telefono = @telefono WHERE id = @id";

                // Crear un objeto SqlCommand y asignar la consulta y la conexión
                SqlCommand cmd = new SqlCommand(query, conn);

                // Asignar los parámetros de la consulta
                cmd.Parameters.AddWithValue("@id", cbId.Text);
                cmd.Parameters.AddWithValue("@nombre", tbNombreCl.Text);
                cmd.Parameters.AddWithValue("@direccion", tbDireccion.Text);
                cmd.Parameters.AddWithValue("@poblacion", tbPoblacion.Text);
                cmd.Parameters.AddWithValue("@telefono",tbTelefono.Text);

                // Ejecutar la consulta
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cliente actualizado");
                }
                else
                {
                    MessageBox.Show("Error al actualizar cliente");
                }

                // Cerrar la conexión
                conn.Close();
            }else if(rbArticulo.Checked == true)
            {
                // Crear una nueva conexión a la base de datos
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8UT0V1G\DI_SQLSERVER;Initial Catalog=GestionPedidos;Persist Security Info=True;User ID=sa;Password=isaac");

                // Abrir la conexión
                conn.Open();

                // Crear una consulta SQL parametrizada para insertar un nuevo pedido
                string query = "UPDATE articulo SET seccion = @seccion, nombreArticulo = @nombre, precio = @precio, fecha = @fecha, paisOrigen = @pais WHERE id = @id";

                // Crear un objeto SqlCommand y asignar la consulta y la conexión
                SqlCommand cmd = new SqlCommand(query, conn);

                // Asignar los parámetros de la consulta
                cmd.Parameters.AddWithValue("@id", cbId.Text);
                cmd.Parameters.AddWithValue("@seccion", tbSecc.Text);
                cmd.Parameters.AddWithValue("@nombre", tbNomArt.Text);
                cmd.Parameters.AddWithValue("@precio", Int32.Parse(tbPrecio.Text));
                cmd.Parameters.AddWithValue("@fecha", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@pais", tbPais.Text);

                // Ejecutar la consulta
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Articulo actualizado");
                }
                else
                {
                    MessageBox.Show("Error al actualizar articulo");
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void rbArticulo_CheckedChanged(object sender, EventArgs e)
        {

            itemComboBoxArticuloId();

            etSeccion.Visible= true;
            etNomArt.Visible= true;
            etPrecio.Visible= true;
            etPais.Visible= true;
            dateTimePicker1.Visible= true;
            tbPrecio.Visible= true;
            tbSecc.Visible= true;
            tbNomArt.Visible= true;
            tbPais.Visible= true;

            etCodC.Visible = false;
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
            itemComboBoxClienteId();

            etNomC.Visible = true;
            etDirecc.Visible = true;
            etPobl.Visible = true;
            etTelef.Visible = true;
            tbDireccion.Visible = true;
            tbNombreCl.Visible = true;
            tbPoblacion.Visible = true;
            tbTelefono.Visible = true;

            etCodC.Visible = false;
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

            itemComboBoxPedidoId();
            itemComboBoxPedidoCod();

            etCodC.Visible = true;
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
