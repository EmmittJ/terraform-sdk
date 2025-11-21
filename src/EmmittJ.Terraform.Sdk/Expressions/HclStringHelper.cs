namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Helper methods for HCL string escaping and formatting.
/// </summary>
internal static class HclStringHelper
{
    /// <summary>
    /// Escapes special characters in a string for use in HCL string literals.
    /// </summary>
    /// <param name="value">The string to escape.</param>
    /// <returns>The escaped string suitable for use within HCL quotes.</returns>
    public static string EscapeString(string value)
    {
        return value
            .Replace("\\", "\\\\")
            .Replace("\"", "\\\"")
            .Replace("\n", "\\n")
            .Replace("\r", "\\r")
            .Replace("\t", "\\t");
    }

    /// <summary>
    /// Wraps HCL expression output in interpolation syntax: ${...}
    /// </summary>
    /// <param name="hcl">The HCL expression string.</param>
    /// <returns>The interpolation-wrapped string.</returns>
    public static string WrapInterpolation(string hcl)
    {
        return $"${{{hcl}}}";
    }
}
