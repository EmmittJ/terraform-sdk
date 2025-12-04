using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermAppConfigurationKeyDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermAppConfigurationKeyDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_app_configuration_key Terraform data source.
/// Retrieves information about a azurerm_app_configuration_key.
/// </summary>
public partial class AzurermAppConfigurationKeyDataSource(string name) : TerraformDataSource("azurerm_app_configuration_key", name)
{
    /// <summary>
    /// The configuration_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationStoreId is required")]
    public required TerraformValue<string> ConfigurationStoreId
    {
        get => GetArgument<TerraformValue<string>>("configuration_store_id");
        set => SetArgument("configuration_store_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformValue<string>? Label
    {
        get => GetArgument<TerraformValue<string>>("label");
        set => SetArgument("label", value);
    }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    public TerraformValue<string> ContentType
        => AsReference("content_type");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// The locked attribute.
    /// </summary>
    public TerraformValue<bool> Locked
        => AsReference("locked");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string> Value
        => AsReference("value");

    /// <summary>
    /// The vault_key_reference attribute.
    /// </summary>
    public TerraformValue<string> VaultKeyReference
        => AsReference("vault_key_reference");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAppConfigurationKeyDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAppConfigurationKeyDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
