namespace Presentacion
{
    partial class FormAlbum
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
            this.dgAlbumes = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVerCanciones = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tbDuracionTotal = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpAnioLanzamiento = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlbumes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAlbumes
            // 
            this.dgAlbumes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlbumes.Location = new System.Drawing.Point(15, 141);
            this.dgAlbumes.Name = "dgAlbumes";
            this.dgAlbumes.Size = new System.Drawing.Size(773, 297);
            this.dgAlbumes.TabIndex = 31;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(387, 101);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 34);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVerCanciones
            // 
            this.btnVerCanciones.Location = new System.Drawing.Point(294, 101);
            this.btnVerCanciones.Name = "btnVerCanciones";
            this.btnVerCanciones.Size = new System.Drawing.Size(87, 34);
            this.btnVerCanciones.TabIndex = 28;
            this.btnVerCanciones.Text = "Ver Canciones";
            this.btnVerCanciones.UseVisualStyleBackColor = true;
            this.btnVerCanciones.Click += new System.EventHandler(this.btnVerCanciones_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(201, 101);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 34);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(108, 101);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 34);
            this.btnModificar.TabIndex = 26;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(15, 101);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(87, 34);
            this.btnRegistrar.TabIndex = 25;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tbDuracionTotal
            // 
            this.tbDuracionTotal.Location = new System.Drawing.Point(604, 58);
            this.tbDuracionTotal.Name = "tbDuracionTotal";
            this.tbDuracionTotal.Size = new System.Drawing.Size(138, 20);
            this.tbDuracionTotal.TabIndex = 23;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(54, 58);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(138, 20);
            this.tbTitulo.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Duración Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Año de lanzamiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Titulo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "ALBUMES";
            // 
            // dtpAnioLanzamiento
            // 
            this.dtpAnioLanzamiento.CustomFormat = "yyyy";
            this.dtpAnioLanzamiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAnioLanzamiento.Location = new System.Drawing.Point(331, 58);
            this.dtpAnioLanzamiento.Name = "dtpAnioLanzamiento";
            this.dtpAnioLanzamiento.Size = new System.Drawing.Size(115, 20);
            this.dtpAnioLanzamiento.TabIndex = 32;
            // 
            // FormAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpAnioLanzamiento);
            this.Controls.Add(this.dgAlbumes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerCanciones);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbDuracionTotal);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAlbum";
            this.Text = "Albumes";
            ((System.ComponentModel.ISupportInitialize)(this.dgAlbumes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAlbumes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVerCanciones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox tbDuracionTotal;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpAnioLanzamiento;
    }
}