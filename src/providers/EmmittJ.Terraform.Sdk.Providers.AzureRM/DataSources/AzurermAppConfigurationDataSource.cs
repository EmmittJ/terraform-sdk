using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAppConfigurationDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_app_configuration.
/// </summary>
public partial class AzurermAppConfigurationDataSource : TerraformDataSource
{
    public AzurermAppConfigurationDataSource(string name) : base("azurerm_app_configuration", name)
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
    public AzurermAppConfigurationDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The data_plane_proxy_authentication_mode attribute.
    /// </summary>
    [TerraformProperty("data_plane_proxy_authentication_mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DataPlaneProxyAuthenticationMode { get; }

    /// <summary>
    /// The data_plane_proxy_private_link_delegation_enabled attribute.
    /// </summary>
    [TerraformProperty("data_plane_proxy_private_link_delegation_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> DataPlaneProxyPrivateLinkDelegationEnabled { get; }

    /// <summary>
    /// The encryption attribute.
    /// </summary>
    [TerraformProperty("encryption")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Encryption { get; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Identity { get; }

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    [TerraformProperty("local_auth_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> LocalAuthEnabled { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The primary_read_key attribute.
    /// </summary>
    [TerraformProperty("primary_read_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PrimaryReadKey { get; }

    /// <summary>
    /// The primary_write_key attribute.
    /// </summary>
    [TerraformProperty("primary_write_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PrimaryWriteKey { get; }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    [TerraformProperty("public_network_access")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PublicNetworkAccess { get; }

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
    /// The replica attribute.
    /// </summary>
    [TerraformProperty("replica")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Replica { get; }

    /// <summary>
    /// The secondary_read_key attribute.
    /// </summary>
    [TerraformProperty("secondary_read_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SecondaryReadKey { get; }

    /// <summary>
    /// The secondary_write_key attribute.
    /// </summary>
    [TerraformProperty("secondary_write_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SecondaryWriteKey { get; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformProperty("sku")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Sku { get; }

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

}
