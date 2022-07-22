namespace Datos
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.btneliminarde = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.txtposicion = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.liver = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(356, 30);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 54);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Base de Datos";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(83, 141);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(247, 54);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "AGREGAR";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtvalor
            // 
            this.txtvalor.AcceptsReturn = true;
            this.txtvalor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor.Location = new System.Drawing.Point(405, 209);
            this.txtvalor.Margin = new System.Windows.Forms.Padding(4);
            this.txtvalor.Multiline = true;
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(249, 62);
            this.txtvalor.TabIndex = 3;
            this.txtvalor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(83, 370);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(145, 43);
            this.btnagregar.TabIndex = 4;
            this.btnagregar.Text = "AGREGAR";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnmostrar
            // 
            this.btnmostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrar.Location = new System.Drawing.Point(236, 370);
            this.btnmostrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(147, 43);
            this.btnmostrar.TabIndex = 5;
            this.btnmostrar.Text = "MOSTRAR";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // btninsertar
            // 
            this.btninsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertar.Location = new System.Drawing.Point(83, 421);
            this.btninsertar.Margin = new System.Windows.Forms.Padding(4);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(145, 43);
            this.btninsertar.TabIndex = 6;
            this.btninsertar.Text = "INSERTAR";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // btneliminarde
            // 
            this.btneliminarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminarde.Location = new System.Drawing.Point(83, 471);
            this.btneliminarde.Margin = new System.Windows.Forms.Padding(4);
            this.btneliminarde.Name = "btneliminarde";
            this.btneliminarde.Size = new System.Drawing.Size(145, 43);
            this.btneliminarde.TabIndex = 7;
            this.btneliminarde.Text = "ELIMINAR DE";
            this.btneliminarde.UseVisualStyleBackColor = true;
            this.btneliminarde.Click += new System.EventHandler(this.btneliminarde_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(83, 522);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(145, 43);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // txtposicion
            // 
            this.txtposicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtposicion.Location = new System.Drawing.Point(418, 387);
            this.txtposicion.Margin = new System.Windows.Forms.Padding(4);
            this.txtposicion.Multiline = true;
            this.txtposicion.Name = "txtposicion";
            this.txtposicion.Size = new System.Drawing.Size(224, 32);
            this.txtposicion.TabIndex = 10;
            this.txtposicion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(418, 336);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(184, 43);
            this.textBox6.TabIndex = 11;
            this.textBox6.Text = "POSICION";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // liver
            // 
            this.liver.AcceptsReturn = true;
            this.liver.AcceptsTab = true;
            this.liver.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.liver.AllowDrop = true;
            this.liver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liver.HideSelection = false;
            this.liver.ImeMode = System.Windows.Forms.ImeMode.On;
            this.liver.Location = new System.Drawing.Point(662, 346);
            this.liver.Margin = new System.Windows.Forms.Padding(4);
            this.liver.Multiline = true;
            this.liver.Name = "liver";
            this.liver.ReadOnly = true;
            this.liver.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.liver.Size = new System.Drawing.Size(296, 280);
            this.liver.TabIndex = 9;
            this.liver.Text = "Base de Datos";
            this.liver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.liver.TextChanged += new System.EventHandler(this.btnmostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = global::Datos.Properties.Resources._4K_Windows_10_Wallpapers_64__images_;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtposicion);
            this.Controls.Add(this.liver);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneliminarde);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "++";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.Button btneliminarde;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.TextBox txtposicion;
        private System.Windows.Forms.TextBox textBox6;
        public System.Windows.Forms.TextBox liver;
    }
}

