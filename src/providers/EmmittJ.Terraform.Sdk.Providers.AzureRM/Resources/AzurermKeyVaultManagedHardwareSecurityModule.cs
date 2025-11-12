using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for network_acls in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKeyVaultManagedHardwareSecurityModuleNetworkAclsBlock() : TerraformBlock("network_acls")
{
    /// <summary>
    /// The bypass attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bypass is required")]
    [TerraformProperty("bypass")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Bypass { get; set; }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    [TerraformProperty("default_action")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DefaultAction { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKeyVaultManagedHardwareSecurityModuleTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_key_vault_managed_hardware_security_module resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermKeyVaultManagedHardwareSecurityModule : TerraformResource
{
    public AzurermKeyVaultManagedHardwareSecurityModule(string name) : base("azurerm_key_vault_managed_hardware_security_module", name)
    {
    }

    /// <summary>
    /// The admin_object_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminObjectIds is required")]
    [TerraformProperty("admin_object_ids")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> AdminObjectIds { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The purge_protection_enabled attribute.
    /// </summary>
    [TerraformProperty("purge_protection_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PurgeProtectionEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The security_domain_key_vault_certificate_ids attribute.
    /// </summary>
    [TerraformProperty("security_domain_key_vault_certificate_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? SecurityDomainKeyVaultCertificateIds { get; set; }

    /// <summary>
    /// The security_domain_quorum attribute.
    /// </summary>
    [TerraformProperty("security_domain_quorum")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SecurityDomainQuorum { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformProperty("sku_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SkuName { get; set; }

    /// <summary>
    /// The soft_delete_retention_days attribute.
    /// </summary>
    [TerraformProperty("soft_delete_retention_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SoftDeleteRetentionDays { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    [TerraformProperty("tenant_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TenantId { get; set; }

    /// <summary>
    /// Block for network_acls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkAcls block(s) allowed")]
    [TerraformProperty("network_acls")]
    public TerraformList<AzurermKeyVaultManagedHardwareSecurityModuleNetworkAclsBlock> NetworkAcls { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermKeyVaultManagedHardwareSecurityModuleTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The hsm_uri attribute.
    /// </summary>
    [TerraformProperty("hsm_uri")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HsmUri { get; }

    /// <summary>
    /// The security_domain_encrypted_data attribute.
    /// </summary>
    [TerraformProperty("security_domain_encrypted_data")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecurityDomainEncryptedData { get; }

}
