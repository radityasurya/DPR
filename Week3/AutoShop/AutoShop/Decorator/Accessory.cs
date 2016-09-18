using AutoShop.Interfaces;

namespace AutoShop.Decorator
{
    public interface Accessory : Car
    {
        Car carObject { get; set; }
        decimal GetPrice();

        string GetName();
    }
}
