using PassagensService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace PassagensService
{
    //Este é nosso Contrato , um padrão que deve ser seguido
    //O contrato sempre é realizado cm uma interface
    [ServiceContract]//Informando que é um contrato wcf
    public interface IClienteService
    {
        [OperationContract]//Cada operação segue um contrato

        [WebInvoke(Method = "Get", ResponseFormat = WebMessageFormat.Json,UriTemplate = "buscar/{nome}" )]
        Cliente Buscar(string nome);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,UriTemplate ="addCliente/{nome};{cpf}")]
        bool Add(string nome, string cpf);
    }
}
