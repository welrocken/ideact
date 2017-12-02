namespace Ideact.Domain
{
    public interface IIdea
    {
        long Id { get; set; }
        IProblem Problem { get; set; }
        ISolution Solution { get; set; }
    }
}