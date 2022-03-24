namespace pokedex
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.Izquerda = new System.Windows.Forms.Button();
            this.Derecha = new System.Windows.Forms.Button();
            this.nombrePokemons = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dato1 = new System.Windows.Forms.Label();
            this.dato2 = new System.Windows.Forms.Label();
            this.dato5 = new System.Windows.Forms.Label();
            this.dato3 = new System.Windows.Forms.Label();
            this.dato6 = new System.Windows.Forms.Label();
            this.dato4 = new System.Windows.Forms.Label();
            this.movimientos = new System.Windows.Forms.Button();
            this.informacion = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // Izquerda
            // 
            this.Izquerda.AutoSize = true;
            this.Izquerda.BackColor = System.Drawing.Color.Transparent;
            this.Izquerda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Izquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Izquerda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Izquerda.Location = new System.Drawing.Point(307, 454);
            this.Izquerda.Name = "Izquerda";
            this.Izquerda.Size = new System.Drawing.Size(45, 45);
            this.Izquerda.TabIndex = 0;
            this.Izquerda.Text = "<";
            this.Izquerda.UseVisualStyleBackColor = false;
            this.Izquerda.Click += new System.EventHandler(this.Izquerda_Click);
            // 
            // Derecha
            // 
            this.Derecha.BackColor = System.Drawing.Color.Transparent;
            this.Derecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Derecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Derecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Derecha.Location = new System.Drawing.Point(349, 454);
            this.Derecha.Name = "Derecha";
            this.Derecha.Size = new System.Drawing.Size(37, 41);
            this.Derecha.TabIndex = 3;
            this.Derecha.Text = ">";
            this.Derecha.UseVisualStyleBackColor = false;
            this.Derecha.Click += new System.EventHandler(this.Derecha_Click);
            // 
            // nombrePokemons
            // 
            this.nombrePokemons.Font = new System.Drawing.Font("Pokemon Solid", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePokemons.ForeColor = System.Drawing.SystemColors.Desktop;
            this.nombrePokemons.Location = new System.Drawing.Point(214, 198);
            this.nombrePokemons.Name = "nombrePokemons";
            this.nombrePokemons.Size = new System.Drawing.Size(96, 33);
            this.nombrePokemons.TabIndex = 4;
            this.nombrePokemons.Text = "Pokemon";
            this.nombrePokemons.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nombrePokemons.AutoSizeChanged += new System.EventHandler(this.label1_AutoSizeChanged);
            this.nombrePokemons.Click += new System.EventHandler(this.nombrePokemons_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(182, 234);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(170, 123);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // dato1
            // 
            this.dato1.AutoEllipsis = true;
            this.dato1.Location = new System.Drawing.Point(479, 214);
            this.dato1.Name = "dato1";
            this.dato1.Size = new System.Drawing.Size(82, 28);
            this.dato1.TabIndex = 5;
            this.dato1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dato1.BindingContextChanged += new System.EventHandler(this.dato1_BindingContextChanged);
            this.dato1.Click += new System.EventHandler(this.datosPokemon_Click);
            // 
            // dato2
            // 
            this.dato2.Location = new System.Drawing.Point(567, 214);
            this.dato2.Name = "dato2";
            this.dato2.Size = new System.Drawing.Size(85, 28);
            this.dato2.TabIndex = 6;
            this.dato2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dato2.Click += new System.EventHandler(this.habitat_Click);
            // 
            // dato5
            // 
            this.dato5.Location = new System.Drawing.Point(476, 282);
            this.dato5.Name = "dato5";
            this.dato5.Size = new System.Drawing.Size(85, 28);
            this.dato5.TabIndex = 7;
            this.dato5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dato5.Click += new System.EventHandler(this.especie_Click);
            // 
            // dato3
            // 
            this.dato3.Location = new System.Drawing.Point(476, 254);
            this.dato3.Name = "dato3";
            this.dato3.Size = new System.Drawing.Size(85, 28);
            this.dato3.TabIndex = 8;
            this.dato3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dato3.Click += new System.EventHandler(this.peso_Click);
            // 
            // dato6
            // 
            this.dato6.Location = new System.Drawing.Point(567, 282);
            this.dato6.Name = "dato6";
            this.dato6.Size = new System.Drawing.Size(85, 28);
            this.dato6.TabIndex = 9;
            this.dato6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dato6.Click += new System.EventHandler(this.tipo2_Click);
            // 
            // dato4
            // 
            this.dato4.Location = new System.Drawing.Point(567, 254);
            this.dato4.Name = "dato4";
            this.dato4.Size = new System.Drawing.Size(85, 28);
            this.dato4.TabIndex = 10;
            this.dato4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dato4.Click += new System.EventHandler(this.tipo1_Click);
            // 
            // movimientos
            // 
            this.movimientos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.movimientos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.movimientos.BackColor = System.Drawing.Color.DarkOrange;
            this.movimientos.Font = new System.Drawing.Font("Pokemon Solid", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimientos.Location = new System.Drawing.Point(470, 489);
            this.movimientos.Name = "movimientos";
            this.movimientos.Size = new System.Drawing.Size(94, 49);
            this.movimientos.TabIndex = 11;
            this.movimientos.Text = "movimientos";
            this.movimientos.UseVisualStyleBackColor = false;
            this.movimientos.Click += new System.EventHandler(this.movimientos_Click);
            // 
            // informacion
            // 
            this.informacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.informacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.informacion.BackColor = System.Drawing.Color.DarkOrange;
            this.informacion.Font = new System.Drawing.Font("Pokemon Solid", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informacion.Location = new System.Drawing.Point(570, 489);
            this.informacion.Name = "informacion";
            this.informacion.Size = new System.Drawing.Size(94, 49);
            this.informacion.TabIndex = 12;
            this.informacion.Text = "descripcion";
            this.informacion.UseVisualStyleBackColor = false;
            this.informacion.Click += new System.EventHandler(this.informacion_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 640);
            this.Controls.Add(this.informacion);
            this.Controls.Add(this.movimientos);
            this.Controls.Add(this.dato4);
            this.Controls.Add(this.dato6);
            this.Controls.Add(this.dato3);
            this.Controls.Add(this.dato5);
            this.Controls.Add(this.dato2);
            this.Controls.Add(this.dato1);
            this.Controls.Add(this.nombrePokemons);
            this.Controls.Add(this.Derecha);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Izquerda);
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Izquerda;
        private System.Windows.Forms.Button Derecha;
        private System.Windows.Forms.Label nombrePokemons;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label dato1;
        private System.Windows.Forms.Label dato2;
        private System.Windows.Forms.Label dato5;
        private System.Windows.Forms.Label dato3;
        private System.Windows.Forms.Label dato6;
        private System.Windows.Forms.Label dato4;
        private System.Windows.Forms.Button movimientos;
        private System.Windows.Forms.Button informacion;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

