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
        get => GetArgument<TerraformValue<string>>("read");
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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The managed_hsm_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedHsmId is required")]
    public required TerraformValue<string> ManagedHsmId
    {
        get => GetArgument<TerraformValue<string>>("managed_hsm_id");
        set => SetArgument("managed_hsm_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The curve attribute.
    /// </summary>
    public TerraformValue<string> Curve
        => AsReference("curve");

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformValue<string> ExpirationDate
        => AsReference("expiration_date");

    /// <summary>
    /// The key_opts attribute.
    /// </summary>
    public TerraformList<string> KeyOpts
        => AsReference("key_opts");

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    public TerraformValue<double> KeySize
        => AsReference("key_size");

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    public TerraformValue<string> KeyType
        => AsReference("key_type");

    /// <summary>
    /// The not_before_date attribute.
    /// </summary>
    public TerraformValue<string> NotBeforeDate
        => AsReference("not_before_date");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
        => AsReference("version");

    /// <summary>
    /// The versioned_id attribute.
    /// </summary>
    public TerraformValue<string> VersionedId
        => AsReference("versioned_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKeyVaultManagedHardwareSecurityModuleKeyDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKeyVaultManagedHardwareSecurityModuleKeyDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
