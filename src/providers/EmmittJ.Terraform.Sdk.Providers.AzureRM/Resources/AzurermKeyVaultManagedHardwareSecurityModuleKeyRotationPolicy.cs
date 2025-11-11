using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKeyVaultManagedHardwareSecurityModuleKeyRotationPolicyTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_key_vault_managed_hardware_security_module_key_rotation_policy resource.
/// </summary>
public partial class AzurermKeyVaultManagedHardwareSecurityModuleKeyRotationPolicy : TerraformResource
{
    public AzurermKeyVaultManagedHardwareSecurityModuleKeyRotationPolicy(string name) : base("azurerm_key_vault_managed_hardware_security_module_key_rotation_policy", name)
    {
    }

    /// <summary>
    /// The expire_after attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpireAfter is required")]
    [TerraformProperty("expire_after")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ExpireAfter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedHsmKeyId is required")]
    [TerraformProperty("managed_hsm_key_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ManagedHsmKeyId { get; set; }

    /// <summary>
    /// The time_after_creation attribute.
    /// </summary>
    [TerraformProperty("time_after_creation")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TimeAfterCreation { get; set; }

    /// <summary>
    /// The time_before_expiry attribute.
    /// </summary>
    [TerraformProperty("time_before_expiry")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TimeBeforeExpiry { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermKeyVaultManagedHardwareSecurityModuleKeyRotationPolicyTimeoutsBlock>? Timeouts { get; set; }

}
