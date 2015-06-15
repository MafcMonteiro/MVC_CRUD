using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Modelos
{
    /// <summary>
    /// Representa um DTO para Veículo
    /// </summary>
    public class VeiculoDTO
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public short Ano { get; set; }
        public int CodigoCliente { get; set; }
    }
}
