﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Data.SQLite;

namespace Biblion.Entities
{
    public class Estados
    {
        public int Id { get; set; }
        public string Sigla { get; set; }

        [JsonProperty("nome")]
        public string Descricao { get; set; }

        // Construtor sem parâmetros
        public Estados() { }

        // Construtor com parâmetros
        public Estados(int id, string sigla, string descricao)
        {
            Id = id;
            Sigla = sigla;
            Descricao = descricao;
        }

        public override string ToString()
        {
            return $"{Sigla} - {Descricao}";
        }
    }
}
