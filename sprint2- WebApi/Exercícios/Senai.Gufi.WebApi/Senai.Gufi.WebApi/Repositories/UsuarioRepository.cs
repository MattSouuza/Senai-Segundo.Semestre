using Senai.Gufi.WebApi.Domains;
using Senai.Gufi.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        GufiContext ctx = new GufiContext();

        public void Atualizar(int id, Usuario UsuarioAtualizado)
        {
            Usuario UsuarioBuscado = ctx.Usuario.Find(id);

            UsuarioBuscado.NomeUsuario = UsuarioAtualizado.NomeUsuario;
            UsuarioBuscado.Email = UsuarioAtualizado.Email;
            UsuarioBuscado.Senha = UsuarioAtualizado.Senha;
            UsuarioBuscado.Genero = UsuarioAtualizado.Genero;
            UsuarioBuscado.DataNascimento = UsuarioAtualizado.DataNascimento;

            //Funciona sem usar o metodo update (talvez)
            ctx.Usuario.Update(UsuarioBuscado);

            ctx.SaveChanges();
        }

        public Usuario BuscarPorId(int id)
        {
            return ctx.Usuario.FirstOrDefault(u => u.IdUsuario == id);
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            ctx.Usuario.Add(novoUsuario);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Usuario.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return ctx.Usuario.ToList();
        }
    }
}
