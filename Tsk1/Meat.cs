namespace Task5
{
    // типы мяса (чтобы нельзя было написать ерунду)
    public enum MeatType { Pork, Beef, Chicken }


    public class Meat : Ingredient, IDiet
    {
        public MeatType Type { get; set; } 

        public Meat(string name, double weight, double calories, double price, MeatType type)
            : base(name, weight, calories, price) // данные в родителя
        {
            Type = type;
            // пересчитываем, так как это диетический продукт 
            Calories = RecalculateCalories();
            Price = RecalculatePrice();
        }

        // логика пересчета для мяса
        public double RecalculateCalories() => Calories * 0.90; // -10% калорий
        public double RecalculatePrice() => Price * 1.15;       // +15% цена

        public override string ToString()
        {
            return $"Мясо ({Type}): " + base.ToString();
        }
    }
}