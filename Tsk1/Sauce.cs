namespace Task5
{
    public enum SauceType { Ketchup, Mayonnaise, Mustard }

    public class Sauce : Ingredient, IDiet
    {
        public SauceType Type { get; set; }

        public Sauce(string name, double weight, double calories, double price, SauceType type)
            : base(name, weight, calories, price)
        {
            Type = type;
            Calories = RecalculateCalories();
            Price = RecalculatePrice();
        }

        public double RecalculateCalories() => Calories; 
        public double RecalculatePrice() => Price * 1.05; // дороже

        public override string ToString()
        {
            return $"Соус ({Type}): " + base.ToString();
        }
    }
}