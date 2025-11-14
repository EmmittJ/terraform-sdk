namespace EmmittJ.Terraform.Sdk.AppHost;

/// <summary>
/// Wrapper for file system operations to enable testing.
/// </summary>
public class FileSystemWrapper : IFileSystem
{
    /// <summary>
    /// Reads all text from a file asynchronously.
    /// </summary>
    public async Task<string> ReadAllTextAsync(string path, CancellationToken cancellationToken = default)
    {
        return await File.ReadAllTextAsync(path, cancellationToken);
    }

    /// <summary>
    /// Writes all text to a file asynchronously.
    /// </summary>
    public async Task WriteAllTextAsync(string path, string content, CancellationToken cancellationToken = default)
    {
        await File.WriteAllTextAsync(path, content, cancellationToken);
    }

    /// <summary>
    /// Creates a directory and all intermediate directories.
    /// </summary>
    public void CreateDirectory(string path)
    {
        Directory.CreateDirectory(path);
    }

    /// <summary>
    /// Determines whether a file exists.
    /// </summary>
    public bool FileExists(string path) => File.Exists(path);

    /// <summary>
    /// Determines whether a directory exists.
    /// </summary>
    public bool DirectoryExists(string path) => Directory.Exists(path);
}
