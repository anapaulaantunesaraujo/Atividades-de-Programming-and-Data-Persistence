using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORUMDIA25MES08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = bancoDados.Abrirconexao();
                    command.CommandText = "INSERT INTO veiculo(num_veiculo, uf_veiculo, marca_veiculo, modelo_veiculo, num_placa, num_chassi, ano_fabricacao) VALUES (" + textBox1.Text + ",'" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "'," + textBox7.Text + ")";




                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    MessageBox.Show("Veiculo cadastrado com sucesso!");

                    textBox1.Text = "";
                    textBox2.Text = "";
                    comboBox1.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel abrir a conexão! " + ex);
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
