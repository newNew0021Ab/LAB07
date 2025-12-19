using System.Text;

namespace Task5
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            Dish meatDish = new Dish("Стейк с гарниром");
            Dish fishDish = new Dish("Уха");

        
            Meat beef = new Meat("Говядина", 300, 600, 500, MeatType.Beef);
            Fish salmon = new Fish("Лосось", 200, 400, 700, true);
            Vegetable potato = new Vegetable("Картошка", 100, 100, 30, "Желтый");
            Sauce ketchup = new Sauce("Кетчуп", 50, 40, 50, SauceType.Ketchup);
            Sauce mayo = new Sauce("Майонез", 50, 150, 40, SauceType.Mayonnaise);

            // Заполняем мясное блюдо
            Console.WriteLine("--- Готовим мясное ---");
            meatDish.AddToDish(beef);
            meatDish.AddToDish(potato);
            meatDish.AddToDish(ketchup);
            meatDish.AddToDish(mayo);   // ошибка (смешивание соусов) 
            meatDish.AddToDish(salmon); // ошибка (мясо с рыбой)

            Console.WriteLine();

            // Заполняем рыбное
            Console.WriteLine("--- Готовим рыбное ---");
            fishDish.AddToDish(salmon);
            fishDish.AddToDish(potato);

            Console.WriteLine();

    
            Console.WriteLine(meatDish.ToString());
            Console.WriteLine();
            Console.WriteLine(fishDish.ToString());

            // сравнение 
            Console.WriteLine("\nСравнение блюд:");
            if (meatDish == fishDish) Console.WriteLine("Блюда одинаковы");
            else Console.WriteLine("Блюда разные");

            Console.ReadKey();
        }
    }
}