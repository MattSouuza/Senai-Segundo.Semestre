using Senai.WebApi.DataBaseFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.WebApi.DataBaseFirst.Interfaces
{
    interface IEstudioRepository
    {
        List<Estudios> Listar();
        Estudios BuscarPorId(int id);
        void Cadastrar(Estudios estudioNovo);
        void Atualizar(Estudios estudioAtualizado);
        void Deletar(int id);
        List<Estudios> ListarComJogos();
    }
}
