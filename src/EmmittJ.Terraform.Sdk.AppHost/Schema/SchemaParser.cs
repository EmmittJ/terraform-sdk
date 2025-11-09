using System.Text.Json;
using EmmittJ.Terraform.Sdk.AppHost.Models;
using EmmittJ.Terraform.Sdk.AppHost.Schema;

namespace EmmittJ.Terraform.Sdk.AppHost.Parsers;

public class SchemaParser
{
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
            var resource = new ResourceModel
            {
                Name = resourceType,
                TerraformType = resourceType,
                ClassName = ToClassName(resourceType),
                Description = resourceSchema.Block.Description ?? $"Manages a {resourceType} resource.",
                IsDeprecated = resourceSchema.Block.Deprecated
            };

            // Parse attributes
            foreach (var (attrName, attr) in resourceSchema.Block.Attributes)
            {
                var property = ParseAttribute(attrName, attr);

                if (attr.Computed && !attr.Optional && !attr.Required)
                {
                    // Computed-only attributes are outputs
                    resource.OutputAttributes.Add(property);
                }
                else
                {
                    // Input properties
                    resource.Properties.Add(property);
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
            var dataSource = new ResourceModel
            {
                Name = dataSourceType,
                TerraformType = dataSourceType,
                ClassName = ToClassName(dataSourceType) + "DataSource",
                Description = dataSourceSchema.Block.Description ?? $"Retrieves information about a {dataSourceType}.",
                IsDeprecated = dataSourceSchema.Block.Deprecated
            };

            // Parse attributes
            foreach (var (attrName, attr) in dataSourceSchema.Block.Attributes)
            {
                var property = ParseAttribute(attrName, attr);

                if (attr.Computed && !attr.Optional && !attr.Required)
                {
                    // Computed-only attributes are outputs
                    dataSource.OutputAttributes.Add(property);
                }
                else
                {
                    // Filter/input properties
                    dataSource.Properties.Add(property);
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

    private PropertyModel ParseAttribute(string name, SchemaAttribute attr)
    {
        var csharpType = MapTerraformTypeToCSharp(attr.Type);
        var isCollection = csharpType.Contains("List<") || csharpType.Contains("Dictionary<") || csharpType.Contains("HashSet<");

        // Extract the inner type from TerraformProperty<T> or collection types
        var isValueType = false;
        if (csharpType.StartsWith("TerraformProperty<"))
        {
            // Extract T from TerraformProperty<T>
            var innerType = csharpType.Substring("TerraformProperty<".Length, csharpType.Length - "TerraformProperty<".Length - 1);
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
            IsValueType = isValueType
        };
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
            MaxItems = blockType.MaxItems
        };

        // Parse block attributes
        foreach (var (attrName, attr) in blockType.Block.Attributes)
        {
            model.Properties.Add(ParseAttribute(attrName, attr));
        }

        return model;
    }

    public string MapTerraformTypeToCSharp(object? type)
    {
        if (type == null)
            return "TerraformProperty<string>";

        var typeStr = type.ToString() ?? "string";

        // Handle JSON element from deserialization
        if (type is JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.String)
            {
                typeStr = element.GetString() ?? "string";
            }
            else if (element.ValueKind == JsonValueKind.Array)
            {
                // Handle complex types like ["list", "string"]
                var arr = element.EnumerateArray().ToList();
                if (arr.Count >= 2)
                {
                    var collectionType = arr[0].GetString();
                    var innerType = MapTerraformTypeToCSharp(arr[1]);

                    return collectionType switch
                    {
                        "list" => $"List<{innerType}>",
                        "set" => $"HashSet<{innerType}>",
                        "map" => $"Dictionary<string, {innerType}>",
                        _ => "TerraformProperty<object>"
                    };
                }
            }
            else if (element.ValueKind == JsonValueKind.Object)
            {
                // Complex object type - use Dictionary for now
                return "Dictionary<string, TerraformProperty<object>>";
            }
        }

        return typeStr switch
        {
            "string" => "TerraformProperty<string>",
            "number" => "TerraformProperty<double>",
            "bool" => "TerraformProperty<bool>",
            "dynamic" => "TerraformProperty<object>",
            _ => "TerraformProperty<string>"
        };
    }

    public string ToClassName(string terraformType)
    {
        // Convert aws_instance to AwsInstance
        return string.Join("", terraformType.Split('_')
            .Select(part => char.ToUpper(part[0]) + part.Substring(1)));
    }

    public string ToPascalCase(string name)
    {
        // Convert snake_case to PascalCase
        return string.Join("", name.Split('_')
            .Select(part => char.ToUpper(part[0]) + part.Substring(1)));
    }
}
