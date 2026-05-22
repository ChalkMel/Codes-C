class Program
{
  static async Task Main(string[] args)
  {
    string[] urls =
    [
      "https://example.com",
      "https://www.blankwindows.com",
      "https://radio.garden",
      "https://longdogechallenge.com"
    ];
    
    List<Task<int>> tasks = new List<Task<int>>();

    foreach (string url in urls)
    {
      tasks.Add(GetCharsCount(url));
    }
    
    int[] results = await Task.WhenAll(tasks);
    
    Console.WriteLine("Результаты загрузки страниц:");
    for (int i = 0; i < urls.Length; i++)
    {
      Console.WriteLine($"{urls[i]}: {results[i]} видимых символов");
    }
  }

  static async Task<int> GetCharsCount(string url)
  {
      using (HttpClient client = new HttpClient())
      {
        string content = await client.GetStringAsync(url);
        
        int visibleCount = 0;
        foreach (char c in content)
        {
          if (!char.IsWhiteSpace(c))
          {
            visibleCount++;
          }
        }
                
        return visibleCount;
      }
  }
}