
namespace CityXtremeSport
{
    partial class Registro
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.cbxClase = new System.Windows.Forms.ComboBox();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.dtpPagoMes = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pbCode = new System.Windows.Forms.PictureBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Alumno";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.txtNombre.Location = new System.Drawing.Point(20, 131);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 32);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(45, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 20F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(268, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 20F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(75, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "Clase";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 20F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(280, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 33);
            this.label5.TabIndex = 5;
            this.label5.Text = "Horario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 20F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(54, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 33);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 20F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(250, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 33);
            this.label7.TabIndex = 7;
            this.label7.Text = "Pago Del Mes";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.txtApellido.Location = new System.Drawing.Point(244, 131);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(200, 32);
            this.txtApellido.TabIndex = 4;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // cbxClase
            // 
            this.cbxClase.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.cbxClase.FormattingEnabled = true;
            this.cbxClase.Items.AddRange(new object[] {
            "Toros",
            "Calistenia",
            "Ballet",
            "Taekwondo",
            "Parkour",
            "Twerk"});
            this.cbxClase.Location = new System.Drawing.Point(20, 201);
            this.cbxClase.Name = "cbxClase";
            this.cbxClase.Size = new System.Drawing.Size(200, 32);
            this.cbxClase.TabIndex = 9;
            this.cbxClase.SelectedIndexChanged += new System.EventHandler(this.cbxClase_SelectedIndexChanged);
            // 
            // txtHorario
            // 
            this.txtHorario.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.txtHorario.Location = new System.Drawing.Point(244, 201);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(200, 32);
            this.txtHorario.TabIndex = 10;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.txtTel.Location = new System.Drawing.Point(20, 273);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(200, 32);
            this.txtTel.TabIndex = 11;
            // 
            // dtpPagoMes
            // 
            this.dtpPagoMes.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.dtpPagoMes.Location = new System.Drawing.Point(244, 273);
            this.dtpPagoMes.Name = "dtpPagoMes";
            this.dtpPagoMes.Size = new System.Drawing.Size(200, 32);
            this.dtpPagoMes.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 20F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(238, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 33);
            this.label8.TabIndex = 13;
            this.label8.Text = "Codigo:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.lblCodigo.Location = new System.Drawing.Point(333, 345);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(73, 24);
            this.lblCodigo.TabIndex = 14;
            this.lblCodigo.Text = "---------";
            // 
            // pbCode
            // 
            this.pbCode.Location = new System.Drawing.Point(20, 338);
            this.pbCode.Name = "pbCode";
            this.pbCode.Size = new System.Drawing.Size(200, 200);
            this.pbCode.TabIndex = 15;
            this.pbCode.TabStop = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.Location = new System.Drawing.Point(244, 378);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(200, 42);
            this.btnRegistrar.TabIndex = 16;
            this.btnRegistrar.Text = "Registrar Alumno";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Location = new System.Drawing.Point(244, 435);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(200, 42);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar Codigo";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Location = new System.Drawing.Point(244, 496);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(200, 42);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 560);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbCode);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.cbxClase);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.dtpPagoMes);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ComboBox cbxClase;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.DateTimePicker dtpPagoMes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.PictureBox pbCode;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
    }
}

