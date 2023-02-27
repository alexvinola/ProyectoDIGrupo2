namespace ProyectoGrupo2
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.buttonArticulo = new System.Windows.Forms.Button();
            this.botonCliente = new System.Windows.Forms.Button();
            this.buttonPedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "VOLVER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Borrar Articulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Borrar Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Borrar Pedido";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(202, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(202, 106);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(252, 24);
            this.comboBox2.TabIndex = 8;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(202, 154);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(252, 24);
            this.comboBox3.TabIndex = 9;
            // 
            // buttonArticulo
            // 
            this.buttonArticulo.Location = new System.Drawing.Point(498, 58);
            this.buttonArticulo.Name = "buttonArticulo";
            this.buttonArticulo.Size = new System.Drawing.Size(75, 23);
            this.buttonArticulo.TabIndex = 10;
            this.buttonArticulo.Text = "Borrar";
            this.buttonArticulo.UseVisualStyleBackColor = true;
            this.buttonArticulo.Click += new System.EventHandler(this.buttonArticulo_Click);
            // 
            // botonCliente
            // 
            this.botonCliente.Location = new System.Drawing.Point(498, 107);
            this.botonCliente.Name = "botonCliente";
            this.botonCliente.Size = new System.Drawing.Size(75, 23);
            this.botonCliente.TabIndex = 11;
            this.botonCliente.Text = "Borrar";
            this.botonCliente.UseVisualStyleBackColor = true;
            this.botonCliente.Click += new System.EventHandler(this.botonCliente_Click);
            // 
            // buttonPedido
            // 
            this.buttonPedido.Location = new System.Drawing.Point(498, 154);
            this.buttonPedido.Name = "buttonPedido";
            this.buttonPedido.Size = new System.Drawing.Size(75, 23);
            this.buttonPedido.TabIndex = 12;
            this.buttonPedido.Text = "Borrar";
            this.buttonPedido.UseVisualStyleBackColor = true;
            this.buttonPedido.Click += new System.EventHandler(this.buttonPedido_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 275);
            this.Controls.Add(this.buttonPedido);
            this.Controls.Add(this.botonCliente);
            this.Controls.Add(this.buttonArticulo);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button buttonArticulo;
        private System.Windows.Forms.Button botonCliente;
        private System.Windows.Forms.Button buttonPedido;
    }
}