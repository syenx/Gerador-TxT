using NHibernate.Mapping.ByCode;

namespace TextGeneratePersistence
{
    public class TransacaoMaps : EntityMapping<TransacaoEntity>
    {
        public TransacaoMaps()
        {
            Table("Transacao");
            Id(
                m => m.IdTransacao,
                map =>
                {
                    map.Column("IdTransacao");
                    map.Generator(Generators.Identity);
                }
            );
            Property(m => m.Cartao, map => map.Column("Cartao"));
            Property(m => m.Valor, map => map.Column("Valor"));
            Property(m => m.Data, map => map.Column("Datas"));
        }
    }
}
