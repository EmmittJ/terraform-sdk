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
public class AzurermKeyVaultManagedHardwareSecurityModuleKeyDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_key_vault_managed_hardware_security_module_key.
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleKeyDataSource : TerraformDataSource
{
    public AzurermKeyVaultManagedHardwareSecurityModuleKeyDataSource(string name) : base("azurerm_key_vault_managed_hardware_security_module_key", name)
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
    /// The managed_hsm_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedHsmId is required")]
    [TerraformArgument("managed_hsm_id")]
    public required TerraformValue<string> ManagedHsmId
    {
        get => new TerraformReference<string>(this, "managed_hsm_id");
        set => SetArgument("managed_hsm_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermKeyVaultManagedHardwareSecurityModuleKeyDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The curve attribute.
    /// </summary>
    [TerraformArgument("curve")]
    public TerraformValue<string> Curve
    {
        get => new TerraformReference<string>(this, "curve");
    }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    [TerraformArgument("expiration_date")]
    public TerraformValue<string> ExpirationDate
    {
        get => new TerraformReference<string>(this, "expiration_date");
    }

    /// <summary>
    /// The key_opts attribute.
    /// </summary>
    [TerraformArgument("key_opts")]
    public TerraformList<string> KeyOpts
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "key_opts").ResolveNodes(ctx));
    }

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    [TerraformArgument("key_size")]
    public TerraformValue<double> KeySize
    {
        get => new TerraformReference<double>(this, "key_size");
    }

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    [TerraformArgument("key_type")]
    public TerraformValue<string> KeyType
    {
        get => new TerraformReference<string>(this, "key_type");
    }

    /// <summary>
    /// The not_before_date attribute.
    /// </summary>
    [TerraformArgument("not_before_date")]
    public TerraformValue<string> NotBeforeDate
    {
        get => new TerraformReference<string>(this, "not_before_date");
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
    /// The version attribute.
    /// </summary>
    [TerraformArgument("version")]
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
    }

    /// <summary>
    /// The versioned_id attribute.
    /// </summary>
    [TerraformArgument("versioned_id")]
    public TerraformValue<string> VersionedId
    {
        get => new TerraformReference<string>(this, "versioned_id");
    }

}
