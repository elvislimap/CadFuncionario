using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CadFuncionario.Application.Interfaces;
using CadFuncionario.Domain.Entities;
using CadFuncionario.Domain.Interfaces.Data;

namespace CadFuncionario.Application
{
    public class ProfissaoAppService : IProfissaoAppService
    {
        private readonly IProfissaoRepository _profissaoRepository;

        public ProfissaoAppService(IProfissaoRepository profissaoRepository)
        {
            _profissaoRepository = profissaoRepository;
        }


        public Task<bool> AdicionarAsync(Profissao profissao)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AdicionarStepAsync(StepProfissao stepProfissao)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AtualizarAsync(Profissao profissao)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AtualizarStepAsync(StepProfissao stepProfissao)
        {
            throw new NotImplementedException();
        }

        public Task<Profissao> ObterAsync(Guid profissaoId)
        {
            throw new NotImplementedException();
        }

        public Task<StepProfissao> ObterStepAsync(Guid stepProfissaoId)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Profissao>> ObterTodosAsync()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}