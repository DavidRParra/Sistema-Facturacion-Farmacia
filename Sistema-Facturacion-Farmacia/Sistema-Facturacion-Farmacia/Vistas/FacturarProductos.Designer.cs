namespace Sistema_Facturacion_Farmacia.Vistas
{
    partial class FacturarProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tabla = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITBIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fACTURACION_FARMACIADataSet = new Sistema_Facturacion_Farmacia.FACTURACION_FARMACIADataSet();
            this.fACTURACIONFARMACIADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Facturar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.tb_CodigoDeBarra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Laboratorio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Controlado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Descuento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Precio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_CantidadDisponible = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_CantidadFacturar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_FechaDeVencimiento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_Descripcion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_Total = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURACION_FARMACIADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURACIONFARMACIADataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabla
            // 
            this.Tabla.AllowUserToDeleteRows = false;
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Laboratorio,
            this.Cantidad,
            this.PrecioUnidad,
            this.ITBIS,
            this.Descuento,
            this.SubTotal});
            this.Tabla.Location = new System.Drawing.Point(18, 18);
            this.Tabla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tabla.Name = "Tabla";
            this.Tabla.ReadOnly = true;
            this.Tabla.Size = new System.Drawing.Size(1209, 230);
            this.Tabla.TabIndex = 0;
            // 
            // Nombre
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle8;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.Width = 300;
            // 
            // Laboratorio
            // 
            this.Laboratorio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Laboratorio.DefaultCellStyle = dataGridViewCellStyle9;
            this.Laboratorio.HeaderText = "Laboratorio";
            this.Laboratorio.Name = "Laboratorio";
            this.Laboratorio.ReadOnly = true;
            this.Laboratorio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Laboratorio.Width = 375;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle10;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cantidad.Width = 110;
            // 
            // PrecioUnidad
            // 
            this.PrecioUnidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioUnidad.DefaultCellStyle = dataGridViewCellStyle11;
            this.PrecioUnidad.HeaderText = "P.Und";
            this.PrecioUnidad.Name = "PrecioUnidad";
            this.PrecioUnidad.ReadOnly = true;
            this.PrecioUnidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PrecioUnidad.Width = 80;
            // 
            // ITBIS
            // 
            this.ITBIS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITBIS.DefaultCellStyle = dataGridViewCellStyle12;
            this.ITBIS.HeaderText = "ITBIS";
            this.ITBIS.Name = "ITBIS";
            this.ITBIS.ReadOnly = true;
            this.ITBIS.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ITBIS.Width = 80;
            // 
            // Descuento
            // 
            this.Descuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descuento.DefaultCellStyle = dataGridViewCellStyle13;
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            this.Descuento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Descuento.Width = 110;
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotal.DefaultCellStyle = dataGridViewCellStyle14;
            this.SubTotal.HeaderText = "Sub. Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SubTotal.Width = 110;
            // 
            // fACTURACION_FARMACIADataSet
            // 
            this.fACTURACION_FARMACIADataSet.DataSetName = "FACTURACION_FARMACIADataSet";
            this.fACTURACION_FARMACIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fACTURACIONFARMACIADataSetBindingSource
            // 
            this.fACTURACIONFARMACIADataSetBindingSource.DataSource = this.fACTURACION_FARMACIADataSet;
            this.fACTURACIONFARMACIADataSetBindingSource.Position = 0;
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.btn_Editar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.Location = new System.Drawing.Point(843, 304);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(114, 32);
            this.btn_Editar.TabIndex = 1;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = false;
            // 
            // btn_Facturar
            // 
            this.btn_Facturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.btn_Facturar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.btn_Facturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Facturar.Location = new System.Drawing.Point(1083, 304);
            this.btn_Facturar.Name = "btn_Facturar";
            this.btn_Facturar.Size = new System.Drawing.Size(114, 32);
            this.btn_Facturar.TabIndex = 2;
            this.btn_Facturar.Text = "Facturar";
            this.btn_Facturar.UseVisualStyleBackColor = false;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.btn_Agregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Location = new System.Drawing.Point(963, 304);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(114, 32);
            this.btn_Agregar.TabIndex = 3;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            // 
            // tb_CodigoDeBarra
            // 
            this.tb_CodigoDeBarra.Location = new System.Drawing.Point(220, 309);
            this.tb_CodigoDeBarra.Name = "tb_CodigoDeBarra";
            this.tb_CodigoDeBarra.Size = new System.Drawing.Size(247, 27);
            this.tb_CodigoDeBarra.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código de barra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1213, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "___________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre:";
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.Location = new System.Drawing.Point(126, 378);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(180, 27);
            this.tb_Nombre.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Laboratorio:";
            // 
            // tb_Laboratorio
            // 
            this.tb_Laboratorio.Location = new System.Drawing.Point(417, 378);
            this.tb_Laboratorio.Name = "tb_Laboratorio";
            this.tb_Laboratorio.Size = new System.Drawing.Size(219, 27);
            this.tb_Laboratorio.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(642, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Controlado:";
            // 
            // tb_Controlado
            // 
            this.tb_Controlado.Location = new System.Drawing.Point(744, 378);
            this.tb_Controlado.Name = "tb_Controlado";
            this.tb_Controlado.Size = new System.Drawing.Size(81, 27);
            this.tb_Controlado.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(831, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Descuento (%):";
            // 
            // tb_Descuento
            // 
            this.tb_Descuento.Location = new System.Drawing.Point(955, 378);
            this.tb_Descuento.Name = "tb_Descuento";
            this.tb_Descuento.Size = new System.Drawing.Size(60, 27);
            this.tb_Descuento.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Precio:";
            // 
            // tb_Precio
            // 
            this.tb_Precio.Location = new System.Drawing.Point(111, 446);
            this.tb_Precio.Name = "tb_Precio";
            this.tb_Precio.Size = new System.Drawing.Size(116, 27);
            this.tb_Precio.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(233, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cantidad Disponible:";
            // 
            // tb_CantidadDisponible
            // 
            this.tb_CantidadDisponible.Location = new System.Drawing.Point(399, 446);
            this.tb_CantidadDisponible.Name = "tb_CantidadDisponible";
            this.tb_CantidadDisponible.Size = new System.Drawing.Size(101, 27);
            this.tb_CantidadDisponible.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(506, 449);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Cantidad a Facturar:";
            // 
            // tb_CantidadFacturar
            // 
            this.tb_CantidadFacturar.Location = new System.Drawing.Point(665, 446);
            this.tb_CantidadFacturar.Name = "tb_CantidadFacturar";
            this.tb_CantidadFacturar.Size = new System.Drawing.Size(96, 27);
            this.tb_CantidadFacturar.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(766, 449);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Fecha de Vencimiento:";
            // 
            // tb_FechaDeVencimiento
            // 
            this.tb_FechaDeVencimiento.Location = new System.Drawing.Point(946, 446);
            this.tb_FechaDeVencimiento.Name = "tb_FechaDeVencimiento";
            this.tb_FechaDeVencimiento.Size = new System.Drawing.Size(175, 27);
            this.tb_FechaDeVencimiento.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(46, 519);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Descripción";
            // 
            // tb_Descripcion
            // 
            this.tb_Descripcion.Location = new System.Drawing.Point(50, 542);
            this.tb_Descripcion.Multiline = true;
            this.tb_Descripcion.Name = "tb_Descripcion";
            this.tb_Descripcion.Size = new System.Drawing.Size(1147, 172);
            this.tb_Descripcion.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 714);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1213, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "___________";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(994, 763);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "Total:";
            // 
            // tb_Total
            // 
            this.tb_Total.Location = new System.Drawing.Point(1050, 760);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(147, 27);
            this.tb_Total.TabIndex = 26;
            // 
            // FacturarProductos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1240, 855);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_Total);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_Descripcion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_FechaDeVencimiento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_CantidadFacturar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_CantidadDisponible);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_Precio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Descuento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Controlado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Laboratorio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_CodigoDeBarra);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Facturar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.Tabla);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1240, 855);
            this.Name = "FacturarProductos";
            this.Text = "FacturarProductos";
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURACION_FARMACIADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURACIONFARMACIADataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Tabla;
        private System.Windows.Forms.BindingSource fACTURACIONFARMACIADataSetBindingSource;
        private FACTURACION_FARMACIADataSet fACTURACION_FARMACIADataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Laboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITBIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Facturar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.TextBox tb_CodigoDeBarra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Laboratorio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Controlado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Descuento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_Precio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_CantidadDisponible;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_CantidadFacturar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_FechaDeVencimiento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_Descripcion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_Total;
    }
}