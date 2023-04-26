namespace Agenda2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelAgenda = new System.Windows.Forms.Panel();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblFechaNAcimiento = new System.Windows.Forms.Label();
            this.lblNumeroTelefonico = new System.Windows.Forms.Label();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.panelAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAgenda
            // 
            this.panelAgenda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelAgenda.Controls.Add(this.dtpFechaNacimiento);
            this.panelAgenda.Controls.Add(this.btnReporte);
            this.panelAgenda.Controls.Add(this.btnEliminar);
            this.panelAgenda.Controls.Add(this.btnGuardar);
            this.panelAgenda.Controls.Add(this.panel7);
            this.panelAgenda.Controls.Add(this.panel6);
            this.panelAgenda.Controls.Add(this.panel5);
            this.panelAgenda.Controls.Add(this.panel3);
            this.panelAgenda.Controls.Add(this.panel2);
            this.panelAgenda.Controls.Add(this.txtDireccion);
            this.panelAgenda.Controls.Add(this.txtEmail);
            this.panelAgenda.Controls.Add(this.txtTelefono);
            this.panelAgenda.Controls.Add(this.txtApellidoMaterno);
            this.panelAgenda.Controls.Add(this.txtApellidoPaterno);
            this.panelAgenda.Controls.Add(this.panel1);
            this.panelAgenda.Controls.Add(this.txtNombre);
            this.panelAgenda.Controls.Add(this.lblEmail);
            this.panelAgenda.Controls.Add(this.pictureBox1);
            this.panelAgenda.Controls.Add(this.lblDireccion);
            this.panelAgenda.Controls.Add(this.lblFechaNAcimiento);
            this.panelAgenda.Controls.Add(this.lblNumeroTelefonico);
            this.panelAgenda.Controls.Add(this.lblApellidoMaterno);
            this.panelAgenda.Controls.Add(this.lblApellidoPaterno);
            this.panelAgenda.Controls.Add(this.lblNombre);
            this.panelAgenda.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.panelAgenda.Location = new System.Drawing.Point(0, 1);
            this.panelAgenda.Name = "panelAgenda";
            this.panelAgenda.Size = new System.Drawing.Size(798, 532);
            this.panelAgenda.TabIndex = 0;
            this.panelAgenda.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReporte.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnReporte.Location = new System.Drawing.Point(476, 465);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(100, 41);
            this.btnReporte.TabIndex = 19;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnEliminar.Location = new System.Drawing.Point(334, 465);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 41);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnGuardar.Location = new System.Drawing.Point(191, 465);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 41);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(51, 438);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(699, 1);
            this.panel7.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(51, 352);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(333, 1);
            this.panel6.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(417, 352);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(333, 1);
            this.panel5.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(417, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 1);
            this.panel3.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(51, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 1);
            this.panel2.TabIndex = 11;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDireccion.Location = new System.Drawing.Point(48, 418);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(699, 21);
            this.txtDireccion.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtEmail.Location = new System.Drawing.Point(417, 332);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(333, 21);
            this.txtEmail.TabIndex = 15;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtTelefono.Location = new System.Drawing.Point(417, 160);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(333, 21);
            this.txtTelefono.TabIndex = 13;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.BackColor = System.Drawing.Color.White;
            this.txtApellidoMaterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoMaterno.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.txtApellidoMaterno.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtApellidoMaterno.Location = new System.Drawing.Point(51, 332);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(333, 21);
            this.txtApellidoMaterno.TabIndex = 12;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.BackColor = System.Drawing.Color.White;
            this.txtApellidoPaterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoPaterno.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.txtApellidoPaterno.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtApellidoPaterno.Location = new System.Drawing.Point(51, 245);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(333, 21);
            this.txtApellidoPaterno.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(51, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 1);
            this.panel1.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtNombre.Location = new System.Drawing.Point(51, 160);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(333, 21);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.Tag = "";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.lblEmail.Location = new System.Drawing.Point(400, 282);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(188, 25);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Correo Electronico :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Agenda2.Properties.Resources._956_9563878_agenda_graphic_design;
            this.pictureBox1.Location = new System.Drawing.Point(253, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.lblDireccion.Location = new System.Drawing.Point(35, 376);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(105, 25);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Dirección :";
            // 
            // lblFechaNAcimiento
            // 
            this.lblFechaNAcimiento.AutoSize = true;
            this.lblFechaNAcimiento.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.lblFechaNAcimiento.Location = new System.Drawing.Point(400, 200);
            this.lblFechaNAcimiento.Name = "lblFechaNAcimiento";
            this.lblFechaNAcimiento.Size = new System.Drawing.Size(210, 25);
            this.lblFechaNAcimiento.TabIndex = 5;
            this.lblFechaNAcimiento.Text = "Fecha de Nacimiento :";
            // 
            // lblNumeroTelefonico
            // 
            this.lblNumeroTelefonico.AutoSize = true;
            this.lblNumeroTelefonico.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.lblNumeroTelefonico.Location = new System.Drawing.Point(400, 116);
            this.lblNumeroTelefonico.Name = "lblNumeroTelefonico";
            this.lblNumeroTelefonico.Size = new System.Drawing.Size(193, 25);
            this.lblNumeroTelefonico.TabIndex = 4;
            this.lblNumeroTelefonico.Text = "Numero Telefonico :";
            this.lblNumeroTelefonico.Click += new System.EventHandler(this.lblNumeroTelefonico_Click);
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.lblApellidoMaterno.Location = new System.Drawing.Point(35, 282);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(180, 25);
            this.lblApellidoMaterno.TabIndex = 3;
            this.lblApellidoMaterno.Text = "Apellido Materno :";
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.lblApellidoPaterno.Location = new System.Drawing.Point(35, 200);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(175, 25);
            this.lblApellidoPaterno.TabIndex = 2;
            this.lblApellidoPaterno.Text = "Apellido Paterno :";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(35, 116);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(96, 25);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre :";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CalendarForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dtpFechaNacimiento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(417, 238);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(333, 28);
            this.dtpFechaNacimiento.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(795, 531);
            this.Controls.Add(this.panelAgenda);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "     Agenda";
            this.TransparencyKey = System.Drawing.Color.GhostWhite;
            this.panelAgenda.ResumeLayout(false);
            this.panelAgenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAgenda;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblFechaNAcimiento;
        private System.Windows.Forms.Label lblNumeroTelefonico;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
    }
}

