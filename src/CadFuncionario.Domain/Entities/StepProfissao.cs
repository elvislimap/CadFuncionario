using System;
using System.Collections.Generic;

namespace CadFuncionario.Domain.Entities
{
    public class StepProfissao
    {
        public StepProfissao(Guid profissaoId, decimal percentualAumento)
        {
            StepProfissaoId = Guid.NewGuid();
            ProfissaoId = profissaoId;
            PercentualAumento = percentualAumento;
        }

        public Guid StepProfissaoId { get; private set; }
        public Guid ProfissaoId { get; private set; }
        public decimal PercentualAumento { get; private set; }

        public virtual Profissao Profissao { get; private set; }
        public virtual ICollection<Funcionario> Funcionarios { get; private set; }


        public void AlterarPercentualAumento(decimal percentualAumento)
        {
            PercentualAumento = percentualAumento;
        }
    }
}