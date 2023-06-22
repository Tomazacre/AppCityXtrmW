namespace CityXtremeSport
{
    partial class DatosAlumnos
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
            this.dtgDatAlu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumAlu = new System.Windows.Forms.Label();
            this.btnActDat = new System.Windows.Forms.Button();
            this.btnModDat = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatAlu)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDatAlu
            // 
            this.dtgDatAlu.AllowUserToAddRows = false;
            this.dtgDatAlu.AllowUserToDeleteRows = false;
            this.dtgDatAlu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatAlu.Location = new System.Drawing.Point(12, 60);
            this.dtgDatAlu.Name = "dtgDatAlu";
            this.dtgDatAlu.ReadOnly = true;
            this.dtgDatAlu.Size = new System.Drawing.Size(776, 345);
            this.dtgDatAlu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datos de Alumnos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(465, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total de alumnos Registrados:";
            // 
            // lblNumAlu
            // 
            this.lblNumAlu.AutoSize = true;
            this.lblNumAlu.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.lblNumAlu.Location = new System.Drawing.Point(739, 20);
            this.lblNumAlu.Name = "lblNumAlu";
            this.lblNumAlu.Size = new System.Drawing.Size(31, 24);
            this.lblNumAlu.TabIndex = 3;
            this.lblNumAlu.Text = "---";
            // 
            // btnActDat
            // 
            this.btnActDat.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.btnActDat.Location = new System.Drawing.Point(12, 412);
            this.btnActDat.Name = "btnActDat";
            this.btnActDat.Size = new System.Drawing.Size(176, 44);
            this.btnActDat.TabIndex = 4;
            this.btnActDat.Text = "Actualizar Datos";
            this.btnActDat.UseVisualStyleBackColor = true;
            this.btnActDat.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModDat
            // 
            this.btnModDat.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.btnModDat.Location = new System.Drawing.Point(194, 412);
            this.btnModDat.Name = "btnModDat";
            this.btnModDat.Size = new System.Drawing.Size(176, 44);
            this.btnModDat.TabIndex = 5;
            this.btnModDat.Text = "Modificar Datos";
            this.btnModDat.UseVisualStyleBackColor = true;
            this.btnModDat.Click += new System.EventHandler(this.btnModDat_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location = new System.Drawing.Point(376, 411);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(176, 44);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar Datos";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Location = new System.Drawing.Point(558, 411);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(176, 44);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button4_Click);
            // 
            // DatosAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModDat);
            this.Controls.Add(this.btnActDat);
            this.Controls.Add(this.lblNumAlu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgDatAlu);
            this.Name = "DatosAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatosAlumnos";
            this.Load += new System.EventHandler(this.DatosAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatAlu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDatAlu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumAlu;
        private System.Windows.Forms.Button btnActDat;
        private System.Windows.Forms.Button btnModDat;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
    }
}