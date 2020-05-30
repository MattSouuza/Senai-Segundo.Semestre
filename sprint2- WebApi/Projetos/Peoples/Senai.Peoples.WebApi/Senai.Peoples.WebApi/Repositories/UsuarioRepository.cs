using Senai.Peoples.WebApi.Domains;
using Senai.Peoples.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private string stringConexao = "Data Source=DESKTOP-PKIN6P4\\MYDATABASE; initial catalog=T_Peoples; integrated security=true";
        //private string stringConexao = "Data Source=DEV4\\SQLEXPRESS; initial catalog=T_Peoples; user Id=sa; pwd=sa@132";

        public UsuarioDomain BuscarPorEmailSenha(string email, string senha)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string query = "SELECT IdUsuario, Nome, Email, Senha, IdTipoUsuario FROM Usuario WHERE Email = @Email AND Senha = @Senha";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.HasRows)
                    {
                        UsuarioDomain usuario = new UsuarioDomain();
 
                        while (rdr.Read())
                        {
                            usuario.IdUsuario = Convert.ToInt32(rdr["IdUsuario"]);

                            usuario.Nome = rdr["Nome"].ToString();

                            usuario.Email = rdr["Email"].ToString();

                            usuario.Senha = rdr["Senha"].ToString();

                            usuario.IdTipoUsuario = Convert.ToInt32(rdr["IdTipoUsuario"]);
                        }

                        return usuario;
                    }

                    return null;
                }
            }
        }
    }
}
