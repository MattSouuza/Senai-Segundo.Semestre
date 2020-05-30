using Senai.WebApi.DataBaseFirst.Domains;
using Senai.WebApi.DataBaseFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.WebApi.DataBaseFirst.Repositories
{
    public class EstudioRepository : IEstudioRepository
    {
        private InLockContext ctx = new InLockContext();

        public void Atualizar(Estudios estudioAtualizado)
        {
            ctx.Estudios.Update(estudioAtualizado);
            ctx.SaveChanges();
        }

        public Estudios BuscarPorId(int id)
        {
            return ctx.Estudios.Single(e => e.IdEstudio == id);
        }

        public void Cadastrar(Estudios estudioNovo)
        {
            ctx.Estudios.Add(estudioNovo);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Remove(ctx.Estudios.Single(e => e.IdEstudio == id));
            ctx.SaveChanges();
        }

        public List<Estudios> Listar()
        {
            return ctx.Estudios.ToList();
        }

        public List<Estudios> ListarComJogos()
        {
            throw new NotImplementedException();
        }
    }
}
