namespace FileHandling;

public class CreateFileWithAppendedText
{
    public void Create()
    {
        Console.WriteLine("Create an Array in a File and append lines \n\n" +
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
            Console.WriteLine("Input the string to append the line: ");
            string AppendString = Console.ReadLine();
            Console.WriteLine("Input number of lines to write in the file: ");
            int numLines = Convert.ToInt32(Console.ReadLine());
            
            string[] lines = new string[numLines];

            for (int i = 0; i < numLines; i++)
            {
                Console.WriteLine("Input line " + (i + 1) + ": ");
                lines[i] = Console.ReadLine();
            }
            
            using (StreamWriter writer = new StreamWriter(filepath))
            {
                foreach (string line in lines)
                {
                    if (line.Contains(AppendString))
                    {
                        writer.WriteLine(line);
                    }
                }
            }
            
            
            Console.WriteLine("The line have been appended which contain the string '" + AppendString + "'.");
            Console.WriteLine("The content of the file is:");
            Console.WriteLine("----------------------------------");
            string[] content = File.ReadAllLines(filepath);
            foreach (string line in content)
            {
                Console.WriteLine(line);
            } 
        }
    }
}
