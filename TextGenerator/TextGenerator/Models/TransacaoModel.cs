using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TextGeneratePersistence;
using TextGenerator.BO;

namespace TextGenerator.Models
{
    public class TransacaoModel
    {
       
        public int IdTransacao { get; set; }
        public int Cartao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }

       
    }
}