public class Product {
    private string _title = "Без названия";

    public string Title {
        get {
            return _title;
        }

        private set {
            if (string.IsNullOrWhiteSpace(value)) {
                _title = "Без названия";
                return;
            }

            _title = value.Trim();
        }
    }

    public int Price { get; private set; }
    public int Quantity { get; private set; }

    public Product(string title, int price, int quantity) {
        Title = title;

        Price = price;

        if (Price < 1) {
            Price = 1;
        }

        Quantity = quantity;

        if (Quantity < 0) {
            Quantity = 0;
        }
    }

    public void Restock(int amount) {
        if (amount <= 0) {
            return;
        }

        if (amount > 2147483647 - Quantity) {
            return;
        }

        Quantity += amount;
    }

    public bool Sell(int amount) {
        if (amount <= 0) {
            return false;
        }

        if (amount > Quantity) {
            return false;
        }

        Quantity -= amount;
        return true;
    }

    public bool ChangePrice(int newPrice) {
        if (newPrice < 1) {
            return false;
        }

        Price = newPrice;
        return true;
    }

    public string GetInfo() {
        return $">>> {Title} <<<\n" +
               $"Цена: {Price}\n" +
               $"Количество: {Quantity}";
    }
}
