namespace EmmittJ.Terraform.Sdk.AppHost;

/// <summary>
/// Provides naming convention conversions for code generation.
/// </summary>
public static class NamingConventions
{
    /// <summary>
    /// Converts a Terraform type (e.g., "aws_instance") to a C# class name (e.g., "AwsInstance").
    /// </summary>
    public static string ToClassName(string terraformType)
    {
        // Convert aws_instance to AwsInstance
        return string.Join("", terraformType.Split('_')
            .Select(part => char.ToUpper(part[0]) + part[1..]));
    }

    /// <summary>
    /// Converts a snake_case name to PascalCase.
    /// </summary>
    public static string ToPascalCase(string name)
    {
        // Convert snake_case to PascalCase
        return string.Join("", name.Split('_')
            .Select(part => char.ToUpper(part[0]) + part[1..]));
    }

    /// <summary>
    /// Converts a snake_case name to camelCase.
    /// </summary>
    public static string ToCamelCase(string name)
    {
        // Convert snake_case to camelCase
        var parts = name.Split('_');
        if (parts.Length == 0)
        {
            return name;
        }

        var result = parts[0].ToLowerInvariant();
        for (int i = 1; i < parts.Length; i++)
        {
            result += char.ToUpper(parts[i][0]) + parts[i][1..];
        }
        return result;
    }

    /// <summary>
    /// Converts a name to a valid property name.
    /// </summary>
    public static string ToPropertyName(string attributeName)
    {
        return ToPascalCase(attributeName);
    }
}
