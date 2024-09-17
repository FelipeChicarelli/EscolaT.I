using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Periferico
{
    static class ConexaoBanco
    {
       
        // 4 variaveis declaradas passando as informacoes do banco de dados
        private const string servidor = "localhost";
        private const string bancoDados = "dbperiferico";
        private const string usuario = "root";
        private const string senha = "Ch1c@r3ll1";

        //Declarando variavel bancoServidor para fazer a conexao com o banco de dados.
        static public string bancoServidor = $"server={servidor}; user id={usuario}; database={bancoDados}; password={senha}";

    }
   
}
