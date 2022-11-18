using System.Text.Json;

namespace News.DataAccess;
public class NewsRepository
{
   
        private static string DirectoryName = "./news/";
        private static string BaseDirectory = AppDomain.CurrentDomain.BaseDirectory;

        public bool Add(NewsModel newNews)
        {
            Directory.CreateDirectory(DirectoryName);

            var json = JsonSerializer.Serialize(newNews, new JsonSerializerOptions { WriteIndented = true });

            var fileName = $"{Guid.NewGuid()}.json";
            var filePath = Path.Combine(BaseDirectory, DirectoryName, fileName);
            File.WriteAllText(filePath, json);

            return true;
        }

        public NewsModel[] Get()
        {
            var filesPath = Path.Combine(BaseDirectory, DirectoryName);
            var files = Directory.GetFiles(filesPath);

            var blockNews = new List<NewsModel>();

            foreach (var file in files)
            {
                var json = File.ReadAllText(file);
                var fileNews = JsonSerializer.Deserialize<NewsModel>(json);
                if (fileNews == null)
                {
                    throw new Exception("Error");
                }
                blockNews.Add(fileNews);
            }
            return blockNews.ToArray();
        }
}
