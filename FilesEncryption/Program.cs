using System;

namespace FilesEncryption;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 3)
        {
            Console.WriteLine("Usage: dotnet run <encrypt(1)/decrypt(2)> <directory_path> <file_extension>");
            return;
        }

        string operation = args[0].ToLower();
        string directoryPath = args[1];
        string fileExtension = args[2];

        if (operation == "encrypt" || operation == "1")
        {
            MyCipher.EncryptFilesInDirectory(directoryPath, fileExtension);
        }
        else if (operation == "decrypt" || operation == "2")
        {
            MyCipher.DecryptFilesInDirectory(directoryPath, fileExtension);
        }
        else
        {
            Console.WriteLine("Invalid operation. Please specify 'encrypt' or 'decrypt'.");
        }
    }
}
