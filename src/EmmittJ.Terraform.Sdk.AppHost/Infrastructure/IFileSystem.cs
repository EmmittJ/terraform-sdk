namespace EmmittJ.Terraform.Sdk.AppHost;

/// <summary>
/// Abstraction for file system operations to enable testing.
/// </summary>
public interface IFileSystem
{
    /// <summary>
    /// Reads all text from a file asynchronously.
    /// </summary>
    Task<string> ReadAllTextAsync(string path, CancellationToken cancellationToken = default);

    /// <summary>
    /// Writes all text to a file asynchronously.
    /// </summary>
    Task WriteAllTextAsync(string path, string content, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a directory and all intermediate directories.
    /// </summary>
    void CreateDirectory(string path);

    /// <summary>
    /// Determines whether a file exists.
    /// </summary>
    bool FileExists(string path);

    /// <summary>
    /// Determines whether a directory exists.
    /// </summary>
    bool DirectoryExists(string path);
}
