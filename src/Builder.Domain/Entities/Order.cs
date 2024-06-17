namespace Builder.Domain.Entities;

public class Order : object
{
    public Order(string firstName, string lastName, string email) : base()
    {
        FirstName = firstName;

        LastName = lastName;

        Email = email;
    }

    public int Id { get; init; }

    public string FirstName { get; init; } = default!;

    public string LastName { get; init; } = default!;

    public string Email { get; init; } = default!;
}
