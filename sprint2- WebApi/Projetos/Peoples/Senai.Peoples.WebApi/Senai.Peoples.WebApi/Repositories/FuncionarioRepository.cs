using Senai.Peoples.WebApi.Domains;
using Senai.Peoples.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private string stringConexao = "Data Source=DESKTOP-PKIN6P4\\MYDATABASE; initial catalog=T_Peoples; integrated security=true";
        //private string stringConexao = "Data Source=DEV4\\SQLEXPRESS; initial catalog=T_Peoples; user Id=sa; pwd=sa@132";

        public void Atualizar(int id, FuncionariosDomain funcionarioNovo)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryUpdate = $"UPDATE Funcionarios SET Nome = '{funcionarioNovo.Nome}', Sobrenome = '{funcionarioNovo.Sobrenome}'," +
                                     $"DataNasc = '{funcionarioNovo.DataNasc}' WHERE IdFuncionario = {id}";

                using (SqlCommand cmd = new SqlCommand(queryUpdate, con))
                {
                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public FuncionariosDomain BuscarPoId(int id)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelectPorId = $"SELECT IdFuncionario, Nome, Sobrenome, DataNasc FROM Funcionarios WHERE IdFuncionario = {id}";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectPorId, con))
                {
                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        FuncionariosDomain funcionario = new FuncionariosDomain
                        {
                            IdFuncionario = Convert.ToInt32(rdr["IdFuncionario"]),
                            Nome = rdr["Nome"].ToString(),
                            Sobrenome = rdr["Sobrenome"].ToString(),
                            DataNasc = Convert.ToDateTime(rdr["DataNasc"])
                        };

                        return funcionario;
                    }

                    return null;
                }
            }
        }

        public FuncionariosDomain BuscarPorNome(string nome)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelectByName = $"SELECT IdFuncionario, Nome, Sobrenome, DataNasc FROM Funcionarios WHERE Nome = '{nome}'";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectByName, con))
                {
                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        FuncionariosDomain funcionario = new FuncionariosDomain
                        {
                            IdFuncionario = Convert.ToInt32(rdr["IdFuncionario"]),
                            Nome = rdr["Nome"].ToString(),
                            Sobrenome = rdr["Sobrenome"].ToString(),
                            DataNasc = Convert.ToDateTime(rdr["DataNasc"])
                        };

                        return funcionario;
                    }

                    return null;
                }
            }
        }

        public void Cadastrar(FuncionariosDomain funcionario)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryInsert = $"INSERT INTO Funcionarios (Nome, Sobrenome, DataNasc) VALUES ('{funcionario.Nome}', '{funcionario.Sobrenome}')," +
                                     $" ('{funcionario.DataNasc}')";

                SqlCommand cmd = new SqlCommand(queryInsert, con);

                con.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public void Deletar(int id)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryDelete = $"DELETE FROM Funcionarios WHERE IdFuncionario = {id}";

                using (SqlCommand cmd = new SqlCommand(queryDelete, con))
                {
                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<FuncionariosDomain> Listar()
        {
            List<FuncionariosDomain> funcionarios = new List<FuncionariosDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelect = "SELECT IdFuncionario, Nome, Sobrenome, DataNasc FROM Funcionarios";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelect, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        FuncionariosDomain funcionario = new FuncionariosDomain()
                        {
                            IdFuncionario = Convert.ToInt32(rdr["IdFuncionario"]),
                            Nome = rdr["Nome"].ToString(),
                            Sobrenome = rdr["SobreNome"].ToString(),
                            DataNasc = Convert.ToDateTime(rdr["DataNasc"])
                        };

                        funcionarios.Add(funcionario);
                    }
                }

                return funcionarios;
            }
        }

        public List<FuncionariosDomain> ListarNomeCompleto()
        {
            List<FuncionariosDomain> funcionarios = new List<FuncionariosDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelectNomeCompleto = "SELECT * FROM Funcionarios";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectNomeCompleto, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        FuncionariosDomain funcionario = new FuncionariosDomain() 
                        {
                            IdFuncionario = Convert.ToInt32(rdr["IdFuncionario"]),
                            Nome = rdr["Nome"].ToString() + ' ' + rdr["SobreNome"].ToString(),
                            DataNasc = Convert.ToDateTime(rdr["DataNasc"])
                        };

                        funcionarios.Add(funcionario);
                    }
                }

                return funcionarios;
            }
        }
    }
}
