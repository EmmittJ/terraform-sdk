using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppConfigurationDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_app_configuration.
/// </summary>
public class AzurermAppConfigurationDataSource : TerraformDataSource
{
    public AzurermAppConfigurationDataSource(string name) : base("azurerm_app_configuration", name)
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
    public TerraformBlock<AzurermAppConfigurationDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The data_plane_proxy_authentication_mode attribute.
    /// </summary>
    [TerraformPropertyName("data_plane_proxy_authentication_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DataPlaneProxyAuthenticationMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "data_plane_proxy_authentication_mode");

    /// <summary>
    /// The data_plane_proxy_private_link_delegation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("data_plane_proxy_private_link_delegation_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DataPlaneProxyPrivateLinkDelegationEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "data_plane_proxy_private_link_delegation_enabled");

    /// <summary>
    /// The encryption attribute.
    /// </summary>
    [TerraformPropertyName("encryption")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Encryption => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "encryption");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Endpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Identity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "identity");

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    [TerraformPropertyName("local_auth_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> LocalAuthEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "local_auth_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The primary_read_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_read_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PrimaryReadKey => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "primary_read_key");

    /// <summary>
    /// The primary_write_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_write_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PrimaryWriteKey => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "primary_write_key");

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublicNetworkAccess => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_network_access");

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
    /// The replica attribute.
    /// </summary>
    [TerraformPropertyName("replica")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Replica => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "replica");

    /// <summary>
    /// The secondary_read_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_read_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SecondaryReadKey => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "secondary_read_key");

    /// <summary>
    /// The secondary_write_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_write_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SecondaryWriteKey => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "secondary_write_key");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Sku => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sku");

    /// <summary>
    /// The soft_delete_retention_days attribute.
    /// </summary>
    [TerraformPropertyName("soft_delete_retention_days")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> SoftDeleteRetentionDays => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "soft_delete_retention_days");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

}
