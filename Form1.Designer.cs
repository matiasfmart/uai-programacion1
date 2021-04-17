namespace TpObligatorio
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
            this.cargar = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.tope = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ingreso_alumno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cargar
            // 
            this.cargar.Location = new System.Drawing.Point(50, 799);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(179, 62);
            this.cargar.TabIndex = 0;
            this.cargar.Text = "Cargar";
            this.cargar.UseVisualStyleBackColor = true;
            this.cargar.Click += new System.EventHandler(this.cargar_Click);
            // 
            // borrar
            // 
            this.borrar.Location = new System.Drawing.Point(402, 799);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(179, 62);
            this.borrar.TabIndex = 1;
            this.borrar.Text = "Borrar";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // tope
            // 
            this.tope.Location = new System.Drawing.Point(50, 912);
            this.tope.Name = "tope";
            this.tope.Size = new System.Drawing.Size(179, 62);
            this.tope.TabIndex = 2;
            this.tope.Text = "Tope";
            this.tope.UseVisualStyleBackColor = true;
            this.tope.Click += new System.EventHandler(this.tope_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(402, 912);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(179, 62);
            this.salir.TabIndex = 3;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Lista
            // 
            this.Lista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lista.FormattingEnabled = true;
            this.Lista.ItemHeight = 31;
            this.Lista.Location = new System.Drawing.Point(50, 184);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(531, 560);
            this.Lista.TabIndex = 4;
            this.Lista.SelectedIndexChanged += new System.EventHandler(this.Lista_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese Alumno";
            // 
            // ingreso_alumno
            // 
            this.ingreso_alumno.Location = new System.Drawing.Point(136, 112);
            this.ingreso_alumno.Name = "ingreso_alumno";
            this.ingreso_alumno.Size = new System.Drawing.Size(357, 38);
            this.ingreso_alumno.TabIndex = 6;
            this.ingreso_alumno.TextChanged += new System.EventHandler(this.ingreso_alumno_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 1026);
            this.Controls.Add(this.ingreso_alumno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.tope);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.cargar);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Button tope;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ingreso_alumno;
    }
}

