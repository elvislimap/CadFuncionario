using System;
using System.Collections.Generic;

namespace CadFuncionario.Domain.Entities
{
    public class Profissao
    {
        public Profissao(string descricao, decimal salarioBase)
        {
            ProfissaoId = Guid.NewGuid();
            Descricao = descricao;
            SalarioBase = salarioBase;
        }

        public Guid ProfissaoId { get; private set; }
        public string Descricao { get; private set; }
        public decimal SalarioBase { get; private set; }

        public virtual ICollection<StepProfissao> StepProfissoes { get; set; }
    }
}