using EmmittJ.Terraform.Sdk.AppHost.Models;
using EmmittJ.Terraform.Sdk.AppHost.Schema;

namespace EmmittJ.Terraform.Sdk.AppHost;

/// <summary>
/// Builds code generation models from Terraform schema models.
/// </summary>
public interface IModelBuilder
{
    /// <summary>
    /// Builds a resource model from a resource schema.
    /// </summary>
    ResourceModel BuildResourceModel(ResourceSchema schema, string terraformType);

    /// <summary>
    /// Builds a property model from a schema attribute.
    /// </summary>
    PropertyModel BuildPropertyModel(SchemaAttribute attribute, string attributeName);

    /// <summary>
    /// Builds a block type model from a schema block type.
    /// </summary>
    BlockTypeModel BuildBlockTypeModel(SchemaBlockType blockType, string blockName, string parentClassName);
}
