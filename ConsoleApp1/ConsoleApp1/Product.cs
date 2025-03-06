namespace ConsoleApp1
{
    class Product
    {
        private string _name;
        private float _price;
        private int _quantity;
        private DateTime _lastChanged = DateTime.Now;
        public string LastChanged => _lastChanged.ToString();
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Empty value!");
                    return;
                }
                _name = value;
                _lastChanged = DateTime.Now;
            }
        }

        public float Price
        {
            get => _price;
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Invalid price");
                    return;
                }
                _price = value;
                _lastChanged = DateTime.Now;
            }
        }

        public int Quantity => _quantity;
        public float TotalValue => _price * _quantity;


        public Product(string name, float price, int quantity)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("Name is empty!");
            _name = name;

            if (price <= 0)
                throw new Exception("Invalid price!");
            _price = price;

            if (quantity < 0)
                throw new Exception("Invalid quantity!");
            _quantity = quantity;
            _lastChanged = DateTime.Now;
        }

        public void Restock(int amount)
        {
            if (amount <= 0)
                throw new Exception("Invalid amount");

            _quantity += amount;
            _lastChanged = DateTime.Now;
        }
        public void Sell(int amount)
        {
            if (amount <= 0)
                throw new Exception("Invalid amount");

            if (amount > _quantity)
                throw new Exception("Not enough product");
            _quantity -= amount;
            _lastChanged = DateTime.Now;
        }

        public string GetInfo()
        {
            return "Товар: " + _name + ", Ціна: " + _price + " грн, Кількість: " + _quantity + ", Загальна вартість: " + TotalValue + " грн, Остання зміна: " + LastChanged;
        }
    }

}
