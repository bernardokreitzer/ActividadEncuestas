namespace EncuestasForm
{
    partial class FormRegistroDeEncuesta
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
            this.cbkUsaBicicleta = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbkUsaTransportePublico = new System.Windows.Forms.CheckBox();
            this.cbkUsaAutomovil = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbkUsaBicicleta
            // 
            this.cbkUsaBicicleta.AutoSize = true;
            this.cbkUsaBicicleta.Location = new System.Drawing.Point(6, 33);
            this.cbkUsaBicicleta.Name = "cbkUsaBicicleta";
            this.cbkUsaBicicleta.Size = new System.Drawing.Size(121, 20);
            this.cbkUsaBicicleta.TabIndex = 0;
            this.cbkUsaBicicleta.Text = "¿Usa bicicleta?";
            this.cbkUsaBicicleta.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbkUsaTransportePublico);
            this.groupBox1.Controls.Add(this.cbkUsaAutomovil);
            this.groupBox1.Controls.Add(this.cbkUsaBicicleta);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 162);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modo de transporte habitual";
            // 
            // cbkUsaTransportePublico
            // 
            this.cbkUsaTransportePublico.AutoSize = true;
            this.cbkUsaTransportePublico.Location = new System.Drawing.Point(6, 121);
            this.cbkUsaTransportePublico.Name = "cbkUsaTransportePublico";
            this.cbkUsaTransportePublico.Size = new System.Drawing.Size(178, 20);
            this.cbkUsaTransportePublico.TabIndex = 2;
            this.cbkUsaTransportePublico.Text = "¿Usa transporte publico?";
            this.cbkUsaTransportePublico.UseVisualStyleBackColor = true;
            // 
            // cbkUsaAutomovil
            // 
            this.cbkUsaAutomovil.AutoSize = true;
            this.cbkUsaAutomovil.Location = new System.Drawing.Point(6, 76);
            this.cbkUsaAutomovil.Name = "cbkUsaAutomovil";
            this.cbkUsaAutomovil.Size = new System.Drawing.Size(129, 20);
            this.cbkUsaAutomovil.TabIndex = 1;
            this.cbkUsaAutomovil.Text = "¿Usa automovil?";
            this.cbkUsaAutomovil.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(472, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 87);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sobre el destino al trabajo/estudio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distancia en (km)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // FormRegistroDeEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRegistroDeEncuesta";
            this.Text = "FormRegistroDeEncuesta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.CheckBox cbkUsaBicicleta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.CheckBox cbkUsaTransportePublico;
        public System.Windows.Forms.CheckBox cbkUsaAutomovil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
    }
}