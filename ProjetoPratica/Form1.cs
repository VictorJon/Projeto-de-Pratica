using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPratica
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
            CarregarDataViewGrid();
        }

        private void CarregarDataViewGrid()
        {
            dt = Evento.GetEventos();
            dataGridViewEventos.DataSource = dt;

            dataGridViewEventos.Columns["id"].Visible = false;
            dataGridViewEventos.Columns["quantidadePessoas"].HeaderText = "Quantidade de Pessoas";
            dataGridViewEventos.Columns["data"].HeaderText = "Data";
            dataGridViewEventos.Columns["nomeResponsavel"].HeaderText = "Nome do Responsável";
        }

        public string nome;
        private void button1_Click(object sender, EventArgs e)
        {

            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
            MySqlConnection con = new MySqlConnection(conn);
            con.Open();
            string comando = "Select * from moradores where nome = @nome";
            MySqlCommand com = new MySqlCommand(comando, con);
            com.Parameters.Add("@nome", MySqlDbType.VarChar).Value = inputNome.Text;
            try
            {
                if (inputNome.Text == "")
                {
                    throw new Exception("Você esqueceu de digitar um nome...");
                }
                MySqlDataReader cs = com.ExecuteReader();
                if (cs.HasRows == false)
                    throw new Exception("Nome não encontrado...");
                else
                {
                    cs.Read();
                    textEndereco.Text = Convert.ToString(cs["numApartamento"]);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
        private void buttonCad_Click(object sender, EventArgs e)
        {
            string conn =
            ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
            MySqlConnection conexao = new MySqlConnection(conn);
            try
            {

                conexao.Open();
                MessageBox.Show("Conexão foi criada.");
                MySqlCommand comando = new MySqlCommand();
                comando = conexao.CreateCommand();
                comando.CommandText = "insert into moradores (Nome, numApartamento) values(@vNome, @vApartamento);";
                comando.Parameters.AddWithValue("vNome", textBoxNome.Text.Trim());
                comando.Parameters.AddWithValue("vApartamento", textBoxEndereco.Text.Trim());
                int valorRetorno = comando.ExecuteNonQuery();
                if (valorRetorno < 1)
                    MessageBox.Show("Erro ao cadastrar");
                else
                    MessageBox.Show("Cadastrado com sucesso");
            }
            catch (MySqlException msqle)
            {
                MessageBox.Show("Erro de acesso ao mysql...." + msqle.Message, "Erro");
            }
            finally
            {
                conexao.Close();
            }
        }
        private void buttonCadEvento_click(object sender, EventArgs e)
        {
            bool isDataValid = ValidaData();

            if (isDataValid)
            {
                string conn =
                ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
                MySqlConnection conexao = new MySqlConnection(conn);
                try
                {

                    conexao.Open();
                    MessageBox.Show("Conexão foi criada.");
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();
                    comando.CommandText = "insert into agendamentos (quantidadePessoas, data, nomeResponsavel) values(@quantidade, @data, @responsavel);";
                    comando.Parameters.AddWithValue("quantidade", inputQuantidade.Text.Trim());
                    comando.Parameters.AddWithValue("data", inputData.Value.Date);
                    comando.Parameters.AddWithValue("responsavel", textBox2.Text.Trim());
                    int valorRetorno = comando.ExecuteNonQuery();
                    if (valorRetorno < 1)
                        MessageBox.Show("Erro ao cadastrar");
                    else
                        MessageBox.Show("Cadastrado com sucesso");
                }
                catch (MySqlException msqle)
                {
                    MessageBox.Show("Erro de acesso ao mysql...." + msqle.Message, "Erro");
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
        private bool ValidaData()
        {
            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
            MySqlConnection con = new MySqlConnection(conn);
            con.Open();
            string comando = "Select * from agendamentos where data = @data";
            MySqlCommand com = new MySqlCommand(comando, con);
            com.Parameters.Add("@data", MySqlDbType.DateTime).Value = inputData.Value.Date;
            try
            {
                if (inputData == null)
                {
                    throw new Exception("Você esqueceu de digitar uma data...");
                }
                MySqlDataReader cs = com.ExecuteReader();
                if (cs.HasRows == true)
                    throw new Exception("Evento já cadastrado nesta data!!");

                return true;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                return false;
            }
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            dataGridViewEventos.DataSource = Evento.GetEventos(datePickerFiltro.Value);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewEventos.DataSource = Evento.GetEventos();
        }
    }
}

