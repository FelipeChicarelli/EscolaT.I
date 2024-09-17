using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Periferico
{
    internal class cadastradoPerifericos
    {
        private int id;
        private string name;
        private string cor;
        private int dataFabricacao;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return name; }
            set { name = value; }
        }

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public int DataFabricacao
        {
            get { return dataFabricacao; }
            set { dataFabricacao = value; }
        }



        //metodo para cadastrar periferico no banco de dados
        public bool cadastrarPerifericos()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string insert = $"insert into periferico(nome,cor,dataFabricacao) values ('{Nome}','{Cor}','{DataFabricacao}')";

                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = insert;

                comandoSql.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                //mensagem de erro do banco de daos quando nao for possivel cadastrar perifericos no banco
                //erro ligado ao banco de dados
                MessageBox.Show("Erro no banco de dados - metodo cadastrarPerifericos: " + ex.Message);

                return false;
            }

        }



        public MySqlDataReader localizarPerifericos()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string select = $"select id, nome, cor, dataFabricacao from periferico where nome = '{Nome}';";

                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = select;

                MySqlDataReader reader = comandoSql.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - metodo localizarPerifericos: " + ex.Message);
                return null;
            }
        }

        public bool atualizarPeriferico()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string update = $"update periferico set cor = '{cor}', dataFabricacao='{dataFabricacao}' where id = '{id}';";

                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = update;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - metodo atualizarPeriferico: " + ex.Message);
                return false;
            }



        }


        public bool deletarPeriferico()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string delete = $"delete from periferico where id = '{id}';";

                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = delete;

                comandoSql.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro banco de dados - metodo deletarPeriferico: " + ex.Message);
                return false;
            }
        }



    }
}
