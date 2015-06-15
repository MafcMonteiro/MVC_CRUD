using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Modelos
{
    /// <summary>
    /// Representa um DTO para Cliente
    /// </summary>
    public class ClienteDTO
    {
        #region Forma longa de escrever propriedade
        //private int _codigo;
        //public int Codigo
        //{
        //    get { return _codigo; }
        //    set { _codigo = value; }
        //} 
        #endregion

        #region Forma curta - propriedades automáticas
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }
        #endregion
    }
}
