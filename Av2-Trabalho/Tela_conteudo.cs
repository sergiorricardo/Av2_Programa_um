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
    public partial class Tela_conteudo : Form
    {
        /// <summary>
        /// 
        /// aqui irá inserir novamente caso escolha dificuldade alta 
        /// </summary>
        /// 
        public string opc1, opc2 ;
        public int tamanho;
        private void opcao(string opc) {

            var maximo = Tela_Escolha.Escolha;
            int  max = Convert.ToInt16(maximo);
            switch (max)
            {
                case  1:
                    this.lblqnt.Text = "Poderá inserir até --"; // pede par colocar  uma quantidade de caracteres  
                    opc1 = lblqnt.Text;
                    break;
                case 2:
                    this.lblqnt.Text = "Poderá inserir até --";
                    opc1 = lblqnt.Text;
                    break;
                case 3:
                    this.lblqnt.Text = "Poderá inserir até --";
                    opc1 = lblqnt.Text;

                    break;
                case 4:
                    this.lblqnt.Text = "Poderá inserir até --";
                    opc1 = lblqnt.Text;
                    break;
                default:
                    lblqnt.Text = "";
                    break;
            }


            
        }
        private void verificar(string opcV) {
            var veri = Tela_Escolha.Escolha;
            int maxT = Convert.ToInt16(veri);
            int moeTr = 0;
            
            switch (maxT)
            {
                case 1:
                    moeTr = 200;
                     tamanho = txtCont.Text.Length;
                    if (tamanho <= moeTr)
                    {
                        MessageBox.Show("feito");
                    }
                    else
                    {
                        MessageBox.Show("Baixe o tanto de caracteres por favor ");
                    }
                    break;
                case 2:
                    moeTr = 160;
                     tamanho = txtCont.Text.Length;
                    if (tamanho <= moeTr)
                    {
                        MessageBox.Show("feito");
                    }
                    else
                    {
                        MessageBox.Show("Baixe o tanto de caracteres por favor ");
                    }
                    break;
                case 3:
                    moeTr = 120;
                     tamanho = txtCont.Text.Length;
                    if (tamanho <= moeTr)
                    {
                        MessageBox.Show("feito");
                    }
                    else
                    {
                        MessageBox.Show("Baixe o tanto de caracteres por favor ");
                    }
                    break;
                case 4:
                    moeTr = 100;
                     tamanho = txtCont.Text.Length;
                    if (tamanho <= moeTr)
                    {
                        MessageBox.Show("feito");
                    }
                    else
                    {
                        MessageBox.Show("Baixe o tanto de caracteres por favor ");
                    }
                    break;
                case 5:
                    moeTr = 60;
                    tamanho = txtCont.Text.Length;
                    if (tamanho <= moeTr)
                    {
                        MessageBox.Show("feito");
                    }
                    else
                    {
                        MessageBox.Show("Baixe o tanto de caracteres por favor ");
                    }

                    break;
                default:
                    moeTr = 1000;
                    tamanho = txtCont.Text.Length;
                    if (tamanho > moeTr)
                    {
                        MessageBox.Show("Muitos caracteres Pessoa");
                    }
                    break;

            }


        }

        public Tela_conteudo()
        {
            InitializeComponent();
        }

        private void btnGerarNovo_Click(object sender, EventArgs e)
        {
            verificar(opc2);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            opcao(opc1);


        }
    }
}
