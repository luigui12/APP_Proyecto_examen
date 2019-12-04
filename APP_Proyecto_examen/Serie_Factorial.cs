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
    public partial class Serie_Factorial : Form
    {
        public Serie_Factorial()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            int limite = 0;
            double suma = 0;
            limite = int.Parse(this.limite.Text);
            suma = Clases.Examen.sumaFactorial(limite);
            this.suma.Text = suma.ToString();
        }
    }
}
