namespace Login___DB
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            this.dB_TiendaDataSet = new Login___DB.DB_TiendaDataSet();
            this.tblPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPersonaTableAdapter = new Login___DB.DB_TiendaDataSetTableAdapters.tblPersonaTableAdapter();
            this.tableAdapterManager = new Login___DB.DB_TiendaDataSetTableAdapters.TableAdapterManager();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.Panel();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btbRegistrar = new System.Windows.Forms.Button();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblDigitar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TiendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonaBindingSource)).BeginInit();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // dB_TiendaDataSet
            // 
            this.dB_TiendaDataSet.DataSetName = "DB_TiendaDataSet";
            this.dB_TiendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPersonaBindingSource
            // 
            this.tblPersonaBindingSource.DataMember = "tblPersona";
            this.tblPersonaBindingSource.DataSource = this.dB_TiendaDataSet;
            // 
            // tblPersonaTableAdapter
            // 
            this.tblPersonaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblPersonaTableAdapter = this.tblPersonaTableAdapter;
            this.tableAdapterManager.tblProductosTableAdapter = null;
            this.tableAdapterManager.tblVentaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Login___DB.DB_TiendaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Contraseña.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPersonaBindingSource, "Correo", true));
            this.txt_Contraseña.Font = new System.Drawing.Font("Heebo", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contraseña.ForeColor = System.Drawing.Color.White;
            this.txt_Contraseña.Location = new System.Drawing.Point(366, 148);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(228, 31);
            this.txt_Contraseña.TabIndex = 10;
            this.txt_Contraseña.Text = "Contraseña";
            this.txt_Contraseña.Enter += new System.EventHandler(this.txt_Contraseña_Enter);
            this.txt_Contraseña.Leave += new System.EventHandler(this.txt_Contraseña_Leave);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Heebo", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(296, 256);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(171, 32);
            this.btnInicio.TabIndex = 11;
            this.btnInicio.Text = "INICIAR SESIÓN";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnl.Controls.Add(this.lblInicio);
            this.pnl.Location = new System.Drawing.Point(2, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(243, 330);
            this.pnl.TabIndex = 12;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Nombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPersonaBindingSource, "Correo", true));
            this.txt_Nombre.Font = new System.Drawing.Font("Heebo", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.ForeColor = System.Drawing.Color.White;
            this.txt_Nombre.Location = new System.Drawing.Point(366, 61);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(228, 31);
            this.txt_Nombre.TabIndex = 13;
            this.txt_Nombre.Text = "Nombre";
            this.txt_Nombre.Enter += new System.EventHandler(this.txt_Nombre_Enter);
            this.txt_Nombre.Leave += new System.EventHandler(this.txt_Nombre_Leave);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCorreo.Location = new System.Drawing.Point(363, 95);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(235, 13);
            this.lblCorreo.TabIndex = 14;
            this.lblCorreo.Text = "______________________________________";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContraseña.Location = new System.Drawing.Point(363, 182);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(235, 13);
            this.lblContraseña.TabIndex = 15;
            this.lblContraseña.Text = "______________________________________";
            // 
            // btbRegistrar
            // 
            this.btbRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btbRegistrar.FlatAppearance.BorderSize = 0;
            this.btbRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbRegistrar.Font = new System.Drawing.Font("Heebo", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbRegistrar.ForeColor = System.Drawing.Color.White;
            this.btbRegistrar.Location = new System.Drawing.Point(491, 256);
            this.btbRegistrar.Name = "btbRegistrar";
            this.btbRegistrar.Size = new System.Drawing.Size(171, 32);
            this.btbRegistrar.TabIndex = 16;
            this.btbRegistrar.Text = "REGISTRARSE";
            this.btbRegistrar.UseVisualStyleBackColor = false;
            this.btbRegistrar.Click += new System.EventHandler(this.btbRegistrar_Click);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.BackColor = System.Drawing.Color.Black;
            this.lblInicio.Font = new System.Drawing.Font("Heebo", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.Color.White;
            this.lblInicio.Location = new System.Drawing.Point(58, 133);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(124, 52);
            this.lblInicio.TabIndex = 17;
            this.lblInicio.Text = "INICIO";
            // 
            // lblDigitar
            // 
            this.lblDigitar.AutoSize = true;
            this.lblDigitar.Font = new System.Drawing.Font("Heebo", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitar.ForeColor = System.Drawing.Color.White;
            this.lblDigitar.Location = new System.Drawing.Point(331, 9);
            this.lblDigitar.Name = "lblDigitar";
            this.lblDigitar.Size = new System.Drawing.Size(286, 39);
            this.lblDigitar.TabIndex = 18;
            this.lblDigitar.Text = "Digite en cada campo:";
            this.lblDigitar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(723, 328);
            this.Controls.Add(this.lblDigitar);
            this.Controls.Add(this.btbRegistrar);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.pnl);
            this.Name = "FrmLogin";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TiendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonaBindingSource)).EndInit();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TiendaDataSet dB_TiendaDataSet;
        private System.Windows.Forms.BindingSource tblPersonaBindingSource;
        private DB_TiendaDataSetTableAdapters.tblPersonaTableAdapter tblPersonaTableAdapter;
        private DB_TiendaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btbRegistrar;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblDigitar;
    }
}

