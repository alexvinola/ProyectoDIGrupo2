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
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8UT0V1G\DI_SQLSERVER;Initial Catalog=GestionPedidos;Persist Security Info=True;User ID=sa;Password=isaac");
        public Form2()
        {
            InitializeComponent();
            //combobox items add from database
            itemComboBox("articulo", "nombreArticulo");
            itemComboBox("cliente", "nombreCliente");
            itemComboBox("Pedido", "Id");

        }

        private void itemComboBox(String tableName, String variable)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select nombre from Cliente";
            cmd.CommandText = "select " + variable + " from " + tableName;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (tableName == "Pedido")
            {
                foreach (DataRow dr in dt.Rows)
                {
                    comboBox3.Items.Add(dr["Id"].ToString());
                }
            }
            else if(tableName == "articulo") { 
            
                foreach (DataRow dr in dt.Rows)
                {
                comboBox1.Items.Add(dr["nombreArticulo"].ToString());
                }
            }
            else if (tableName == "cliente")
            {
                foreach (DataRow dr in dt.Rows)
                {
                    comboBox2.Items.Add(dr["nombreCliente"].ToString());
                }
            }



                conn.Close();
        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonArticulo_Click(object sender, EventArgs e)
        {
            //Borrar articulo de la base de datos seleccionado en el combobox
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from articulo where nombreArticulo = '" + comboBox1.Text + "'";
            
            int cmdint = cmd.ExecuteNonQuery();
            //si el articulo no existe
            if (cmdint == 0)
            {
                MessageBox.Show("Articulo no existe");
                conn.Close();
                return;
            }
            conn.Close();
            MessageBox.Show("Articulo borrado");
            //actualizar combobox
            comboBox1.Items.Clear();
            itemComboBox("articulo", "nombreArticulo");

        }

        private void botonCliente_Click(object sender, EventArgs e)
        {
            //Borrar articulo de la base de datos seleccionado en el combobox
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from cliente where nombreCliente = '" + comboBox1.Text + "'";
            int cmdint = cmd.ExecuteNonQuery();
            //si el articulo no existe
            if (cmdint == 0)
            {
                MessageBox.Show("Cliente no existe");
                conn.Close();
                return;
            }
            conn.Close();
            MessageBox.Show("Cliente borrado");
            //actualizar combobox
            comboBox1.Items.Clear();
            itemComboBox("cliente", "nombreCliente");
        }

        private void buttonPedido_Click(object sender, EventArgs e)
        {
            //Borrar articulo de la base de datos seleccionado en el combobox
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Pedido where id = '" + comboBox1.Text + "'";
            int cmdint = cmd.ExecuteNonQuery();
            //si el articulo no existe
            if (cmdint == 0)
            {
                MessageBox.Show("Pedido no existe");
                conn.Close();
                return;
            }
            conn.Close();
            MessageBox.Show("Pedido borrado");
            //actualizar combobox
            comboBox1.Items.Clear();
            itemComboBox("Pedido", "Id");
        }
    }
}
