using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermEventhubNamespaceSchemaGroup.
/// Nesting mode: single
/// </summary>
public class AzurermEventhubNamespaceSchemaGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_eventhub_namespace_schema_group Terraform resource.
/// Manages a azurerm_eventhub_namespace_schema_group resource.
/// </summary>
public partial class AzurermEventhubNamespaceSchemaGroup(string name) : TerraformResource("azurerm_eventhub_namespace_schema_group", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceId is required")]
    public required TerraformValue<string> NamespaceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("namespace_id");
        set => SetArgument("namespace_id", value);
    }

    /// <summary>
    /// The schema_compatibility attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaCompatibility is required")]
    public required TerraformValue<string> SchemaCompatibility
    {
        get => GetRequiredArgument<TerraformValue<string>>("schema_compatibility");
        set => SetArgument("schema_compatibility", value);
    }

    /// <summary>
    /// The schema_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaType is required")]
    public required TerraformValue<string> SchemaType
    {
        get => GetRequiredArgument<TerraformValue<string>>("schema_type");
        set => SetArgument("schema_type", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermEventhubNamespaceSchemaGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermEventhubNamespaceSchemaGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
