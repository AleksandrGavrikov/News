namespace News.API.Models;
public class News
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Article { get; set; }
    public DateTime Date { get; set; }
}