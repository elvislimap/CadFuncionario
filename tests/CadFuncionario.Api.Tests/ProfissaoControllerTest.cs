using System;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CadFuncionario.Api.Tests.Config;
using CadFuncionario.Domain.Entities;
using Xunit;

namespace CadFuncionario.Api.Tests
{
    [TestCaseOrderer("CadFuncionario.Api.Tests.Config.PriorityOrderer", "CadFuncionario.Api.Tests")]
    [Collection(nameof(IntegracaoTestsFixtureCollection))]
    public class ProfissaoControllerTest
    {
        private readonly IntegracaoTestsFixture _testsFixture;

        public ProfissaoControllerTest(IntegracaoTestsFixture testsFixture)
        {
            _testsFixture = testsFixture;
        }

        [Fact(DisplayName = "Adicionar profissao"), TestPriority(1)]
        [Trait("Grupo", "IntegracaoAPI")]
        public async Task ProfissaoController_Adicionar()
        {
            // Arrange
            var faker = _testsFixture.Faker;
            var profissao = new Profissao(Guid.Empty, faker.Company.CompanyName(),
                faker.Random.Decimal(1000, 5000));
            _testsFixture.ProfissaoId = profissao.ProfissaoId;

            // Act
            var response = await _testsFixture.Client
                .PostAsJsonAsync("api/profissao/adicionar", profissao);

            // Assert
            response.EnsureSuccessStatusCode();

            var retornoApi = await response.Content.ReadFromJsonAsync<bool>();
            Assert.True(retornoApi);
        }

        [Fact(DisplayName = "Adicionar step profissao"), TestPriority(2)]
        [Trait("Grupo", "IntegracaoAPI")]
        public async Task ProfissaoController_AdicionarStep()
        {
            // Arrange
            var stepProfissao = new StepProfissao(_testsFixture.ProfissaoId,
                _testsFixture.Faker.Random.Decimal(3, 7));

            // Act
            var response = await _testsFixture.Client
                .PostAsJsonAsync("api/profissao/adicionarstep", stepProfissao);

            // Assert
            response.EnsureSuccessStatusCode();

            var retornoApi = await response.Content.ReadFromJsonAsync<bool>();
            Assert.True(retornoApi);
        }
    }
}
