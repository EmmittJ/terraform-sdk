using System.Text.Json;
using EmmittJ.Terraform.Sdk.AppHost.Models;
using EmmittJ.Terraform.Sdk.AppHost.Schema;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace EmmittJ.Terraform.Sdk.AppHost.Parsers;

public class SchemaParser : ISchemaParser
{
    // C# reserved keywords - using Roslyn's SyntaxFacts for accurate detection
    private static readonly HashSet<string> CSharpReservedKeywords = GetReservedKeywords();

    private static HashSet<string> GetReservedKeywords()
    {
        // Use Roslyn to get all C# keywords
        var keywords = SyntaxFacts.GetReservedKeywordKinds()
            .Select(SyntaxFacts.GetText)
            .ToHashSet(StringComparer.OrdinalIgnoreCase);

        // Add contextual keywords that could cause issues
        keywords.Add("var");
        keywords.Add("dynamic");
        keywords.Add("nameof");
        keywords.Add("when");
        keywords.Add("where");
        keywords.Add("async");
        keywords.Add("await");
        keywords.Add("yield");
        keywords.Add("partial");
        keywords.Add("global");

        return keywords;
    }

    // Common base class members that would cause conflicts
    private static readonly HashSet<string> BaseClassMembers = new(StringComparer.OrdinalIgnoreCase)
    {
        "GetType", "ToString", "Equals", "GetHashCode", "ReferenceEquals", "MemberwiseClone",
        "Add", "Remove", "Clear", "Contains", "ContainsKey", "TryGetValue", "Keys", "Values", "Count" // TerraformMap<object> members
    };

    // Terraform SDK base class members
    private static readonly HashSet<string> TerraformBaseMembers = new(StringComparer.OrdinalIgnoreCase)
    {
        "TerraformName", "TerraformType", "Stack", "Node", "DependsOn", "ForEach", "Provider",
        "Lifecycle", "Connection", "Provisioner", "Count", "TerraformResourceType",
        "TerraformGeneratorMetadata", "TerraformMetaArguments", "FriendlyUniqueId", "Fqn",
        "ResourceType" // TerraformResource.ResourceType property
    };

    // Reserved class/namespace names that would cause conflicts
    private static readonly HashSet<string> ReservedClassNames = GetReservedClassNames();

    private static HashSet<string> GetReservedClassNames()
    {
        var reserved = new HashSet<string>(CSharpReservedKeywords, StringComparer.OrdinalIgnoreCase);

        // Add common type names that could collide
        reserved.Add("license");  // Collides with LICENSE file on case-insensitive filesystems
        reserved.Add("version");  // Collides for certain package systems
        reserved.Add("provider"); // Reserved for Terraform provider resources
        reserved.Add("resource"); // Generic resource type
        reserved.Add("data");     // Generic data source prefix
        reserved.Add("module");   // Terraform module
        reserved.Add("variable"); // Terraform variable
        reserved.Add("output");   // Terraform output
        reserved.Add("locals");   // Terraform locals

        return reserved;
    }    // Tracks struct definitions to detect recursive loops
    private readonly Dictionary<string, NestedStructModel> _structRegistry = new();
    private readonly HashSet<string> _currentPath = new();

    /// <summary>
    /// Sanitizes a property name to avoid C# reserved keywords and base class member conflicts.
    /// Follows CDKTF pattern of appending "Attribute" suffix.
    /// </summary>
    private static string SanitizePropertyName(string name)
    {
        if (CSharpReservedKeywords.Contains(name) ||
            BaseClassMembers.Contains(name) ||
            TerraformBaseMembers.Contains(name))
        {
            return $"{name}Attribute";
        }

        return name;
    }
    public ProviderSchemaRoot ParseSchema(string schemaJson)
    {
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        return JsonSerializer.Deserialize<ProviderSchemaRoot>(schemaJson, options)
            ?? throw new InvalidOperationException("Failed to parse provider schema");
    }

    public List<ResourceModel> ParseResources(ProviderSchema providerSchema, string providerName)
    {
        var resources = new List<ResourceModel>();

        foreach (var (resourceType, resourceSchema) in providerSchema.ResourceSchemas)
        {
            // Clear struct registry for each resource to avoid cross-resource pollution
            _structRegistry.Clear();
            _currentPath.Clear();

            var resource = new ResourceModel
            {
                Name = resourceType,
                TerraformType = resourceType,
                ClassName = ToClassName(resourceType),
                Description = resourceSchema.Block.Description ?? $"Manages a {resourceType} resource.",
                IsDeprecated = resourceSchema.Block.Deprecated
            };

            // Parse attributes
            var allProperties = new List<PropertyModel>();
            foreach (var (attrName, attr) in resourceSchema.Block.Attributes)
            {
                allProperties.Add(ParseAttribute(attrName, attr));
            }

            // Deduplicate properties with the same C# name
            var deduplicatedProperties = DeduplicateProperties(allProperties, resourceType);

            // Categorize into arguments and outputs
            foreach (var property in deduplicatedProperties)
            {
                var originalAttr = resourceSchema.Block.Attributes[property.TerraformName];

                if (originalAttr.Computed && !originalAttr.Optional && !originalAttr.Required)
                {
                    // Computed-only attributes are outputs
                    resource.OutputAttributes.Add(property);
                }
                else
                {
                    // Input arguments
                    resource.Arguments.Add(property);
                }
            }

            // Parse block types
            foreach (var (blockName, blockType) in resourceSchema.Block.BlockTypes)
            {
                resource.BlockTypes.Add(ParseBlockType(blockName, blockType, resource.ClassName));
            }

            resources.Add(resource);
        }

        return resources;
    }

    public List<ResourceModel> ParseDataSources(ProviderSchema providerSchema, string providerName)
    {
        var dataSources = new List<ResourceModel>();

        foreach (var (dataSourceType, dataSourceSchema) in providerSchema.DataSourceSchemas)
        {
            // Clear struct registry for each data source to avoid cross-resource pollution
            _structRegistry.Clear();
            _currentPath.Clear();

            var dataSource = new ResourceModel
            {
                Name = dataSourceType,
                TerraformType = dataSourceType,
                ClassName = ToClassName(dataSourceType) + "DataSource",
                Description = dataSourceSchema.Block.Description ?? $"Retrieves information about a {dataSourceType}.",
                IsDeprecated = dataSourceSchema.Block.Deprecated
            };

            // Parse attributes
            var allProperties = new List<PropertyModel>();
            foreach (var (attrName, attr) in dataSourceSchema.Block.Attributes)
            {
                allProperties.Add(ParseAttribute(attrName, attr));
            }

            // Deduplicate properties with the same C# name
            var deduplicatedProperties = DeduplicateProperties(allProperties, dataSourceType);

            // Categorize into arguments and outputs
            foreach (var property in deduplicatedProperties)
            {
                var originalAttr = dataSourceSchema.Block.Attributes[property.TerraformName];

                if (originalAttr.Computed && !originalAttr.Optional && !originalAttr.Required)
                {
                    // Computed-only attributes are outputs
                    dataSource.OutputAttributes.Add(property);
                }
                else
                {
                    // Filter/input arguments
                    dataSource.Arguments.Add(property);
                }
            }

            // Parse block types
            foreach (var (blockName, blockType) in dataSourceSchema.Block.BlockTypes)
            {
                dataSource.BlockTypes.Add(ParseBlockType(blockName, blockType, dataSource.ClassName));
            }

            dataSources.Add(dataSource);
        }

        return dataSources;
    }

    public List<ResourceModel> ParseEphemeralResources(ProviderSchema providerSchema, string providerName)
    {
        var ephemeralResources = new List<ResourceModel>();

        foreach (var (ephemeralType, ephemeralSchema) in providerSchema.EphemeralResourceSchemas)
        {
            // Clear struct registry for each ephemeral resource to avoid cross-resource pollution
            _structRegistry.Clear();
            _currentPath.Clear();

            var ephemeralResource = new ResourceModel
            {
                Name = ephemeralType,
                TerraformType = ephemeralType,
                ClassName = ToClassName(ephemeralType) + "EphemeralResource",
                Description = ephemeralSchema.Block.Description ?? $"Manages a {ephemeralType} ephemeral resource (temporary credentials/tokens).",
                IsDeprecated = ephemeralSchema.Block.Deprecated
            };

            // Parse attributes
            var allProperties = new List<PropertyModel>();
            foreach (var (attrName, attr) in ephemeralSchema.Block.Attributes)
            {
                allProperties.Add(ParseAttribute(attrName, attr));
            }

            // Deduplicate properties with the same C# name
            var deduplicatedProperties = DeduplicateProperties(allProperties, ephemeralType);

            // Categorize into arguments and outputs
            foreach (var property in deduplicatedProperties)
            {
                var originalAttr = ephemeralSchema.Block.Attributes[property.TerraformName];

                if (originalAttr.Computed && !originalAttr.Optional && !originalAttr.Required)
                {
                    // Computed-only attributes are outputs
                    ephemeralResource.OutputAttributes.Add(property);
                }
                else
                {
                    // Input arguments
                    ephemeralResource.Arguments.Add(property);
                }
            }

            // Parse block types
            foreach (var (blockName, blockType) in ephemeralSchema.Block.BlockTypes)
            {
                ephemeralResource.BlockTypes.Add(ParseBlockType(blockName, blockType, ephemeralResource.ClassName));
            }

            ephemeralResources.Add(ephemeralResource);
        }

        return ephemeralResources;
    }

    /// <summary>
    /// Removes duplicate properties that have the same C# name after case conversion.
    /// Keeps the first occurrence and prefers non-deprecated over deprecated if both exist.
    /// </summary>
    /// <param name="properties">List of all properties from the schema.</param>
    /// <param name="resourceType">The resource type name for logging purposes.</param>
    /// <returns>Deduplicated list of properties.</returns>
    private List<PropertyModel> DeduplicateProperties(List<PropertyModel> properties, string resourceType)
    {
        var seen = new Dictionary<string, PropertyModel>(StringComparer.OrdinalIgnoreCase);
        var result = new List<PropertyModel>();

        foreach (var property in properties)
        {
            if (!seen.TryGetValue(property.Name, out var existing))
            {
                // First occurrence, add it
                seen[property.Name] = property;
                result.Add(property);
            }
            else
            {
                // Duplicate found - prefer non-deprecated version
                if (existing.IsDeprecated && !property.IsDeprecated)
                {
                    // Replace deprecated with non-deprecated
                    result.Remove(existing);
                    result.Add(property);
                    seen[property.Name] = property;
                    Console.WriteLine($"Warning: {resourceType} has duplicate property '{property.Name}' (from '{existing.TerraformName}' and '{property.TerraformName}'). Keeping non-deprecated version '{property.TerraformName}'.");
                }
                else
                {
                    // Keep first occurrence
                    Console.WriteLine($"Warning: {resourceType} has duplicate property '{property.Name}' (from '{existing.TerraformName}' and '{property.TerraformName}'). Keeping first occurrence '{existing.TerraformName}'.");
                }
            }
        }

        return result;
    }

    private PropertyModel ParseAttribute(string name, SchemaAttribute attr)
    {
        string csharpType;
        NestedStructModel? nestedStruct = null;

        // Check if this attribute has a nested_type instead of a simple type
        if (attr.NestedType != null)
        {
            // Handle nested type attribute
            var structName = $"{ToPascalCase(name)}Struct";
            nestedStruct = ParseNestedType(structName, attr.NestedType);
            csharpType = nestedStruct.PropertyType;
        }
        else
        {
            // Handle simple type
            csharpType = MapTerraformTypeToCSharp(attr.Type);
        }

        var isCollection = csharpType.Contains("List<") || csharpType.Contains("Dictionary<") || csharpType.Contains("HashSet<");

        // Extract the inner type from TerraformValue<T> or collection types
        var isValueType = false;
        if (csharpType.StartsWith("TerraformValue<"))
        {
            // Extract T from TerraformValue<T>
            var innerType = csharpType.Substring("TerraformValue<".Length, csharpType.Length - "TerraformValue<".Length - 1);
            isValueType = innerType == "bool" || innerType == "double" || innerType == "int" || innerType == "long" || innerType == "float";
        }

        return new PropertyModel
        {
            Name = ToPascalCase(name),
            TerraformName = name,
            CSharpType = csharpType,
            Description = attr.Description ?? $"The {name} attribute.",
            IsRequired = attr.Required,
            IsOptional = attr.Optional,
            IsComputed = attr.Computed,
            IsSensitive = attr.Sensitive,
            IsDeprecated = attr.Deprecated,
            IsCollection = isCollection,
            IsValueType = isValueType,
            NestedStruct = nestedStruct
        };
    }

    /// <summary>
    /// Parses a nested type definition into a struct model.
    /// Detects recursive structures and reuses existing struct definitions to prevent infinite loops.
    /// </summary>
    private NestedStructModel ParseNestedType(string structName, SchemaNestedType nestedType)
    {
        // Check if we've already parsed this struct (recursion detection)
        if (_structRegistry.TryGetValue(structName, out var existingStruct))
        {
            Console.WriteLine($"Info: Detected recursive structure for '{structName}'. Reusing existing struct definition.");
            return existingStruct;
        }

        // Check if we're currently parsing this struct (cycle detection)
        if (_currentPath.Contains(structName))
        {
            Console.WriteLine($"Warning: Detected circular reference while parsing '{structName}'. Breaking recursion cycle.");
            // Return a minimal struct to break the cycle
            return new NestedStructModel
            {
                ClassName = structName,
                NestingMode = nestedType.NestingMode,
                Properties = new List<PropertyModel>()
            };
        }

        // Add to current path to detect cycles
        _currentPath.Add(structName);

        var model = new NestedStructModel
        {
            ClassName = structName,
            NestingMode = nestedType.NestingMode
        };

        // Register early to handle recursive references
        _structRegistry[structName] = model;

        // Recursively parse nested attributes
        foreach (var (attrName, attr) in nestedType.Attributes)
        {
            model.Properties.Add(ParseAttribute(attrName, attr));
        }

        // Remove from current path after parsing
        _currentPath.Remove(structName);

        return model;
    }

    private BlockTypeModel ParseBlockType(string name, SchemaBlockType blockType, string parentClassName)
    {
        var model = new BlockTypeModel
        {
            Name = ToPascalCase(name),
            TerraformName = name,
            ClassName = $"{parentClassName}{ToPascalCase(name)}Block",
            NestingMode = blockType.NestingMode,
            MinItems = blockType.MinItems,
            MaxItems = blockType.MaxItems,
            IsDeprecated = blockType.Block.Deprecated
        };

        // Parse block attributes
        foreach (var (attrName, attr) in blockType.Block.Attributes)
        {
            model.Arguments.Add(ParseAttribute(attrName, attr));
        }

        return model;
    }

    /// <summary>
    /// Maps a raw Terraform type (e.g., "string", "number") to the unwrapped C# type (e.g., "string", "double").
    /// Used for collection element types where the collection handles the wrapping.
    /// </summary>
    private string MapTerraformTypeToRawCSharp(object? type)
    {
        if (type == null)
            return "string";

        // Handle JSON element from deserialization
        if (type is JsonElement element)
        {
            return ParseJsonElementToRawType(element);
        }

        var typeStr = type.ToString() ?? "string";
        return MapPrimitiveType(typeStr);
    }

    public string MapTerraformTypeToCSharp(object? type)
    {
        if (type == null)
            return "TerraformValue<string>";

        // Handle JSON element from deserialization
        if (type is JsonElement element)
        {
            return ParseJsonElementToType(element);
        }

        var typeStr = type.ToString() ?? "string";
        return WrapInTerraformValue(MapPrimitiveType(typeStr));
    }

    /// <summary>
    /// Parses a JSON element into a raw C# type (without TerraformValue wrapper).
    /// </summary>
    private string ParseJsonElementToRawType(JsonElement element)
    {
        if (element.ValueKind == JsonValueKind.String)
        {
            var typeStr = element.GetString() ?? "string";
            return MapPrimitiveType(typeStr);
        }
        else if (element.ValueKind == JsonValueKind.Array)
        {
            // Handle complex types like ["list", "string"], ["map", ["list", "number"]], etc.
            var arr = element.EnumerateArray().ToList();
            if (arr.Count >= 2)
            {
                var collectionType = arr[0].GetString();
                var innerType = MapTerraformTypeToRawCSharp(arr[1]); // Recursively parse inner type

                return collectionType switch
                {
                    "list" => $"TerraformList<{innerType}>",
                    "set" => $"TerraformSet<{innerType}>",
                    "map" => $"TerraformMap<{innerType}>",
                    "object" => "TerraformMap<object>", // Object types become maps
                    _ => "object"
                };
            }
        }
        else if (element.ValueKind == JsonValueKind.Object)
        {
            // Complex object type - use Dictionary/Map
            return "TerraformMap<object>";
        }

        return "string";
    }

    /// <summary>
    /// Parses a JSON element into a C# type (with TerraformValue wrapper for primitives).
    /// </summary>
    private string ParseJsonElementToType(JsonElement element)
    {
        if (element.ValueKind == JsonValueKind.String)
        {
            var typeStr = element.GetString() ?? "string";
            return WrapInTerraformValue(MapPrimitiveType(typeStr));
        }
        else if (element.ValueKind == JsonValueKind.Array)
        {
            // Handle complex types like ["list", "string"], ["map", ["list", "number"]], etc.
            var arr = element.EnumerateArray().ToList();
            if (arr.Count >= 2)
            {
                var collectionType = arr[0].GetString();
                var innerType = MapTerraformTypeToRawCSharp(arr[1]); // Use raw type for collection elements

                return collectionType switch
                {
                    "list" => $"TerraformList<{innerType}>",
                    "set" => $"TerraformSet<{innerType}>",
                    "map" => $"TerraformMap<{innerType}>",
                    "object" => "TerraformMap<object>",
                    _ => "TerraformValue<object>"
                };
            }
        }
        else if (element.ValueKind == JsonValueKind.Object)
        {
            // Complex object type
            return "TerraformMap<object>";
        }

        return "TerraformValue<string>";
    }

    /// <summary>
    /// Maps Terraform primitive type names to C# primitive types.
    /// </summary>
    private static string MapPrimitiveType(string typeStr)
    {
        return typeStr switch
        {
            "string" => "string",
            "number" => "double",
            "bool" => "bool",
            "dynamic" => "object",
            "any" => "object",
            _ => "string"
        };
    }

    /// <summary>
    /// Wraps a primitive C# type in TerraformValue&lt;T&gt;.
    /// </summary>
    private static string WrapInTerraformValue(string primitiveType)
    {
        return $"TerraformValue<{primitiveType}>";
    }

    public List<ProviderFunctionModel> ParseProviderFunctions(ProviderSchema providerSchema, string providerName)
    {
        var functions = new List<ProviderFunctionModel>();

        foreach (var (functionName, functionSchema) in providerSchema.Functions)
        {
            var function = new ProviderFunctionModel
            {
                Name = ToPascalCase(functionName),
                TerraformName = functionName,
                ProviderName = providerName,
                Summary = functionSchema.Summary,
                Description = functionSchema.Description,
                DeprecationMessage = functionSchema.DeprecationMessage
            };

            // Parse parameters
            foreach (var param in functionSchema.Parameters)
            {
                function.Parameters.Add(new FunctionParameterModel
                {
                    Name = ToCamelCase(param.Name),
                    Description = param.Description,
                    IsNullable = param.IsNullable
                });
            }

            // Parse variadic parameter
            if (functionSchema.VariadicParameter != null)
            {
                var varParam = functionSchema.VariadicParameter;
                function.VariadicParameter = new FunctionParameterModel
                {
                    Name = ToCamelCase(varParam.Name),
                    Description = varParam.Description,
                    IsNullable = varParam.IsNullable
                };
            }

            functions.Add(function);
        }

        return functions;
    }

    public string ToClassName(string terraformType)
    {
        // Convert aws_instance to AwsInstance
        var className = string.Join("", terraformType.Split('_')
            .Select(part => char.ToUpper(part[0]) + part.Substring(1)));

        // Sanitize class name to avoid reserved words
        return SanitizeClassName(className);
    }

    /// <summary>
    /// Sanitizes a class or namespace name to avoid C# reserved keywords and common conflicts.
    /// Follows CDKTF pattern of appending "Resource" suffix.
    /// </summary>
    private static string SanitizeClassName(string name)
    {
        if (ReservedClassNames.Contains(name))
        {
            return $"{name}Resource";
        }

        return name;
    }

    public string ToPascalCase(string name)
    {
        // Convert snake_case to PascalCase
        var pascalCase = string.Join("", name.Split('_')
            .Select(part => char.ToUpper(part[0]) + part.Substring(1)));

        // Sanitize to avoid reserved keywords and conflicts
        return SanitizePropertyName(pascalCase);
    }

    public string ToCamelCase(string name)
    {
        // Convert snake_case to camelCase
        var parts = name.Split('_');
        if (parts.Length == 0)
            return SanitizePropertyName(name);

        var result = parts[0].ToLowerInvariant();
        for (int i = 1; i < parts.Length; i++)
        {
            result += char.ToUpper(parts[i][0]) + parts[i].Substring(1);
        }

        // Sanitize to avoid reserved keywords and conflicts
        return SanitizePropertyName(result);
    }
}
