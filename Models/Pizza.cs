namespace la_mia_pizzeria_static.Models
{
   
    public class Pizza
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string? Descrizione { get; set; }

        public string? ImgPath { get; set; }

        public string Prezzo { get; set; }

        
    }

    public class listaPizze {

        public List<Pizza> pizzas { get; set; }

        public listaPizze() {

          pizzas = new List<Pizza>();
    }
    }
}
