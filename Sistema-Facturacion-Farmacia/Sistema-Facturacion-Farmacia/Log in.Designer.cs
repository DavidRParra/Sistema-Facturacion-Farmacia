namespace Sistema_Facturacion_Farmacia
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
            this.User_IMG = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_User = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Pass = new System.Windows.Forms.TextBox();
            this.Logo_IMG = new System.Windows.Forms.PictureBox();
            this.btn_InicioSesion = new System.Windows.Forms.Button();
            this.btn_RegistrarUsuario = new System.Windows.Forms.Button();
            this.Cerrar_IMG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.User_IMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_IMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar_IMG)).BeginInit();
            this.SuspendLayout();
            // 
            // User_IMG
            // 
            this.User_IMG.Location = new System.Drawing.Point(126, 13);
            this.User_IMG.Name = "User_IMG";
            this.User_IMG.Size = new System.Drawing.Size(131, 118);
            this.User_IMG.TabIndex = 0;
            this.User_IMG.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "__________________________________";
            // 
            // tb_User
            // 
            this.tb_User.BackColor = System.Drawing.SystemColors.Window;
            this.tb_User.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_User.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_User.Location = new System.Drawing.Point(64, 210);
            this.tb_User.Name = "tb_User";
            this.tb_User.Size = new System.Drawing.Size(271, 28);
            this.tb_User.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña";
            // 
            // tb_Pass
            // 
            this.tb_Pass.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Pass.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Pass.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_Pass.Location = new System.Drawing.Point(64, 292);
            this.tb_Pass.Name = "tb_Pass";
            this.tb_Pass.PasswordChar = '*';
            this.tb_Pass.Size = new System.Drawing.Size(271, 28);
            this.tb_Pass.TabIndex = 5;
            // 
            // Logo_IMG
            // 
            this.Logo_IMG.Location = new System.Drawing.Point(144, 394);
            this.Logo_IMG.Name = "Logo_IMG";
            this.Logo_IMG.Size = new System.Drawing.Size(100, 108);
            this.Logo_IMG.TabIndex = 7;
            this.Logo_IMG.TabStop = false;
            // 
            // btn_InicioSesion
            // 
            this.btn_InicioSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.btn_InicioSesion.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InicioSesion.ForeColor = System.Drawing.Color.Gray;
            this.btn_InicioSesion.Location = new System.Drawing.Point(64, 326);
            this.btn_InicioSesion.Name = "btn_InicioSesion";
            this.btn_InicioSesion.Size = new System.Drawing.Size(271, 29);
            this.btn_InicioSesion.TabIndex = 8;
            this.btn_InicioSesion.Text = "Iniciar  sesión";
            this.btn_InicioSesion.UseVisualStyleBackColor = false;
            this.btn_InicioSesion.Click += new System.EventHandler(this.btn_InicioSesion_Click);
            // 
            // btn_RegistrarUsuario
            // 
            this.btn_RegistrarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.btn_RegistrarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_RegistrarUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegistrarUsuario.ForeColor = System.Drawing.Color.Gray;
            this.btn_RegistrarUsuario.Location = new System.Drawing.Point(64, 359);
            this.btn_RegistrarUsuario.Name = "btn_RegistrarUsuario";
            this.btn_RegistrarUsuario.Size = new System.Drawing.Size(271, 29);
            this.btn_RegistrarUsuario.TabIndex = 9;
            this.btn_RegistrarUsuario.Text = "Registrar Usuario";
            this.btn_RegistrarUsuario.UseVisualStyleBackColor = false;
            this.btn_RegistrarUsuario.Click += new System.EventHandler(this.btn_RegistrarUsuario_Click);
            // 
            // Cerrar_IMG
            // 
            this.Cerrar_IMG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cerrar_IMG.Location = new System.Drawing.Point(365, 12);
            this.Cerrar_IMG.Name = "Cerrar_IMG";
            this.Cerrar_IMG.Size = new System.Drawing.Size(20, 20);
            this.Cerrar_IMG.TabIndex = 10;
            this.Cerrar_IMG.TabStop = false;
            this.Cerrar_IMG.Click += new System.EventHandler(this.Cerrar_IMG_Click);
            this.Cerrar_IMG.MouseEnter += new System.EventHandler(this.Cerrar_IMG_MouseEnter);
            this.Cerrar_IMG.MouseLeave += new System.EventHandler(this.Cerrar_IMG_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(397, 514);
            this.ControlBox = false;
            this.Controls.Add(this.Cerrar_IMG);
            this.Controls.Add(this.btn_RegistrarUsuario);
            this.Controls.Add(this.btn_InicioSesion);
            this.Controls.Add(this.Logo_IMG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_User);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.User_IMG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.User_IMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_IMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar_IMG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox User_IMG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Pass;
        private System.Windows.Forms.PictureBox Logo_IMG;
        private System.Windows.Forms.Button btn_InicioSesion;
        private System.Windows.Forms.Button btn_RegistrarUsuario;
        private System.Windows.Forms.PictureBox Cerrar_IMG;
    }
}

