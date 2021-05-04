using System;

namespace CadFuncionario.Domain.Entities
{
    public class Funcionario
    {
        public Funcionario(Guid stepProfissaoId, string cpf, string rg, string nome, string ctps, DateTime dataNascimento)
        {
            FuncionarioId = Guid.NewGuid();
            StepProfissaoId = stepProfissaoId;
            Cpf = cpf;
            Rg = rg;
            Nome = nome;
            Ctps = ctps;
            DataNascimento = dataNascimento;
        }

        public Guid FuncionarioId { get; private set; }
        public Guid StepProfissaoId { get; private set; }
        public string Cpf { get; private set; }
        public string Rg { get; private set; }
        public string Nome { get; private set; }
        public string Ctps { get; private set; }
        public DateTime DataNascimento { get; private set; }

        public virtual StepProfissao StepProfissao { get; private set; }
    }
}