using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using Biblion.DAL;

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

        public static int gerarNovoID(string tabela)
        {
            // Recupera o caminho atual da imagem do banco de dados
            using (var conexao = new Conexao())
            {
                string queryBusca = "";
                int id = 0;

                queryBusca = "Select COALESCE(Max(id),0) As 'id' from " + tabela;
                using (var comandoBusca = conexao.CriarComando(queryBusca))
                {
                    var reader = comandoBusca.ExecuteReader();

                    if (reader.Read())
                    {
                        id = int.Parse(reader["id"].ToString()); // Obtém o caminho da imagem do banco
                        id++;
                    }
                    reader.Close();
                    return id;
                }
            }
        }

        public static void primeiro(DataGridView dgv)
        {
            dgv.Rows[0].Selected = true;
            dgv.Rows[0].Cells[0].Selected = true;
        }

        public static void ultimo(DataGridView dgv)
        {
            int nRowIndex = dgv.Rows.Count - 1;
            int nColumnIndex = 1;

            dgv.Rows[nRowIndex].Selected = true;
            dgv.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;
        }

        public static void anterior(DataGridView dgv)
        {
            if (dgv.SelectedRows[0].Index > 0)
            {
                dgv.Rows[dgv.SelectedRows[0].Index - 1].Selected = true;
            }
        }

        public static void proximo(DataGridView dgv)
        {
            if (dgv.SelectedRows[0].Index < dgv.Rows.Count - 1)
            {
                dgv.Rows[dgv.SelectedRows[0].Index + 1].Selected = true;
            }
        }

        public static void MoverParaProximaAba(TabControl tabControl)
        {
            if (tabControl == null) return;

            if (tabControl.SelectedIndex < tabControl.TabCount - 1)
            {
                tabControl.SelectedIndex++;
            }
        }

        public static void MoverParaAbaAnterior(TabControl tabControl)
        {
            if (tabControl == null) return;

            if (tabControl.SelectedIndex > 0)
            {
                tabControl.SelectedIndex--;
            }
        }

    }
}
