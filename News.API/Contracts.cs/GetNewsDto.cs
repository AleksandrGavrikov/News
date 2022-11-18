namespace News.API.Contracts;

public class GetNewsDto
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Article { get; set; }
    public DateTimeOffset Date { get; set; }
}