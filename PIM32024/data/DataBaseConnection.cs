//Fazendo a conexao com o banco de dados
//abrindo conexao e fechando!

using MySql.Data.MySqlClient; 
using System;

namespace PIM32024.data
{
    public class DatabaseConnection
    {
        private MySqlConnection connection;

        public DatabaseConnection(string connectionString)
        {
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection(){
            return connection;
        }

        public void OpenConnection()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Conexão com o Banco de Dados Realizada com Sucesso!");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erro ao abrir conexão" + ex.Message);
            }
        }

        public void CloseConnection()
        {
            try
            {
                connection.Close();
                Console.WriteLine("Conexão fechada com sucesso!");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erro ao fechar conexão" + ex.Message);
            }
        }
    }
}