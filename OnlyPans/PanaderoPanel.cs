using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyPans
{
    public partial class PanaderoPanel : Form
    {
        private const int A = 0;
        private const int N = 0;
        private const int E = 0;
        private const int C = 0;
        private const int P = 0;

        public PanaderoPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cliente.Text != string.Empty && cedula.Text != string.Empty)
            {
                factura.Text += "\n" + cliente.Text + "\n" + cedula.Text + "\n" + tipo.SelectedItem + "\n" + 1 + "\n" + 1 * 1000;
                if (tipo.SelectedIndex == 0)
                {
                    const int A =+ 1;
                    label5.Text = "Vendidos aliñados: " + A;
                    const int C = +1;
                    label8.Text = "Cantidad vendida: " + C;
                    const int P = +1 * 1000;
                    label9.Text = "Ganancias totales: " + P;
                }
                if (tipo.SelectedIndex == 1)
                {
                    const int N = +1;
                    label6.Text = "Vendidos no aliñados: " + N;
                    const int C = +1;
                    label8.Text = "Cantidad vendida: " + C;
                    const int P = +1 * 1000;
                    label9.Text = "Ganancias totales: " + P;
                }
                if (tipo.SelectedIndex == 2)
                {
                    const int E = +1;
                    label7.Text = "Vendidos especial: " + E;
                    const int C = +1;
                    label8.Text = "Cantidad vendida: " + C;
                    const int P = +1 * 1000;
                    label9.Text = "Ganancias totales: " + P;
                }
                cliente.Clear();
                cedula.Clear();
                MessageBox.Show("Compra registrada");
            }
        }
    }
}
