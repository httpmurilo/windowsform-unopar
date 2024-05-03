using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using unopar.opcoes;

namespace unopar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AdicionarGuias();
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;

        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AdicionarGuias()
        {
            tabControl1.TabPages.Add("Opção A");
            tabControl1.TabPages.Add("Opção B");
            tabControl1.TabPages.Add("Opção C");
            tabControl1.TabPages.Add("Opção D");
            tabControl1.TabPages.Add("Opção E");
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage selectedTab = tabControl1.SelectedTab;
            string mensagem = "";
            switch (selectedTab.Text)
            {
                case "Opção A":
                    mensagem = "Você selecionou a Opção A!";
                    AbrirFormulario(new FormOpcaoA(), mensagem);
                    break;
                case "Opção B":
                    mensagem = "Você selecionou a Opção B!";
                    AbrirFormulario(new FormOpcaoB(), mensagem);
                    break;
                case "Opção C":
                    mensagem = "Você selecionou a Opção C!";
                    AbrirFormulario(new FormOpcaoC(), mensagem);
                    break;
                case "Opção D":
                    mensagem = "Você selecionou a Opção D!";
                    AbrirFormulario(new FormOpcaoD(), mensagem);
                    break;
                case "Opção E":
                    mensagem = "Você selecionou a Opção E!";
                    AbrirFormulario(new FormOpcaoE(), mensagem);
                    break;
            }
        }

        private void AbrirFormulario(Form formulario, string mensagem)
        {
            MessageBox.Show(mensagem);
            formulario.ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
