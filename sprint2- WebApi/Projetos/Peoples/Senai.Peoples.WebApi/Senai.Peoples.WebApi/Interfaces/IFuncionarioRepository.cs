using Senai.Peoples.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Interfaces
{
    interface IFuncionarioRepository
    {
        List<FuncionariosDomain> Listar();
        void Cadastrar(FuncionariosDomain funcionario);
        FuncionariosDomain BuscarPoId(int id);
        void Atualizar(int id, FuncionariosDomain funcionarioNovo);
        void Deletar(int id);
        FuncionariosDomain BuscarPorNome(string nome);
        List<FuncionariosDomain> ListarNomeCompleto();
    }
}
