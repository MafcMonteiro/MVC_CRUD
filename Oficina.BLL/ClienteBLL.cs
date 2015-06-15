using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oficina.Modelos;
using Oficina.DAL;

namespace Oficina.BLL
{
    /// <summary>
    /// Representa a camada de negócios para Cliente
    /// </summary>
    public class ClienteBLL
    {
        /// <summary>
        /// Repassa a solicitação ListarClientes() para
        /// a DAL (ClienteDAL) e retorna a coleção de 
        /// objetos ClienteDTO oriundas da DAL
        /// </summary>
        /// <returns></returns>
        public List<ClienteDTO> ListarClientes()
        {
            var dal = new ClienteDAL();
            return dal.ListarClientes();
        }
    }
}
