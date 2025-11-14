using EmmittJ.Terraform.Sdk.AppHost.Models;
using EmmittJ.Terraform.Sdk.AppHost.Schema;

namespace EmmittJ.Terraform.Sdk.AppHost;

/// <summary>
/// Builds code generation models from Terraform schema models.
/// </summary>
public class ModelBuilder : IModelBuilder
{
    private readonly ITypeMapper _typeMapper;

    public ModelBuilder(ITypeMapper typeMapper)
    {
        _typeMapper = typeMapper;
    }

    /// <summary>
    /// Builds a resource model from a resource schema.
    /// </summary>
    public ResourceModel BuildResourceModel(ResourceSchema schema, string terraformType)
    {
        var model = new ResourceModel
        {
            Name = terraformType,
            TerraformType = terraformType,
            ClassName = NamingConventions.ToClassName(terraformType),
            Description = schema.Block.Description ?? $"Manages a {terraformType} resource.",
            IsDeprecated = schema.Block.Deprecated
        };

        // Parse attributes
        foreach (var (attrName, attr) in schema.Block.Attributes)
        {
            var property = BuildPropertyModel(attr, attrName);

            if (attr.Computed && !attr.Optional && !attr.Required)
            {
                // Computed-only attributes are outputs
                model.OutputAttributes.Add(property);
            }
            else
            {
                // Input arguments
                model.Arguments.Add(property);
            }
        }

        // Parse block types
        foreach (var (blockName, blockType) in schema.Block.BlockTypes)
        {
            model.BlockTypes.Add(BuildBlockTypeModel(blockType, blockName, model.ClassName));
        }

        return model;
    }

    /// <summary>
    /// Builds a property model from a schema attribute.
    /// </summary>
    public PropertyModel BuildPropertyModel(SchemaAttribute attribute, string attributeName)
    {
        var csharpType = _typeMapper.MapToWrappedCSharpType(attribute.Type);
        var isCollection = _typeMapper.IsCollectionType(csharpType);
        var isValueType = _typeMapper.IsValueType(csharpType);

        return new PropertyModel
        {
            Name = NamingConventions.ToPascalCase(attributeName),
            TerraformName = attributeName,
            CSharpType = csharpType,
            Description = attribute.Description ?? $"The {attributeName} attribute.",
            IsRequired = attribute.Required,
            IsOptional = attribute.Optional,
            IsComputed = attribute.Computed,
            IsSensitive = attribute.Sensitive,
            IsDeprecated = attribute.Deprecated,
            IsCollection = isCollection,
            IsValueType = isValueType
        };
    }

    /// <summary>
    /// Builds a block type model from a schema block type.
    /// </summary>
    public BlockTypeModel BuildBlockTypeModel(SchemaBlockType blockType, string blockName, string parentClassName)
    {
        var model = new BlockTypeModel
        {
            Name = NamingConventions.ToPascalCase(blockName),
            TerraformName = blockName,
            ClassName = $"{parentClassName}{NamingConventions.ToPascalCase(blockName)}Block",
            NestingMode = blockType.NestingMode,
            MinItems = blockType.MinItems,
            MaxItems = blockType.MaxItems,
            IsDeprecated = blockType.Block.Deprecated
        };

        // Parse block attributes
        foreach (var (attrName, attr) in blockType.Block.Attributes)
        {
            model.Arguments.Add(BuildPropertyModel(attr, attrName));
        }

        return model;
    }
}
