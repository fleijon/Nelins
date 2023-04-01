namespace Nelins.Management.Services;
public class InMemoryData : IData
{
    private readonly List<Receipt> _receipts = new();

    public Task Store(Receipt receipt)
    {
        _receipts.Add(receipt);

        return Task.CompletedTask;
    }
}
