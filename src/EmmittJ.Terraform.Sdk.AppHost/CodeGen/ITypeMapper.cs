namespace EmmittJ.Terraform.Sdk.AppHost;

/// <summary>
/// Maps Terraform schema types to C# types.
/// </summary>
public interface ITypeMapper
{
    /// <summary>
    /// Maps a Terraform type to a wrapped C# type (e.g., TerraformValue&lt;string&gt;).
    /// </summary>
    string MapToWrappedCSharpType(object? terraformType);

    /// <summary>
    /// Maps a Terraform type to a raw C# type (e.g., string).
    /// </summary>
    string MapToRawCSharpType(object? terraformType);

    /// <summary>
    /// Determines whether a C# type is a collection type.
    /// </summary>
    bool IsCollectionType(string csharpType);

    /// <summary>
    /// Determines whether a C# type is a value type.
    /// </summary>
    bool IsValueType(string csharpType);
}
