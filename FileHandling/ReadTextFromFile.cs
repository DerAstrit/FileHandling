namespace FileHandling;

public class ReadTextFromFile
{
    public void Read()
    {
        Console.WriteLine("Read text from a file \n\n" +
                          "Enter the directory path");
        var path = Console.ReadLine();

        Console.WriteLine("\nEnter the file name to be read");
        var filename = Console.ReadLine();

        var filepath = path + "\\" + filename + ".txt";

        Console.WriteLine("-------------------------------------------------------");

        if (File.Exists(filepath))
        {
            var text = File.ReadAllText(filepath);
            Console.WriteLine(text);
        }
        else
        {
            Console.WriteLine("File does not exist");
        }
    }
}