using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermStorageTableEntitiesDataSource.
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
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_storage_table_entities Terraform data source.
/// Retrieves information about a azurerm_storage_table_entities.
/// </summary>
public partial class AzurermStorageTableEntitiesDataSource(string name) : TerraformDataSource("azurerm_storage_table_entities", name)
{
    /// <summary>
    /// The filter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformValue<string> Filter
    {
        get => GetRequiredArgument<TerraformValue<string>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The select attribute.
    /// </summary>
    public TerraformList<string>? Select
    {
        get => GetArgument<TerraformList<string>>("select");
        set => SetArgument("select", value);
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
    /// The items attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Items
        => CreateReference("items");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStorageTableEntitiesDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStorageTableEntitiesDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
