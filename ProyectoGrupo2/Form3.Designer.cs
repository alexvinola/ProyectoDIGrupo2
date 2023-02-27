namespace ProyectoGrupo2
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbPago = new System.Windows.Forms.TextBox();
            this.etCodCl = new System.Windows.Forms.Label();
            this.etPago = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbArticulo = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.rbPedido = new System.Windows.Forms.RadioButton();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbSecc = new System.Windows.Forms.TextBox();
            this.tbNomArt = new System.Windows.Forms.TextBox();
            this.etPrecio = new System.Windows.Forms.Label();
            this.etPais = new System.Windows.Forms.Label();
            this.etNomArt = new System.Windows.Forms.Label();
            this.etSeccion = new System.Windows.Forms.Label();
            this.tbPoblacion = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.etTelef = new System.Windows.Forms.Label();
            this.etPobl = new System.Windows.Forms.Label();
            this.etDirecc = new System.Windows.Forms.Label();
            this.tbNombreCl = new System.Windows.Forms.TextBox();
            this.etNomC = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 450);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(656, 450);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Alta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbPago
            // 
            this.tbPago.Location = new System.Drawing.Point(196, 223);
            this.tbPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPago.Name = "tbPago";
            this.tbPago.Size = new System.Drawing.Size(155, 22);
            this.tbPago.TabIndex = 3;
            // 
            // etCodCl
            // 
            this.etCodCl.AutoSize = true;
            this.etCodCl.Location = new System.Drawing.Point(80, 110);
            this.etCodCl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.etCodCl.Name = "etCodCl";
            this.etCodCl.Size = new System.Drawing.Size(96, 16);
            this.etCodCl.TabIndex = 4;
            this.etCodCl.Text = "Código cliente:";
            // 
            // etPago
            // 
            this.etPago.AutoSize = true;
            this.etPago.Location = new System.Drawing.Point(80, 226);
            this.etPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.etPago.Name = "etPago";
            this.etPago.Size = new System.Drawing.Size(103, 16);
            this.etPago.TabIndex = 5;
            this.etPago.Text = "Forma de pago:";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(191, 107);
            this.cbClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(160, 24);
            this.cbClientes.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPedido);
            this.groupBox1.Controls.Add(this.rbCliente);
            this.groupBox1.Controls.Add(this.rbArticulo);
            this.groupBox1.Location = new System.Drawing.Point(83, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 45);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tablas";
            // 
            // rbArticulo
            // 
            this.rbArticulo.AutoSize = true;
            this.rbArticulo.Location = new System.Drawing.Point(7, 19);
            this.rbArticulo.Name = "rbArticulo";
            this.rbArticulo.Size = new System.Drawing.Size(72, 20);
            this.rbArticulo.TabIndex = 0;
            this.rbArticulo.TabStop = true;
            this.rbArticulo.Text = "Artículo";
            this.rbArticulo.UseVisualStyleBackColor = true;
            this.rbArticulo.CheckedChanged += new System.EventHandler(this.rbArticulo_CheckedChanged);
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(117, 18);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(69, 20);
            this.rbCliente.TabIndex = 1;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            this.rbCliente.CheckedChanged += new System.EventHandler(this.rbCliente_CheckedChanged);
            // 
            // rbPedido
            // 
            this.rbPedido.AutoSize = true;
            this.rbPedido.Location = new System.Drawing.Point(226, 19);
            this.rbPedido.Name = "rbPedido";
            this.rbPedido.Size = new System.Drawing.Size(72, 20);
            this.rbPedido.TabIndex = 2;
            this.rbPedido.TabStop = true;
            this.rbPedido.Text = "Pedido";
            this.rbPedido.UseVisualStyleBackColor = true;
            this.rbPedido.CheckedChanged += new System.EventHandler(this.rbPedido_CheckedChanged);
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(656, 240);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(100, 22);
            this.tbPais.TabIndex = 52;
            this.tbPais.Visible = false;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(145, 348);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(100, 22);
            this.tbPrecio.TabIndex = 51;
            this.tbPrecio.Visible = false;
            // 
            // tbSecc
            // 
            this.tbSecc.Location = new System.Drawing.Point(191, 142);
            this.tbSecc.Name = "tbSecc";
            this.tbSecc.Size = new System.Drawing.Size(100, 22);
            this.tbSecc.TabIndex = 50;
            this.tbSecc.Visible = false;
            // 
            // tbNomArt
            // 
            this.tbNomArt.Location = new System.Drawing.Point(200, 265);
            this.tbNomArt.Name = "tbNomArt";
            this.tbNomArt.Size = new System.Drawing.Size(100, 22);
            this.tbNomArt.TabIndex = 49;
            this.tbNomArt.Visible = false;
            // 
            // etPrecio
            // 
            this.etPrecio.AutoSize = true;
            this.etPrecio.Location = new System.Drawing.Point(66, 348);
            this.etPrecio.Name = "etPrecio";
            this.etPrecio.Size = new System.Drawing.Size(49, 16);
            this.etPrecio.TabIndex = 48;
            this.etPrecio.Text = "Precio:";
            this.etPrecio.Visible = false;
            // 
            // etPais
            // 
            this.etPais.AutoSize = true;
            this.etPais.Location = new System.Drawing.Point(543, 240);
            this.etPais.Name = "etPais";
            this.etPais.Size = new System.Drawing.Size(99, 16);
            this.etPais.TabIndex = 47;
            this.etPais.Text = "Pais de Origen:";
            this.etPais.Visible = false;
            // 
            // etNomArt
            // 
            this.etNomArt.AutoSize = true;
            this.etNomArt.Location = new System.Drawing.Point(78, 268);
            this.etNomArt.Name = "etNomArt";
            this.etNomArt.Size = new System.Drawing.Size(106, 16);
            this.etNomArt.TabIndex = 46;
            this.etNomArt.Text = "Nombre Articulo:";
            this.etNomArt.Visible = false;
            // 
            // etSeccion
            // 
            this.etSeccion.AutoSize = true;
            this.etSeccion.Location = new System.Drawing.Point(80, 148);
            this.etSeccion.Name = "etSeccion";
            this.etSeccion.Size = new System.Drawing.Size(59, 16);
            this.etSeccion.TabIndex = 45;
            this.etSeccion.Text = "Sección:";
            this.etSeccion.Visible = false;
            // 
            // tbPoblacion
            // 
            this.tbPoblacion.Location = new System.Drawing.Point(630, 157);
            this.tbPoblacion.Name = "tbPoblacion";
            this.tbPoblacion.Size = new System.Drawing.Size(100, 22);
            this.tbPoblacion.TabIndex = 44;
            this.tbPoblacion.Visible = false;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(630, 195);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(100, 22);
            this.tbTelefono.TabIndex = 43;
            this.tbTelefono.Visible = false;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(145, 302);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(100, 22);
            this.tbDireccion.TabIndex = 42;
            this.tbDireccion.Visible = false;
            // 
            // etTelef
            // 
            this.etTelef.AutoSize = true;
            this.etTelef.Location = new System.Drawing.Point(543, 201);
            this.etTelef.Name = "etTelef";
            this.etTelef.Size = new System.Drawing.Size(61, 16);
            this.etTelef.TabIndex = 41;
            this.etTelef.Text = "Teléfono";
            this.etTelef.Visible = false;
            // 
            // etPobl
            // 
            this.etPobl.AutoSize = true;
            this.etPobl.Location = new System.Drawing.Point(543, 157);
            this.etPobl.Name = "etPobl";
            this.etPobl.Size = new System.Drawing.Size(68, 16);
            this.etPobl.TabIndex = 40;
            this.etPobl.Text = "Población";
            this.etPobl.Visible = false;
            // 
            // etDirecc
            // 
            this.etDirecc.AutoSize = true;
            this.etDirecc.Location = new System.Drawing.Point(66, 305);
            this.etDirecc.Name = "etDirecc";
            this.etDirecc.Size = new System.Drawing.Size(64, 16);
            this.etDirecc.TabIndex = 39;
            this.etDirecc.Text = "Dirección";
            this.etDirecc.Visible = false;
            // 
            // tbNombreCl
            // 
            this.tbNombreCl.Location = new System.Drawing.Point(191, 183);
            this.tbNombreCl.Name = "tbNombreCl";
            this.tbNombreCl.Size = new System.Drawing.Size(131, 22);
            this.tbNombreCl.TabIndex = 38;
            this.tbNombreCl.Visible = false;
            // 
            // etNomC
            // 
            this.etNomC.AutoSize = true;
            this.etNomC.Location = new System.Drawing.Point(78, 189);
            this.etNomC.Name = "etNomC";
            this.etNomC.Size = new System.Drawing.Size(98, 16);
            this.etNomC.TabIndex = 37;
            this.etNomC.Text = "Nombre cliente";
            this.etNomC.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(546, 110);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 22);
            this.dateTimePicker1.TabIndex = 33;
            this.dateTimePicker1.Value = new System.DateTime(2023, 2, 23, 0, 0, 0, 0);
            this.dateTimePicker1.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.etPago);
            this.Controls.Add(this.etCodCl);
            this.Controls.Add(this.tbPago);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbPago;
        private System.Windows.Forms.Label etCodCl;
        private System.Windows.Forms.Label etPago;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPedido;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.RadioButton rbArticulo;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbSecc;
        private System.Windows.Forms.TextBox tbNomArt;
        private System.Windows.Forms.Label etPrecio;
        private System.Windows.Forms.Label etPais;
        private System.Windows.Forms.Label etNomArt;
        private System.Windows.Forms.Label etSeccion;
        private System.Windows.Forms.TextBox tbPoblacion;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label etTelef;
        private System.Windows.Forms.Label etPobl;
        private System.Windows.Forms.Label etDirecc;
        private System.Windows.Forms.TextBox tbNombreCl;
        private System.Windows.Forms.Label etNomC;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
