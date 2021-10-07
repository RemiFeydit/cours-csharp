using System;

namespace pizza.Repositories
{
    public class Pizza
    {
        public int Id { get; set; }
        public string PizzaType { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }
        public Pizza(int id, string pizzaType, string ingredients, double price)
        {
            this.Id = id;
            this.PizzaType = pizzaType;
            this.Ingredients = ingredients;
            this.Price = price;
        }
    }
}
