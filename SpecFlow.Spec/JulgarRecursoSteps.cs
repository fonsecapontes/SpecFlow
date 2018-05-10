using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlow.Spec
{
    [Binding]
    public class JulgarRecursoSteps
    {
        private Recurso recurso = new Recurso();
        private List<Recurso> recursos = new List<Recurso>();
        private string mensagem;

        [Given(@"Eu informei o Recurso:")]
        public void GivenEuInformeiORecurso(Table table)
        {
            this.recurso = table.CreateInstance<Recurso>();
        }

        [When(@"Eu julgar ele")]
        public void WhenEuJulgarEle()
        {
            mensagem = this.recurso.Julgar();
        }

        [When(@"Eu listar os recursos ativos")]
        public void WhenEuListarOsRecursosAtivos()
        {
            this.recursos = this.recurso.Listar();
        }

        [Then(@"O resultado deverá ser a mensagem de ""(.*)""")]
        public void ThenOResultadoDeveraSerAMensagemDe(string expected)
        {
            Assert.AreEqual(expected, mensagem);
        }

        [Then(@"O resultado não poderá ter recursos inativos")]
        public void ThenOResultadoNaoPoderaTerRecursosInativos()
        {
            var isInativos = this.recursos.Any(x => !x.IsAtivo);

            Assert.IsFalse(isInativos);
        }
    }
}