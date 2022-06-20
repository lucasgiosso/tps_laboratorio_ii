namespace Formularios
{
    partial class FormPrincipal
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
            this.btn_Turno = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_listaEspera = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.tm_HoraFecha = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Turno
            // 
            this.btn_Turno.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Turno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Turno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Turno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Turno.Location = new System.Drawing.Point(0, 132);
            this.btn_Turno.Name = "btn_Turno";
            this.btn_Turno.Size = new System.Drawing.Size(132, 29);
            this.btn_Turno.TabIndex = 3;
            this.btn_Turno.Text = "Registrar Turno";
            this.btn_Turno.UseVisualStyleBackColor = false;
            this.btn_Turno.Click += new System.EventHandler(this.btn_Turno_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(131, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(669, 111);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(132, 451);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // btn_listaEspera
            // 
            this.btn_listaEspera.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_listaEspera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listaEspera.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_listaEspera.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_listaEspera.Location = new System.Drawing.Point(0, 165);
            this.btn_listaEspera.Name = "btn_listaEspera";
            this.btn_listaEspera.Size = new System.Drawing.Size(132, 29);
            this.btn_listaEspera.TabIndex = 4;
            this.btn_listaEspera.Text = "Turnos Registrados";
            this.btn_listaEspera.UseVisualStyleBackColor = false;
            this.btn_listaEspera.Click += new System.EventHandler(this.btn_listaEspera_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Salir.Location = new System.Drawing.Point(0, 402);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(132, 29);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Hora.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Hora.Location = new System.Drawing.Point(138, 9);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(79, 28);
            this.lbl_Hora.TabIndex = 6;
            this.lbl_Hora.Text = "Horario";
            // 
            // pb_Logo
            // 
            this.pb_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_Logo.Image = global::Formularios.Properties.Resources.Logo_Principal;
            this.pb_Logo.Location = new System.Drawing.Point(204, -15);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(500, 500);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Logo.TabIndex = 7;
            this.pb_Logo.TabStop = false;
            // 
            // tm_HoraFecha
            // 
            this.tm_HoraFecha.Enabled = true;
            this.tm_HoraFecha.Tick += new System.EventHandler(this.tm_HoraFecha_Tick);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Hora);
            this.Controls.Add(this.pb_Logo);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_listaEspera);
            this.Controls.Add(this.btn_Turno);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_Turno;
        private System.Windows.Forms.Button btn_listaEspera;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Timer tm_HoraFecha;
    }
}