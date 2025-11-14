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
public class AzurermStorageTableEntitiesDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_storage_table_entities.
/// </summary>
public class AzurermStorageTableEntitiesDataSource : TerraformDataSource
{
    public AzurermStorageTableEntitiesDataSource(string name) : base("azurerm_storage_table_entities", name)
    {
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [TerraformArgument("filter")]
    public required TerraformValue<string> Filter
    {
        get => new TerraformReference<string>(this, "filter");
        set => SetArgument("filter", value);
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
    /// The select attribute.
    /// </summary>
    [TerraformArgument("select")]
    public TerraformList<string>? Select
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "select").ResolveNodes(ctx));
        set => SetArgument("select", value);
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
    public AzurermStorageTableEntitiesDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The items attribute.
    /// </summary>
    [TerraformArgument("items")]
    public TerraformList<object> Items
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "items").ResolveNodes(ctx));
    }

}
