using Senai.Gufi.WebApi.Domains;
using Senai.Gufi.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Repositories
{
    public class PresencaRepository : IPresencaRepository
    {

        GufiContext ctx = new GufiContext();

        public void Aprovar(Presenca presencaAprovar)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Presenca presencaAtualizada)
        {
            throw new NotImplementedException();
        }

        public Presenca BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Presenca novaPresenca)
        {
            throw new NotImplementedException();
        }

        public void Convidar(Presenca presenca)
        {
            ctx.Presenca.Add(presenca);

            ctx.SaveChanges();
        }

        public void Deletar(Presenca presencaDelete)
        {
            throw new NotImplementedException();
        }

        public void Inscricao(Presenca presencaInscricao)
        {
            throw new NotImplementedException();
        }

        public List<Presenca> Listar()
        {
            throw new NotImplementedException();
        }

        public List<Presenca> ListarMinhasPresencas()
        {
            throw new NotImplementedException();
        }
    }
}
