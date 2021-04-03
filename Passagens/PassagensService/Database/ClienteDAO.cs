using PassagensService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassagensService.Database
{
    public class ClienteDAO
    {
        private static IList<Cliente> Clientes = new List<Cliente>();


        public void Add(Cliente cliente)
        {
            Clientes.Add(cliente);
        }

        public Cliente Buscar(string nome)
        {
            var resultado = Clientes.Where(c => c.Nome == nome);

            return resultado as Cliente;
        }
    }
}
