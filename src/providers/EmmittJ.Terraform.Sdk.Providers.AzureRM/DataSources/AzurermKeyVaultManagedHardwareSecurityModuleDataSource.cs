using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKeyVaultManagedHardwareSecurityModuleDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_key_vault_managed_hardware_security_module.
/// </summary>
public partial class AzurermKeyVaultManagedHardwareSecurityModuleDataSource : TerraformDataSource
{
    public AzurermKeyVaultManagedHardwareSecurityModuleDataSource(string name) : base("azurerm_key_vault_managed_hardware_security_module", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermKeyVaultManagedHardwareSecurityModuleDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The admin_object_ids attribute.
    /// </summary>
    [TerraformProperty("admin_object_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> AdminObjectIds { get; }

    /// <summary>
    /// The hsm_uri attribute.
    /// </summary>
    [TerraformProperty("hsm_uri")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HsmUri { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The purge_protection_enabled attribute.
    /// </summary>
    [TerraformProperty("purge_protection_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> PurgeProtectionEnabled { get; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformProperty("sku_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SkuName { get; }

    /// <summary>
    /// The soft_delete_retention_days attribute.
    /// </summary>
    [TerraformProperty("soft_delete_retention_days")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> SoftDeleteRetentionDays { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformProperty("tenant_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TenantId { get; }

}
