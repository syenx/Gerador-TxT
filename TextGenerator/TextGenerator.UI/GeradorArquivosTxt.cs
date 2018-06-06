using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using TextGeneratePersistence;
using System.Reflection;

namespace TextGenerator.UI
{
    public static class GeradorArquivosTxt
    {


        public static void GerarArquivo(TransacaoEntity entidade)
        {


            // Cria o nome do arquivo com ano, mês, dia, hora minuto e segundo
            string nomeArquivo = AppDomain.CurrentDomain.BaseDirectory + "ArquivosTxt\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";

            // Cria um novo arquivo e devolve um StreamWriter para ele

            StreamWriter writer = new StreamWriter(nomeArquivo);

            // Agora é só sair escrevendo

            writer.WriteLine("Cartao: " + entidade.Cartao);
            writer.WriteLine("Valor: " + entidade.Valor);
            writer.WriteLine("Data: " + entidade.Data);

            // Não esqueça de fechar o arquivo ao terminar

            writer.Close();
        }

        public static void GerarTodosArquivos(List<TransacaoEntity> entidade)
        {


            // Cria o nome do arquivo com ano, mês, dia, hora minuto e segundo

            string nomeArquivo = AppDomain.CurrentDomain.BaseDirectory + "ArquivosTxt\\Lista_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";

            // Cria um novo arquivo e devolve um StreamWriter para ele

            StreamWriter writer = new StreamWriter(nomeArquivo);

            // Agora é só sair escrevendo
            foreach (var item in entidade)
            {
                writer.WriteLine("Cartao: " + item.Cartao);
                writer.WriteLine("Valor: " + item.Valor);
                writer.WriteLine("Data: " + item.Data);
            }
         

            // Não esqueça de fechar o arquivo ao terminar

            writer.Close();
        }

    }
}