using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Biblion.Entities
{
    class Globais
    {
        public static string versao = "2.0";
        public static Boolean logado = false;
        public static int nivel = 0; //0=basico - 1=Gerente - 2=Master
        public static string caminho = System.Environment.CurrentDirectory;
        //public static string caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string nomeBanco = "bd_biblion.db";
        public static string caminhoBanco = @"C:\Users\ph_ma\OneDrive\Documentos\Programação\C#\Biblion2\Biblion\bd\";
        public static string caminhoFotos = @"C:\Users\ph_ma\OneDrive\Documentos\Programação\C#\Biblion2\Biblion\Resources\";
    }
}
