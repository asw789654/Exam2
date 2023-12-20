namespace Task2
{
    internal class Appetizer : Dish
    {
        protected int _calorieValue;

        public Appetizer(string name, double price, int calorieValue = 100) : base(name, price)
        {
            this._calorieValue = calorieValue;
        }

        public int CalorieValue
        {
            get { return _calorieValue; }
            set
            {
                if (_calorieValue > 0)
                {
                    _calorieValue = value;
                }
                else
                {
                    _calorieValue = 100;
                }
            }
        }
    }
}
