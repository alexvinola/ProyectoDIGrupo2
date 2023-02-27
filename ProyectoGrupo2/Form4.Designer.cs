namespace ProyectoGrupo2
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMod = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.etPago = new System.Windows.Forms.Label();
            this.cbId = new System.Windows.Forms.ComboBox();
            this.tbPago = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.etCodC = new System.Windows.Forms.Label();
            this.rbArticulo = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.rbPedido = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.etNomC = new System.Windows.Forms.Label();
            this.tbNombreCl = new System.Windows.Forms.TextBox();
            this.etDirecc = new System.Windows.Forms.Label();
            this.etPobl = new System.Windows.Forms.Label();
            this.etTelef = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbPoblacion = new System.Windows.Forms.TextBox();
            this.etSeccion = new System.Windows.Forms.Label();
            this.etNomArt = new System.Windows.Forms.Label();
            this.etPais = new System.Windows.Forms.Label();
            this.etPrecio = new System.Windows.Forms.Label();
            this.tbNomArt = new System.Windows.Forms.TextBox();
            this.tbSecc = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(518, 374);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 23);
            this.btnMod.TabIndex = 0;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(159, 374);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(58, 87);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(83, 16);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Identificador:";
            // 
            // etPago
            // 
            this.etPago.AutoSize = true;
            this.etPago.Location = new System.Drawing.Point(41, 237);
            this.etPago.Name = "etPago";
            this.etPago.Size = new System.Drawing.Size(103, 16);
            this.etPago.TabIndex = 3;
            this.etPago.Text = "Forma de pago:";
            this.etPago.Visible = false;
            // 
            // cbId
            // 
            this.cbId.FormattingEnabled = true;
            this.cbId.Location = new System.Drawing.Point(147, 84);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(121, 24);
            this.cbId.TabIndex = 4;
            // 
            // tbPago
            // 
            this.tbPago.Location = new System.Drawing.Point(162, 231);
            this.tbPago.Name = "tbPago";
            this.tbPago.Size = new System.Drawing.Size(100, 22);
            this.tbPago.TabIndex = 5;
            this.tbPago.Visible = false;
            this.tbPago.WordWrap = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(454, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 22);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2023, 2, 23, 0, 0, 0, 0);
            this.dateTimePicker1.Visible = false;
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(133, 201);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(121, 24);
            this.cbClientes.TabIndex = 7;
            this.cbClientes.Visible = false;
            // 
            // etCodC
            // 
            this.etCodC.AutoSize = true;
            this.etCodC.Location = new System.Drawing.Point(58, 209);
            this.etCodC.Name = "etCodC";
            this.etCodC.Size = new System.Drawing.Size(58, 16);
            this.etCodC.TabIndex = 8;
            this.etCodC.Text = "cCliente:";
            this.etCodC.Visible = false;
            // 
            // rbArticulo
            // 
            this.rbArticulo.AutoSize = true;
            this.rbArticulo.Location = new System.Drawing.Point(6, 21);
            this.rbArticulo.Name = "rbArticulo";
            this.rbArticulo.Size = new System.Drawing.Size(72, 20);
            this.rbArticulo.TabIndex = 9;
            this.rbArticulo.TabStop = true;
            this.rbArticulo.Text = "Articulo";
            this.rbArticulo.UseVisualStyleBackColor = true;
            this.rbArticulo.CheckedChanged += new System.EventHandler(this.rbArticulo_CheckedChanged);
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(121, 21);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(69, 20);
            this.rbCliente.TabIndex = 10;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            this.rbCliente.CheckedChanged += new System.EventHandler(this.rbCliente_CheckedChanged);
            // 
            // rbPedido
            // 
            this.rbPedido.AutoSize = true;
            this.rbPedido.Location = new System.Drawing.Point(246, 21);
            this.rbPedido.Name = "rbPedido";
            this.rbPedido.Size = new System.Drawing.Size(72, 20);
            this.rbPedido.TabIndex = 11;
            this.rbPedido.TabStop = true;
            this.rbPedido.Text = "Pedido";
            this.rbPedido.UseVisualStyleBackColor = true;
            this.rbPedido.CheckedChanged += new System.EventHandler(this.rbPedido_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbArticulo);
            this.groupBox1.Controls.Add(this.rbPedido);
            this.groupBox1.Controls.Add(this.rbCliente);
            this.groupBox1.Location = new System.Drawing.Point(38, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 47);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tablas de la Base de Datos";
            // 
            // etNomC
            // 
            this.etNomC.AutoSize = true;
            this.etNomC.Location = new System.Drawing.Point(58, 138);
            this.etNomC.Name = "etNomC";
            this.etNomC.Size = new System.Drawing.Size(98, 16);
            this.etNomC.TabIndex = 13;
            this.etNomC.Text = "Nombre cliente";
            this.etNomC.Visible = false;
            // 
            // tbNombreCl
            // 
            this.tbNombreCl.Location = new System.Drawing.Point(174, 131);
            this.tbNombreCl.Name = "tbNombreCl";
            this.tbNombreCl.Size = new System.Drawing.Size(131, 22);
            this.tbNombreCl.TabIndex = 14;
            this.tbNombreCl.Visible = false;
            // 
            // etDirecc
            // 
            this.etDirecc.AutoSize = true;
            this.etDirecc.Location = new System.Drawing.Point(61, 169);
            this.etDirecc.Name = "etDirecc";
            this.etDirecc.Size = new System.Drawing.Size(64, 16);
            this.etDirecc.TabIndex = 15;
            this.etDirecc.Text = "Dirección";
            this.etDirecc.Visible = false;
            // 
            // etPobl
            // 
            this.etPobl.AutoSize = true;
            this.etPobl.Location = new System.Drawing.Point(390, 131);
            this.etPobl.Name = "etPobl";
            this.etPobl.Size = new System.Drawing.Size(68, 16);
            this.etPobl.TabIndex = 16;
            this.etPobl.Text = "Población";
            this.etPobl.Visible = false;
            // 
            // etTelef
            // 
            this.etTelef.AutoSize = true;
            this.etTelef.Location = new System.Drawing.Point(390, 169);
            this.etTelef.Name = "etTelef";
            this.etTelef.Size = new System.Drawing.Size(61, 16);
            this.etTelef.TabIndex = 17;
            this.etTelef.Text = "Teléfono";
            this.etTelef.Visible = false;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(159, 162);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(100, 22);
            this.tbDireccion.TabIndex = 18;
            this.tbDireccion.Visible = false;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(476, 169);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(100, 22);
            this.tbTelefono.TabIndex = 19;
            this.tbTelefono.Visible = false;
            // 
            // tbPoblacion
            // 
            this.tbPoblacion.Location = new System.Drawing.Point(476, 132);
            this.tbPoblacion.Name = "tbPoblacion";
            this.tbPoblacion.Size = new System.Drawing.Size(100, 22);
            this.tbPoblacion.TabIndex = 20;
            this.tbPoblacion.Visible = false;
            // 
            // etSeccion
            // 
            this.etSeccion.AutoSize = true;
            this.etSeccion.Location = new System.Drawing.Point(61, 122);
            this.etSeccion.Name = "etSeccion";
            this.etSeccion.Size = new System.Drawing.Size(59, 16);
            this.etSeccion.TabIndex = 21;
            this.etSeccion.Text = "Sección:";
            this.etSeccion.Visible = false;
            // 
            // etNomArt
            // 
            this.etNomArt.AutoSize = true;
            this.etNomArt.Location = new System.Drawing.Point(64, 158);
            this.etNomArt.Name = "etNomArt";
            this.etNomArt.Size = new System.Drawing.Size(106, 16);
            this.etNomArt.TabIndex = 22;
            this.etNomArt.Text = "Nombre Articulo:";
            this.etNomArt.Visible = false;
            // 
            // etPais
            // 
            this.etPais.AutoSize = true;
            this.etPais.Location = new System.Drawing.Point(407, 147);
            this.etPais.Name = "etPais";
            this.etPais.Size = new System.Drawing.Size(99, 16);
            this.etPais.TabIndex = 23;
            this.etPais.Text = "Pais de Origen:";
            this.etPais.Visible = false;
            // 
            // etPrecio
            // 
            this.etPrecio.AutoSize = true;
            this.etPrecio.Location = new System.Drawing.Point(75, 208);
            this.etPrecio.Name = "etPrecio";
            this.etPrecio.Size = new System.Drawing.Size(49, 16);
            this.etPrecio.TabIndex = 24;
            this.etPrecio.Text = "Precio:";
            this.etPrecio.Visible = false;
            // 
            // tbNomArt
            // 
            this.tbNomArt.Location = new System.Drawing.Point(186, 151);
            this.tbNomArt.Name = "tbNomArt";
            this.tbNomArt.Size = new System.Drawing.Size(100, 22);
            this.tbNomArt.TabIndex = 25;
            this.tbNomArt.Visible = false;
            // 
            // tbSecc
            // 
            this.tbSecc.Location = new System.Drawing.Point(163, 122);
            this.tbSecc.Name = "tbSecc";
            this.tbSecc.Size = new System.Drawing.Size(100, 22);
            this.tbSecc.TabIndex = 26;
            this.tbSecc.Visible = false;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(133, 203);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(100, 22);
            this.tbPrecio.TabIndex = 27;
            this.tbPrecio.Visible = false;
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(518, 141);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(100, 22);
            this.tbPais.TabIndex = 28;
            this.tbPais.Visible = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbPais);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbSecc);
            this.Controls.Add(this.tbNomArt);
            this.Controls.Add(this.etPrecio);
            this.Controls.Add(this.etPais);
            this.Controls.Add(this.etNomArt);
            this.Controls.Add(this.etSeccion);
            this.Controls.Add(this.tbPoblacion);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.etTelef);
            this.Controls.Add(this.etPobl);
            this.Controls.Add(this.etDirecc);
            this.Controls.Add(this.tbNombreCl);
            this.Controls.Add(this.etNomC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.etCodC);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbPago);
            this.Controls.Add(this.cbId);
            this.Controls.Add(this.etPago);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnMod);
            this.Name = "Form4";
            this.Text = "Form4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label etPago;
        private System.Windows.Forms.ComboBox cbId;
        private System.Windows.Forms.TextBox tbPago;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.Label etCodC;
        private System.Windows.Forms.RadioButton rbArticulo;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.RadioButton rbPedido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label etNomC;
        private System.Windows.Forms.TextBox tbNombreCl;
        private System.Windows.Forms.Label etDirecc;
        private System.Windows.Forms.Label etPobl;
        private System.Windows.Forms.Label etTelef;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbPoblacion;
        private System.Windows.Forms.Label etSeccion;
        private System.Windows.Forms.Label etNomArt;
        private System.Windows.Forms.Label etPais;
        private System.Windows.Forms.Label etPrecio;
        private System.Windows.Forms.TextBox tbNomArt;
        private System.Windows.Forms.TextBox tbSecc;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbPais;
    }
}

