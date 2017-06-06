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
    public partial class Form5 : Form
    {/// <summary>
     /// tela onde teremos a avaliação por parte do avaliador do conteúdo seguindo a explicação 
     /// </summary>
        public bool logado = false;
        private Conecta conn;
        public SqlConnection ConnectOpen;
        public string a="", b = "", c = "", d = "", cinco = "", f = "", g = "", h = "", i = "", j = "", k = "", l = "", avalia,conteudo;
        public int w=10000;
        private void ckb7_CheckedChanged(object sender, EventArgs e)
        {
            i= "marcado";
        }

        private void ckb1_CheckedChanged(object sender, EventArgs e)
        {
            j= "marcado";
        }

        private void rdBtn1_CheckedChanged(object sender, EventArgs e)
        {
            avalia = "muito bom";
        }

        private void rdBtn3_CheckedChanged(object sender, EventArgs e)
        {
            avalia = "a melhorar";
        }

        private void rdBtn4_CheckedChanged(object sender, EventArgs e)
        {
            avalia = "ruim";
        }

        private void rdBtn5_CheckedChanged(object sender, EventArgs e)
        {
            avalia="nada bom";
        }

        private void btnSubmeter_Click(object sender, EventArgs e)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into cont (id, avaliacao, pontuacao, argumentacao, desenvoltura, objetividade, organizacao, clareza, roteiro, introducao, tempo_verbal, coerencia, metodologia, vocabulario, conteudo ) ");
            sql.Append("Values (@id, @avaliacao, @pontuacao, @argumentacao, @desenvoltura, @objetividade, @organizacao, @clareza, @roteiro, @introducao, @tempo_verbal, @coerencia, @metodologia, @vocabulario, @conteudo )");
            SqlCommand command = null;



            try
            {
                if (w == 10000)
                {
                    MessageBox.Show("Insira um numero por favor ");
                }
                else
                {
                    command = new SqlCommand(sql.ToString(), ConnectOpen);
                    command.Parameters.Add(new SqlParameter("@id", w));
                    command.Parameters.Add(new SqlParameter("@avaliacao", avalia));
                    command.Parameters.Add(new SqlParameter("@pontuacao", ckb1.Checked));
                    command.Parameters.Add(new SqlParameter("@argumentacao", ckb2.Checked));
                    command.Parameters.Add(new SqlParameter("@desenvoltura", ckb3.Checked));
                    command.Parameters.Add(new SqlParameter("@objetividade", ckb4.Checked));
                    command.Parameters.Add(new SqlParameter("@organizacao", ckb5.Checked));
                    command.Parameters.Add(new SqlParameter("@clareza", ckb6.Checked));
                    command.Parameters.Add(new SqlParameter("@roteiro", ckb7.Checked));
                    command.Parameters.Add(new SqlParameter("@introducao", ckb8.Checked));
                    command.Parameters.Add(new SqlParameter("@tempo_verbal", ckb9.Checked));
                    command.Parameters.Add(new SqlParameter("@coerencia", ckb10.Checked));
                    command.Parameters.Add(new SqlParameter("@metodologia", ckb11.Checked));
                    command.Parameters.Add(new SqlParameter("@vocabulario", ckb12.Checked));
                    command.Parameters.Add(new SqlParameter("@conteudo", conteudo));
                    command.ExecuteNonQuery();

                    MessageBox.Show("Cadastrado com sucesso!");

                    Hide();
                    var pri = new Tela_inicial();
                    pri.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar" + ex);

            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            w = Convert.ToInt16(txtNumero.Text);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            var conFeed = Tela_conteudo.Conteudo;
            conteudo = conFeed;
        }

        private void ckb6_CheckedChanged(object sender, EventArgs e)
        {
            k= "marcado";
        }

        private void ckb11_CheckedChanged(object sender, EventArgs e)
        {
            h = "marcado";
        }

        private void ckb10_CheckedChanged(object sender, EventArgs e)
        {
            g = "marcado";
        }

        private void ckb9_CheckedChanged(object sender, EventArgs e)
        {
            f= "marcado";
        }

        private void ckb8_CheckedChanged(object sender, EventArgs e)
        {
            cinco = "marcado";
        }

        private void ckb5_CheckedChanged(object sender, EventArgs e)
        {
            d = "marcado";
        }

        private void ckb4_CheckedChanged(object sender, EventArgs e)
        {
            c= "marcado";
        }

        private void ckb3_CheckedChanged(object sender, EventArgs e)
        {
            b = "marcado";
        }

        private void ckb2_CheckedChanged(object sender, EventArgs e)
        {
            a = "marcado";
        }

        public Form5()
        {
            InitializeComponent();
            conn = new Conecta();
            ConnectOpen = conn.ConnectToDatabase();
        }

        private void rdBtn2_CheckedChanged(object sender, EventArgs e)
        {
            avalia = "bom";
        }

        private void ckb12_CheckedChanged(object sender, EventArgs e)
        {
            l= "marcado";
        }
    }
}
