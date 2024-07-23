public class Query
{
    public Review GetReview() =>
        new Review
        {
            Id = 1,
            Name = "Ned Flanders"
        };
}

public class Review
{
    public int Id { get; set; }
    public string Name { get; set; }
}