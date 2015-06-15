using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oficina.Modelos;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Oficina.DAL
{
    /// <summary>
    /// Representa o Acesso a Dados para Cliente
    /// </summary>
    public class ClienteDAL
    {
        /// <summary>
        /// Busca os registros no BD 
        /// (utilizando PROC pCliente_SEL_Todos)
        /// e os retorna na forma de uma coleção de ClienteDTO
        /// </summary>
        /// <returns>A própria coleção de ClienteDTO com dados</returns>
        public List<ClienteDTO> ListarClientes()
        {
            #region Preparação
            var cn = new SqlConnection();
            cn.ConnectionString =
                ConfigurationManager
                    .ConnectionStrings["OficinaConnectionString"]
                        .ConnectionString;

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "pCliente_SEL_Todos";
            cmd.CommandType = CommandType.StoredProcedure;

            // declara e instancia coleção (sem objetos!!!)
            var listaClientes = new List<ClienteDTO>();
            #endregion
            #region Processamento
            try
            {
                cn.Open();
                var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    #region Declara, instancia e popula o DTO para Cliente
                    //var cliente = new ClienteDTO();
                    ////cliente.Codigo = (int)dr["Codigo"];
                    //cliente.Codigo = Convert.ToInt32(dr["Codigo"]);
                    //cliente.Nome = dr["Nome"].ToString();
                    //cliente.Email = dr["Email"].ToString();
                    //cliente.Nascimento = Convert.ToDateTime(dr["Nascimento"]);

                    var cliente = new ClienteDTO
                        {
                            Codigo = Convert.ToInt32(dr["Codigo"]),
                            Nome = dr["Nome"].ToString(),
                            Email = dr["Email"].ToString(),
                            Nascimento = Convert.ToDateTime(dr["Nascimento"])
                        };
                    #endregion

                    #region Adiciona o DTO à coleção (de clientes)
                    listaClientes.Add(cliente);
                    #endregion
                }

                dr.Close();

                return listaClientes;
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
