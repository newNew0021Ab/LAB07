namespace Task5
{
    public class Fish : Ingredient, IDiet
    {
        public bool IsSeaFish { get; set; } 

        public Fish(string name, double weight, double calories, double price, bool isSeaFish)
            : base(name, weight, calories, price)
        {
            IsSeaFish = isSeaFish;
            // Пересчет при создании 
            Calories = RecalculateCalories();
            Price = RecalculatePrice();
        }

        // рыба полезнее, снижаем калории сильнее
        public double RecalculateCalories() => Calories * 0.85; 
        public double RecalculatePrice() => Price * 1.10;

        public override string ToString()
        {
            string type = IsSeaFish ? "Морская" : "Речная";
            return $"Рыба ({type}): " + base.ToString();
        }
    }
}