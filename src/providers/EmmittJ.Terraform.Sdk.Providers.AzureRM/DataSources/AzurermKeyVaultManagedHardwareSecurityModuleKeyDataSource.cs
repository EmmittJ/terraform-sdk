using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleKeyDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The managed_hsm_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedHsmId is required")]
    [TerraformPropertyName("managed_hsm_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ManagedHsmId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKeyVaultManagedHardwareSecurityModuleKeyDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The curve attribute.
    /// </summary>
    [TerraformPropertyName("curve")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Curve => new TerraformReference(this, "curve");

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    [TerraformPropertyName("expiration_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ExpirationDate => new TerraformReference(this, "expiration_date");

    /// <summary>
    /// The key_opts attribute.
    /// </summary>
    [TerraformPropertyName("key_opts")]
    // Output-only attribute - read-only reference
    public TerraformList<string> KeyOpts => new TerraformReference(this, "key_opts");

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    [TerraformPropertyName("key_size")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> KeySize => new TerraformReference(this, "key_size");

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    [TerraformPropertyName("key_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KeyType => new TerraformReference(this, "key_type");

    /// <summary>
    /// The not_before_date attribute.
    /// </summary>
    [TerraformPropertyName("not_before_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NotBeforeDate => new TerraformReference(this, "not_before_date");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Version => new TerraformReference(this, "version");

    /// <summary>
    /// The versioned_id attribute.
    /// </summary>
    [TerraformPropertyName("versioned_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VersionedId => new TerraformReference(this, "versioned_id");

}
