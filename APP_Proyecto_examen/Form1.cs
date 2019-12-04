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
    }
}
