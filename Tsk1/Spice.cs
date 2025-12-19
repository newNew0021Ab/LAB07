namespace Task5
{
    public class Spice : Ingredient
    {
        public bool IsSpicy { get; set; } 

        public Spice(string name, double weight, double calories, double price, bool isSpicy)
            : base(name, weight, calories, price)
        {
            IsSpicy = isSpicy;
        }
        
        public override string ToString()
        {
            string spicy = IsSpicy ? "Острая" : "Не острая";
            return $"Специя ({spicy}): " + base.ToString();
        }
    }
}