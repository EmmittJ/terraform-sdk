using EmmittJ.Terraform.Sdk.AppHost.Models;

namespace EmmittJ.Terraform.Sdk.AppHost;

/// <summary>
/// Transforms code generation models into view models for template rendering.
/// </summary>
public class ViewModelTransformer
{
    /// <summary>
    /// Transforms a property model into a view model for template rendering.
    /// </summary>
    public object TransformProperty(PropertyModel property, bool isNestedBlockProperty = false)
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

        // The CSharpType already contains the properly wrapped type from MapTerraformTypeToCSharp
        // (e.g., "TerraformValue<string>", "List<TerraformValue<int>>")
        // Don't wrap it again - just use it directly
        string propertyTypeWrapper = property.CSharpType;

        // Determine if we should use 'required' keyword:
        // - Property is marked Required in schema
        // - Property is not a collection (collections can't be required in C#)
        bool useRequiredKeyword = property.IsRequired && !property.IsCollection;

        // Check if property name conflicts with TerraformMap<object> methods or base class properties
        // TerraformBlock inherits from TerraformMap<object>, which has an Add(string, object) method
        // TerraformResource has a ResourceType property
        // Note: Nested block properties only conflict with "Add", not "ResourceType" (they don't inherit from TerraformResource)
        bool needsNewKeyword = isNestedBlockProperty
            ? property.Name == "Add"
            : property.Name is "Add" or "ResourceType";

        bool isCollectionType = IsCollectionType(property.CSharpType);

        return new
        {
            property.Name,
            property.TerraformName,
            property.CSharpType,
            InnerType = GetInnerType(property.CSharpType), // Inner type for TerraformComputedProperty<T>
            Description = EscapeXmlDoc(property.Description), // Only escape for XML doc comments
            property.IsRequired,
            property.IsOptional,
            property.IsComputed,
            property.IsSensitive,
            property.IsDeprecated,
            PropertyWrapper = propertyTypeWrapper,
            SetterValue = "value", // Goes in code
            UseRequiredKeyword = useRequiredKeyword,
            UseNullable = !useRequiredKeyword, // If not required, make it nullable
            NeedsNewKeyword = needsNewKeyword, // Add 'new' keyword if property name conflicts with inherited member
            IsArgument = isArgument, // Arguments can be set (includes Required, Optional, Optional+Computed)
            IsComputedAttribute = isComputedAttribute, // Pure computed attributes (read-only)
            IsRequiredArgument = isRequiredArgument,
            IsOptionalArgument = isOptionalArgument,
            IsOptionalAndComputed = isOptionalAndComputed,
            IsCollectionType = isCollectionType, // Is TerraformList, TerraformMap, or TerraformSet
            CollectionElementType = isCollectionType ? GetCollectionElementType(property.CSharpType) : string.Empty,
            CollectionTypeName = isCollectionType ? property.CSharpType[..property.CSharpType.IndexOf('<')] : string.Empty
        };
    }

    /// <summary>
    /// Transforms a block type model into a view model for template rendering.
    /// </summary>
    public object TransformBlockType(BlockTypeModel block)
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

        // All blocks (single and collections) should be non-nullable with initialization
        // This eliminates null checks and makes the API cleaner
        bool useRequiredKeyword = isRequired;
        bool useNullable = false; // No blocks are nullable - all have = new() initializers
        bool useInitializer = true; // All blocks get = new() or = new("label") initializer

        if (isRequired && block.NestingMode != "single")
        {
            // For collections, add the Required attribute
            validationAttributes.Insert(0, $"[System.ComponentModel.DataAnnotations.Required(ErrorMessage = \"{block.Name} is required\")]");
        }

        // Wrap block type in collection wrapper (or use direct for single blocks)
        string blockPropertyType = block.NestingMode switch
        {
            "single" => block.ClassName,
            "list" => $"TerraformList<{block.ClassName}>",
            "set" => $"TerraformSet<{block.ClassName}>",
            "map" => $"TerraformMap<{block.ClassName}>",
            _ => block.ClassName
        };

        // Check if block property name conflicts with TerraformMap<object> methods or TerraformResource properties
        // - Nested blocks (defined inside a Resource/DataSource) that are named "Add" conflict with TerraformMap<object>.Add
        // - Resource/DataSource blocks named "ResourceType" conflict with TerraformResource.ResourceType
        bool needsNewKeyword = block.Name is "Add" or "ResourceType";

        // Single blocks need blockLabel parameter in constructor: new("label")
        // Collection blocks use parameterless constructor: new()
        bool useBlockLabelInInitializer = block.NestingMode == "single";

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
            UseInitializer = useInitializer,
            UseBlockLabelInInitializer = useBlockLabelInInitializer,
            NeedsNewKeyword = needsNewKeyword,
            ValidationAttributes = validationAttributes,
            HasValidation = validationAttributes.Count > 0,
            Properties = block.Properties.Select(p => TransformProperty(p, isNestedBlockProperty: true)).ToList()
        };
    }

    private static string EscapeXmlDoc(string? text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return string.Empty;
        }

        // Only escape XML special characters, not the whole string
        // These appear in XML doc comments, not in code
        return text
            .Replace("&", "&amp;")
            .Replace("<", "&lt;")
            .Replace(">", "&gt;")
            .Replace("\"", "&quot;")
            .Replace("\n", "\n    /// ");
    }

    private static string GetInnerType(string csharpType)
    {
        // Extract the inner type from TerraformValue<T>
        // e.g., "TerraformValue<string>" => "string"
        // e.g., "List<TerraformValue<int>>" => "List<TerraformValue<int>>" (no change)
        if (csharpType.StartsWith("TerraformValue<") && csharpType.EndsWith(">"))
        {
            return csharpType.Substring("TerraformValue<".Length, csharpType.Length - "TerraformValue<".Length - 1);
        }
        return csharpType;
    }

    private static bool IsCollectionType(string csharpType)
    {
        return csharpType.StartsWith("TerraformList<") ||
               csharpType.StartsWith("TerraformMap<") ||
               csharpType.StartsWith("TerraformSet<");
    }

    private static string GetCollectionElementType(string csharpType)
    {
        // Extract element type from collection type
        // e.g., "TerraformList<string>" => "string"
        // e.g., "TerraformMap<string>" => "string"
        if (csharpType.StartsWith("TerraformList<") && csharpType.EndsWith(">"))
        {
            return csharpType.Substring("TerraformList<".Length, csharpType.Length - "TerraformList<".Length - 1);
        }
        if (csharpType.StartsWith("TerraformMap<") && csharpType.EndsWith(">"))
        {
            return csharpType.Substring("TerraformMap<".Length, csharpType.Length - "TerraformMap<".Length - 1);
        }
        if (csharpType.StartsWith("TerraformSet<") && csharpType.EndsWith(">"))
        {
            return csharpType.Substring("TerraformSet<".Length, csharpType.Length - "TerraformSet<".Length - 1);
        }
        return csharpType;
    }

    /// <summary>
    /// Transforms a resource model into a view model for template rendering.
    /// </summary>
    public object TransformResource(ResourceModel resource)
    {
        var properties = resource.Properties
            .Select(p => TransformProperty(p, isNestedBlockProperty: false))
            .ToList();

        var outputAttributes = resource.OutputAttributes
            .Select(p => TransformProperty(p, isNestedBlockProperty: false))
            .ToList();

        var blockTypes = resource.BlockTypes
            .Select(TransformBlockType)
            .ToList();

        return new
        {
            resource.Name,
            resource.TerraformType,
            resource.ClassName,
            resource.Description,
            resource.IsDeprecated,
            Properties = properties,
            OutputAttributes = outputAttributes,
            BlockTypes = blockTypes,
            HasProperties = properties.Count > 0,
            HasOutputAttributes = outputAttributes.Count > 0,
            HasBlockTypes = blockTypes.Count > 0
        };
    }
}
