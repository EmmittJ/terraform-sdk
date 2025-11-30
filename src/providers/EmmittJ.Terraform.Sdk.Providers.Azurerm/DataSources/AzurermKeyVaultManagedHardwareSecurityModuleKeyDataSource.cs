using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermKeyVaultManagedHardwareSecurityModuleKeyDataSource.
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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_key_vault_managed_hardware_security_module_key Terraform data source.
/// Retrieves information about a azurerm_key_vault_managed_hardware_security_module_key.
/// </summary>
public partial class AzurermKeyVaultManagedHardwareSecurityModuleKeyDataSource(string name) : TerraformDataSource("azurerm_key_vault_managed_hardware_security_module_key", name)
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
    /// The managed_hsm_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedHsmId is required")]
    public required TerraformValue<string> ManagedHsmId
    {
        get => new TerraformReference<string>(this, "managed_hsm_id");
        set => SetArgument("managed_hsm_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The curve attribute.
    /// </summary>
    public TerraformValue<string> Curve
    {
        get => new TerraformReference<string>(this, "curve");
    }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformValue<string> ExpirationDate
    {
        get => new TerraformReference<string>(this, "expiration_date");
    }

    /// <summary>
    /// The key_opts attribute.
    /// </summary>
    public TerraformList<string> KeyOpts
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "key_opts").ResolveNodes(ctx));
    }

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    public TerraformValue<double> KeySize
    {
        get => new TerraformReference<double>(this, "key_size");
    }

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    public TerraformValue<string> KeyType
    {
        get => new TerraformReference<string>(this, "key_type");
    }

    /// <summary>
    /// The not_before_date attribute.
    /// </summary>
    public TerraformValue<string> NotBeforeDate
    {
        get => new TerraformReference<string>(this, "not_before_date");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
    }

    /// <summary>
    /// The versioned_id attribute.
    /// </summary>
    public TerraformValue<string> VersionedId
    {
        get => new TerraformReference<string>(this, "versioned_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKeyVaultManagedHardwareSecurityModuleKeyDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKeyVaultManagedHardwareSecurityModuleKeyDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
