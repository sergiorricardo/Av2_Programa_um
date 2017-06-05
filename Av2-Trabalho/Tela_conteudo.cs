using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace Av2_Trabalho
{
    public partial class Tela_conteudo : Form
    {
        /// <summary>
        /// 
        /// aqui irá inserir novamente qntd depois da  escolha dificuldade alta /baixa .
        /// </summary>
        /// 

        public string opc1, opc2,erro,certo,ac;
        public int tamanho;
        public bool logado = false;
        private Conecta conn;
        public  SqlConnection ConnectOpen;


        private void opcao(string opc)
        {
            //função para que traga o núnero escolhido em relação aos numeros
            var maximo = Tela_Escolha.Escolha;
            lblqnt.Text = Convert.ToString(maximo);

        }

        private void grande(string x)
        {
            //falha no tamahho reexcrito
            MessageBox.Show("Baixe o tanto de caracteres por favor ");

        }

        private void ideal(string x)
        {
            //sucesso no tamahho reexcrito
            MessageBox.Show("feito");


        }


        private void verificar(string opcV)
        {
            //validação da quantidade de caracteres. 
            var veri = Tela_Escolha.Escolha;
            int maxT = Convert.ToInt16(veri);
            int moeTr = 0;
            if (txtCont.Text == "")
            {
                MessageBox.Show("insira algum texto");
            }
            else
            {
                switch (maxT)
                {
                    case 200:
                        moeTr = 200;
                        tamanho = txtCont.Text.Length;
                        if (tamanho <= moeTr)
                        {
                            ideal(certo);
                            btnGravarCont.Visible = true;
                            btnAvanco.Visible = true;
                            Conteudo = txtCont.Text;
                            Horario = lblData2.Text;
                        }
                        else
                        {
                            grande(erro);
                        }
                        break;

                    case 160:
                        moeTr = 160;
                        tamanho = txtCont.Text.Length;
                        if (tamanho <= moeTr)
                        {
                            ideal(certo);
                            btnGravarCont.Visible = true;
                            btnAvanco.Visible = true;
                            Conteudo = txtCont.Text;
                            Horario = lblData2.Text;
                        }
                        else
                        {
                            grande(erro);
                        }
                        break;

                    case 120:
                        moeTr = 120;
                        tamanho = txtCont.Text.Length;
                        if (tamanho <= moeTr)
                        {
                            ideal(certo);
                            btnGravarCont.Visible = true;
                            btnAvanco.Visible = true;
                            Conteudo = txtCont.Text;
                            Horario = lblData2.Text;
                        }
                        else
                        {
                            grande(erro);
                        }
                        break;

                    case 100:
                        moeTr = 100;
                        tamanho = txtCont.Text.Length;
                        if (tamanho <= moeTr)
                        {
                            ideal(certo);
                            btnGravarCont.Visible = true;
                            btnAvanco.Visible = true;
                            Conteudo = txtCont.Text;
                            Horario = lblData2.Text;
                        }
                        else
                        {
                            grande(erro);
                        }
                        break;

                    case 60:
                        moeTr = 60;
                        tamanho = txtCont.Text.Length;
                        if (tamanho <= moeTr)
                        {
                            ideal(certo);
                            btnGravarCont.Visible = true;
                            btnAvanco.Visible = true;
                            Conteudo = txtCont.Text;
                            Horario = lblData2.Text;
                        }
                        else
                        {
                            grande(erro);
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


        }
       public void insere(){
            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into resc (id, reescrita ) ");
            sql.Append("Values (@id, @reescrita )");
            SqlCommand command = null;



            try
            {
                command = new SqlCommand(sql.ToString(), ConnectOpen);
                command.Parameters.Add(new SqlParameter("@id", lblData2.Text));
                command.Parameters.Add(new SqlParameter("@reescrita", txtCont.Text));
                command.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com sucesso!");

                Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar" + ex);

            }

        }

        private void btnAvanco_Click(object sender, EventArgs e)
        {
            //var prox = new Form4();  velho
            //prox.ShowDialog();
        }

        public static string Conteudo { get; set; }
        public static string Horario { get; set; }



        public Tela_conteudo()
        {
            InitializeComponent();
            conn = new Conecta();
            ConnectOpen = conn.ConnectToDatabase();
        }

        private void btnGerarNovo_Click(object sender, EventArgs e)
        {
            verificar(opc2);      
            
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {

            insere();
            var prox = new Form4();
            prox.ShowDialog();
            //Conteudo = txtCont.Text;
            // btnAvanco.Visible = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DateTime locaDate = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time"));
            lblData2.Text = Convert.ToString(locaDate);
            opcao(opc1);
            logado = true;
            //Conteudo = txtCont.Text;

        }
    }
}
