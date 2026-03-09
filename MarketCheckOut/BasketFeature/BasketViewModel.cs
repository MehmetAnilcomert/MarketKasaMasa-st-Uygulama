using MarketCheckOut.BasketFeature;
using System.ComponentModel;
using System.Linq;

public class BasketViewModel : INotifyPropertyChanged
{
    public BindingList<Product> Products { get; private set; } = new BindingList<Product>();

    private decimal _total;
    public decimal Total
    {
        get => _total;
        private set
        {
            if (_total != value)
            {
                _total = value;
                OnPropertyChanged(nameof(Total));
            }
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged(string propName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }

    public void AddProduct(string name, decimal price, int qty)
    {
        var existing = Products.FirstOrDefault(p => p.Name == name);

        if (existing != null)
        {
            existing.Quantity += qty;
        }
        else
        {
            Products.Add(new Product
            {
                Name = name,
                UnitPrice = price,
                Quantity = qty
            });
        }

        OnPropertyChanged(nameof(Total));
        UpdateTotal();
    }

    public void RemoveProduct(Product product)
    {
        if (Products.Contains(product))
        {
            Products.Remove(product);
            UpdateTotal();
        }
    }

    private void UpdateTotal()
    {
        Total = Products.Sum(p => p.TotalPrice);
    }
}