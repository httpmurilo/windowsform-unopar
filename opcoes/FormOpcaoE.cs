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
    public partial class FormOpcaoE : Form
    {
        public FormOpcaoE()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int soma = 0;
            for (int i = 2; i <= 50; i ++)
            {
                soma += i;
            }
            txtResultado.Text = soma.ToString();
        }
    }
}
