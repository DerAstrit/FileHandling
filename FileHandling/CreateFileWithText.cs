namespace FileHandling;

public class CreateFileWithText
{
    //create a file and add some text
    public void Create()
    {
        Console.WriteLine("Create a file in the disk \n\n" +
                          "Enter the directory path");
        var path = Console.ReadLine();

        Console.WriteLine("\nEnter the file name to be created");
        var filename = Console.ReadLine();

        var filepath = path + "\\" + filename + ".txt";

        Console.WriteLine("-------------------------------------------------------");

        if (File.Exists(filepath))
        {
            Console.WriteLine("File already exists");
        }
        else
        {
            Console.WriteLine("Enter the text to be added to the file");
            var text = Console.ReadLine();
            File.WriteAllText(filepath, text);
            Console.WriteLine($"The File {filename} created successfully");
        }
    }
}