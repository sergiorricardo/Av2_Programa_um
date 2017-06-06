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
    public partial class Form4 : Form
    {/// <summary>
     /// aqui teremos a vista do conteúdo por uma pessoa diferente de quem estudou o assunto 
     /// </summary>
     /// 
        public bool logado = false;
        private Conecta conn;
        public SqlConnection ConnectOpen;

        public Form4()
        {
            InitializeComponent();
            conn = new Conecta();
            ConnectOpen = conn.ConnectToDatabase();
        }

        private void confuso()
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into conteudos (id, conteudo ) ");
            sql.Append("Values (@id, @conteudo )");
            SqlCommand command = null;



            try
            {
                command = new SqlCommand(sql.ToString(), ConnectOpen);
                command.Parameters.Add(new SqlParameter("@id", lblDataTres.Text));
                command.Parameters.Add(new SqlParameter("@conteudo", lblseguinte.Text));
                command.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com sucesso!");

                Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar" + ex);

            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            // trazendo o conteúdo e horario de uma variável para avaliação (cópia)
            var conteudoAvali = Tela_conteudo.Conteudo;
            lblseguinte.Text = conteudoAvali;
            var horarioTr = Tela_conteudo.Horario;
            lblDataTres.Text = horarioTr;
            //definindo parametro de id do banco 
            DateTime locaDate = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time"));
            lblDataTres.Text = Convert.ToString(locaDate);

        }

        private void btnEntendido_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado por nos avaliar");
        }

        private void btnConfuso_Click(object sender, EventArgs e)
        {
            confuso();
            var avaliar = new Form5();
            avaliar.ShowDialog();


        }
        private void btnAvaliar_Click(object sender, EventArgs e)
        {
            
            //var avaliar = new Form5(); velho
            //avaliar.ShowDialog();

        }

        private void lblDataTres_Click(object sender, EventArgs e)
        {

        }
    }
}
