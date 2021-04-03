using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassagensService.Database;
using PassagensService.Model;

namespace PassagensService
{
    //Essa aqui é a implementação da nossa interface
    public class ClienteService : IClienteService
    {
        private readonly ClienteDAO _contexto;

        public ClienteService()
        {
            _contexto = new ClienteDAO();
        }

        public void Add(Cliente cliente)
        {
            _contexto.Add(cliente);
        }

        public Cliente Buscar(string nome)
        {
           return  _contexto.Buscar(nome);
        }
    }
}
