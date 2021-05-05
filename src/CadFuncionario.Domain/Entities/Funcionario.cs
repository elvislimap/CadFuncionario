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
        public DateTime? DataNascimento { get; private set; }

        public virtual StepProfissao StepProfissao { get; private set; }

        public void AlterarStep(Guid stepProfissaoId)
        {
            StepProfissaoId = stepProfissaoId;
        }

        public string ObterMensagemAniversario()
        {
            if (DataNascimento == null)
                return null;

            var dataAtual = DateTime.Now;
            return dataAtual.Day == DataNascimento.Value.Day && dataAtual.Month == DataNascimento.Value.Month
                ? $"Feliz aniversário! Parabéns pelos seus {DataNascimento.Value.Year - dataAtual.Year} anos, " +
                    "por favor hoje é dia de você pagar salgado!"
                : null;
        }
    }
}