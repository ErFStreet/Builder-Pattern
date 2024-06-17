namespace Builder.Domain.Builders;

public class OrderBuilder
{
    private string _firstName = default!;

    private string _lastName = default!;

    private string _email = default!;


    //******* Methods *******\\

    public static OrderBuilder Initialize()
    {
        return new OrderBuilder();
    }

    public OrderBuilder WithFirstName(string firstName)
    {
        _firstName = firstName;

        return this;
    }

    public OrderBuilder WithLastName(string lastName)
    {
        _lastName = lastName;

        return this;
    }

    public OrderBuilder WithEmail(string email)
    {
        _email = email;

        return this;
    }

    public Order Build()
    {
        return new Order(firstName: _firstName,
            lastName: _lastName,
            email: _email);
    }
}
