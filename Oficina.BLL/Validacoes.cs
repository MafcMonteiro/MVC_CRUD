using Oficina.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Oficina.BLL.Extras
{
    public static class Validacoes
    {
        /// <summary>
        /// Valida a placa de um VeiculoDTO
        /// </summary>
        /// <param name="placa">a própria placa a ser validada</param>
        public static void ValidarPlaca(this string placa)
        {
            if (string.IsNullOrEmpty(placa.Trim()))
            {
                throw new Exception("Erro Validação (BLL) - Placa obrigatória!");
            }
            else if (!Regex.IsMatch(input: placa, 
                    pattern: "^[a-zA-Z]{3,3}[0-9]{4,4}$"))
            {
                throw new Exception("Erro Validação (BLL) - Placa inválida!");
            }
        }

        /// <summary>
        /// Valida todos as propriedades de VeiculoDTO
        /// </summary>
        /// <param name="dto">Instância de VeiculoDTO a ser validada</param>
        public static void ValidarTodosOsCampos(this VeiculoDTO dto)
        {
            dto.Placa.ValidarPlaca();

            if (dto.Modelo.Trim() == "")
            {
                throw new Exception("Erro Validação (BLL) - Modelo obrigatório!");
            }
            else if (dto.Cor.Trim() == "")
            {
                throw new Exception("Erro Validação (BLL) - Cor obrigatória!");
            }
            else if (dto.Ano.ToString() == "")
            {
                throw new Exception("Erro Validação (BLL) - Ano obrigatório!");
            }
            else if (!Regex.IsMatch(dto.Ano.ToString(), "^[0-9]{4}$"))
            {
                throw new Exception("Erro Validação (BLL) - Ano inválido!");
            }
            else if (dto.CodigoCliente.ToString() == "")
            {
                throw new Exception("Erro Validação (BLL) - Proprietário obrigatório!");
            }
        }
    }
}
