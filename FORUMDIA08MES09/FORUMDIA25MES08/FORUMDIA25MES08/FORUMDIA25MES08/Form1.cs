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

                    atualizarGrid();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel abrir a conexão! " + ex);
                    Console.WriteLine(ex.Message);
                }

            }
        }

        private void atualizarGrid()
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = bancoDados.Abrirconexao();
            try
            {
                command.CommandText = "SELECT id, num_veiculo, uf_veiculo, marca_veiculo, modelo_veiculo, num_placa, num_chassi, ano_fabricacao from veiculo "; 
                MySqlDataReader reader = command.ExecuteReader();

                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);
                    row.Cells[1].Value = reader.GetString(1);
                    row.Cells[2].Value = reader.GetString(2);
                    row.Cells[3].Value = reader.GetString(3);
                    row.Cells[4].Value = reader.GetString(4);
                    row.Cells[5].Value = reader.GetString(5);
                    row.Cells[6].Value = reader.GetString(6);
                    row.Cells[7].Value = reader.GetInt16(7);
                    dataGridView1.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                bancoDados.Fecharconexao();
                //MessageBox.Show("Removido com sucesso"); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel abrir a conexão! " + ex);
                Console.WriteLine(ex.Message);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                //preenche os textbox com as células da linha selecionada

                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["numeroveiculo"].FormattedValue.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Ufveiculo"].FormattedValue.ToString();
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Marcavaiculo"].FormattedValue.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["modeloveiculo"].FormattedValue.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["placa"].FormattedValue.ToString();
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells["Chassi"].FormattedValue.ToString();
                textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells["anofabricacao"].FormattedValue.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void limparCampos()
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
         }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = bancoDados.Abrirconexao();

                command.CommandText = "DELETE FROM veiculo WHERE id in ('" + textBox3.Text + "')";

                command.ExecuteNonQuery();
                command.Connection.Close();

                MessageBox.Show("Deletado com sucesso"); 
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel abrir a conexão! " + ex);
                Console.WriteLine(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = bancoDados.Abrirconexao();

                command.CommandText = "UPDATE `veiculo` SET num_veiculo = " + textBox1.Text + ", uf_veiculo = '" + textBox2.Text + "', marca_veiculo = '" + comboBox1.Text + "', modelo_veiculo = '" + textBox4.Text + "', num_placa = '" + textBox5.Text + "', num_chassi = '" + textBox6.Text + "', ano_fabricacao = " + textBox7.Text + " WHERE id in ('" + textBox3.Text + "')";


                command.ExecuteNonQuery();
                command.Connection.Close();

                MessageBox.Show("Alterado com sucesso");
                atualizarGrid();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel abrir a conexão! " + ex);
                Console.WriteLine(ex.Message);
            }
        }
    }
}
