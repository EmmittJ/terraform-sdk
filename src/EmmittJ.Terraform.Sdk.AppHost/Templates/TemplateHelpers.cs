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
        // The CSharpType already contains the full type (e.g., TerraformProperty<string>, List<TerraformProperty<int>>)
        // Just return it directly
        return property.CSharpType;
    }

    public static string GetSetterValue(PropertyModel property)
    {
        // Since we're using native collections, just pass the value through
        // The implicit conversions on TerraformProperty will handle it
        return "value";
    }

    public static object PreparePropertyForTemplate(PropertyModel property)
    {
        // Determine if we should use 'required' keyword:
        // - Property is marked Required in schema
        // - Property is not a collection (collections can't be required in C#)
        // - Property is not a value type with nullable wrapper
        bool useRequiredKeyword = property.IsRequired && !property.IsCollection;

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
            SetterValue = GetSetterValue(property), // NOT escaped - goes in code
            UseRequiredKeyword = useRequiredKeyword,
            UseNullable = !useRequiredKeyword // If not required, make it nullable
        };
    }

    public static object PrepareBlockTypeForTemplate(BlockTypeModel block)
    {
        // Generate validation attributes for block collections
        var validationAttributes = new List<string>();

        if (block.MinItems.HasValue && block.NestingMode != "single")
        {
            validationAttributes.Add($"[System.ComponentModel.DataAnnotations.MinLength({block.MinItems.Value}, ErrorMessage = \"At least {block.MinItems.Value} {block.Name} block(s) required\")]");
        }

        if (block.MaxItems.HasValue && block.NestingMode != "single")
        {
            validationAttributes.Add($"[System.ComponentModel.DataAnnotations.MaxLength({block.MaxItems.Value}, ErrorMessage = \"Maximum {block.MaxItems.Value} {block.Name} block(s) allowed\")]");
        }

        return new
        {
            block.Name,
            block.TerraformName,
            block.ClassName,
            block.NestingMode,
            block.BlockPropertyType,
            block.MinItems,
            block.MaxItems,
            block.IsDeprecated,
            ValidationAttributes = validationAttributes,
            HasValidation = validationAttributes.Count > 0,
            Properties = block.Properties.Select(PreparePropertyForTemplate).ToList()
        };
    }
}
