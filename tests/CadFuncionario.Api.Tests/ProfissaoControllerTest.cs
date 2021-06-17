using System.Net.Http.Json;
using System.Threading.Tasks;
using CadFuncionario.Api.Tests.Config;
using CadFuncionario.Domain.Entities;
using Xunit;

namespace CadFuncionario.Api.Tests
{
    [Collection(nameof(IntegracaoTestsFixtureCollection))]
    public class ProfissaoControllerTest
    {
        private readonly IntegracaoTestsFixture _testsFixture;

        public ProfissaoControllerTest(IntegracaoTestsFixture testsFixture)
        {
            _testsFixture = testsFixture;
        }

        [Fact(DisplayName = "Adicionar profissao")]
        [Trait("Grupo", "IntegracaoAPI")]
        public async Task ProfissaoController_Adicionar()
        {
            // Arrange
            var faker = _testsFixture.Faker;
            var profissao = new Profissao(faker.Company.CompanyName(),
                faker.Random.Decimal(1000, 5000));

            // Act
            var response = await _testsFixture.Client
                .PostAsJsonAsync("api/profissao/adicionar", profissao);

            // Assert
            response.EnsureSuccessStatusCode();
            var retornoApi = await response.Content.ReadFromJsonAsync<bool>();

            Assert.True(retornoApi);
        }
    }
}
