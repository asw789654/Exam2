namespace Task2
{
    internal class Dish
    {
        protected string _name;
        protected double _price;

        public Dish(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Price
        {
            get { return _price; }
            set 
            {
                if (_price > 0)
                {
                    _price = value;
                }
                else
                {
                    _price = 1;
                }
            }
        }
    }
}
