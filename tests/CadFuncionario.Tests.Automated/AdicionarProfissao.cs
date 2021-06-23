using System;
using System.IO;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Xunit;

namespace CadFuncionario.Tests.Automated
{
    public class AdicionarProfissao
    {
        [Fact(DisplayName = "Adicionar profissao")]
        [Trait("Grupo", "Automated")]
        public void ProfissaoAutomated_Sucesso()
        {
            //var options = new ChromeOptions();
            //options.AddArgument("--headless");

            var driver = new ChromeDriver(Directory.GetCurrentDirectory());
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(0.5));
        }
    }
}
