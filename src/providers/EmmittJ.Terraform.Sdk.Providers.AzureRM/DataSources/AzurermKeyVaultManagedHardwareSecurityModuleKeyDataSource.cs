using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKeyVaultManagedHardwareSecurityModuleKeyDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_key_vault_managed_hardware_security_module_key.
/// </summary>
public partial class AzurermKeyVaultManagedHardwareSecurityModuleKeyDataSource : TerraformDataSource
{
    public AzurermKeyVaultManagedHardwareSecurityModuleKeyDataSource(string name) : base("azurerm_key_vault_managed_hardware_security_module_key", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermKeyVaultManagedHardwareSecurityModuleKeyDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The curve attribute.
    /// </summary>
    [TerraformProperty("curve")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Curve { get; }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    [TerraformProperty("expiration_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExpirationDate { get; }

    /// <summary>
    /// The key_opts attribute.
    /// </summary>
    [TerraformProperty("key_opts")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> KeyOpts { get; }

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    [TerraformProperty("key_size")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> KeySize { get; }

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    [TerraformProperty("key_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KeyType { get; }

    /// <summary>
    /// The not_before_date attribute.
    /// </summary>
    [TerraformProperty("not_before_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NotBeforeDate { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Version { get; }

    /// <summary>
    /// The versioned_id attribute.
    /// </summary>
    [TerraformProperty("versioned_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VersionedId { get; }

}
