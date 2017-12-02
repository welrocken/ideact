namespace Ideact.Domain
{
    public interface IProblem
    {
        long Id { get; set; }
        string Title { get; set; }
        string Description { get; set; }
    }
}