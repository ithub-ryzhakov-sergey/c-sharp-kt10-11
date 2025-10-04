using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace App.Tasks.Task3_Extensions;


public interface IDataRow
{
    public string GetFormattedString();
}
public class Employee : IDataRow
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Position { get; set; }
    public string GetFormattedString()
    {
        return $"ID: {Id}, Имя: {FullName}, Должность: {Position}";
    }
}
public class Product : IDataRow
{
    public string Sku { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public string GetFormattedString()
    {
        var currentCulture = Thread.CurrentThread.CurrentCulture;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        return $"Артикул: {Sku}, Название: {Name}, Цена: {Price}";
        Thread.CurrentThread.CurrentCulture = currentCulture;
    }
}
public static class CollectionExtensions
{
    public static void PrintToConsole<T>
        (this IEnumerable<T> collection) 
        where T : IDataRow
    {
        if (collection == null)
        {
            throw new ArgumentNullException();
        }
        else 
        {
            foreach (T item in collection)
            {
                Console.WriteLine(item.GetFormattedString());
            }
        }

    }
}