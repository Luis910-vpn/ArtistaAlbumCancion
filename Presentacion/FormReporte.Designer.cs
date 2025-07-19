namespace Presentacion
{
    partial class FormReporte
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
            this.btnCanciónMayorDuracion = new System.Windows.Forms.Button();
            this.dgAlbumes = new System.Windows.Forms.DataGridView();
            this.dgCanciones = new System.Windows.Forms.DataGridView();
            this.btnCancionesYoutubeMusic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlbumes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCanciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPORTES";
            // 
            // btnCanciónMayorDuracion
            // 
            this.btnCanciónMayorDuracion.Location = new System.Drawing.Point(55, 52);
            this.btnCanciónMayorDuracion.Name = "btnCanciónMayorDuracion";
            this.btnCanciónMayorDuracion.Size = new System.Drawing.Size(171, 40);
            this.btnCanciónMayorDuracion.TabIndex = 3;
            this.btnCanciónMayorDuracion.Text = "Canción con mayor duración";
            this.btnCanciónMayorDuracion.UseVisualStyleBackColor = true;
            this.btnCanciónMayorDuracion.Click += new System.EventHandler(this.btnCanciónMayorDuracion_Click);
            // 
            // dgAlbumes
            // 
            this.dgAlbumes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlbumes.Location = new System.Drawing.Point(280, 240);
            this.dgAlbumes.Name = "dgAlbumes";
            this.dgAlbumes.Size = new System.Drawing.Size(509, 176);
            this.dgAlbumes.TabIndex = 32;
            // 
            // dgCanciones
            // 
            this.dgCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCanciones.Location = new System.Drawing.Point(280, 52);
            this.dgCanciones.Name = "dgCanciones";
            this.dgCanciones.Size = new System.Drawing.Size(508, 173);
            this.dgCanciones.TabIndex = 45;
            // 
            // btnCancionesYoutubeMusic
            // 
            this.btnCancionesYoutubeMusic.Location = new System.Drawing.Point(55, 98);
            this.btnCancionesYoutubeMusic.Name = "btnCancionesYoutubeMusic";
            this.btnCancionesYoutubeMusic.Size = new System.Drawing.Size(171, 40);
            this.btnCancionesYoutubeMusic.TabIndex = 46;
            this.btnCancionesYoutubeMusic.Text = "Canciones de Youtube Music";
            this.btnCancionesYoutubeMusic.UseVisualStyleBackColor = true;
            this.btnCancionesYoutubeMusic.Click += new System.EventHandler(this.btnCancionesYoutubeMusic_Click);
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancionesYoutubeMusic);
            this.Controls.Add(this.dgCanciones);
            this.Controls.Add(this.dgAlbumes);
            this.Controls.Add(this.btnCanciónMayorDuracion);
            this.Controls.Add(this.label1);
            this.Name = "FormReporte";
            this.Text = "FormReporte";
            ((System.ComponentModel.ISupportInitialize)(this.dgAlbumes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCanciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCanciónMayorDuracion;
        private System.Windows.Forms.DataGridView dgAlbumes;
        private System.Windows.Forms.DataGridView dgCanciones;
        private System.Windows.Forms.Button btnCancionesYoutubeMusic;
    }
}