using EncuestasLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncuestasForm
{
    public partial class Form1 : Form
    {
        ProcesoEncuestas proceso = new ProcesoEncuestas();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistroDeEncuesta_Click(object sender, EventArgs e)
        {
            FormRegistroDeEncuesta fRegitro = new FormRegistroDeEncuesta();

            if (fRegitro.ShowDialog() == DialogResult.OK)
            {
                Encuesta nuevo = new Encuesta();
                               
                nuevo.UsaBicicleta = fRegitro.cbkUsaBicicleta.Checked;
                nuevo.UsaAuto = fRegitro.cbkUsaAutomovil.Checked;
                nuevo.UsaTransportePublico = fRegitro.cbkUsaTransportePublico.Checked;

                //Console.WriteLine("¿Cuál es la distancia aproximada a su destino de trabajo/estudio en km? (ej:1,5)\n");
                nuevo.DistanciaASuDestino = fRegitro.textBox1.Text;//Convert.ToDouble(Console.ReadLine());

                bool puedeSerContactado = false; //Consulta("¿Puede ser contactado?: S/N");
                if (puedeSerContactado == true)
                {
                    //Console.Write("Email: ");
                    nuevo.Email = "uncorreo@correo.com";//Console.ReadLine();
                                                        //Console.Write("\n");
                }

                proceso.RegistrarEncuesta(nuevo, puedeSerContactado);

                //Console.WriteLine("\nEncuesta procesada!");

                MessageBox.Show("Encuesta Procesada");
            }
            
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            FormResultados fInforme = new FormResultados();

            fInforme.listBox1.Items.Add($"\t{"Bicicleta:",-20}  {proceso.PorcBicleta,10:f2}%");
            fInforme.listBox1.Items.Add($"\t{"Automóvil:",-20}  {proceso.PorcAuto,10:f2}%");
            fInforme.listBox1.Items.Add($"\t{"Transporte público:",-20}  {proceso.PorcTranspPublico,10:f2}%");
            fInforme.ShowDialog();            
        }
    }
}
