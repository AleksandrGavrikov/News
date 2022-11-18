namespace News.API.Contracts;

public class CreateNewsRequest
{
    public string? Title { get; set; }
    public string? Article { get; set; }
}