namespace Formularios
{
    partial class FormLista
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
            this.dgv_Lista = new System.Windows.Forms.DataGridView();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Exportar = new System.Windows.Forms.Button();
            this.btn_Importar = new System.Windows.Forms.Button();
            this.lbl_InfoCarga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Lista
            // 
            this.dgv_Lista.AllowUserToAddRows = false;
            this.dgv_Lista.AllowUserToDeleteRows = false;
            this.dgv_Lista.AllowUserToResizeColumns = false;
            this.dgv_Lista.AllowUserToResizeRows = false;
            this.dgv_Lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lista.Location = new System.Drawing.Point(12, 12);
            this.dgv_Lista.MultiSelect = false;
            this.dgv_Lista.Name = "dgv_Lista";
            this.dgv_Lista.ReadOnly = true;
            this.dgv_Lista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgv_Lista.RowTemplate.Height = 25;
            this.dgv_Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Lista.Size = new System.Drawing.Size(1110, 554);
            this.dgv_Lista.TabIndex = 0;
            this.dgv_Lista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Lista_CellDoubleClick);
            // 
            // btn_Volver
            // 
            this.btn_Volver.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Volver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.btn_Volver.FlatAppearance.BorderSize = 0;
            this.btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Volver.Location = new System.Drawing.Point(1021, 572);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(104, 23);
            this.btn_Volver.TabIndex = 22;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Eliminar.Location = new System.Drawing.Point(911, 572);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(104, 23);
            this.btn_Eliminar.TabIndex = 23;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Exportar
            // 
            this.btn_Exportar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Exportar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.btn_Exportar.FlatAppearance.BorderSize = 0;
            this.btn_Exportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exportar.Location = new System.Drawing.Point(801, 572);
            this.btn_Exportar.Name = "btn_Exportar";
            this.btn_Exportar.Size = new System.Drawing.Size(104, 23);
            this.btn_Exportar.TabIndex = 24;
            this.btn_Exportar.Text = "Exportar";
            this.btn_Exportar.UseVisualStyleBackColor = false;
            this.btn_Exportar.Click += new System.EventHandler(this.btn_Exportar_Click);
            // 
            // btn_Importar
            // 
            this.btn_Importar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Importar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.btn_Importar.FlatAppearance.BorderSize = 0;
            this.btn_Importar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Importar.Location = new System.Drawing.Point(691, 572);
            this.btn_Importar.Name = "btn_Importar";
            this.btn_Importar.Size = new System.Drawing.Size(104, 23);
            this.btn_Importar.TabIndex = 25;
            this.btn_Importar.Text = "Importar";
            this.btn_Importar.UseVisualStyleBackColor = false;
            this.btn_Importar.Click += new System.EventHandler(this.btn_Importar_Click);
            // 
            // lbl_InfoCarga
            // 
            this.lbl_InfoCarga.AutoSize = true;
            this.lbl_InfoCarga.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_InfoCarga.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_InfoCarga.Location = new System.Drawing.Point(12, 580);
            this.lbl_InfoCarga.Name = "lbl_InfoCarga";
            this.lbl_InfoCarga.Size = new System.Drawing.Size(240, 15);
            this.lbl_InfoCarga.TabIndex = 26;
            this.lbl_InfoCarga.Text = "Verificando conexión de la base de datos...";
            this.lbl_InfoCarga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1134, 607);
            this.Controls.Add(this.lbl_InfoCarga);
            this.Controls.Add(this.btn_Importar);
            this.Controls.Add(this.btn_Exportar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.dgv_Lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(415, 246);
            this.Name = "FormLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLista";
            this.Load += new System.EventHandler(this.FormLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Exportar;
        private System.Windows.Forms.Button btn_Importar;
        public System.Windows.Forms.DataGridView dgv_Lista;
        private System.Windows.Forms.Label lbl_InfoCarga;
    }
}