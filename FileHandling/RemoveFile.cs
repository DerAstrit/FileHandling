namespace FileHandling;

public class RemoveFile
{
    public void Remove()
    {
        // remove a selected file from the directory

        Console.WriteLine("Remove a file from the disk \n\n" +
                          "Enter the directory path");
        var path = Console.ReadLine();

        Console.WriteLine("\nEnter the file name to be removed");
        var filename = Console.ReadLine();

        var filepath = path + "\\" + filename;

        Console.WriteLine("-------------------------------------------------------");

        if (File.Exists(filepath))
        {
            File.Delete(filepath);
            Console.WriteLine($"The File {filename} deleted successfully");
        }
        else
        {
            Console.WriteLine("File does not exist");
        }
    }
}
