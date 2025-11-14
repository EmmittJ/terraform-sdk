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
public class AzurermAppConfigurationKeyDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_app_configuration_key.
/// </summary>
public class AzurermAppConfigurationKeyDataSource : TerraformDataSource
{
    public AzurermAppConfigurationKeyDataSource(string name) : base("azurerm_app_configuration_key", name)
    {
    }

    /// <summary>
    /// The configuration_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationStoreId is required")]
    [TerraformArgument("configuration_store_id")]
    public required TerraformValue<string> ConfigurationStoreId
    {
        get => new TerraformReference<string>(this, "configuration_store_id");
        set => SetArgument("configuration_store_id", value);
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
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformArgument("key")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    [TerraformArgument("label")]
    public TerraformValue<string>? Label
    {
        get => new TerraformReference<string>(this, "label");
        set => SetArgument("label", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermAppConfigurationKeyDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [TerraformArgument("content_type")]
    public TerraformValue<string> ContentType
    {
        get => new TerraformReference<string>(this, "content_type");
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformArgument("etag")]
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// The locked attribute.
    /// </summary>
    [TerraformArgument("locked")]
    public TerraformValue<bool> Locked
    {
        get => new TerraformReference<bool>(this, "locked");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformArgument("type")]
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformArgument("value")]
    public TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
    }

    /// <summary>
    /// The vault_key_reference attribute.
    /// </summary>
    [TerraformArgument("vault_key_reference")]
    public TerraformValue<string> VaultKeyReference
    {
        get => new TerraformReference<string>(this, "vault_key_reference");
    }

}
