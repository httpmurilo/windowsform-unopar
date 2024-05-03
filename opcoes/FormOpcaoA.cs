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
    public partial class FormOpcaoA : Form
    {
        public FormOpcaoA()
        {
            InitializeComponent();
        }

        private string ObterNumerosImpares()
        {
            string resultado = "";
            for (int i = 0; i <= 40; i++)
            {
                if (i % 2 != 0) 
                {
                    resultado += i.ToString() + "\n";
                }
            }
            return resultado;
        }

        private void FormOpcaoA_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            string numerosImpares = ObterNumerosImpares();
            txtResultado.Text = numerosImpares;

        }
    }

}
