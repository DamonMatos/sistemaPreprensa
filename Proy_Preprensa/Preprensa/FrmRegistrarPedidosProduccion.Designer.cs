namespace Preprensa
{
    partial class FrmRegistrarPedidosProduccion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumproducion = new System.Windows.Forms.TextBox();
            this.txtNombreElaborado = new System.Windows.Forms.TextBox();
            this.txtCargoElaborado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgDetalle = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.dgactividades = new System.Windows.Forms.DataGridView();
            this.txtactividad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtcanpagina = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtcancorrecion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txthorafin = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txthorainicio = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtcomentario = new System.Windows.Forms.TextBox();
            this.dtpfecharegistro = new System.Windows.Forms.DateTimePicker();
            this.gbColaborador = new System.Windows.Forms.GroupBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.grpcordinador = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcomentariocoordinador = new System.Windows.Forms.TextBox();
            this.BtnGuardarComentario = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgactividades)).BeginInit();
            this.gbColaborador.SuspendLayout();
            this.grpcordinador.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(107, 42);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(347, 20);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "N°Producción:";
            // 
            // txtNumproducion
            // 
            this.txtNumproducion.Enabled = false;
            this.txtNumproducion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumproducion.Location = new System.Drawing.Point(107, 19);
            this.txtNumproducion.Name = "txtNumproducion";
            this.txtNumproducion.Size = new System.Drawing.Size(169, 20);
            this.txtNumproducion.TabIndex = 5;
            // 
            // txtNombreElaborado
            // 
            this.txtNombreElaborado.Enabled = false;
            this.txtNombreElaborado.Location = new System.Drawing.Point(97, 19);
            this.txtNombreElaborado.Name = "txtNombreElaborado";
            this.txtNombreElaborado.Size = new System.Drawing.Size(258, 20);
            this.txtNombreElaborado.TabIndex = 6;
            // 
            // txtCargoElaborado
            // 
            this.txtCargoElaborado.Enabled = false;
            this.txtCargoElaborado.Location = new System.Drawing.Point(97, 42);
            this.txtCargoElaborado.Name = "txtCargoElaborado";
            this.txtCargoElaborado.Size = new System.Drawing.Size(202, 20);
            this.txtCargoElaborado.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cargo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombreElaborado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCargoElaborado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(659, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 75);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trabajador";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(460, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Fecha:";
            // 
            // dgDetalle
            // 
            this.dgDetalle.AllowUserToAddRows = false;
            this.dgDetalle.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalle.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgDetalle.Location = new System.Drawing.Point(12, 100);
            this.dgDetalle.Name = "dgDetalle";
            this.dgDetalle.Size = new System.Drawing.Size(494, 124);
            this.dgDetalle.TabIndex = 15;
            this.dgDetalle.Click += new System.EventHandler(this.dgDetalle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Estado:";
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(338, 19);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(116, 20);
            this.txtEstado.TabIndex = 17;
            // 
            // dtpfecha
            // 
            this.dtpfecha.Enabled = false;
            this.dtpfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha.Location = new System.Drawing.Point(512, 19);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(137, 20);
            this.dtpfecha.TabIndex = 19;
            // 
            // dgactividades
            // 
            this.dgactividades.AllowUserToAddRows = false;
            this.dgactividades.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgactividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgactividades.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgactividades.Location = new System.Drawing.Point(512, 100);
            this.dgactividades.Name = "dgactividades";
            this.dgactividades.Size = new System.Drawing.Size(508, 298);
            this.dgactividades.TabIndex = 21;
            this.dgactividades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgactividades_CellClick);
            // 
            // txtactividad
            // 
            this.txtactividad.Enabled = false;
            this.txtactividad.Location = new System.Drawing.Point(141, 45);
            this.txtactividad.Name = "txtactividad";
            this.txtactividad.Size = new System.Drawing.Size(332, 20);
            this.txtactividad.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Actividad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Fecha Registro:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(258, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Cantidad Paginas:";
            // 
            // txtcanpagina
            // 
            this.txtcanpagina.Enabled = false;
            this.txtcanpagina.Location = new System.Drawing.Point(376, 123);
            this.txtcanpagina.Name = "txtcanpagina";
            this.txtcanpagina.Size = new System.Drawing.Size(97, 20);
            this.txtcanpagina.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Cantidad Correciones:";
            // 
            // txtcancorrecion
            // 
            this.txtcancorrecion.Enabled = false;
            this.txtcancorrecion.Location = new System.Drawing.Point(141, 123);
            this.txtcancorrecion.Name = "txtcancorrecion";
            this.txtcancorrecion.Size = new System.Drawing.Size(111, 20);
            this.txtcancorrecion.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(258, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Hora Fin:";
            // 
            // txthorafin
            // 
            this.txthorafin.Enabled = false;
            this.txthorafin.Location = new System.Drawing.Point(376, 97);
            this.txthorafin.Name = "txthorafin";
            this.txthorafin.Size = new System.Drawing.Size(97, 20);
            this.txthorafin.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(24, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Hora Inicio:";
            // 
            // txthorainicio
            // 
            this.txthorainicio.Enabled = false;
            this.txthorainicio.Location = new System.Drawing.Point(141, 97);
            this.txthorainicio.Name = "txthorainicio";
            this.txthorainicio.Size = new System.Drawing.Size(111, 20);
            this.txthorainicio.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 153);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Comentario:";
            // 
            // txtcomentario
            // 
            this.txtcomentario.Enabled = false;
            this.txtcomentario.Location = new System.Drawing.Point(141, 150);
            this.txtcomentario.Multiline = true;
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.Size = new System.Drawing.Size(332, 112);
            this.txtcomentario.TabIndex = 27;
            // 
            // dtpfecharegistro
            // 
            this.dtpfecharegistro.Enabled = false;
            this.dtpfecharegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecharegistro.Location = new System.Drawing.Point(141, 71);
            this.dtpfecharegistro.Name = "dtpfecharegistro";
            this.dtpfecharegistro.Size = new System.Drawing.Size(332, 20);
            this.dtpfecharegistro.TabIndex = 28;
            // 
            // gbColaborador
            // 
            this.gbColaborador.Controls.Add(this.BtnModificar);
            this.gbColaborador.Controls.Add(this.BtnNuevo);
            this.gbColaborador.Controls.Add(this.txtcodigo);
            this.gbColaborador.Controls.Add(this.txtLibro);
            this.gbColaborador.Controls.Add(this.label7);
            this.gbColaborador.Controls.Add(this.BtnGuardar);
            this.gbColaborador.Controls.Add(this.label5);
            this.gbColaborador.Controls.Add(this.dtpfecharegistro);
            this.gbColaborador.Controls.Add(this.label10);
            this.gbColaborador.Controls.Add(this.txtcomentario);
            this.gbColaborador.Controls.Add(this.label11);
            this.gbColaborador.Controls.Add(this.label15);
            this.gbColaborador.Controls.Add(this.label13);
            this.gbColaborador.Controls.Add(this.txthorainicio);
            this.gbColaborador.Controls.Add(this.txtcanpagina);
            this.gbColaborador.Controls.Add(this.txtcancorrecion);
            this.gbColaborador.Controls.Add(this.txthorafin);
            this.gbColaborador.Controls.Add(this.txtactividad);
            this.gbColaborador.Controls.Add(this.label12);
            this.gbColaborador.Controls.Add(this.label14);
            this.gbColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbColaborador.Location = new System.Drawing.Point(10, 232);
            this.gbColaborador.Name = "gbColaborador";
            this.gbColaborador.Size = new System.Drawing.Size(490, 308);
            this.gbColaborador.TabIndex = 29;
            this.gbColaborador.TabStop = false;
            this.gbColaborador.Text = "Actividad";
            // 
            // BtnModificar
            // 
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar.Location = new System.Drawing.Point(165, 266);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(74, 32);
            this.BtnModificar.TabIndex = 34;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevo.Location = new System.Drawing.Point(6, 266);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(74, 32);
            this.BtnNuevo.TabIndex = 33;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(141, 22);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(96, 20);
            this.txtcodigo.TabIndex = 32;
            // 
            // txtLibro
            // 
            this.txtLibro.Location = new System.Drawing.Point(243, 22);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.Size = new System.Drawing.Size(230, 20);
            this.txtLibro.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Libro:";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(85, 266);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(74, 32);
            this.BtnGuardar.TabIndex = 29;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // grpcordinador
            // 
            this.grpcordinador.Controls.Add(this.label8);
            this.grpcordinador.Controls.Add(this.txtcomentariocoordinador);
            this.grpcordinador.Controls.Add(this.BtnGuardarComentario);
            this.grpcordinador.Location = new System.Drawing.Point(10, 234);
            this.grpcordinador.Name = "grpcordinador";
            this.grpcordinador.Size = new System.Drawing.Size(490, 142);
            this.grpcordinador.TabIndex = 35;
            this.grpcordinador.TabStop = false;
            this.grpcordinador.Text = "Coordinador";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Comentario";
            // 
            // txtcomentariocoordinador
            // 
            this.txtcomentariocoordinador.Location = new System.Drawing.Point(95, 28);
            this.txtcomentariocoordinador.Multiline = true;
            this.txtcomentariocoordinador.Name = "txtcomentariocoordinador";
            this.txtcomentariocoordinador.Size = new System.Drawing.Size(376, 108);
            this.txtcomentariocoordinador.TabIndex = 1;
            // 
            // BtnGuardarComentario
            // 
            this.BtnGuardarComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarComentario.Location = new System.Drawing.Point(8, 103);
            this.BtnGuardarComentario.Name = "BtnGuardarComentario";
            this.BtnGuardarComentario.Size = new System.Drawing.Size(75, 33);
            this.BtnGuardarComentario.TabIndex = 0;
            this.BtnGuardarComentario.Text = "Guardar";
            this.BtnGuardarComentario.UseVisualStyleBackColor = true;
            this.BtnGuardarComentario.Click += new System.EventHandler(this.BtnGuardarComentario_Click);
            // 
            // FrmRegistrarPedidosProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 548);
            this.Controls.Add(this.grpcordinador);
            this.Controls.Add(this.gbColaborador);
            this.Controls.Add(this.dgactividades);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgDetalle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNumproducion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistrarPedidosProduccion";
            this.Text = "Registro de Actividades";
            this.Load += new System.EventHandler(this.FrmRegistrarPedidosProduccion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgactividades)).EndInit();
            this.gbColaborador.ResumeLayout(false);
            this.gbColaborador.PerformLayout();
            this.grpcordinador.ResumeLayout(false);
            this.grpcordinador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumproducion;
        private System.Windows.Forms.TextBox txtNombreElaborado;
        private System.Windows.Forms.TextBox txtCargoElaborado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgDetalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.DataGridView dgactividades;
        private System.Windows.Forms.TextBox txtactividad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtcanpagina;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtcancorrecion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txthorafin;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txthorainicio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtcomentario;
        private System.Windows.Forms.DateTimePicker dtpfecharegistro;
        public System.Windows.Forms.GroupBox gbColaborador;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox txtLibro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnNuevo;
        public System.Windows.Forms.GroupBox grpcordinador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcomentariocoordinador;
        private System.Windows.Forms.Button BtnGuardarComentario;
    }
}