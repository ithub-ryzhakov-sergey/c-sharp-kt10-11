namespace App.Tasks.Task3_Extensions;
public interface IDataRow
{
    string GetFormattedString();
}

public class Employee : IDataRow
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;

    public string GetFormattedString()
    {
        return $"ID: {Id}, ���: {FullName}, ���������: {Position}";
    }
}

public class Product : IDataRow
{
    public string Sku { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }

    public string GetFormattedString()
    {
        return $"�������: {Sku}, ��������: {Name}, ����: {Price:F2}";
    }
}

// ����������� ����� � �������� ����������
public static class CollectionExtensions
{
    public static void PrintToConsole<T>(this IEnumerable<T> collection) where T : IDataRow
    {
        if (collection == null)
            throw new ArgumentNullException(nameof(collection));

        foreach (var item in collection)
        {
            Console.WriteLine(item.GetFormattedString());
        }
    }
}