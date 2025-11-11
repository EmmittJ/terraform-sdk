using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_key_vault.
/// </summary>
public class AzurermKeyVaultDataSource : TerraformDataSource
{
    public AzurermKeyVaultDataSource(string name) : base("azurerm_key_vault", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKeyVaultDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The access_policy attribute.
    /// </summary>
    [TerraformPropertyName("access_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AccessPolicy => new TerraformReference(this, "access_policy");

    /// <summary>
    /// The enable_rbac_authorization attribute.
    /// </summary>
    [TerraformPropertyName("enable_rbac_authorization")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableRbacAuthorization => new TerraformReference(this, "enable_rbac_authorization");

    /// <summary>
    /// The enabled_for_deployment attribute.
    /// </summary>
    [TerraformPropertyName("enabled_for_deployment")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnabledForDeployment => new TerraformReference(this, "enabled_for_deployment");

    /// <summary>
    /// The enabled_for_disk_encryption attribute.
    /// </summary>
    [TerraformPropertyName("enabled_for_disk_encryption")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnabledForDiskEncryption => new TerraformReference(this, "enabled_for_disk_encryption");

    /// <summary>
    /// The enabled_for_template_deployment attribute.
    /// </summary>
    [TerraformPropertyName("enabled_for_template_deployment")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnabledForTemplateDeployment => new TerraformReference(this, "enabled_for_template_deployment");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The network_acls attribute.
    /// </summary>
    [TerraformPropertyName("network_acls")]
    // Output-only attribute - read-only reference
    public TerraformList<object> NetworkAcls => new TerraformReference(this, "network_acls");

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> PublicNetworkAccessEnabled => new TerraformReference(this, "public_network_access_enabled");

    /// <summary>
    /// The purge_protection_enabled attribute.
    /// </summary>
    [TerraformPropertyName("purge_protection_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> PurgeProtectionEnabled => new TerraformReference(this, "purge_protection_enabled");

    /// <summary>
    /// The rbac_authorization_enabled attribute.
    /// </summary>
    [TerraformPropertyName("rbac_authorization_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> RbacAuthorizationEnabled => new TerraformReference(this, "rbac_authorization_enabled");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformPropertyName("sku_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SkuName => new TerraformReference(this, "sku_name");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TenantId => new TerraformReference(this, "tenant_id");

    /// <summary>
    /// The vault_uri attribute.
    /// </summary>
    [TerraformPropertyName("vault_uri")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VaultUri => new TerraformReference(this, "vault_uri");

}
