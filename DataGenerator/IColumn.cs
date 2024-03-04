namespace DataGenerator
{
    public interface IColumn
    {
        string GenerateValue();
        string Name { get; }
    }
}