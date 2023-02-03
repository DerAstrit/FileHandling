namespace FileHandling;

public class CreateFileWithArray
{
    // create a file and write an array of strings to the file.
    public void Create()
    {
        Console.WriteLine("Create an Array in a File \n\n" +
                          "Enter the directory path");
        var path = Console.ReadLine();

        Console.WriteLine("\nEnter the file name to be created");
        var filename = Console.ReadLine();

        var filepath = path + "\\" + filename + ".txt";

        
       

        Console.Write("\n\n Create a file and write an array of strings  :\n");
        Console.Write("---------------------------------------------------\n");


        if (File.Exists(filepath))
        {
            Console.WriteLine("File already exists");
        }
        else
        {
            Console.Write(" Input number of lines to write in the file  :");
            int n = Convert.ToInt32(Console.ReadLine());
            
            string[] ArrLines = new string[n];
            Console.Write(" Input {0} strings below :\n", n);
            
            for (int i = 0; i < n; i++)
            {
                Console.Write(" Input line {0} : ", i + 1);
                ArrLines[i] = Console.ReadLine();
            }

            File.WriteAllLines(filepath, ArrLines);

            using (var sr = File.OpenText(filepath))
            {
                var s = "";
                Console.Write("\n The content of the file is  :\n", n);
                Console.Write("----------------------------------\n");
                while ((s = sr.ReadLine()) != null) Console.WriteLine(" {0} ", s);

                Console.WriteLine();
            }
        }
    }
}