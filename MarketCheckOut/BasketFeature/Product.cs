using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MarketCheckOut.BasketFeature
{
    public class Product : INotifyPropertyChanged
    {
        private int quantity;

        public string Name { get; set; }

        public int Quantity
        {
            get => quantity;
            set
            {
                quantity = value;
                OnPropertyChanged(nameof(Quantity));
                OnPropertyChanged(nameof(TotalPrice));
            }
        }

        public decimal UnitPrice { get; set; }

        public decimal TotalPrice => Quantity * UnitPrice;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
