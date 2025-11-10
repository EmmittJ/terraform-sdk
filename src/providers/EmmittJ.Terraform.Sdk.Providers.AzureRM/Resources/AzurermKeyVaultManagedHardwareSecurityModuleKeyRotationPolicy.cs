using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleKeyRotationPolicyTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_key_vault_managed_hardware_security_module_key_rotation_policy resource.
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleKeyRotationPolicy : TerraformResource
{
    public AzurermKeyVaultManagedHardwareSecurityModuleKeyRotationPolicy(string name) : base("azurerm_key_vault_managed_hardware_security_module_key_rotation_policy", name)
    {
    }

    /// <summary>
    /// The expire_after attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpireAfter is required")]
    [TerraformPropertyName("expire_after")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ExpireAfter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedHsmKeyId is required")]
    [TerraformPropertyName("managed_hsm_key_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ManagedHsmKeyId { get; set; }

    /// <summary>
    /// The time_after_creation attribute.
    /// </summary>
    [TerraformPropertyName("time_after_creation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TimeAfterCreation { get; set; }

    /// <summary>
    /// The time_before_expiry attribute.
    /// </summary>
    [TerraformPropertyName("time_before_expiry")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TimeBeforeExpiry { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKeyVaultManagedHardwareSecurityModuleKeyRotationPolicyTimeoutsBlock>? Timeouts { get; set; } = new();

}
