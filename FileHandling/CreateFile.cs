namespace FileHandling;

public class CreateFile
{
    public void Create()
    {
        Console.WriteLine("Create a file in the disk \n\n" +
                          "Enter the directory path");
        var path = Console.ReadLine();

        Console.WriteLine("\nEnter the file name to be created");
        var filename = Console.ReadLine();

        var filepath = path + "\\" + filename;

        Console.WriteLine("-------------------------------------------------------");

        if (File.Exists(filepath))
        {
            Console.WriteLine("File already exists");
        }
        else
        {
            File.Create(filepath);
            Console.WriteLine($"The File {filename} created successfully");
        }
    }
}