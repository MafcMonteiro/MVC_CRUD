using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oficina.Modelos;
using Oficina.DAL;
using Oficina.BLL.Extras;   // "Acopla" métodos de extensão

namespace Oficina.BLL
{
    /// <summary>
    /// Representa a Camada de Negócios
    /// para Veículo
    /// </summary>
    public class VeiculoBLL
    {
        public List<VeiculoDTO> ListarVeiculos()
        {
            var dal = new VeiculoDAL();
            return dal.ListarVeiculos();
        }

        /// <summary>
        /// Recebe os dados de Veículo da PL e, após validá-los,
        /// repassa o DTO para a DAL para inserção no BD
        /// </summary>
        /// <param name="dto">Instância de VeiculoDTO</param>
        public void Inserir(VeiculoDTO dto)
        {
            dto.ValidarTodosOsCampos(); // Validações!!!
            var dal = new VeiculoDAL();
            dal.Inserir(dto); // Repassa solicitação à DAL!!!
        }

        /// <summary>
        /// Repassa para à PL (GUI) 
        /// a instância de VeiculoDTO já populada
        /// com dados pela DAL
        /// </summary>
        /// <param name="placa">Placa a ser pesquisada</param>
        /// <returns>Instância de VeiculoDTO</returns>
        public VeiculoDTO Pesquisar(string placa)
        {
            placa.ValidarPlaca();
            var dal = new VeiculoDAL();
            //return dal.Pesquisar(placa);
            return dal[placa];
        }

        /// <summary>
        /// Recebe os dados de Veículo da PL e, após validá-los,
        /// repassa o DTO para a DAL para alteração no BD
        /// </summary>
        /// <param name="dto">Instância de VeiculoDTO</param>
        public void Atualizar(VeiculoDTO dto)
        {
            dto.ValidarTodosOsCampos(); // Validações!!!
            var dal = new VeiculoDAL();
            dal.Atualizar(dto); // Repassa solicitação à DAL!!!
        }

        /// <summary>
        /// Recebe os dados de Veículo da PL e, após validá-los,
        /// repassa o DTO para a DAL para exclusão no BD
        /// </summary>
        /// <param name="placa">Placa do veículo a ser excluído</param>
        public void Excluir(string placa)
        {
            placa.ValidarPlaca(); // Validação!!!
            var dal = new VeiculoDAL();
            dal.Excluir(placa); // Repassa solicitação à DAL!!!
        }
    }
}
