using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Av2_Trabalho
{
    public partial class Tela_Escolha : Form
    {

        public static string Escolha { get; set; }
        public  int   cont = 0;



        /// <summary>
        ///  colocar um nivel de entendimento do assunto que será utilizado para verificação  dependente da dificuldade escolhida terá um padrão
        ///  de avaliação 
        /// </summary>
        public Tela_Escolha()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnProceguir_Click(object sender, EventArgs e)
        {
            Escolha = Convert.ToString(cont);
            var contE = new Tela_conteudo();
            contE.ShowDialog();
        }

        private void rdop1_CheckedChanged(object sender, EventArgs e)
        {
            cont = +200;
        }

        private void rdop2_CheckedChanged(object sender, EventArgs e)
        {
            cont = +160;
        }

        private void rdop3_CheckedChanged(object sender, EventArgs e)
        {
            cont = +120;
        }

        private void rdop4_CheckedChanged(object sender, EventArgs e)
        {
            cont = +100;
        }

        private void rdop5_CheckedChanged(object sender, EventArgs e)
        {
            cont = +60;
        }
    }
}
