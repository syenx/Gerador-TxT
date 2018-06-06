using System;

namespace TextGenerator.Entity
{
    public class TransacaoEntity
    {

        private static readonly TransacaoEntity instance = new TransacaoEntity();
        private TransacaoEntity() { }

        public static TransacaoEntity Instance
        {
            get
            {
                return instance;
            }
        }

        public int IdTransacao { get; set; }
        public int Cartao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
    }
}
