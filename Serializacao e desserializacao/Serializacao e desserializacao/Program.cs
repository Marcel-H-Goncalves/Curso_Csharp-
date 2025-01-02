using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Runtime.Serialization;

namespace Serializacao_e_desserializacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cachorro meuCachorro = new Cachorro("Bilu", "Boxer", "Marrom");
            Cachorro meuCachorroDesserializado;

            DataContractSerializer serializador = new DataContractSerializer(typeof(Cachorro));

            //Serializaão
            XmlWriterSettings xmlConfig = new XmlWriterSettings { Indent = true };
            StringBuilder construtorDeString = new StringBuilder();
            XmlWriter escritorDeXml = XmlWriter.Create(construtorDeString, xmlConfig);
            serializador.WriteObject(escritorDeXml, meuCachorro);
            escritorDeXml.Flush();
            string objetoSerializadoStr = construtorDeString.ToString();

            //Salvando o conteudo do objeto num XML
            string caminhoDoMeuArquivoXml = "cachorro.xml";
            FileStream meuArquivoXml = File.Create(caminhoDoMeuArquivoXml);
            meuArquivoXml.Close();
            File.WriteAllText(caminhoDoMeuArquivoXml, objetoSerializadoStr);

            //Desserialização
            string conteudoDoObjetoSerializado = File.ReadAllText(caminhoDoMeuArquivoXml);
            StringReader leitorDeString = new StringReader(conteudoDoObjetoSerializado);
            XmlReader leitorDeXml = XmlReader.Create(leitorDeString);
            meuCachorroDesserializado = (Cachorro)serializador.ReadObject(leitorDeXml);

            escritorDeXml.Close();
            leitorDeXml.Close();
        }
    }
}
