using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageTableEntityDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_storage_table_entity Terraform data source.
/// Retrieves information about a azurerm_storage_table_entity.
/// </summary>
public partial class AzurermStorageTableEntityDataSource(string name) : TerraformDataSource("azurerm_storage_table_entity", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The partition_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionKey is required")]
    public required TerraformValue<string> PartitionKey
    {
        get => new TerraformReference<string>(this, "partition_key");
        set => SetArgument("partition_key", value);
    }

    /// <summary>
    /// The row_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RowKey is required")]
    public required TerraformValue<string> RowKey
    {
        get => new TerraformReference<string>(this, "row_key");
        set => SetArgument("row_key", value);
    }

    /// <summary>
    /// The storage_table_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageTableId is required")]
    public required TerraformValue<string> StorageTableId
    {
        get => new TerraformReference<string>(this, "storage_table_id");
        set => SetArgument("storage_table_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStorageTableEntityDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStorageTableEntityDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
