using System;
using Bogus;
using Bogus.Extensions.Brazil;
using CadFuncionario.Domain.Entities;
using Xunit;

namespace CadFuncionario.Domain.Tests.Entities
{
    public class FuncionarioTest
    {
        private readonly Faker _faker;

        public FuncionarioTest()
        {
            _faker = new Faker("pt_BR");
        }


        [Fact(DisplayName = "Testando geração do FuncionarioId")]
        [Trait("Grupo", "Entities")]
        public void Funcionario_GerandoId_ComSucesso()
        {
            // Arrange & Act
            var funcionario = GerarFuncionario();

            // Assert
            Assert.NotNull(funcionario.FuncionarioId);
        }

        [Fact(DisplayName = "Alterar o step do funcionario")]
        [Trait("Grupo", "Entities")]
        public void Funcionario_AlterarStep()
        {
            // Arrange 
            var funcionario = GerarFuncionario();
            var stepOriginal = funcionario.StepProfissaoId;

            // Act
            funcionario.AlterarStep(_faker.Random.Guid());

            // Assert
            Assert.NotEqual(stepOriginal, funcionario.StepProfissaoId);
        }

        [Fact(DisplayName = "Obter mensagem aniversário com data nascimento nulo")]
        [Trait("Grupo", "Entities")]
        public void Funcionario_ObterMensagemAniversarioDataNascimentoNulo()
        {
            // Arrange 
            var funcionario = GerarFuncionario(false);

            // Act & Assert
            Assert.Null(funcionario.ObterMensagemAniversario());
        }

        // TODO: Continuar cenários...

        private Funcionario GerarFuncionario(bool gerarDataNascimento = true)
        {
            DateTime? dataNascimento = null;
            if (gerarDataNascimento)
                dataNascimento = _faker.Person.DateOfBirth;

            return new Funcionario(
                _faker.Random.Guid(),
                _faker.Person.Cpf(false),
                _faker.Random.String(_faker.Random.Int(8, 10)),
                _faker.Person.FullName,
                _faker.Random.String(_faker.Random.Int(8, 10)),
                dataNascimento
            );
        }
    }
}