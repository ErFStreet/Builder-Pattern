namespace Builder.Application;

internal static class Program
{
    internal static void Main()
    {
        new Thread(start: () =>
        {
            Thread.Sleep(millisecondsTimeout: 5000);

            var order = OrderBuilder.Initialize()
                .WithFirstName(firstName: "Erfan")
                .WithLastName(lastName: "Edalati")
                .WithEmail(email: "erfannstreet@gmail.com")
                .Build();

            Console.WriteLine(value: "Order Builded");

        }).Start();

        Console.WriteLine(value: "The Order is Building ! Please Wait .... \n");
    }
}
