using System.Diagnostics.CodeAnalysis;

namespace Task2
{
    internal class Order
    {
        private List<Dish> _orderedDishes;

        public Order(List<Dish> order)
        {

        }

        public List<Dish> OrderedDishes
        {
            get { return _orderedDishes; }
            set { _orderedDishes = value; }
        }

        public string AddDish(Dish dish)
        {
            try
            {
                _orderedDishes.Add(dish);
                return $"Блюдо {dish.Name} добавлено";
            }
            catch
            {
                return "Ошибка добавления блюда";
            }
        }

        public double calculatePrice()
        { 
            double sum = 0;
            foreach (var dish in _orderedDishes)
            {
                sum += dish.Price;
            }
            return sum;
        }

        public string giveCheque() 
        {
            string result = string.Empty;
            foreach(var dish in _orderedDishes)
            {
                result += $"{dish.Name} стоимость = {dish.Price}{Environment.NewLine}";
            }
            return result + calculatePrice();
        }
    }
}
