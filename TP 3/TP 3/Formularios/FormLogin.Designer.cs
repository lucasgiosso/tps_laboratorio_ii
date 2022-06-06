namespace Formularios
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Login = new System.Windows.Forms.Button();
            this.txb_Dni = new System.Windows.Forms.TextBox();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.pb_Fondo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Fondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.Location = new System.Drawing.Point(98, 258);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(100, 23);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Iniciar Sesión";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txb_Dni
            // 
            this.txb_Dni.Location = new System.Drawing.Point(47, 177);
            this.txb_Dni.Name = "txb_Dni";
            this.txb_Dni.PlaceholderText = "Dni";
            this.txb_Dni.ReadOnly = true;
            this.txb_Dni.Size = new System.Drawing.Size(207, 23);
            this.txb_Dni.TabIndex = 2;
            this.txb_Dni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(47, 206);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.PasswordChar = '*';
            this.txb_Password.PlaceholderText = "Password";
            this.txb_Password.Size = new System.Drawing.Size(207, 23);
            this.txb_Password.TabIndex = 3;
            this.txb_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pb_Fondo
            // 
            this.pb_Fondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pb_Fondo.Location = new System.Drawing.Point(19, 27);
            this.pb_Fondo.Name = "pb_Fondo";
            this.pb_Fondo.Size = new System.Drawing.Size(266, 293);
            this.pb_Fondo.TabIndex = 5;
            this.pb_Fondo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Image = global::Formularios.Properties.Resources.Logo_Login;
            this.pictureBox1.Location = new System.Drawing.Point(60, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 121);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(303, 351);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.txb_Dni);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.pb_Fondo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Fondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txb_Dni;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.PictureBox pb_Fondo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
