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
    public partial class Tela_inicial : Form
    {
        public bool logado = false;
        private Conecta conn;
        public static SqlConnection ConnectOpen;
        public void insere() {
                     botao();

            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into conteudos (id, conteudo ) ");
            sql.Append("Values (@id, @conteudo )");
            SqlCommand command = null;



            try
            {
                command = new SqlCommand(sql.ToString(), ConnectOpen);
                command.Parameters.Add(new SqlParameter("@id", lblData.Text));
                command.Parameters.Add(new SqlParameter("@conteudo", txtArtigo.Text));
                command.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com sucesso!");
                Hide();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar" + ex);

            }

        }
        public void botao() {
            btnSeguinte.Visible = true;
            btnNao.Visible = true;
            lblAvaliarSN.Visible = true;


        }
      
      

        // gerar conteúdo sobre o assunto que estudou recentemente e guarda-lo 
        public Tela_inicial()
        {
            InitializeComponent();
            conn = new Conecta();
            ConnectOpen = conn.ConnectToDatabase();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
     
        DateTime locaDate = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time"));
           lblData.Text =Convert.ToString(locaDate) ;
            logado = true;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            
            if (txtArtigo.Text == "")
            {
                MessageBox.Show("Insira algum texto");
            }
            else
            {
                insere();
                var esco = new Tela_Escolha();
                esco.ShowDialog();

            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtArtigo.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var esco = new Tela_Escolha();
            esco.ShowDialog();
            
        }
    }
}
