namespace Nelins.Management.Services;

public record Receipt(long UserId, string Utf8Content, IReadOnlyList<Product> ParsedContent, MetaData MetaData, byte Image);

public record Product(string Name, long Price, int Amount);

public record struct MetaData(string Store);

public interface IData
{
    Task Store(Receipt receipt);
}
