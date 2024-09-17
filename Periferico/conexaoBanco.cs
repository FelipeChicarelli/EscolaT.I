using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perifericos
{
    static class ConexaoBanco
    {
        //4 Variaveis declaradas passando as informações do banco de dados
        private const string servidor = "localhost";
        private const string bancoDados = "dbperiferico";
        private const string usuario = "root";
        private const string senha = "Ch1c@r3ll1";

        //Declarando Variavel conexaoBanco para fazer a conexao com o banco de dados
        static public string bancoServidor = $"server={servidor}; user id ={usuario}; database ={bancoDados}; password={senha}";

    }
}