namespace Formularios
{
    partial class FormRegistro
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
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.btn_ingreso = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_nombreGuion = new System.Windows.Forms.Label();
            this.txb_apellido = new System.Windows.Forms.TextBox();
            this.lbl_apellidoGuion = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txb_dni = new System.Windows.Forms.TextBox();
            this.lbl_dniGuion = new System.Windows.Forms.Label();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.txb_telefono = new System.Windows.Forms.TextBox();
            this.lbl_telefonoGuion = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txb_mail = new System.Windows.Forms.TextBox();
            this.lbl_mailGuion = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.cmb_ObraSocialLista = new System.Windows.Forms.ComboBox();
            this.lbl_obraSocial = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_horario = new System.Windows.Forms.Label();
            this.cmb_Horario = new System.Windows.Forms.ComboBox();
            this.dtp_agenda = new System.Windows.Forms.DateTimePicker();
            this.cmb_TipoConsulta = new System.Windows.Forms.ComboBox();
            this.lbl_tipoConsulta = new System.Windows.Forms.Label();
            this.pb_LogoChicoR = new System.Windows.Forms.PictureBox();
            this.lbl_Info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LogoChicoR)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_nombre
            // 
            this.txb_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_nombre.Location = new System.Drawing.Point(26, 88);
            this.txb_nombre.MaxLength = 15;
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.Size = new System.Drawing.Size(100, 16);
            this.txb_nombre.TabIndex = 1;
            this.txb_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_Nombre_KeyPress);
            // 
            // btn_ingreso
            // 
            this.btn_ingreso.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_ingreso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.btn_ingreso.FlatAppearance.BorderSize = 0;
            this.btn_ingreso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ingreso.Location = new System.Drawing.Point(22, 269);
            this.btn_ingreso.Name = "btn_ingreso";
            this.btn_ingreso.Size = new System.Drawing.Size(232, 23);
            this.btn_ingreso.TabIndex = 10;
            this.btn_ingreso.Text = "Registro";
            this.btn_ingreso.UseVisualStyleBackColor = false;
            this.btn_ingreso.Click += new System.EventHandler(this.btn_Ingreso_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Titulo.Location = new System.Drawing.Point(7, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(432, 28);
            this.lbl_Titulo.TabIndex = 7;
            this.lbl_Titulo.Text = "Completá los campos con los datos del paciente";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_nombre.Location = new System.Drawing.Point(22, 70);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(51, 15);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_nombreGuion
            // 
            this.lbl_nombreGuion.AutoSize = true;
            this.lbl_nombreGuion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombreGuion.Location = new System.Drawing.Point(22, 91);
            this.lbl_nombreGuion.Name = "lbl_nombreGuion";
            this.lbl_nombreGuion.Size = new System.Drawing.Size(112, 15);
            this.lbl_nombreGuion.TabIndex = 8;
            this.lbl_nombreGuion.Text = "_____________________";
            // 
            // txb_apellido
            // 
            this.txb_apellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_apellido.Location = new System.Drawing.Point(147, 88);
            this.txb_apellido.MaxLength = 15;
            this.txb_apellido.Name = "txb_apellido";
            this.txb_apellido.Size = new System.Drawing.Size(100, 16);
            this.txb_apellido.TabIndex = 2;
            this.txb_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_Apellido_KeyPress);
            // 
            // lbl_apellidoGuion
            // 
            this.lbl_apellidoGuion.AutoSize = true;
            this.lbl_apellidoGuion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_apellidoGuion.Location = new System.Drawing.Point(143, 91);
            this.lbl_apellidoGuion.Name = "lbl_apellidoGuion";
            this.lbl_apellidoGuion.Size = new System.Drawing.Size(112, 15);
            this.lbl_apellidoGuion.TabIndex = 11;
            this.lbl_apellidoGuion.Text = "_____________________";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_apellido.Location = new System.Drawing.Point(143, 70);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(51, 15);
            this.lbl_apellido.TabIndex = 9;
            this.lbl_apellido.Text = "Apellido";
            // 
            // txb_dni
            // 
            this.txb_dni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_dni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_dni.Location = new System.Drawing.Point(26, 134);
            this.txb_dni.MaxLength = 8;
            this.txb_dni.Name = "txb_dni";
            this.txb_dni.Size = new System.Drawing.Size(100, 16);
            this.txb_dni.TabIndex = 3;
            this.txb_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_Dni_KeyPress);
            // 
            // lbl_dniGuion
            // 
            this.lbl_dniGuion.AutoSize = true;
            this.lbl_dniGuion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dniGuion.Location = new System.Drawing.Point(22, 137);
            this.lbl_dniGuion.Name = "lbl_dniGuion";
            this.lbl_dniGuion.Size = new System.Drawing.Size(112, 15);
            this.lbl_dniGuion.TabIndex = 14;
            this.lbl_dniGuion.Text = "_____________________";
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_dni.Location = new System.Drawing.Point(22, 116);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(25, 15);
            this.lbl_dni.TabIndex = 12;
            this.lbl_dni.Text = "Dni";
            // 
            // txb_telefono
            // 
            this.txb_telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_telefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_telefono.Location = new System.Drawing.Point(147, 134);
            this.txb_telefono.MaxLength = 15;
            this.txb_telefono.Name = "txb_telefono";
            this.txb_telefono.Size = new System.Drawing.Size(100, 16);
            this.txb_telefono.TabIndex = 4;
            this.txb_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_Telefono_KeyPress);
            // 
            // lbl_telefonoGuion
            // 
            this.lbl_telefonoGuion.AutoSize = true;
            this.lbl_telefonoGuion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_telefonoGuion.Location = new System.Drawing.Point(143, 137);
            this.lbl_telefonoGuion.Name = "lbl_telefonoGuion";
            this.lbl_telefonoGuion.Size = new System.Drawing.Size(112, 15);
            this.lbl_telefonoGuion.TabIndex = 17;
            this.lbl_telefonoGuion.Text = "_____________________";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_telefono.Location = new System.Drawing.Point(143, 116);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(52, 15);
            this.lbl_telefono.TabIndex = 15;
            this.lbl_telefono.Text = "Teléfono";
            // 
            // txb_mail
            // 
            this.txb_mail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_mail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_mail.Location = new System.Drawing.Point(26, 180);
            this.txb_mail.MaxLength = 20;
            this.txb_mail.Multiline = true;
            this.txb_mail.Name = "txb_mail";
            this.txb_mail.Size = new System.Drawing.Size(228, 18);
            this.txb_mail.TabIndex = 5;
            // 
            // lbl_mailGuion
            // 
            this.lbl_mailGuion.AutoSize = true;
            this.lbl_mailGuion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mailGuion.Location = new System.Drawing.Point(22, 185);
            this.lbl_mailGuion.Name = "lbl_mailGuion";
            this.lbl_mailGuion.Size = new System.Drawing.Size(232, 15);
            this.lbl_mailGuion.TabIndex = 20;
            this.lbl_mailGuion.Text = "_____________________________________________";
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_mail.Location = new System.Drawing.Point(22, 164);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(30, 15);
            this.lbl_mail.TabIndex = 18;
            this.lbl_mail.Text = "Mail";
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_volver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.btn_volver.FlatAppearance.BorderSize = 0;
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_volver.Location = new System.Drawing.Point(22, 301);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(104, 23);
            this.btn_volver.TabIndex = 11;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_borrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.btn_borrar.FlatAppearance.BorderSize = 0;
            this.btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_borrar.Location = new System.Drawing.Point(151, 301);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(104, 23);
            this.btn_borrar.TabIndex = 12;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = false;
            this.btn_borrar.Click += new System.EventHandler(this.btn_Borrar_Click);
            // 
            // cmb_ObraSocialLista
            // 
            this.cmb_ObraSocialLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ObraSocialLista.FormattingEnabled = true;
            this.cmb_ObraSocialLista.Location = new System.Drawing.Point(278, 85);
            this.cmb_ObraSocialLista.Name = "cmb_ObraSocialLista";
            this.cmb_ObraSocialLista.Size = new System.Drawing.Size(138, 23);
            this.cmb_ObraSocialLista.TabIndex = 7;
            // 
            // lbl_obraSocial
            // 
            this.lbl_obraSocial.AutoSize = true;
            this.lbl_obraSocial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_obraSocial.Location = new System.Drawing.Point(278, 70);
            this.lbl_obraSocial.Name = "lbl_obraSocial";
            this.lbl_obraSocial.Size = new System.Drawing.Size(67, 15);
            this.lbl_obraSocial.TabIndex = 25;
            this.lbl_obraSocial.Text = "Obra Social";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_fecha.Location = new System.Drawing.Point(278, 116);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(38, 15);
            this.lbl_fecha.TabIndex = 27;
            this.lbl_fecha.Text = "Fecha";
            // 
            // lbl_horario
            // 
            this.lbl_horario.AutoSize = true;
            this.lbl_horario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_horario.Location = new System.Drawing.Point(278, 162);
            this.lbl_horario.Name = "lbl_horario";
            this.lbl_horario.Size = new System.Drawing.Size(47, 15);
            this.lbl_horario.TabIndex = 29;
            this.lbl_horario.Text = "Horario";
            // 
            // cmb_Horario
            // 
            this.cmb_Horario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Horario.DropDownWidth = 233;
            this.cmb_Horario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_Horario.FormatString = "t";
            this.cmb_Horario.FormattingEnabled = true;
            this.cmb_Horario.Location = new System.Drawing.Point(278, 179);
            this.cmb_Horario.Name = "cmb_Horario";
            this.cmb_Horario.Size = new System.Drawing.Size(138, 23);
            this.cmb_Horario.TabIndex = 9;
            // 
            // dtp_agenda
            // 
            this.dtp_agenda.CustomFormat = "dd/MM/yyyy";
            this.dtp_agenda.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_agenda.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_agenda.Location = new System.Drawing.Point(278, 134);
            this.dtp_agenda.Name = "dtp_agenda";
            this.dtp_agenda.Size = new System.Drawing.Size(138, 23);
            this.dtp_agenda.TabIndex = 8;
            // 
            // cmb_TipoConsulta
            // 
            this.cmb_TipoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoConsulta.DropDownWidth = 233;
            this.cmb_TipoConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_TipoConsulta.FormattingEnabled = true;
            this.cmb_TipoConsulta.Location = new System.Drawing.Point(22, 227);
            this.cmb_TipoConsulta.Name = "cmb_TipoConsulta";
            this.cmb_TipoConsulta.Size = new System.Drawing.Size(232, 23);
            this.cmb_TipoConsulta.TabIndex = 6;
            // 
            // lbl_tipoConsulta
            // 
            this.lbl_tipoConsulta.AutoSize = true;
            this.lbl_tipoConsulta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_tipoConsulta.Location = new System.Drawing.Point(22, 209);
            this.lbl_tipoConsulta.Name = "lbl_tipoConsulta";
            this.lbl_tipoConsulta.Size = new System.Drawing.Size(96, 15);
            this.lbl_tipoConsulta.TabIndex = 32;
            this.lbl_tipoConsulta.Text = "Tipo de Consulta";
            // 
            // pb_LogoChicoR
            // 
            this.pb_LogoChicoR.Image = global::Formularios.Properties.Resources.Logo_Login;
            this.pb_LogoChicoR.Location = new System.Drawing.Point(261, 218);
            this.pb_LogoChicoR.Name = "pb_LogoChicoR";
            this.pb_LogoChicoR.Size = new System.Drawing.Size(178, 106);
            this.pb_LogoChicoR.TabIndex = 33;
            this.pb_LogoChicoR.TabStop = false;
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Info.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Info.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Info.Location = new System.Drawing.Point(22, 371);
            this.lbl_Info.MaximumSize = new System.Drawing.Size(443, 434);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(133, 19);
            this.lbl_Info.TabIndex = 34;
            this.lbl_Info.Text = "Esperando Turno...";
            this.lbl_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(443, 434);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.pb_LogoChicoR);
            this.Controls.Add(this.lbl_tipoConsulta);
            this.Controls.Add(this.cmb_TipoConsulta);
            this.Controls.Add(this.dtp_agenda);
            this.Controls.Add(this.lbl_horario);
            this.Controls.Add(this.cmb_Horario);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_obraSocial);
            this.Controls.Add(this.cmb_ObraSocialLista);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.txb_mail);
            this.Controls.Add(this.lbl_mailGuion);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.txb_telefono);
            this.Controls.Add(this.lbl_telefonoGuion);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.txb_dni);
            this.Controls.Add(this.lbl_dniGuion);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.txb_apellido);
            this.Controls.Add(this.lbl_apellidoGuion);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.txb_nombre);
            this.Controls.Add(this.lbl_nombreGuion);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btn_ingreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(415, 246);
            this.Name = "FormRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegistro";
            this.Load += new System.EventHandler(this.FormRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_LogoChicoR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ingreso;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_nombreGuion;
        private System.Windows.Forms.Label lbl_apellidoGuion;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_dniGuion;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Label lbl_telefonoGuion;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_mailGuion;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Label lbl_obraSocial;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_horario;
        private System.Windows.Forms.Label lbl_tipoConsulta;
        public System.Windows.Forms.TextBox txb_nombre;
        public System.Windows.Forms.TextBox txb_apellido;
        public System.Windows.Forms.TextBox txb_dni;
        public System.Windows.Forms.TextBox txb_telefono;
        public System.Windows.Forms.TextBox txb_mail;
        public System.Windows.Forms.ComboBox cmb_ObraSocialLista;
        public System.Windows.Forms.ComboBox cmb_Horario;
        public System.Windows.Forms.DateTimePicker dtp_agenda;
        public System.Windows.Forms.ComboBox cmb_TipoConsulta;
        private System.Windows.Forms.PictureBox pb_LogoChicoR;
        private System.Windows.Forms.Label lbl_Info;
    }
}