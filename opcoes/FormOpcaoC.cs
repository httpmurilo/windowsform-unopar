using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unopar.opcoes
{
    public partial class FormOpcaoC : Form
    {
        public FormOpcaoC()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            string resultado = "";
            int numero = 1;
            while (numero < 40)
            {
                if (numero % 4 == 0)
                {
                    resultado += numero.ToString() + Environment.NewLine;
                }
                numero++;
            }
            txtResultado.Text = resultado;
        }
    }
}
