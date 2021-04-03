using PassagensService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost Host = new ServiceHost(typeof(ClienteService));

            //Criando Nossa EndPoint
            Uri endereco = new Uri("http://localhost:8080/clientes");
            Host.AddServiceEndpoint(typeof(IClienteService), new BasicHttpBinding(), endereco);

            try
            {
                Host.Open();
                ExibirInformacoes(Host);
                Console.ReadLine();
                Host.Close();
            }
            catch (Exception ex)
            {
                Host.Abort();   
                Console.WriteLine(ex.Message);
            }
        }

        static void ExibirInformacoes(ServiceHost sh)   
        {
            Console.WriteLine($"Online: {sh.Description.ServiceType}");

            foreach (var se in sh.Description.Endpoints)
            {
                Console.WriteLine(se.Address);
            }
        }

    }
}
