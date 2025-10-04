using System.Data.Common;
using System.Runtime.InteropServices;
using System.Globalization;

namespace App.Tasks.Task3_Extensions;

public interface IDataRow
{
    string GetFormattedString();
}

public class Employee : IDataRow
{
    public int Id;
    public string FullName;
    public string Position;
    public string GetFormattedString()
    {
        return $"ID: {Id}, Имя: {FullName}, Должность: {Position}";
    }
}
public class Product : IDataRow
{
    public string Sku;
    public string Name;
    public decimal Price;
    public string GetFormattedString()
    {
        return $"Артикул: {Sku}, Название: {Name}, Цена: {Price.ToString(CultureInfo.InvariantCulture)}";
    }
}
public static class CollectionExtensions {
    public static void PrintToConsole<T>(this IEnumerable<T> collection) where T : IDataRow {
        if (collection == null)
        {
            throw new ArgumentNullException();
        }
        foreach (var item in collection)
        {
            System.Console.WriteLine(item.GetFormattedString());
        }
    }
}