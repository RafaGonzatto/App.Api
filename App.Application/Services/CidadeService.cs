using App.Domain.Entities;
using App.Domain.Interfaces.Application;
using App.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Services
{
    public class CidadeService : ICidadeService
    {             //ISSO AQUI É ESTANCIAR UMA FUNÇÃO, STATIC VOID INJECT
        // COM INJECT É SÓ PUXAR DIRETO
        private IRepositoryBase<Cidade> _repository { get; set; }
        public CidadeService(IRepositoryBase<Cidade> repository)
        {
            _repository = repository;
        }

        public Cidade BuscaPorCep(string cep)                  //Se fosse necessario retornar mais, seria um list
        {                       //acessa o banco com ele                //Vai pegar o primeiro que for encontrado
            var retornoCidade = _repository.Query(cidade => cidade.Cep == cep).FirstOrDefault();
            return retornoCidade;
        //repositorio é uma conexão do banco, isso aqui é um filtro == é uma comparação, retorna 
        //a cidade desejada, literalmente uma buscar por cep
        //quer achar um aluno com melhor nota, order by e firstordefault
        }

        public List<Cidade> ListaCidades(string cep, string nome)
        {   
            throw new NotImplementedException();
        }

        public void Remover(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Salvar(Cidade obj)
        {
            throw new NotImplementedException();
        }
    }
}
