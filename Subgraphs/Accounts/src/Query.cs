public class Query
{
    public Account GetAccount() =>
        new Account
        {
            Id = 1,
            Name = "Ned Flanders"
        };
}

public class Account
{
    public int Id { get; set; }
    public string Name { get; set; }
}