using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKeyVaultManagedHardwareSecurityModuleKeyTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_key_vault_managed_hardware_security_module_key resource.
/// </summary>
public partial class AzurermKeyVaultManagedHardwareSecurityModuleKey : TerraformResource
{
    public AzurermKeyVaultManagedHardwareSecurityModuleKey(string name) : base("azurerm_key_vault_managed_hardware_security_module_key", name)
    {
    }

    /// <summary>
    /// The curve attribute.
    /// </summary>
    [TerraformProperty("curve")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Curve { get; set; }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    [TerraformProperty("expiration_date")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExpirationDate { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key_opts attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyOpts is required")]
    [TerraformProperty("key_opts")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> KeyOpts { get; set; }

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    [TerraformProperty("key_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? KeySize { get; set; }

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyType is required")]
    [TerraformProperty("key_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyType { get; set; }

    /// <summary>
    /// The managed_hsm_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedHsmId is required")]
    [TerraformProperty("managed_hsm_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ManagedHsmId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The not_before_date attribute.
    /// </summary>
    [TerraformProperty("not_before_date")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NotBeforeDate { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermKeyVaultManagedHardwareSecurityModuleKeyTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The versioned_id attribute.
    /// </summary>
    [TerraformProperty("versioned_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VersionedId { get; }

}
