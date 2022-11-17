namespace News.API.Contracts;

public class GetNewsResponse
{
    public GetNewsDto[] News {get; set;}
}

public class GetNewsDto
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Article { get; set; }
    public DateTime Date { get; set; }
}