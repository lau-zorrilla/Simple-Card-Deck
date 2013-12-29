namespace FormsAppBaraja
{
    partial class FormBaraja
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbPlayer1 = new System.Windows.Forms.TextBox();
            this.tbPlayer2 = new System.Windows.Forms.TextBox();
            this.tbBaraja = new System.Windows.Forms.TextBox();
            this.lbPlayer1 = new System.Windows.Forms.Label();
            this.lbPlayer2 = new System.Windows.Forms.Label();
            this.tbScore1 = new System.Windows.Forms.TextBox();
            this.tbScore2 = new System.Windows.Forms.TextBox();
            this.btPlay = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.Button();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbMarcador1 = new System.Windows.Forms.Label();
            this.lbMarcador2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbLogo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPlayer1
            // 
            this.tbPlayer1.Location = new System.Drawing.Point(34, 152);
            this.tbPlayer1.Name = "tbPlayer1";
            this.tbPlayer1.Size = new System.Drawing.Size(100, 20);
            this.tbPlayer1.TabIndex = 2;
            // 
            // tbPlayer2
            // 
            this.tbPlayer2.Location = new System.Drawing.Point(179, 152);
            this.tbPlayer2.Name = "tbPlayer2";
            this.tbPlayer2.Size = new System.Drawing.Size(100, 20);
            this.tbPlayer2.TabIndex = 3;
            // 
            // tbBaraja
            // 
            this.tbBaraja.Location = new System.Drawing.Point(34, 201);
            this.tbBaraja.Name = "tbBaraja";
            this.tbBaraja.ReadOnly = true;
            this.tbBaraja.Size = new System.Drawing.Size(253, 20);
            this.tbBaraja.TabIndex = 4;
            this.tbBaraja.TabStop = false;
            // 
            // lbPlayer1
            // 
            this.lbPlayer1.AutoSize = true;
            this.lbPlayer1.BackColor = System.Drawing.Color.Black;
            this.lbPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbPlayer1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayer1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbPlayer1.Location = new System.Drawing.Point(71, 318);
            this.lbPlayer1.Name = "lbPlayer1";
            this.lbPlayer1.Size = new System.Drawing.Size(27, 16);
            this.lbPlayer1.TabIndex = 1;
            this.lbPlayer1.Text = "0, 0";
            // 
            // lbPlayer2
            // 
            this.lbPlayer2.AutoSize = true;
            this.lbPlayer2.BackColor = System.Drawing.Color.Black;
            this.lbPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbPlayer2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayer2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPlayer2.Location = new System.Drawing.Point(216, 318);
            this.lbPlayer2.Name = "lbPlayer2";
            this.lbPlayer2.Size = new System.Drawing.Size(27, 16);
            this.lbPlayer2.TabIndex = 1;
            this.lbPlayer2.Text = "0, 0";
            // 
            // tbScore1
            // 
            this.tbScore1.Location = new System.Drawing.Point(64, 345);
            this.tbScore1.Name = "tbScore1";
            this.tbScore1.Size = new System.Drawing.Size(41, 20);
            this.tbScore1.TabIndex = 5;
            // 
            // tbScore2
            // 
            this.tbScore2.Location = new System.Drawing.Point(207, 345);
            this.tbScore2.Name = "tbScore2";
            this.tbScore2.Size = new System.Drawing.Size(45, 20);
            this.tbScore2.TabIndex = 6;
            // 
            // btPlay
            // 
            this.btPlay.BackColor = System.Drawing.Color.Gray;
            this.btPlay.Enabled = false;
            this.btPlay.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btPlay.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btPlay.Location = new System.Drawing.Point(121, 425);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(75, 23);
            this.btPlay.TabIndex = 0;
            this.btPlay.Text = "JUGAR";
            this.btPlay.UseVisualStyleBackColor = false;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // btNew
            // 
            this.btNew.BackColor = System.Drawing.Color.Gray;
            this.btNew.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNew.Location = new System.Drawing.Point(121, 68);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(75, 23);
            this.btNew.TabIndex = 1;
            this.btNew.Text = "NUEVO";
            this.btNew.UseVisualStyleBackColor = false;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btCerrar
            // 
            this.btCerrar.BackColor = System.Drawing.Color.Gray;
            this.btCerrar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCerrar.Location = new System.Drawing.Point(212, 486);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(75, 23);
            this.btCerrar.TabIndex = 7;
            this.btCerrar.Text = "CERRAR";
            this.btCerrar.UseVisualStyleBackColor = false;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.BackColor = System.Drawing.Color.Black;
            this.lbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCantidad.Location = new System.Drawing.Point(144, 237);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(18, 20);
            this.lbCantidad.TabIndex = 8;
            this.lbCantidad.Text = "0";
            // 
            // lbMarcador1
            // 
            this.lbMarcador1.AutoSize = true;
            this.lbMarcador1.BackColor = System.Drawing.Color.Black;
            this.lbMarcador1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMarcador1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarcador1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbMarcador1.Location = new System.Drawing.Point(49, 117);
            this.lbMarcador1.Name = "lbMarcador1";
            this.lbMarcador1.Size = new System.Drawing.Size(70, 16);
            this.lbMarcador1.TabIndex = 9;
            this.lbMarcador1.Text = "Marcador 1";
            // 
            // lbMarcador2
            // 
            this.lbMarcador2.AutoSize = true;
            this.lbMarcador2.BackColor = System.Drawing.Color.Black;
            this.lbMarcador2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMarcador2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarcador2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbMarcador2.Location = new System.Drawing.Point(194, 117);
            this.lbMarcador2.Name = "lbMarcador2";
            this.lbMarcador2.Size = new System.Drawing.Size(70, 16);
            this.lbMarcador2.TabIndex = 9;
            this.lbMarcador2.Text = "Marcador 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(34, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cantidad: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(53, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jugador 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(198, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Jugador 2";
            // 
            // lbLogo
            // 
            this.lbLogo.AutoSize = true;
            this.lbLogo.BackColor = System.Drawing.Color.Transparent;
            this.lbLogo.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogo.ForeColor = System.Drawing.Color.DarkGray;
            this.lbLogo.Location = new System.Drawing.Point(35, 22);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(101, 39);
            this.lbLogo.TabIndex = 10;
            this.lbLogo.Text = "baraja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(185, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 39);
            this.label4.TabIndex = 10;
            this.label4.Text = "baraja";
            // 
            // FormBaraja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = global::FormsAppBaraja.Properties.Resources.fondo_baraja_png;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(312, 534);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbLogo);
            this.Controls.Add(this.lbMarcador2);
            this.Controls.Add(this.lbMarcador1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbPlayer2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPlayer1);
            this.Controls.Add(this.tbBaraja);
            this.Controls.Add(this.tbScore2);
            this.Controls.Add(this.tbScore1);
            this.Controls.Add(this.tbPlayer2);
            this.Controls.Add(this.tbPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormBaraja";
            this.Text = "Baraja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPlayer1;
        private System.Windows.Forms.TextBox tbPlayer2;
        private System.Windows.Forms.TextBox tbBaraja;
        private System.Windows.Forms.Label lbPlayer1;
        private System.Windows.Forms.Label lbPlayer2;
        private System.Windows.Forms.TextBox tbScore1;
        private System.Windows.Forms.TextBox tbScore2;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbMarcador1;
        private System.Windows.Forms.Label lbMarcador2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.Label label4;
    }
}

