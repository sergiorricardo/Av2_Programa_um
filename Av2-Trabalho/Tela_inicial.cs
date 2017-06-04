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
        private SqlConnection ConnectOpen;

      
      

        // gerar conteúdo sobre o assunto que estudou recentemente e guarda-lo 
        public Tela_inicial()
        {
            InitializeComponent();
            conn = new Conecta();
            ConnectOpen = conn.ConnectToDatabase();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime locaDate = DateTime.Now;
           lblData.Text =Convert.ToString(locaDate) ;
            logado = true;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            {
               
                StringBuilder sql = new StringBuilder();
                sql.Append("Insert into conteudos (id, conteudo ) ");
                sql.Append("Values (@id, @conteudo )");
                SqlCommand command = null;

               

                try
                {
                    command = new SqlCommand(sql.ToString(), ConnectOpen);
                    command.Parameters.Add(new SqlParameter("@id", DateTime.Now));
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
