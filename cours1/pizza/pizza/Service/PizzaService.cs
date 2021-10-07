using pizza.Domain;
using pizza.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace pizza.Service
{
    public static class PizzaService
    {
        public static IEnumerable<Pizza> GetAll()
        {
            IEnumerable<Pizza> query = from n in PizzaRepository.GetPizzas()
                                       select new Pizza(n.Id, n.PizzaType, n.Ingredients,n.Price.ConvertToEur());
            return query;
        }

        public static double ConvertToEur(this double usd)
        {
            if (usd > 0)
            {
                return usd * 0.85;
            }
            return usd;
        }

        public static IEnumerable<Pizza> GetPizzaType(string type)
        {
            if (string.IsNullOrEmpty(type))
            {
                return GetAll();
            }
            IEnumerable<Pizza> query = from n in PizzaRepository.GetPizzas()
                                       where n.PizzaType == type
                                       select new Pizza(n.Id, n.PizzaType, n.Ingredients, n.Price.ConvertToEur());
            if (!query.Any())
            {
                return GetAll();
            }
            return query;
        }
    }
}
