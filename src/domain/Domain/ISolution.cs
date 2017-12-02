namespace Ideact.Domain
{
    public interface ISolution
    {
        long Id { get; set; }
        string Title { get; set; }
        string Description { get; set; }
    }
}