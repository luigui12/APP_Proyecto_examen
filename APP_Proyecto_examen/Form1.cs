using System;
using System.Windows.Forms;

namespace APP_Proyecto_examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.limite.Text = "";
            this.suma.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int limite = 0;
            limite = int.Parse(this.limite.Text);
            int suma = Clases.Examen.sumatoria(limite);
            this.suma.Text = suma.ToString();
        }
    }
}
