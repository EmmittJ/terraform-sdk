using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKeyVaultDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_key_vault.
/// </summary>
public partial class AzurermKeyVaultDataSource : TerraformDataSource
{
    public AzurermKeyVaultDataSource(string name) : base("azurerm_key_vault", name)
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
    public partial TerraformBlock<AzurermKeyVaultDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The access_policy attribute.
    /// </summary>
    [TerraformProperty("access_policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> AccessPolicy { get; }

    /// <summary>
    /// The enable_rbac_authorization attribute.
    /// </summary>
    [TerraformProperty("enable_rbac_authorization")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> EnableRbacAuthorization { get; }

    /// <summary>
    /// The enabled_for_deployment attribute.
    /// </summary>
    [TerraformProperty("enabled_for_deployment")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> EnabledForDeployment { get; }

    /// <summary>
    /// The enabled_for_disk_encryption attribute.
    /// </summary>
    [TerraformProperty("enabled_for_disk_encryption")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> EnabledForDiskEncryption { get; }

    /// <summary>
    /// The enabled_for_template_deployment attribute.
    /// </summary>
    [TerraformProperty("enabled_for_template_deployment")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> EnabledForTemplateDeployment { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The network_acls attribute.
    /// </summary>
    [TerraformProperty("network_acls")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> NetworkAcls { get; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> PublicNetworkAccessEnabled { get; }

    /// <summary>
    /// The purge_protection_enabled attribute.
    /// </summary>
    [TerraformProperty("purge_protection_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> PurgeProtectionEnabled { get; }

    /// <summary>
    /// The rbac_authorization_enabled attribute.
    /// </summary>
    [TerraformProperty("rbac_authorization_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> RbacAuthorizationEnabled { get; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformProperty("sku_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SkuName { get; }

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

    /// <summary>
    /// The vault_uri attribute.
    /// </summary>
    [TerraformProperty("vault_uri")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VaultUri { get; }

}
