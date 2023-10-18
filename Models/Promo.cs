namespace AndresGuaman_EjercicioCF.Models
{
    public class Promo
    {
        public int PromoID { get; set; }
        public string? PromoName { get; set; }
        public string? PromoDescription { get; set; }
        public int ID { get; set; }
        public Burger? Burger { get; set; }
    
    }
}
