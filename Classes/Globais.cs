using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudocsharp
{
    class Globais
    {
        public static string versao = "1.0";
        public static Boolean logado = false;
        public static int nivel = 0;
        public static string caminho = System.Environment.CurrentDirectory;
        public static string nomeBanco = "banco_projeto.db";
        public static string caminhoBanco = caminho+@"\banco_projeto\";
        public static string caminhoFotos = caminho+@"\foto\";
    }
}
