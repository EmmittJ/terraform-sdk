using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKeyVaultDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The access_policy attribute.
    /// </summary>
    [TerraformPropertyName("access_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AccessPolicy => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "access_policy");

    /// <summary>
    /// The enable_rbac_authorization attribute.
    /// </summary>
    [TerraformPropertyName("enable_rbac_authorization")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableRbacAuthorization => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_rbac_authorization");

    /// <summary>
    /// The enabled_for_deployment attribute.
    /// </summary>
    [TerraformPropertyName("enabled_for_deployment")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnabledForDeployment => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enabled_for_deployment");

    /// <summary>
    /// The enabled_for_disk_encryption attribute.
    /// </summary>
    [TerraformPropertyName("enabled_for_disk_encryption")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnabledForDiskEncryption => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enabled_for_disk_encryption");

    /// <summary>
    /// The enabled_for_template_deployment attribute.
    /// </summary>
    [TerraformPropertyName("enabled_for_template_deployment")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnabledForTemplateDeployment => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enabled_for_template_deployment");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The network_acls attribute.
    /// </summary>
    [TerraformPropertyName("network_acls")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> NetworkAcls => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "network_acls");

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PublicNetworkAccessEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "public_network_access_enabled");

    /// <summary>
    /// The purge_protection_enabled attribute.
    /// </summary>
    [TerraformPropertyName("purge_protection_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PurgeProtectionEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "purge_protection_enabled");

    /// <summary>
    /// The rbac_authorization_enabled attribute.
    /// </summary>
    [TerraformPropertyName("rbac_authorization_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> RbacAuthorizationEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "rbac_authorization_enabled");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformPropertyName("sku_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SkuName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sku_name");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tenant_id");

    /// <summary>
    /// The vault_uri attribute.
    /// </summary>
    [TerraformPropertyName("vault_uri")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VaultUri => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vault_uri");

}
