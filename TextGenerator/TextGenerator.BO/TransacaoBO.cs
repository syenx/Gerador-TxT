using System;
using System.Collections.Generic;
using System.Linq;
using TextGeneratePersistence;

namespace TextGenerator.BO
{
    public class TransacaoBO 
    {
        public static List<TransacaoEntity> Consultar()
        {
            return new RepositoryBase().ObterTodos<TransacaoEntity>().ToList();
        }
        public static List<TransacaoEntity> ConsultarPorCartao(int cartao)
        {
            var lista = new RepositoryBase().ProcurarTodos<TransacaoEntity>(x => x.Cartao == cartao).ToList();
            return lista;
        }

        public static TransacaoEntity ConsultaraPorID(int id)
        {
            var lista = new RepositoryBase().ProcurarTodos<TransacaoEntity>(x => x.IdTransacao == id).FirstOrDefault();
            return lista;
        }

        public static void Inserir(TransacaoEntity data)
        {
            new RepositoryBase().Salvar(data);
        }

        public static void Alterar(TransacaoEntity data)
        {
            new RepositoryBase().Atualizar(data);
        }
    }
}
