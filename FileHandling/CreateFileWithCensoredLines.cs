namespace FileHandling;

public class CreateFileWithCensoredLines
{
    //create and write some line of text into a file which does not contain a given string in a line. Go to the editor
    // Test Data :
    // Input the string to ignore the line : fox
    //     Input number of lines to write in the file : 2
    // Input 2 strings below :
    // Input line 1 : the quick brown fox jumps
    //     Input line 2 : over the lazy dog.
    //     Expected Output :
    //
    // The line have ignored which contain the string 'fox'.                                                        
    // The content of the file is  :                                                                                
    // ----------------------------------                                                                            
    // over the lazy dog.    

    public void Create()
    {
        Console.WriteLine("Create an Array in a File and Censor lines \n\n" +
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
            Console.WriteLine("Input the string to ignore the line: ");
            string ignoreString = Console.ReadLine();
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
                    if (!line.Contains(ignoreString))
                    {
                        writer.WriteLine(line);
                    }
                }
            }
            
            
            Console.WriteLine("The line have ignored which contain the string '" + ignoreString + "'.");
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