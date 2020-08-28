using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NotasAlunos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void atualizarGrid()
        {
            //Crio a estrutura da conexão com o banco e passa os parametros
            MySqlConnectionStringBuilder conexaoDB = new MySqlConnectionStringBuilder();
            conexaoDB.Server = "localhost";
            conexaoDB.Database = "notas_alunos";
            conexaoDB.UserID = "root";
            conexaoDB.Password = "";
            //Realizo a conexão com o banco
            MySqlConnection realizaConexacoDB = new MySqlConnection(conexaoDB.ToString());
            try
            {
                realizaConexacoDB.Open();

                MySqlCommand comandoMySql = realizaConexacoDB.CreateCommand();
                comandoMySql.CommandText = "SELECT * from cadastroalunos"; //Traz todo mundo da tabela cadastro
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                gridAlunos.Rows.Clear();//FAZ LIMPAR A TABELA

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)gridAlunos.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);
                    row.Cells[1].Value = reader.GetString(1);
                    row.Cells[2].Value = reader.GetString(2);
                    row.Cells[3].Value = reader.GetString(3);
                    row.Cells[4].Value = reader.GetString(4);
                    gridAlunos.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizaConexacoDB.Close();
                //MessageBox.Show("Removido com sucesso"); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                Console.WriteLine(ex.Message);
            }


        }

        private void gridAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}