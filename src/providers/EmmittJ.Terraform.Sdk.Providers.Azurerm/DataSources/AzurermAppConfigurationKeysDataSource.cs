using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermAppConfigurationKeysDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermAppConfigurationKeysDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_app_configuration_keys Terraform data source.
/// Retrieves information about a azurerm_app_configuration_keys.
/// </summary>
public partial class AzurermAppConfigurationKeysDataSource(string name) : TerraformDataSource("azurerm_app_configuration_keys", name)
{
    /// <summary>
    /// The configuration_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationStoreId is required")]
    public required TerraformValue<string> ConfigurationStoreId
    {
        get => new TerraformReference<string>(this, "configuration_store_id");
        set => SetArgument("configuration_store_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformValue<string>? Label
    {
        get => new TerraformReference<string>(this, "label");
        set => SetArgument("label", value);
    }

    /// <summary>
    /// The items attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Items
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "items").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAppConfigurationKeysDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAppConfigurationKeysDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
