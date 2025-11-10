using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleKeyDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The managed_hsm_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedHsmId is required")]
    [TerraformPropertyName("managed_hsm_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ManagedHsmId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKeyVaultManagedHardwareSecurityModuleKeyDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The curve attribute.
    /// </summary>
    [TerraformPropertyName("curve")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Curve => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "curve");

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    [TerraformPropertyName("expiration_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExpirationDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "expiration_date");

    /// <summary>
    /// The key_opts attribute.
    /// </summary>
    [TerraformPropertyName("key_opts")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> KeyOpts => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "key_opts");

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    [TerraformPropertyName("key_size")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> KeySize => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "key_size");

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    [TerraformPropertyName("key_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KeyType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_type");

    /// <summary>
    /// The not_before_date attribute.
    /// </summary>
    [TerraformPropertyName("not_before_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NotBeforeDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "not_before_date");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Version => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

    /// <summary>
    /// The versioned_id attribute.
    /// </summary>
    [TerraformPropertyName("versioned_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VersionedId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "versioned_id");

}
