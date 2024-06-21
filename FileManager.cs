using System;
using System.IO;
using System.Text;

namespace FilesEnc;

public static class MyCipher
{
    private const int ShiftValue = 96; // Example shift value, adjust as needed

    public static void EncryptFilesInDirectory(string directoryPath, string fileExtension = "*.*")
    {
        if (!Directory.Exists(directoryPath))
        {
            Console.WriteLine("Directory does not exist.");
            return;
        }

        foreach (string file in Directory.GetFiles(directoryPath, $"*.{fileExtension}", SearchOption.AllDirectories))
        {
            try
            {
                byte[] contentBytes = File.ReadAllBytes(file);
                byte[] encryptedContent = EncryptByteArray(contentBytes);
                File.WriteAllBytes(file, encryptedContent);
                Console.WriteLine($"File '{file}' encrypted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to encrypt file '{file}'. Error: {ex.Message}");
            }
        }
    }

    public static void DecryptFilesInDirectory(string directoryPath, string fileExtension = "*.*")
    {
        if (!Directory.Exists(directoryPath))
        {
            Console.WriteLine("Directory does not exist.");
            return;
        }

        foreach (string file in Directory.GetFiles(directoryPath, $"*.{fileExtension}", SearchOption.AllDirectories))
        {
            try
            {
                byte[] encryptedBytes = File.ReadAllBytes(file);
                byte[] decryptedBytes = DecryptByteArray(encryptedBytes);
                File.WriteAllBytes(file, decryptedBytes);
                Console.WriteLine($"File '{file}' decrypted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to decrypt file '{file}'. Error: {ex.Message}");
            }
        }
    }

    private static byte[] EncryptByteArray(byte[] data)
    {
        byte[] encryptedData = new byte[data.Length];

        for (int i = 0; i < data.Length; i++)
        {
            encryptedData[i] = (byte)(data[i] + ShiftValue);
        }

        return encryptedData;
    }

    private static byte[] DecryptByteArray(byte[] encryptedData)
    {
        byte[] decryptedData = new byte[encryptedData.Length];

        for (int i = 0; i < encryptedData.Length; i++)
        {
            decryptedData[i] = (byte)(encryptedData[i] - ShiftValue);
        }

        return decryptedData;
    }
}
