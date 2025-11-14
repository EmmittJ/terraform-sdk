using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_storage_table_entity.
/// </summary>
public class AzurermStorageTableEntityDataSource : TerraformDataSource
{
    public AzurermStorageTableEntityDataSource(string name) : base("azurerm_storage_table_entity", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The partition_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionKey is required")]
    [TerraformArgument("partition_key")]
    public required TerraformValue<string> PartitionKey
    {
        get => new TerraformReference<string>(this, "partition_key");
        set => SetArgument("partition_key", value);
    }

    /// <summary>
    /// The row_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RowKey is required")]
    [TerraformArgument("row_key")]
    public required TerraformValue<string> RowKey
    {
        get => new TerraformReference<string>(this, "row_key");
        set => SetArgument("row_key", value);
    }

    /// <summary>
    /// The storage_table_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageTableId is required")]
    [TerraformArgument("storage_table_id")]
    public required TerraformValue<string> StorageTableId
    {
        get => new TerraformReference<string>(this, "storage_table_id");
        set => SetArgument("storage_table_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermStorageTableEntityDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The entity attribute.
    /// </summary>
    [TerraformArgument("entity")]
    public TerraformMap<string> Entity
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "entity").ResolveNodes(ctx));
    }

}
