# Files Encryption Utility

This C# console application provides a simple file encryption and decryption utility using a basic byte-shifting cipher.

## Features

- **Encrypt Files:** Encrypts all files in a specified directory (including subdirectories) with a chosen file extension.
- **Decrypt Files:** Decrypts previously encrypted files back to their original state.

## Usage

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) installed on your machine.

### How to Use

1. Clone the repository to your local machine:

   ```bash
   git clone https://github.com/your-username/your-repository.git
   cd your-repository
   ```

2. Open a terminal or command prompt and navigate to the project directory.

3. Compile the project:

   ```bash
   dotnet build
   ```

4. Run the application with the following command-line arguments:

   ```bash
   dotnet run <encrypt/decrypt> <directory_path> <file_extension>
   ```

   - `<encrypt/decrypt>`: Specify `encrypt` or `decrypt` to choose the operation.
   - `<directory_path>`: Path to the directory containing files to encrypt/decrypt.
   - `<file_extension>`: File extension of the files to process (e.g., `txt`, `pdf`, `*` for all files).

   Example:
   ```bash
   dotnet run encrypt /path/to/your/directory txt
   ```

5. Follow the on-screen instructions and check the console output for status updates.

## Example

Encrypt all `.txt` files in `/path/to/your/directory`:

```bash
dotnet run encrypt /path/to/your/directory txt
```

Decrypt all previously encrypted files:

```bash
dotnet run decrypt /path/to/your/directory txt
```


## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
