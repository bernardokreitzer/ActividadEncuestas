namespace EncuestasForm
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
            this.btnRegistroDeEncuesta = new System.Windows.Forms.Button();
            this.btnInforme = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistroDeEncuesta
            // 
            this.btnRegistroDeEncuesta.Location = new System.Drawing.Point(270, 158);
            this.btnRegistroDeEncuesta.Name = "btnRegistroDeEncuesta";
            this.btnRegistroDeEncuesta.Size = new System.Drawing.Size(165, 52);
            this.btnRegistroDeEncuesta.TabIndex = 0;
            this.btnRegistroDeEncuesta.Text = "Registro de Encuesta";
            this.btnRegistroDeEncuesta.UseVisualStyleBackColor = true;
            this.btnRegistroDeEncuesta.Click += new System.EventHandler(this.btnRegistroDeEncuesta_Click);
            // 
            // btnInforme
            // 
            this.btnInforme.Location = new System.Drawing.Point(270, 220);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(165, 52);
            this.btnInforme.TabIndex = 1;
            this.btnInforme.Text = "Resultados";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(270, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 52);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.btnRegistroDeEncuesta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistroDeEncuesta;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.Button button3;
    }
}

