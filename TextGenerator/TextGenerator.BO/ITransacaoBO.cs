using System.Collections.Generic;
using TextGeneratePersistence;


namespace TextGenerator.BO
{
    public interface ITransacaoBO
    {
        void Insert(TransacaoEntity entity);
        void Delete(int id);
        void Update(int id);
        IList<TransacaoEntity> GetList();
        TransacaoEntity GetSingle(int Id);
    }
}