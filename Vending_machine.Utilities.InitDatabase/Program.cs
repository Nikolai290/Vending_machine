// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.Configuration;
using Vending_machine.Domain.Implementation;
using Vending_machine.Utilities.InitDatabase;

Console.WriteLine("Начата инициализация базы данных.");

var builder = new ConfigurationBuilder()
    .AddJsonFile($"appsettings.json", false, false);
var config = builder.Build();
var connectionString = config.GetConnectionString("PostgreSql");
Console.WriteLine("Прочтены настройки appsettings.");

var dbContext = new PostgresContext(connectionString);
Console.WriteLine("Инициализирован экземпляр dbContext.");

await dbContext.CoinTypes.AddRangeAsync(DataSet.CoinTypes);
Console.WriteLine("Заполнена таблица CoinTypes.");

await dbContext.Products.AddRangeAsync(DataSet.Products);
Console.WriteLine("Заполнена таблица Products.");

await dbContext.SaveChangesAsync();
Console.WriteLine("Инициализация завершена.");



