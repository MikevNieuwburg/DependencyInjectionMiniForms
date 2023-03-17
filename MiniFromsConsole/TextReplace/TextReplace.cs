using MiniFormsConsole.Core;

namespace MiniFormsConsole.TextReplace;

internal class TextReplace : IServiceModule
{
    private readonly LoggerService _logger;

    public TextReplace(LoggerService logger)
    {
        _logger = logger;
    }
    public bool Completed { get; private set; }
    public int Order { get; set; }

    public void Run()
    {
        var text = GetTextModule();
        var output = ReplaceText(text);
        Completed = true;
        _logger.Log($"{nameof(TextReplace)} ran to completion at: {DateTime.Now.ToString("HH:mm:ss")}");
    }

    private string ReplaceText(TextModule textModule)
    {
        int occurances = 0;
        var fileContent = File.ReadAllLines(textModule.Source).ToList();
        var output = new List<string>();
        foreach ( var line in fileContent) 
        {
            output.Add( line.Replace(textModule.From,textModule.To));
            if(line.Contains(textModule.From))
                occurances++;
        }
        File.WriteAllLines(textModule.Source, output);
        return $"{textModule.Source} changed a total of {occurances}";
    }

    private TextModule GetTextModule()
    {
        string _source = string.Empty;
        string _textToReplace = string.Empty;
        string _textToReplaceWith = string.Empty;

        Console.WriteLine("Enter file path here.");
        _source = Console.ReadLine();
        if (_source == "")
            while (File.Exists(_source) == false)
            {
                Console.WriteLine("Invalid file or not found.");
                Console.WriteLine("Give a valid file.");
                _source = Console.ReadLine();
            }

        Console.WriteLine("Enter the text you want to replace here.");
        _textToReplace = Console.ReadLine();

        Console.WriteLine("Enter the text you want to replace with here.");
        _textToReplaceWith = Console.ReadLine();


        return new TextModule(_source, _textToReplace, _textToReplaceWith);

    }
}
internal record TextModule(string Source, string From, string To);
