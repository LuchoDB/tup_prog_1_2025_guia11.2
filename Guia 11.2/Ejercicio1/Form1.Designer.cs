namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.boxPedirNum = new System.Windows.Forms.GroupBox();
            this.btnRegistrarNum = new System.Windows.Forms.Button();
            this.tbPedirNumero = new System.Windows.Forms.TextBox();
            this.lbPedirNum = new System.Windows.Forms.Label();
            this.boxMaxMin = new System.Windows.Forms.GroupBox();
            this.btnActualizarMaxYMin = new System.Windows.Forms.Button();
            this.lbMostrarMinimo = new System.Windows.Forms.Label();
            this.lbMostrarMaximo = new System.Windows.Forms.Label();
            this.lbTituloMinimo = new System.Windows.Forms.Label();
            this.lbTituloMaximo = new System.Windows.Forms.Label();
            this.boxPromedio = new System.Windows.Forms.GroupBox();
            this.btnActualizarPromedio = new System.Windows.Forms.Button();
            this.lbMostrarPromedio = new System.Windows.Forms.Label();
            this.lbTituloPromedio = new System.Windows.Forms.Label();
            this.boxCantidad = new System.Windows.Forms.GroupBox();
            this.btnActualizarCant = new System.Windows.Forms.Button();
            this.lbMostrarCantidad = new System.Windows.Forms.Label();
            this.lbTituloCantidad = new System.Windows.Forms.Label();
            this.boxValorBuscado = new System.Windows.Forms.GroupBox();
            this.btnBuscarValor = new System.Windows.Forms.Button();
            this.tbBuscarNumero = new System.Windows.Forms.TextBox();
            this.lbTituloValorBuscado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listaValores = new System.Windows.Forms.ListBox();
            this.btnMayorPromedio = new System.Windows.Forms.Button();
            this.btnListaOrdenada = new System.Windows.Forms.Button();
            this.boxPedirNum.SuspendLayout();
            this.boxMaxMin.SuspendLayout();
            this.boxPromedio.SuspendLayout();
            this.boxCantidad.SuspendLayout();
            this.boxValorBuscado.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxPedirNum
            // 
            this.boxPedirNum.Controls.Add(this.btnRegistrarNum);
            this.boxPedirNum.Controls.Add(this.tbPedirNumero);
            this.boxPedirNum.Controls.Add(this.lbPedirNum);
            this.boxPedirNum.Location = new System.Drawing.Point(12, 12);
            this.boxPedirNum.Name = "boxPedirNum";
            this.boxPedirNum.Size = new System.Drawing.Size(385, 112);
            this.boxPedirNum.TabIndex = 0;
            this.boxPedirNum.TabStop = false;
            this.boxPedirNum.Text = "Procesar un numero";
            // 
            // btnRegistrarNum
            // 
            this.btnRegistrarNum.Location = new System.Drawing.Point(104, 72);
            this.btnRegistrarNum.Name = "btnRegistrarNum";
            this.btnRegistrarNum.Size = new System.Drawing.Size(141, 23);
            this.btnRegistrarNum.TabIndex = 2;
            this.btnRegistrarNum.Text = "Registrar Numero";
            this.btnRegistrarNum.UseVisualStyleBackColor = true;
            this.btnRegistrarNum.Click += new System.EventHandler(this.btnRegistrarNum_Click);
            // 
            // tbPedirNumero
            // 
            this.tbPedirNumero.Location = new System.Drawing.Point(182, 31);
            this.tbPedirNumero.Name = "tbPedirNumero";
            this.tbPedirNumero.Size = new System.Drawing.Size(100, 22);
            this.tbPedirNumero.TabIndex = 1;
            // 
            // lbPedirNum
            // 
            this.lbPedirNum.AutoSize = true;
            this.lbPedirNum.Location = new System.Drawing.Point(23, 31);
            this.lbPedirNum.Name = "lbPedirNum";
            this.lbPedirNum.Size = new System.Drawing.Size(117, 16);
            this.lbPedirNum.TabIndex = 0;
            this.lbPedirNum.Text = "Ingrese un numero";
            // 
            // boxMaxMin
            // 
            this.boxMaxMin.Controls.Add(this.btnActualizarMaxYMin);
            this.boxMaxMin.Controls.Add(this.lbMostrarMinimo);
            this.boxMaxMin.Controls.Add(this.lbMostrarMaximo);
            this.boxMaxMin.Controls.Add(this.lbTituloMinimo);
            this.boxMaxMin.Controls.Add(this.lbTituloMaximo);
            this.boxMaxMin.Location = new System.Drawing.Point(12, 130);
            this.boxMaxMin.Name = "boxMaxMin";
            this.boxMaxMin.Size = new System.Drawing.Size(385, 116);
            this.boxMaxMin.TabIndex = 1;
            this.boxMaxMin.TabStop = false;
            this.boxMaxMin.Text = "Procesar Maximo y Minimo";
            // 
            // btnActualizarMaxYMin
            // 
            this.btnActualizarMaxYMin.Location = new System.Drawing.Point(285, 48);
            this.btnActualizarMaxYMin.Name = "btnActualizarMaxYMin";
            this.btnActualizarMaxYMin.Size = new System.Drawing.Size(75, 40);
            this.btnActualizarMaxYMin.TabIndex = 3;
            this.btnActualizarMaxYMin.Text = "Actualizar";
            this.btnActualizarMaxYMin.UseVisualStyleBackColor = true;
            this.btnActualizarMaxYMin.Click += new System.EventHandler(this.btnActualizarMaxYMin_Click);
            // 
            // lbMostrarMinimo
            // 
            this.lbMostrarMinimo.AutoSize = true;
            this.lbMostrarMinimo.Location = new System.Drawing.Point(137, 86);
            this.lbMostrarMinimo.Name = "lbMostrarMinimo";
            this.lbMostrarMinimo.Size = new System.Drawing.Size(61, 16);
            this.lbMostrarMinimo.TabIndex = 4;
            this.lbMostrarMinimo.Text = "lbMinimo";
            // 
            // lbMostrarMaximo
            // 
            this.lbMostrarMaximo.AutoSize = true;
            this.lbMostrarMaximo.Location = new System.Drawing.Point(137, 48);
            this.lbMostrarMaximo.Name = "lbMostrarMaximo";
            this.lbMostrarMaximo.Size = new System.Drawing.Size(65, 16);
            this.lbMostrarMaximo.TabIndex = 3;
            this.lbMostrarMaximo.Text = "lbMaximo";
            // 
            // lbTituloMinimo
            // 
            this.lbTituloMinimo.AutoSize = true;
            this.lbTituloMinimo.Location = new System.Drawing.Point(23, 86);
            this.lbTituloMinimo.Name = "lbTituloMinimo";
            this.lbTituloMinimo.Size = new System.Drawing.Size(53, 16);
            this.lbTituloMinimo.TabIndex = 2;
            this.lbTituloMinimo.Text = "Minimo:";
            // 
            // lbTituloMaximo
            // 
            this.lbTituloMaximo.AutoSize = true;
            this.lbTituloMaximo.Location = new System.Drawing.Point(23, 48);
            this.lbTituloMaximo.Name = "lbTituloMaximo";
            this.lbTituloMaximo.Size = new System.Drawing.Size(57, 16);
            this.lbTituloMaximo.TabIndex = 1;
            this.lbTituloMaximo.Text = "Maximo:";
            // 
            // boxPromedio
            // 
            this.boxPromedio.Controls.Add(this.btnActualizarPromedio);
            this.boxPromedio.Controls.Add(this.lbMostrarPromedio);
            this.boxPromedio.Controls.Add(this.lbTituloPromedio);
            this.boxPromedio.Location = new System.Drawing.Point(12, 252);
            this.boxPromedio.Name = "boxPromedio";
            this.boxPromedio.Size = new System.Drawing.Size(385, 97);
            this.boxPromedio.TabIndex = 1;
            this.boxPromedio.TabStop = false;
            this.boxPromedio.Text = "Procesar Promedio";
            // 
            // btnActualizarPromedio
            // 
            this.btnActualizarPromedio.Location = new System.Drawing.Point(285, 40);
            this.btnActualizarPromedio.Name = "btnActualizarPromedio";
            this.btnActualizarPromedio.Size = new System.Drawing.Size(75, 36);
            this.btnActualizarPromedio.TabIndex = 5;
            this.btnActualizarPromedio.Text = "Actualizar";
            this.btnActualizarPromedio.UseVisualStyleBackColor = true;
            this.btnActualizarPromedio.Click += new System.EventHandler(this.btnActualizarPromedio_Click);
            // 
            // lbMostrarPromedio
            // 
            this.lbMostrarPromedio.AutoSize = true;
            this.lbMostrarPromedio.Location = new System.Drawing.Point(137, 50);
            this.lbMostrarPromedio.Name = "lbMostrarPromedio";
            this.lbMostrarPromedio.Size = new System.Drawing.Size(77, 16);
            this.lbMostrarPromedio.TabIndex = 5;
            this.lbMostrarPromedio.Text = "lbPromedio";
            // 
            // lbTituloPromedio
            // 
            this.lbTituloPromedio.AutoSize = true;
            this.lbTituloPromedio.Location = new System.Drawing.Point(23, 50);
            this.lbTituloPromedio.Name = "lbTituloPromedio";
            this.lbTituloPromedio.Size = new System.Drawing.Size(69, 16);
            this.lbTituloPromedio.TabIndex = 3;
            this.lbTituloPromedio.Text = "Promedio:";
            // 
            // boxCantidad
            // 
            this.boxCantidad.Controls.Add(this.btnActualizarCant);
            this.boxCantidad.Controls.Add(this.lbMostrarCantidad);
            this.boxCantidad.Controls.Add(this.lbTituloCantidad);
            this.boxCantidad.Location = new System.Drawing.Point(12, 355);
            this.boxCantidad.Name = "boxCantidad";
            this.boxCantidad.Size = new System.Drawing.Size(385, 97);
            this.boxCantidad.TabIndex = 2;
            this.boxCantidad.TabStop = false;
            this.boxCantidad.Text = "Mostrar Cantidad de ingresados ";
            // 
            // btnActualizarCant
            // 
            this.btnActualizarCant.Location = new System.Drawing.Point(285, 46);
            this.btnActualizarCant.Name = "btnActualizarCant";
            this.btnActualizarCant.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarCant.TabIndex = 6;
            this.btnActualizarCant.Text = "Actualizar";
            this.btnActualizarCant.UseVisualStyleBackColor = true;
            this.btnActualizarCant.Click += new System.EventHandler(this.btnActualizarCant_Click);
            // 
            // lbMostrarCantidad
            // 
            this.lbMostrarCantidad.AutoSize = true;
            this.lbMostrarCantidad.Location = new System.Drawing.Point(137, 49);
            this.lbMostrarCantidad.Name = "lbMostrarCantidad";
            this.lbMostrarCantidad.Size = new System.Drawing.Size(72, 16);
            this.lbMostrarCantidad.TabIndex = 6;
            this.lbMostrarCantidad.Text = "lbCantidad";
            // 
            // lbTituloCantidad
            // 
            this.lbTituloCantidad.AutoSize = true;
            this.lbTituloCantidad.Location = new System.Drawing.Point(23, 49);
            this.lbTituloCantidad.Name = "lbTituloCantidad";
            this.lbTituloCantidad.Size = new System.Drawing.Size(64, 16);
            this.lbTituloCantidad.TabIndex = 4;
            this.lbTituloCantidad.Text = "Cantidad:";
            // 
            // boxValorBuscado
            // 
            this.boxValorBuscado.Controls.Add(this.btnBuscarValor);
            this.boxValorBuscado.Controls.Add(this.tbBuscarNumero);
            this.boxValorBuscado.Controls.Add(this.lbTituloValorBuscado);
            this.boxValorBuscado.Location = new System.Drawing.Point(489, 12);
            this.boxValorBuscado.Name = "boxValorBuscado";
            this.boxValorBuscado.Size = new System.Drawing.Size(236, 147);
            this.boxValorBuscado.TabIndex = 3;
            this.boxValorBuscado.TabStop = false;
            this.boxValorBuscado.Text = "Valor a Buscar";
            // 
            // btnBuscarValor
            // 
            this.btnBuscarValor.Location = new System.Drawing.Point(76, 106);
            this.btnBuscarValor.Name = "btnBuscarValor";
            this.btnBuscarValor.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarValor.TabIndex = 7;
            this.btnBuscarValor.Text = "Buscar";
            this.btnBuscarValor.UseVisualStyleBackColor = true;
            this.btnBuscarValor.Click += new System.EventHandler(this.btnBuscarValor_Click);
            // 
            // tbBuscarNumero
            // 
            this.tbBuscarNumero.Location = new System.Drawing.Point(76, 62);
            this.tbBuscarNumero.Name = "tbBuscarNumero";
            this.tbBuscarNumero.Size = new System.Drawing.Size(100, 22);
            this.tbBuscarNumero.TabIndex = 2;
            // 
            // lbTituloValorBuscado
            // 
            this.lbTituloValorBuscado.AutoSize = true;
            this.lbTituloValorBuscado.Location = new System.Drawing.Point(19, 43);
            this.lbTituloValorBuscado.Name = "lbTituloValorBuscado";
            this.lbTituloValorBuscado.Size = new System.Drawing.Size(98, 16);
            this.lbTituloValorBuscado.TabIndex = 5;
            this.lbTituloValorBuscado.Text = "Valor a Buscar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listaValores);
            this.groupBox1.Controls.Add(this.btnMayorPromedio);
            this.groupBox1.Controls.Add(this.btnListaOrdenada);
            this.groupBox1.Location = new System.Drawing.Point(474, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 283);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Procesar Promedio";
            // 
            // listaValores
            // 
            this.listaValores.FormattingEnabled = true;
            this.listaValores.ItemHeight = 16;
            this.listaValores.Location = new System.Drawing.Point(15, 30);
            this.listaValores.Name = "listaValores";
            this.listaValores.Size = new System.Drawing.Size(159, 228);
            this.listaValores.TabIndex = 10;
            // 
            // btnMayorPromedio
            // 
            this.btnMayorPromedio.Location = new System.Drawing.Point(201, 133);
            this.btnMayorPromedio.Name = "btnMayorPromedio";
            this.btnMayorPromedio.Size = new System.Drawing.Size(84, 79);
            this.btnMayorPromedio.TabIndex = 9;
            this.btnMayorPromedio.Text = "Mostrar Cantidad Superior al Promedio";
            this.btnMayorPromedio.UseVisualStyleBackColor = true;
            this.btnMayorPromedio.Click += new System.EventHandler(this.btnMayorPromedio_Click);
            // 
            // btnListaOrdenada
            // 
            this.btnListaOrdenada.Location = new System.Drawing.Point(201, 47);
            this.btnListaOrdenada.Name = "btnListaOrdenada";
            this.btnListaOrdenada.Size = new System.Drawing.Size(84, 66);
            this.btnListaOrdenada.TabIndex = 8;
            this.btnListaOrdenada.Text = "Mostrar Lista Ordenada";
            this.btnListaOrdenada.UseVisualStyleBackColor = true;
            this.btnListaOrdenada.Click += new System.EventHandler(this.btnListaOrdenada_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(821, 464);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.boxValorBuscado);
            this.Controls.Add(this.boxCantidad);
            this.Controls.Add(this.boxPromedio);
            this.Controls.Add(this.boxMaxMin);
            this.Controls.Add(this.boxPedirNum);
            this.Name = "Form1";
            this.Text = "Ejercicio1 - Introduccion";
            this.boxPedirNum.ResumeLayout(false);
            this.boxPedirNum.PerformLayout();
            this.boxMaxMin.ResumeLayout(false);
            this.boxMaxMin.PerformLayout();
            this.boxPromedio.ResumeLayout(false);
            this.boxPromedio.PerformLayout();
            this.boxCantidad.ResumeLayout(false);
            this.boxCantidad.PerformLayout();
            this.boxValorBuscado.ResumeLayout(false);
            this.boxValorBuscado.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox boxPedirNum;
        private System.Windows.Forms.GroupBox boxMaxMin;
        private System.Windows.Forms.GroupBox boxPromedio;
        private System.Windows.Forms.GroupBox boxCantidad;
        private System.Windows.Forms.GroupBox boxValorBuscado;
        private System.Windows.Forms.Label lbPedirNum;
        private System.Windows.Forms.Label lbTituloMinimo;
        private System.Windows.Forms.Label lbTituloMaximo;
        private System.Windows.Forms.Label lbTituloPromedio;
        private System.Windows.Forms.Label lbTituloCantidad;
        private System.Windows.Forms.Label lbTituloValorBuscado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPedirNumero;
        private System.Windows.Forms.Label lbMostrarMinimo;
        private System.Windows.Forms.Label lbMostrarMaximo;
        private System.Windows.Forms.Label lbMostrarPromedio;
        private System.Windows.Forms.Label lbMostrarCantidad;
        private System.Windows.Forms.TextBox tbBuscarNumero;
        private System.Windows.Forms.Button btnRegistrarNum;
        private System.Windows.Forms.Button btnActualizarMaxYMin;
        private System.Windows.Forms.Button btnActualizarPromedio;
        private System.Windows.Forms.Button btnActualizarCant;
        private System.Windows.Forms.Button btnBuscarValor;
        private System.Windows.Forms.ListBox listaValores;
        private System.Windows.Forms.Button btnMayorPromedio;
        private System.Windows.Forms.Button btnListaOrdenada;
    }
}

