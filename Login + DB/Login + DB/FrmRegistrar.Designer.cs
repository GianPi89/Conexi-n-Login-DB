namespace Login___DB
{
    partial class FrmRegistrar
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
            this.btbRegistrar = new System.Windows.Forms.Button();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TipoUsuario = new System.Windows.Forms.TextBox();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.lblDigitar1 = new System.Windows.Forms.Label();
            this.lblDigitar2 = new System.Windows.Forms.Label();
            this.lblDigitar3 = new System.Windows.Forms.Label();
            this.lblDigitar4 = new System.Windows.Forms.Label();
            this.lblDigitar5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btbRegistrar
            // 
            this.btbRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btbRegistrar.FlatAppearance.BorderSize = 0;
            this.btbRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbRegistrar.Font = new System.Drawing.Font("Heebo", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbRegistrar.ForeColor = System.Drawing.Color.White;
            this.btbRegistrar.Location = new System.Drawing.Point(104, 386);
            this.btbRegistrar.Name = "btbRegistrar";
            this.btbRegistrar.Size = new System.Drawing.Size(171, 32);
            this.btbRegistrar.TabIndex = 21;
            this.btbRegistrar.Text = "REGISTRARSE";
            this.btbRegistrar.UseVisualStyleBackColor = false;
            this.btbRegistrar.Click += new System.EventHandler(this.btbRegistrar_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContraseña.Location = new System.Drawing.Point(114, 219);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(235, 13);
            this.lblContraseña.TabIndex = 20;
            this.lblContraseña.Text = "______________________________________";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCorreo.Location = new System.Drawing.Point(114, 156);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(235, 13);
            this.lblCorreo.TabIndex = 19;
            this.lblCorreo.Text = "______________________________________";
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Contraseña.Font = new System.Drawing.Font("Heebo", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contraseña.ForeColor = System.Drawing.Color.White;
            this.txt_Contraseña.Location = new System.Drawing.Point(117, 185);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(228, 31);
            this.txt_Contraseña.TabIndex = 17;
            this.txt_Contraseña.Text = "Contraseña";
            this.txt_Contraseña.Enter += new System.EventHandler(this.txt_Contraseña_Enter);
            this.txt_Contraseña.Leave += new System.EventHandler(this.txt_Contraseña_Leave);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Nombre.Font = new System.Drawing.Font("Heebo", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.ForeColor = System.Drawing.Color.White;
            this.txt_Nombre.Location = new System.Drawing.Point(117, 122);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(228, 31);
            this.txt_Nombre.TabIndex = 18;
            this.txt_Nombre.Text = "Nombre";
            this.txt_Nombre.Enter += new System.EventHandler(this.txt_Nombre_Enter);
            this.txt_Nombre.Leave += new System.EventHandler(this.txt_Nombre_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(114, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "______________________________________";
            // 
            // txt_Id
            // 
            this.txt_Id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Id.Font = new System.Drawing.Font("Heebo", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id.ForeColor = System.Drawing.Color.White;
            this.txt_Id.Location = new System.Drawing.Point(117, 64);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(228, 31);
            this.txt_Id.TabIndex = 22;
            this.txt_Id.Text = "ID";
            this.txt_Id.Enter += new System.EventHandler(this.txt_Id_Enter);
            this.txt_Id.Leave += new System.EventHandler(this.txt_Id_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(114, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "______________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(114, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "______________________________________";
            // 
            // txt_TipoUsuario
            // 
            this.txt_TipoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_TipoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TipoUsuario.Font = new System.Drawing.Font("Heebo", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TipoUsuario.ForeColor = System.Drawing.Color.White;
            this.txt_TipoUsuario.Location = new System.Drawing.Point(117, 312);
            this.txt_TipoUsuario.Name = "txt_TipoUsuario";
            this.txt_TipoUsuario.Size = new System.Drawing.Size(228, 31);
            this.txt_TipoUsuario.TabIndex = 24;
            this.txt_TipoUsuario.Text = "Tipo de Usuario";
            this.txt_TipoUsuario.Enter += new System.EventHandler(this.txt_TipoUsuario_Enter);
            this.txt_TipoUsuario.Leave += new System.EventHandler(this.txt_TipoUsuario_Leave);
            // 
            // txt_Correo
            // 
            this.txt_Correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_Correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Correo.Font = new System.Drawing.Font("Heebo", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Correo.ForeColor = System.Drawing.Color.White;
            this.txt_Correo.Location = new System.Drawing.Point(117, 248);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(228, 31);
            this.txt_Correo.TabIndex = 25;
            this.txt_Correo.Text = "Correo";
            this.txt_Correo.Enter += new System.EventHandler(this.txt_Correo_Enter);
            this.txt_Correo.Leave += new System.EventHandler(this.txt_Correo_Leave);
            // 
            // lblDigitar1
            // 
            this.lblDigitar1.AutoSize = true;
            this.lblDigitar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitar1.ForeColor = System.Drawing.Color.White;
            this.lblDigitar1.Location = new System.Drawing.Point(46, 71);
            this.lblDigitar1.Name = "lblDigitar1";
            this.lblDigitar1.Size = new System.Drawing.Size(62, 24);
            this.lblDigitar1.TabIndex = 28;
            this.lblDigitar1.Text = "Digite:";
            // 
            // lblDigitar2
            // 
            this.lblDigitar2.AutoSize = true;
            this.lblDigitar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitar2.ForeColor = System.Drawing.Color.White;
            this.lblDigitar2.Location = new System.Drawing.Point(46, 129);
            this.lblDigitar2.Name = "lblDigitar2";
            this.lblDigitar2.Size = new System.Drawing.Size(62, 24);
            this.lblDigitar2.TabIndex = 29;
            this.lblDigitar2.Text = "Digite:";
            // 
            // lblDigitar3
            // 
            this.lblDigitar3.AutoSize = true;
            this.lblDigitar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitar3.ForeColor = System.Drawing.Color.White;
            this.lblDigitar3.Location = new System.Drawing.Point(46, 192);
            this.lblDigitar3.Name = "lblDigitar3";
            this.lblDigitar3.Size = new System.Drawing.Size(62, 24);
            this.lblDigitar3.TabIndex = 30;
            this.lblDigitar3.Text = "Digite:";
            // 
            // lblDigitar4
            // 
            this.lblDigitar4.AutoSize = true;
            this.lblDigitar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitar4.ForeColor = System.Drawing.Color.White;
            this.lblDigitar4.Location = new System.Drawing.Point(46, 255);
            this.lblDigitar4.Name = "lblDigitar4";
            this.lblDigitar4.Size = new System.Drawing.Size(62, 24);
            this.lblDigitar4.TabIndex = 31;
            this.lblDigitar4.Text = "Digite:";
            // 
            // lblDigitar5
            // 
            this.lblDigitar5.AutoSize = true;
            this.lblDigitar5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitar5.ForeColor = System.Drawing.Color.White;
            this.lblDigitar5.Location = new System.Drawing.Point(46, 319);
            this.lblDigitar5.Name = "lblDigitar5";
            this.lblDigitar5.Size = new System.Drawing.Size(62, 24);
            this.lblDigitar5.TabIndex = 32;
            this.lblDigitar5.Text = "Digite:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblRegistro);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 41);
            this.panel1.TabIndex = 33;
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Heebo", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(132, 8);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(100, 31);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Text = "Registro";
            // 
            // FrmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDigitar5);
            this.Controls.Add(this.lblDigitar4);
            this.Controls.Add(this.lblDigitar3);
            this.Controls.Add(this.lblDigitar2);
            this.Controls.Add(this.lblDigitar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_TipoUsuario);
            this.Controls.Add(this.txt_Correo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.btbRegistrar);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.txt_Nombre);
            this.Name = "FrmRegistrar";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.FrmRegistrar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btbRegistrar;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TipoUsuario;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.Label lblDigitar1;
        private System.Windows.Forms.Label lblDigitar2;
        private System.Windows.Forms.Label lblDigitar3;
        private System.Windows.Forms.Label lblDigitar4;
        private System.Windows.Forms.Label lblDigitar5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRegistro;
    }
}