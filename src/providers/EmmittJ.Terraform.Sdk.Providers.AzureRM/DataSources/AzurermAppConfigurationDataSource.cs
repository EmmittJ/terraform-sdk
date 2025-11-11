using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppConfigurationDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    public TerraformBlock<AzurermAppConfigurationDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The data_plane_proxy_authentication_mode attribute.
    /// </summary>
    [TerraformPropertyName("data_plane_proxy_authentication_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DataPlaneProxyAuthenticationMode => new TerraformReference(this, "data_plane_proxy_authentication_mode");

    /// <summary>
    /// The data_plane_proxy_private_link_delegation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("data_plane_proxy_private_link_delegation_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DataPlaneProxyPrivateLinkDelegationEnabled => new TerraformReference(this, "data_plane_proxy_private_link_delegation_enabled");

    /// <summary>
    /// The encryption attribute.
    /// </summary>
    [TerraformPropertyName("encryption")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Encryption => new TerraformReference(this, "encryption");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Endpoint => new TerraformReference(this, "endpoint");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Identity => new TerraformReference(this, "identity");

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    [TerraformPropertyName("local_auth_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> LocalAuthEnabled => new TerraformReference(this, "local_auth_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The primary_read_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_read_key")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PrimaryReadKey => new TerraformReference(this, "primary_read_key");

    /// <summary>
    /// The primary_write_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_write_key")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PrimaryWriteKey => new TerraformReference(this, "primary_write_key");

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PublicNetworkAccess => new TerraformReference(this, "public_network_access");

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
    /// The replica attribute.
    /// </summary>
    [TerraformPropertyName("replica")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Replica => new TerraformReference(this, "replica");

    /// <summary>
    /// The secondary_read_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_read_key")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SecondaryReadKey => new TerraformReference(this, "secondary_read_key");

    /// <summary>
    /// The secondary_write_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_write_key")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SecondaryWriteKey => new TerraformReference(this, "secondary_write_key");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Sku => new TerraformReference(this, "sku");

    /// <summary>
    /// The soft_delete_retention_days attribute.
    /// </summary>
    [TerraformPropertyName("soft_delete_retention_days")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> SoftDeleteRetentionDays => new TerraformReference(this, "soft_delete_retention_days");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

}
