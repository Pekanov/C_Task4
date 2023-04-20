using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Класс 1-го уровня
class MobilePhone
{
    public string Brand { get; set; }
    public decimal Price { get; set; }
    public int Memory { get; set; }

    public MobilePhone(string brand, decimal price, int memory)
    {
        Brand = brand;
        Price = price;
        Memory = memory;
    }

    public virtual decimal GetQuality()
    {
        return Memory / Price;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine("Mobile Phone:");
        Console.WriteLine("Brand: {0}", Brand);
        Console.WriteLine("Price: {0}", Price);
        Console.WriteLine("Memory: {0}", Memory);
        Console.WriteLine("Quality: {0}", GetQuality());
    }
}

// Класс 2-го уровня (потомок)
class DualSimPhone : MobilePhone
{
    public int SimCards { get; set; }

    public DualSimPhone(string brand, decimal price, int memory, int simCards)
        : base(brand, price, memory)
    {
        SimCards = simCards;
    }

    public override decimal GetQuality()
    {
        return base.GetQuality() * SimCards;
    }

    public override void PrintInfo()
    {
        Console.WriteLine("Dual SIM Mobile Phone:");
        Console.WriteLine("Brand: {0}", Brand);
        Console.WriteLine("Price: {0}", Price);
        Console.WriteLine("Memory: {0}", Memory);
        Console.WriteLine("SIM cards: {0}", SimCards);
        Console.WriteLine("Quality: {0}", GetQuality());
        Console.WriteLine("QualityP: {0}", GetQuality());
    }
}

// Пример использования классов
class Program
{
    static void Main()
    {
        MobilePhone phone1 = new MobilePhone("Nokia", 100, 256);
        phone1.PrintInfo();
        Console.WriteLine();

        DualSimPhone phone2 = new DualSimPhone("Samsung", 200, 512, 2);
        phone2.PrintInfo();
        Console.WriteLine();

        Console.ReadKey();
    }
}