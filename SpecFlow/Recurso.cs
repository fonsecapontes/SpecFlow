using System.Collections.Generic;

namespace SpecFlow
{
    public class Recurso
    {
        public int Id { get; set; }
        public string Parecer { get; set; }
        public bool IsAtivo { get; set; }

        public string Julgar()
        {
            // Faça a sua lógica aqui
            if (Id != 1) { return "Erro"; }

            return "Sucesso";
        }

        public List<Recurso> Listar()
        {
            // Faça a sua lógica aqui
            return new List<Recurso>
            {
                new Recurso { Id = 1, Parecer = "Recurso Teste 1", IsAtivo = true },
                new Recurso { Id = 2, Parecer = "Recurso Teste 2", IsAtivo = true },
                new Recurso { Id = 3, Parecer = "Recurso Teste 3", IsAtivo = false }
            };
        }
    }
}