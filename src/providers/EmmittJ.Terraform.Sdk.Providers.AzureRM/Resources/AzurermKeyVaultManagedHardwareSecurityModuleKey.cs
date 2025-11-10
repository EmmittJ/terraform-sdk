using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleKeyTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_key_vault_managed_hardware_security_module_key resource.
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleKey : TerraformResource
{
    public AzurermKeyVaultManagedHardwareSecurityModuleKey(string name) : base("azurerm_key_vault_managed_hardware_security_module_key", name)
    {
    }

    /// <summary>
    /// The curve attribute.
    /// </summary>
    [TerraformPropertyName("curve")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Curve { get; set; }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    [TerraformPropertyName("expiration_date")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExpirationDate { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The key_opts attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyOpts is required")]
    [TerraformPropertyName("key_opts")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? KeyOpts { get; set; }

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    [TerraformPropertyName("key_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? KeySize { get; set; }

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyType is required")]
    [TerraformPropertyName("key_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyType { get; set; }

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
    /// The not_before_date attribute.
    /// </summary>
    [TerraformPropertyName("not_before_date")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NotBeforeDate { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKeyVaultManagedHardwareSecurityModuleKeyTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The versioned_id attribute.
    /// </summary>
    [TerraformPropertyName("versioned_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VersionedId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "versioned_id");

}
