namespace Matricula
{
    partial class frmAlumno
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
            this.dgAlumno = new System.Windows.Forms.DataGridView();
            this.cmdSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAlumno
            // 
            this.dgAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlumno.Location = new System.Drawing.Point(12, 12);
            this.dgAlumno.Name = "dgAlumno";
            this.dgAlumno.Size = new System.Drawing.Size(667, 295);
            this.dgAlumno.TabIndex = 0;
            // 
            // cmdSalvar
            // 
            this.cmdSalvar.Location = new System.Drawing.Point(12, 313);
            this.cmdSalvar.Name = "cmdSalvar";
            this.cmdSalvar.Size = new System.Drawing.Size(75, 23);
            this.cmdSalvar.TabIndex = 1;
            this.cmdSalvar.Text = "Salvar";
            this.cmdSalvar.UseVisualStyleBackColor = true;
            this.cmdSalvar.Click += new System.EventHandler(this.cmdSalvar_Click);
            // 
            // frmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 344);
            this.Controls.Add(this.cmdSalvar);
            this.Controls.Add(this.dgAlumno);
            this.Name = "frmAlumno";
            this.Text = "frmAlumno";
            this.Load += new System.EventHandler(this.frmAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAlumno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAlumno;
        private System.Windows.Forms.Button cmdSalvar;
    }
}