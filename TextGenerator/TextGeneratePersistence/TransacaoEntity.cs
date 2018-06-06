using System;


namespace TextGeneratePersistence
{
    public class TransacaoEntity : Entity
    {
        public virtual int IdTransacao { get; set; }
        public virtual int Cartao { get; set; }
        public virtual decimal Valor { get; set; }
        public virtual DateTime Data { get; set; }
      
    }
}
