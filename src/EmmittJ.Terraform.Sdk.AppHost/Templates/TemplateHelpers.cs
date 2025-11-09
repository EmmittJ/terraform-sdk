using EmmittJ.Terraform.Sdk.AppHost.Models;

namespace EmmittJ.Terraform.Sdk.AppHost.Templates;

public static class TemplateHelpers
{
    public static string EscapeXmlDoc(string? text)
    {
        if (string.IsNullOrEmpty(text))
            return string.Empty;

        // Only escape XML special characters, not the whole string
        // These appear in XML doc comments, not in code
        return text
            .Replace("&", "&amp;")
            .Replace("<", "&lt;")
            .Replace(">", "&gt;")
            .Replace("\"", "&quot;")
            .Replace("\n", "\n    /// ");
    }

    public static string GetPropertyWrapper(PropertyModel property)
    {
        // Remove nullable from the type for the wrapper
        // This goes in actual C# code, so NO XML escaping
        var baseType = property.CSharpType.TrimEnd('?');

        // Handle Dictionary types specially
        if (baseType.StartsWith("Dictionary<"))
        {
            var types = ExtractDictionaryTypes(baseType);
            var typeParts = types.Split(new[] { ", " }, StringSplitOptions.None);
            if (typeParts.Length == 2)
            {
                // TerraformMapProperty<TValue> - always string keys
                return $"TerraformMapProperty<{typeParts[1]}>";
            }
            return $"TerraformMapProperty<object>";
        }

        return $"TerraformProperty<{baseType}>";
    }
    private static string ExtractDictionaryTypes(string dictionaryType)
    {
        // Extract "TKey, TValue" from "Dictionary<TKey, TValue>"
        var start = dictionaryType.IndexOf('<');
        var end = dictionaryType.LastIndexOf('>');
        if (start >= 0 && end > start)
        {
            return dictionaryType.Substring(start + 1, end - start - 1);
        }
        return "string, object"; // fallback
    }

    public static string GetSetterValue(PropertyModel property)
    {
        // This goes in actual C# code, so NO XML escaping
        var baseType = property.CSharpType.TrimEnd('?');

        // Handle Dictionary types specially
        if (baseType.StartsWith("Dictionary<"))
        {
            var types = ExtractDictionaryTypes(baseType);
            var typeParts = types.Split(new[] { ", " }, StringSplitOptions.None);
            if (typeParts.Length == 2)
            {
                // TerraformMapProperty has implicit conversion from Dictionary<string, TValue>
                return $"value == null ? null : new TerraformMapProperty<{typeParts[1]}>(value)";
            }
            return $"value == null ? null : new TerraformMapProperty<object>(value)";
        }

        if (property.IsCollection)
        {
            return $"value == null ? null : new TerraformLiteralProperty<{baseType}>(value)";
        }

        // For nullable value types (bool?, double?, int?, etc.)
        if (property.IsValueType && property.CSharpType.EndsWith("?"))
        {
            return $"value == null ? null : new TerraformLiteralProperty<{baseType}>(value.Value)";
        }

        // For reference types (string?, List<>, etc.)
        return $"value == null ? null : new TerraformLiteralProperty<{baseType}>(value)";
    }

    public static object PreparePropertyForTemplate(PropertyModel property)
    {
        return new
        {
            property.Name,
            property.TerraformName,
            property.CSharpType,
            Description = EscapeXmlDoc(property.Description), // Only escape for XML doc comments
            property.IsRequired,
            property.IsOptional,
            property.IsComputed,
            property.IsSensitive,
            property.IsDeprecated,
            PropertyWrapper = GetPropertyWrapper(property), // NOT escaped - goes in code
            SetterValue = GetSetterValue(property) // NOT escaped - goes in code
        };
    }
}
