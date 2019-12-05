using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_Proyecto_examen
{
    public partial class Arreglo_numeros_arrays_ : Form
    {
        public Arreglo_numeros_arrays_()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mostrar_Click(object sender, EventArgs e)
        {
            const int max = 20;
            int[] vec = new int[max];
            try
            {

                muestra.Items.Clear();
                generar();
                this.muestra.Items.Add(Clases.numero_reales.Burbuja());
                mostrar1(muestra);
                orden.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int generar()
        {
            const int max = 20;
            int[] vec = new int[max];
            for (int i = 0; i < max; i += 1)
            {
                this.muestra.Items.Add(Clases.numero_reales.generardatos());
                
            }
            return 0;
        }
       private int mostrar1(ListBox most)
        {
            const int max = 20;
            int[] vec = new int[max];
            for (int i=0;i<max;i+=1)
            {
                int n = Clases.numero_reales.Burbuja();
                most.Items.Add(vec[i]);
            }
            return 0;
        }

        private void orden_Click(object sender, EventArgs e)
        {
            /*int bur = Clases.numero_reales.Burbuja();
            mostrar1(ordenar);
            orden.Enabled = false;*/
        }
    }
}
