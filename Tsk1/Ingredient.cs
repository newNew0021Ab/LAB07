using System;

namespace Task5
{
    
    public class Ingredient
    {

        public string Name { get; set; }      
        public double Weight { get; set; }   
        public double Calories { get; set; }  
        public double Price { get; set; }    

        // Конструктор
        public Ingredient(string name, double weight, double calories, double price)
        {
            Name = name;
            Weight = weight;
            Calories = calories;
            Price = price;
        }

        // Переопределение метода ToString
        public override string ToString()
        {
            return $"{Name} (Вес: {Weight}г, Калории: {Calories}, Цена: {Price}р)";
        }
    }
}