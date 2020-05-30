using DataBaseFirst2.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBaseFirst2.Interfaces
{
    interface IEstudioRepository
    {
        List<Estudios> Listar();
        Estudios BuscarPorId(int id);
        void Cadastrar(Estudios estudioNovo);
        void Atualizar(int id, Estudios estudioAtualizado);
        void Deletar(int id);
        List<Estudios> ListarComJogos();
    }
}
