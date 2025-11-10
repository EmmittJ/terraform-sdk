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
        // Property classification for new property system:
        // 1. Required Arguments: IsRequired=true, IsOptional=false, IsComputed=false (settable, must be set)
        // 2. Optional Arguments: IsOptional=true, IsComputed=false (settable, optional)
        // 3. Computed Attributes: IsComputed=true, IsRequired=false, IsOptional=false (read-only, computed by Terraform)
        // 4. Optional+Computed: IsOptional=true, IsComputed=true (can be set OR computed)

        bool isRequiredArgument = property.IsRequired && !property.IsOptional && !property.IsComputed;
        bool isOptionalArgument = property.IsOptional && !property.IsComputed;
        bool isComputedAttribute = property.IsComputed && !property.IsRequired && !property.IsOptional;
        bool isOptionalAndComputed = property.IsOptional && property.IsComputed;

        // Arguments (settable) include: Required, Optional, and Optional+Computed
        bool isArgument = isRequiredArgument || isOptionalArgument || isOptionalAndComputed;

        // All properties use TerraformProperty<T> wrapper
        // The distinction between literal/reference is handled by initialization
        string propertyTypeWrapper = $"TerraformProperty<{property.CSharpType}>";

        // Determine if we should use 'required' keyword:
        // - Property is marked Required in schema
        // - Property is not a collection (collections can't be required in C#)
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
            PropertyWrapper = propertyTypeWrapper,
            SetterValue = GetSetterValue(property), // NOT escaped - goes in code
            UseRequiredKeyword = useRequiredKeyword,
            UseNullable = !useRequiredKeyword, // If not required, make it nullable
            IsArgument = isArgument, // Arguments can be set (includes Required, Optional, Optional+Computed)
            IsComputedAttribute = isComputedAttribute, // Pure computed attributes (read-only)
            IsRequiredArgument = isRequiredArgument,
            IsOptionalArgument = isOptionalArgument,
            IsOptionalAndComputed = isOptionalAndComputed
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

        // Determine if the block should be required:
        // - Single blocks with MinItems = 1 should be required
        // - List/Set blocks with MinItems = 1 should be required (must have at least 1 item)
        bool isRequired = block.MinItems == 1;
        bool useRequiredKeyword = isRequired && block.NestingMode == "single";
        bool useNullable = !useRequiredKeyword;

        if (isRequired && block.NestingMode != "single")
        {
            // For collections, add the Required attribute
            validationAttributes.Insert(0, $"[System.ComponentModel.DataAnnotations.Required(ErrorMessage = \"{block.Name} is required\")]");
        }

        // Wrap block type in TerraformBlock<T> or collection wrapper
        string blockPropertyType = block.NestingMode switch
        {
            "single" => $"TerraformBlock<{block.ClassName}>",
            "list" => $"TerraformList<TerraformBlock<{block.ClassName}>>",
            "set" => $"TerraformSet<TerraformBlock<{block.ClassName}>>",
            "map" => $"TerraformMap<TerraformBlock<{block.ClassName}>>",
            _ => $"TerraformBlock<{block.ClassName}>"
        };

        return new
        {
            block.Name,
            block.TerraformName,
            block.ClassName,
            block.NestingMode,
            BlockPropertyType = blockPropertyType, // New: wrapped in TerraformBlock<T>
            OriginalBlockPropertyType = block.BlockPropertyType, // Old: raw type for backward compat
            block.MinItems,
            block.MaxItems,
            block.IsDeprecated,
            IsRequired = isRequired,
            UseRequiredKeyword = useRequiredKeyword,
            UseNullable = useNullable,
            ValidationAttributes = validationAttributes,
            HasValidation = validationAttributes.Count > 0,
            Properties = block.Properties.Select(PreparePropertyForTemplate).ToList()
        };
    }
}
