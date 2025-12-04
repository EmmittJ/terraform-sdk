using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermStorageTableEntity.
/// Nesting mode: single
/// </summary>
public class AzurermStorageTableEntityTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_storage_table_entity Terraform resource.
/// Manages a azurerm_storage_table_entity resource.
/// </summary>
public partial class AzurermStorageTableEntity(string name) : TerraformResource("azurerm_storage_table_entity", name)
{
    /// <summary>
    /// The entity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Entity is required")]
    public required TerraformMap<string> Entity
    {
        get => GetRequiredArgument<TerraformMap<string>>("entity");
        set => SetArgument("entity", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The partition_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionKey is required")]
    public required TerraformValue<string> PartitionKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("partition_key");
        set => SetArgument("partition_key", value);
    }

    /// <summary>
    /// The row_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RowKey is required")]
    public required TerraformValue<string> RowKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("row_key");
        set => SetArgument("row_key", value);
    }

    /// <summary>
    /// The storage_table_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageTableId is required")]
    public required TerraformValue<string> StorageTableId
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_table_id");
        set => SetArgument("storage_table_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStorageTableEntityTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStorageTableEntityTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
