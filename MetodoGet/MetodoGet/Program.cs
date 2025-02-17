using System;
using System.Text;
using System.Net;
using System.Collections.Specialized;
using System.Web;


namespace MetodoGet
{
    internal class Program
    {
        public static string dadosMinhaPrimeiraPagina =
            "<!DOCTYPE html>" +
                 "<html>" +
                   " <head>" +
                      "<title>C# completo</title>" +
                      "<meta charset = \"utf-8\">" +
                    "</head>" +
                   "<body>" +
                       "<h1> Olá.Essa é a minha primeira página do meu próprio servidor web!</h1>" +
                        "<h2>Esse é o melhor curso de C# do mundo. Nenhum outro curso ensina tanta coisa!</h2>" +
                   " </body>" +
               " </html>";
        public static string dadosPaginaDesconhecida =
            "<!DOCTYPE html>" +
                 "<html>" +
                   " <head>" +
                      "<title>C# completo</title>" +
                      "<meta charset = \"utf-8\">" +

                    "</head>" +

                   " <body>" +

                       " <h1> Página inválida</h1>" +
                        "<h2>Essa página não existe no servidor!</h2>" +
                   " </body>" +
               " </html>";

        public static string dadosPaginaLoginSucesso  =
            "<!DOCTYPE html>" +
                 "<html>" +
                   " <head>" +
                      "<title>C# completo</title>" +
                      "<meta charset = \"utf-8\">" +

                    "</head>" +

                   " <body>" +

                       " <h1> Login Sucesso</h1>" +
                   " </body>" +
               " </html>";

        public static string dadosPaginaLoginFalha =
            "<!DOCTYPE html>" +
                 "<html>" +
                   " <head>" +
                      "<title>C# completo</title>" +
                      "<meta charset = \"utf-8\">" +

                    "</head>" +

                   " <body>" +

                       " <h1> Login Falhou</h1>" +
                   " </body>" +
               " </html>";

        public static string dadosFormularioGet =
            "<!DOCTYPE html>" +
                  "<html>" +
                      "<head>" +
                          "<title>C# completo</title>" +
                          "<meta charset = \"utf-8\">" +
                      "</head>" +
                      "<body>" +
                          "<header>" +
                              "<h1> Aprenda tudo em C# </h1>" +
                              "<p>Essa é uma página em HTML</p>" +
                              "<br>" +
                          "</header>" +
                          "<section id=\"contato\">" +
                              "<h2> Meu primeiro formulário HTML</h1>" +
                              "<form method = \"get\" action=\"acao_get_login\">" +
                                  "<label for=\"id_nome\">Digite o seu nome: </label>" +
                                  "<input type = \"text\" id=\"id_name\" name=\"nome\"><br><br>" +
                                  "<label for=\"id_senha\">Digite a sua senha: </label>" +
                                  "<input type = \"text\" id=\"id_senha\" name=\"senha\"><br><br>" +
                                  "<input type = \"submit\" value=\"enviar login com get\">" +
                              "</form>" +
                          "</section>" +
                      "</body>" +
                  "</html>";

        static void Main(string[] args)
        {
            string url = "http://localhost:80/";
            byte[] dados;
            HttpListener httpListener = new HttpListener();
            httpListener.Prefixes.Add(url);
            httpListener.Start();
            Console.WriteLine("Iniciando servidor WEB");
            Console.WriteLine("URL: " + url);

            bool deveContinuarExecutando = true;

            while (deveContinuarExecutando)
            {
                //Aguardando conexões
                Console.WriteLine("Aguardando por conexões...");
                HttpListenerContext conexao = httpListener.GetContext();
                Console.WriteLine("Conexão estabelecida");

                //Conexão estabelecida
                HttpListenerRequest req = conexao.Request;
                HttpListenerResponse resp = conexao.Response;

                //Processando o método GET
                if (req.HttpMethod == "GET")
                {
                    switch (req.Url.AbsolutePath)
                    {
                        case "/favicon.ico":
                            dados = new byte[0];
                            break;
                        case "/minhaprimeirapagina":
                            dados = Encoding.UTF8.GetBytes(dadosMinhaPrimeiraPagina);
                            break;
                        case "/login":
                            dados = Encoding.UTF8.GetBytes(dadosFormularioGet);
                            break;
                        case "/acao_get_login":
                            NameValueCollection parametrosValores = HttpUtility.ParseQueryString(req.Url.Query);
                            if (parametrosValores["nome"]=="Marcel" && parametrosValores["senha"] == "1234")
                            {
                                dados = Encoding.UTF8.GetBytes(dadosPaginaLoginSucesso);
                            }
                            else
                            {
                                dados = Encoding.UTF8.GetBytes(dadosPaginaLoginFalha);
                            }
                            break;
                        default:
                            dados = Encoding.UTF8.GetBytes(dadosPaginaDesconhecida);
                            break;
                    }
                }
                else
                {
                    dados = Encoding.UTF8.GetBytes(dadosPaginaDesconhecida);
                }

                //Preenchendo a resposta
                resp.ContentType = "text/html";
                resp.ContentEncoding = Encoding.UTF8;
                resp.ContentLength64 = dados.LongLength;

                //Enviar a resposta de volta
                resp.OutputStream.WriteAsync(dados, 0, dados.Length);
                resp.Close();
            }

        }
    }
}
