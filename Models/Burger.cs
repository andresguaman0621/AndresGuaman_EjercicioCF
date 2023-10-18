using System.ComponentModel.DataAnnotations;

namespace AndresGuaman_EjercicioCF.Models
{
    public class Burger
    {
 
        public int ID { get; set; }
        [Required]
        public string? Name { get; set; }
        public bool WithCheese { get; set; }
        [Range(0.01, 999.99)]
        public decimal Price { get; set; }
        public List<Promo>? Promo { get; set; } 
        
        
        //una hamburguesa puede estar en diferentes promociones. Por ello se usa List
    }
}
