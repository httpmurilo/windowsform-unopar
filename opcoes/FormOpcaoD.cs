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
    public partial class FormOpcaoD : Form
    {
        public FormOpcaoD()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            string resultado = "";
            for (int i = 15; i <= 200; i++)
            {
                resultado += (i * i).ToString() + Environment.NewLine;

                //paleativo para mostrar a visualização do text label somente ate 10 campos....

                if (resultado.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).Length >= 10)
                {
                    break;
                }

            }
            txtResultado.Text = resultado;
        }
    }
}
