using Vending_machine.Entities;

namespace Vending_machine.Utilities.InitDatabase;

public static class DataSet
{
    public static List<CoinType> CoinTypes = new List<CoinType>()
    {
        new()
        {
            Name = "Один рубль",
            Value = 1,
            Stock = 30
        },
        new()
        {
            Name = "Два рубля",
            Value = 2,
            Stock = 30
        },
        new()
        {
            Name = "Пять рублей",
            Value = 5,
            Stock = 20
        },
        new()
        {
            Name = "Десять рублей",
            Value = 10,
            Stock = 10
        }
    };

    public static List<Product> Products = new List<Product>()
    {
        new()
        {
            Name = "Добрый кола 0.5л",
            Cost = 67,
            Stock = 10,
            Image = ""
        },
        new()
        {
            Name = "Добрый кола 0.5л без сахара",
            Cost = 68,
            Stock = 10,
            Image = ""
        },
        new()
        {
            Name = "Добрый апельсин 0.5л",
            Cost = 69,
            Stock = 10,
            Image = ""
        },
        new()
        {
            Name = "Липтон зелёный чай 0.5л",
            Cost = 73,
            Stock = 10,
            Image = ""
        },
        new()
        {
            Name = "Липтон чёрный чай с лимоном 0.5л",
            Cost = 72,
            Stock = 10,
            Image = ""
        },
        new()
        {
            Name = "Сникрес",
            Cost = 56,
            Stock = 10,
            Image = ""
        },
        new()
        {
            Name = "Твикс",
            Cost = 52,
            Stock = 10,
            Image = ""
        },
        new()
        {
            Name = "Чипсы лейс сметана и зелень 50г",
            Cost = 83,
            Stock = 10,
            Image = ""
        },
        new()
        {
            Name = "Чипсы лейс лобстер 50г",
            Cost = 82,
            Stock = 10,
            Image = ""
        },
        new()
        {
            Name = "Кириешки",
            Cost = 22,
            Stock = 10,
            Image = ""
        },
        new()
        {
            Name = "Энергетик dirve 0.5л",
            Cost = 71,
            Stock = 10,
            Image = ""
        }
    };
}