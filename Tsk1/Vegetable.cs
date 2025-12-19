namespace Task5
{
    // овощи наследуют Ingredient, но не реализуют IDiet
    public class Vegetable : Ingredient
    {
        public string Color { get; set; } 

        public Vegetable(string name, double weight, double calories, double price, string color)
            : base(name, weight, calories, price)
        {
            Color = color;
            // цену и калории НЕ меняем
        }

        public override string ToString()
        {
            return $"Овощ ({Color}): " + base.ToString();
        }
    }
}