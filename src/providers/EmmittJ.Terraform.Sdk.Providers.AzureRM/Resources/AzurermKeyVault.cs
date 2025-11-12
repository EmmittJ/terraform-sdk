using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for contact in .
/// Nesting mode: set
/// </summary>
[Obsolete("This block is deprecated.")]
public partial class AzurermKeyVaultContactBlock() : TerraformBlock("contact")
{
    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    [TerraformProperty("email")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Email { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The phone attribute.
    /// </summary>
    [TerraformProperty("phone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Phone { get; set; }

}

/// <summary>
/// Block type for network_acls in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKeyVaultNetworkAclsBlock() : TerraformBlock("network_acls")
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

    /// <summary>
    /// The ip_rules attribute.
    /// </summary>
    [TerraformProperty("ip_rules")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IpRules { get; set; }

    /// <summary>
    /// The virtual_network_subnet_ids attribute.
    /// </summary>
    [TerraformProperty("virtual_network_subnet_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? VirtualNetworkSubnetIds { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKeyVaultTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_key_vault resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermKeyVault : TerraformResource
{
    public AzurermKeyVault(string name) : base("azurerm_key_vault", name)
    {
    }

    /// <summary>
    /// The access_policy attribute.
    /// </summary>
    [TerraformProperty("access_policy")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<object> AccessPolicy { get; set; }

    /// <summary>
    /// The enable_rbac_authorization attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("enable_rbac_authorization")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> EnableRbacAuthorization { get; set; }

    /// <summary>
    /// The enabled_for_deployment attribute.
    /// </summary>
    [TerraformProperty("enabled_for_deployment")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnabledForDeployment { get; set; }

    /// <summary>
    /// The enabled_for_disk_encryption attribute.
    /// </summary>
    [TerraformProperty("enabled_for_disk_encryption")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnabledForDiskEncryption { get; set; }

    /// <summary>
    /// The enabled_for_template_deployment attribute.
    /// </summary>
    [TerraformProperty("enabled_for_template_deployment")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnabledForTemplateDeployment { get; set; }

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
    /// The rbac_authorization_enabled attribute.
    /// </summary>
    [TerraformProperty("rbac_authorization_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> RbacAuthorizationEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

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
    /// Block for contact.
    /// Nesting mode: set
    /// </summary>
    [Obsolete("This block is deprecated.")]
    [TerraformProperty("contact")]
    public TerraformSet<AzurermKeyVaultContactBlock> Contact { get; set; } = new();

    /// <summary>
    /// Block for network_acls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkAcls block(s) allowed")]
    [TerraformProperty("network_acls")]
    public TerraformList<AzurermKeyVaultNetworkAclsBlock> NetworkAcls { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermKeyVaultTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The vault_uri attribute.
    /// </summary>
    [TerraformProperty("vault_uri")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VaultUri { get; }

}
