using Oficina.Modelos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.DAL
{
    /// <summary>
    /// Representa o Acesso a Dados
    /// para Veículo
    /// </summary>
    public class VeiculoDAL
    {
        public List<VeiculoDTO> ListarVeiculos()
        {
            #region Preparação
            var cn = new SqlConnection();
            cn.ConnectionString =
                ConfigurationManager
                    .ConnectionStrings["OficinaConnectionString"]
                        .ConnectionString;

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Veiculo ORDER BY Placa_vei";
            cmd.CommandType = CommandType.Text;

            // declara e instancia coleção (sem objetos!!!)
            var listaVeiculos = new List<VeiculoDTO>();
            #endregion
            #region Processamento
            try
            {
                cn.Open();
                var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    var veiculo = new VeiculoDTO
                        {
                            Placa = dr["Placa_vei"].ToString(),
                            Modelo = dr["Modelo_vei"].ToString(),
                            Cor = dr["Cor_vei"].ToString(),
                            Ano = Convert.ToInt16(dr["Ano_vei"]),
                            CodigoCliente =
                                Convert.ToInt32(dr["Codigo_cli"])
                        };

                    listaVeiculos.Add(veiculo);
                }

                dr.Close();
                return listaVeiculos;
            }
            #endregion
            #region Tratamento de Exceções (DAL)
            catch (SqlException sqlex)
            {
                throw new Exception(
                    message: string.Format("Ocorreu erro (DAL) # {0} - {1}",
                                        sqlex.Number,
                                        sqlex.Message),
                    innerException: sqlex);
            }
            catch (Exception ex)
            {
                throw new Exception(
                    message: string.Format("Ocorreu erro (DAL - Geral) - {0}",
                            ex.Message),
                    innerException: ex);
            }
            #endregion
            #region Finalização
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
            #endregion
        }

        // Indexador!!!
        public VeiculoDTO this[string placa]
        {
            get
            {
                return Pesquisar(placa);
            }
        }

        /// <summary>
        /// Recebe uma instância de VeiculoDTO já validada
        /// pela BLL e procede com a inserção no BD através da PROC
        /// pVeiculo_INS
        /// </summary>
        /// <param name="dto">Instância de VeiculoDTO</param>
        public void Inserir(VeiculoDTO dto)
        {
            #region Preparação
            var cn = new SqlConnection();
            cn.ConnectionString =
                ConfigurationManager
                    .ConnectionStrings["OficinaConnectionString"]
                        .ConnectionString;

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "pVeiculo_INS";
            cmd.CommandType = CommandType.StoredProcedure;

            // Passagem de parâmetros
            cmd.Parameters.AddWithValue("@Placa", dto.Placa);
            cmd.Parameters.AddWithValue("@Modelo", dto.Modelo);
            cmd.Parameters.AddWithValue("@Cor", dto.Cor);
            cmd.Parameters.AddWithValue("@Ano", dto.Ano);
            cmd.Parameters.AddWithValue("@CodigoCliente", dto.CodigoCliente);
            #endregion
            #region Processamento
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            #endregion
            #region Tratamento de Exceções (DAL)
            catch (SqlException sqlex)
            {
                throw new Exception(
                    message: string.Format("Ocorreu erro (DAL) # {0} - {1}",
                                        sqlex.Number,
                                        sqlex.Message),
                    innerException: sqlex);
            }
            catch (Exception ex)
            {
                throw new Exception(
                    message: string.Format("Ocorreu erro (DAL - Geral) - {0}",
                            ex.Message),
                    innerException: ex);
            }
            #endregion
            #region Finalização
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
            #endregion
        }

        /// <summary>
        /// Retorna uma instância de VeiculoDTO
        /// devidamente "populada" com os dados 
        /// retornados pela PROC pVeiculo_SEL_PorPlaca
        /// </summary>
        /// <param name="placa">Placa a ser pesquisada</param>
        /// <returns>A instância de VeiculoDTO</returns>
        public VeiculoDTO Pesquisar(string placa)
        {
            #region Preparação
            var cn = new SqlConnection();
            cn.ConnectionString =
                ConfigurationManager
                    .ConnectionStrings["OficinaConnectionString"]
                        .ConnectionString;

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "pVeiculo_SEL_PorPlaca";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue(
                            parameterName: "@Placa",
                            value: placa);
            #endregion
            #region Processamento
            try
            {
                cn.Open();
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    var veiculo = new VeiculoDTO
                    {
                        Placa = dr["Placa"].ToString(),
                        Modelo = dr["Modelo"].ToString(),
                        Cor = dr["Cor"].ToString(),
                        Ano = Convert.ToInt16(dr["Ano"]),
                        CodigoCliente = Convert.ToInt32(dr["CodigoCliente"])
                    };

                    dr.Close();
                    return veiculo;
                }
                else
                {
                    return null;
                }
            }
            #endregion
            #region Tratamento de Exceções (DAL)
            catch (SqlException sqlex)
            {
                throw new Exception(
                    message: string.Format("Ocorreu erro (DAL) # {0} - {1}",
                                        sqlex.Number,
                                        sqlex.Message),
                    innerException: sqlex);
            }
            catch (Exception ex)
            {
                throw new Exception(
                    message: string.Format("Ocorreu erro (DAL - Geral) - {0}",
                            ex.Message),
                    innerException: ex);
            }
            #endregion
            #region Finalização
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
            #endregion
        }

        /// <summary>
        /// Recebe uma instância de VeiculoDTO já validada
        /// e procede com a alteração no BD através da PROC
        /// pVeiculo_UPD_PorPlaca
        /// </summary>
        /// <param name="dto">Instância de VeiculoDTO</param>
        /// <returns>Quantidade de linhas afetadas pela execução da PROC</returns>
        public void Atualizar(VeiculoDTO dto)
        {
            #region Preparação
            var cn = new SqlConnection();
            cn.ConnectionString =
                ConfigurationManager
                    .ConnectionStrings["OficinaConnectionString"]
                        .ConnectionString;

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "pVeiculo_UPD_PorPlaca";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Placa", dto.Placa);
            cmd.Parameters.AddWithValue("@Modelo", dto.Modelo);
            cmd.Parameters.AddWithValue("@Cor", dto.Cor);
            cmd.Parameters.AddWithValue("@Ano", dto.Ano);
            cmd.Parameters.AddWithValue("@CodigoCliente", dto.CodigoCliente);
            #endregion
            #region Processamento
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            #endregion
            #region Tratamento de Exceções (DAL)
            catch (SqlException sqlex)
            {
                throw new Exception(
                    message: string.Format("Ocorreu erro (DAL) # {0} - {1}",
                                        sqlex.Number,
                                        sqlex.Message),
                    innerException: sqlex);
            }
            catch (Exception ex)
            {
                throw new Exception(
                    message: string.Format("Ocorreu erro (DAL - Geral) - {0}",
                            ex.Message),
                    innerException: ex);
            }
            #endregion
            #region Finalização
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
            #endregion
        }

        /// <summary>
        /// Recebe apenas a placa do veiculo já validada
        /// e procede com a exclusão no BD através da PROC
        /// pVeiculo_DEL_PorPlaca
        /// </summary>
        /// <param name="placa">Placa do veículo a ser excluído</param>
        /// <returns>Quantidade de linhas afetadas pela execução da PROC</returns>
        public void Excluir(string placa)
        {
            #region Preparação
            var cn = new SqlConnection();
            cn.ConnectionString =
                ConfigurationManager
                    .ConnectionStrings["OficinaConnectionString"]
                        .ConnectionString;

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "pVeiculo_DEL_PorPlaca";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Placa", placa);
            #endregion
            #region Processamento
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            #endregion
            #region Tratamento de Exceções (DAL)
            catch (SqlException sqlex)
            {
                throw new Exception(
                    message: string.Format("Ocorreu erro (DAL) # {0} - {1}",
                                        sqlex.Number,
                                        sqlex.Message),
                    innerException: sqlex);
            }
            catch (Exception ex)
            {
                throw new Exception(
                    message: string.Format("Ocorreu erro (DAL - Geral) - {0}",
                            ex.Message),
                    innerException: ex);
            }
            #endregion
            #region Finalização
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
            #endregion
        }
    }
}
