namespace Task5
{
    public class Dish
    {
        public string Name { get; set; }
        // Список ингредиентов 
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        public Dish(string name)
        {
            Name = name;
        }

        // добавление
        public void AddToDish(Ingredient item)
        {
            
            if (item is Meat && Ingredients.Any(i => i is Fish))
            {
                Console.WriteLine($"Ошибка: Нельзя добавить мясо ({item.Name}), если есть рыба!");
                return;
            }
            if (item is Fish && Ingredients.Any(i => i is Meat))
            {
                Console.WriteLine($"Ошибка: Нельзя добавить рыбу ({item.Name}), если есть мясо!");
                return;
            }

            
            if (item is Sauce newSauce)
            {
                
                var existingSauce = Ingredients.OfType<Sauce>().FirstOrDefault();
                if (existingSauce != null && existingSauce.Type != newSauce.Type)
                {
                    Console.WriteLine($"Ошибка: Нельзя смешивать разные соусы ({existingSauce.Type} и {newSauce.Type})!");
                    return;
                }
            }

            Ingredients.Add(item);
            Console.WriteLine($"Добавлено: {item.Name}");
        }

       
        public double TotalCalories()
        {
            double sum = 0;
            foreach (var i in Ingredients) sum += i.Calories;
            return sum;
        }

       
        public double TotalCost()
        {
            double sum = 0;
            foreach (var i in Ingredients) sum += i.Price;
            return sum;
        }

        public override string ToString()
        {
            string info = $"--- Блюдо: {Name} ---\n";
            foreach (var i in Ingredients) info += i.ToString() + "\n";
            info += $"Всего: {TotalCost()} руб, {TotalCalories()} ккал";
            return info;
        }

        
        public static bool operator ==(Dish d1, Dish d2)
        {
           
            if (d1.TotalCost() == d2.TotalCost())
                return d1.TotalCalories() == d2.TotalCalories(); 
            
            return false;
        }

        public static bool operator !=(Dish d1, Dish d2) => !(d1 == d2);

        //  методы, обязательные при перегрузке ==
        public override bool Equals(object obj) => obj is Dish d && this == d;
        public override int GetHashCode() => TotalCost().GetHashCode();
    }
}