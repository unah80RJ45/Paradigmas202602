namespace Conceptos
{
    partial class Estructuras
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.cmdMostrar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.cmdPerro = new System.Windows.Forms.Button();
            this.cmdMosquito = new System.Windows.Forms.Button();
            this.cmdSize = new System.Windows.Forms.Button();
            this.cmdPerros = new System.Windows.Forms.Button();
            this.cmbPerros = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.txtDueno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdDueno = new System.Windows.Forms.Button();
            this.txtNombreDueno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Location = new System.Drawing.Point(223, 23);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(75, 23);
            this.cmdNuevo.TabIndex = 2;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.UseVisualStyleBackColor = true;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // cmdMostrar
            // 
            this.cmdMostrar.Location = new System.Drawing.Point(304, 23);
            this.cmdMostrar.Name = "cmdMostrar";
            this.cmdMostrar.Size = new System.Drawing.Size(75, 23);
            this.cmdMostrar.TabIndex = 3;
            this.cmdMostrar.Text = "Mostrar";
            this.cmdMostrar.UseVisualStyleBackColor = true;
            this.cmdMostrar.Click += new System.EventHandler(this.cmdMostrar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(223, 52);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(75, 23);
            this.cmdEliminar.TabIndex = 4;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Location = new System.Drawing.Point(304, 52);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(75, 23);
            this.cmdLimpiar.TabIndex = 5;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // cmdPerro
            // 
            this.cmdPerro.Location = new System.Drawing.Point(223, 81);
            this.cmdPerro.Name = "cmdPerro";
            this.cmdPerro.Size = new System.Drawing.Size(75, 23);
            this.cmdPerro.TabIndex = 6;
            this.cmdPerro.Text = "Perro";
            this.cmdPerro.UseVisualStyleBackColor = true;
            this.cmdPerro.Click += new System.EventHandler(this.cmdPerro_Click);
            // 
            // cmdMosquito
            // 
            this.cmdMosquito.Location = new System.Drawing.Point(304, 81);
            this.cmdMosquito.Name = "cmdMosquito";
            this.cmdMosquito.Size = new System.Drawing.Size(75, 23);
            this.cmdMosquito.TabIndex = 7;
            this.cmdMosquito.Text = "Mosquito";
            this.cmdMosquito.UseVisualStyleBackColor = true;
            this.cmdMosquito.Click += new System.EventHandler(this.cmdMosquito_Click);
            // 
            // cmdSize
            // 
            this.cmdSize.Location = new System.Drawing.Point(223, 110);
            this.cmdSize.Name = "cmdSize";
            this.cmdSize.Size = new System.Drawing.Size(75, 23);
            this.cmdSize.TabIndex = 8;
            this.cmdSize.Text = "Size";
            this.cmdSize.UseVisualStyleBackColor = true;
            this.cmdSize.Click += new System.EventHandler(this.cmdSize_Click);
            // 
            // cmdPerros
            // 
            this.cmdPerros.Location = new System.Drawing.Point(304, 110);
            this.cmdPerros.Name = "cmdPerros";
            this.cmdPerros.Size = new System.Drawing.Size(75, 23);
            this.cmdPerros.TabIndex = 9;
            this.cmdPerros.Text = "Perros";
            this.cmdPerros.UseVisualStyleBackColor = true;
            this.cmdPerros.Click += new System.EventHandler(this.cmdPerros_Click);
            // 
            // cmbPerros
            // 
            this.cmbPerros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerros.FormattingEnabled = true;
            this.cmbPerros.Location = new System.Drawing.Point(105, 154);
            this.cmbPerros.Name = "cmbPerros";
            this.cmbPerros.Size = new System.Drawing.Size(193, 21);
            this.cmbPerros.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Perros";
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(304, 152);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(75, 23);
            this.cmdCargar.TabIndex = 12;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // txtDueno
            // 
            this.txtDueno.Location = new System.Drawing.Point(105, 55);
            this.txtDueno.Name = "txtDueno";
            this.txtDueno.Size = new System.Drawing.Size(100, 20);
            this.txtDueno.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Dueno";
            // 
            // cmdDueno
            // 
            this.cmdDueno.Location = new System.Drawing.Point(304, 181);
            this.cmdDueno.Name = "cmdDueno";
            this.cmdDueno.Size = new System.Drawing.Size(75, 23);
            this.cmdDueno.TabIndex = 15;
            this.cmdDueno.Text = "Dueno";
            this.cmdDueno.UseVisualStyleBackColor = true;
            this.cmdDueno.Click += new System.EventHandler(this.cmdDueno_Click);
            // 
            // txtNombreDueno
            // 
            this.txtNombreDueno.Location = new System.Drawing.Point(105, 184);
            this.txtNombreDueno.Name = "txtNombreDueno";
            this.txtNombreDueno.ReadOnly = true;
            this.txtNombreDueno.Size = new System.Drawing.Size(193, 20);
            this.txtNombreDueno.TabIndex = 16;
            // 
            // Estructuras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 431);
            this.Controls.Add(this.txtNombreDueno);
            this.Controls.Add(this.cmdDueno);
            this.Controls.Add(this.txtDueno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPerros);
            this.Controls.Add(this.cmdPerros);
            this.Controls.Add(this.cmdSize);
            this.Controls.Add(this.cmdMosquito);
            this.Controls.Add(this.cmdPerro);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdMostrar);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Estructuras";
            this.Text = "Estructuras";
            this.Load += new System.EventHandler(this.Estructuras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.Button cmdMostrar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Button cmdPerro;
        private System.Windows.Forms.Button cmdMosquito;
        private System.Windows.Forms.Button cmdSize;
        private System.Windows.Forms.Button cmdPerros;
        private System.Windows.Forms.ComboBox cmbPerros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.TextBox txtDueno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdDueno;
        private System.Windows.Forms.TextBox txtNombreDueno;
    }
}