namespace CSharp11;

#if NET7_0_OR_GREATER
public class Person
{
    public required int Id { get; init; }
    public required string FirstName { get; set; }
    public string? LastName { get; init; }

}

public record Pet(string Name)
{
    public required string Nickname { get; init; }
    public string? LastName { get; init; }
}
#endif
