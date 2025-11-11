using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVpnServerConfigurationDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_vpn_server_configuration.
/// </summary>
public partial class AzurermVpnServerConfigurationDataSource : TerraformDataSource
{
    public AzurermVpnServerConfigurationDataSource(string name) : base("azurerm_vpn_server_configuration", name)
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
    public partial TerraformBlock<AzurermVpnServerConfigurationDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The azure_active_directory_authentication attribute.
    /// </summary>
    [TerraformProperty("azure_active_directory_authentication")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> AzureActiveDirectoryAuthentication { get; }

    /// <summary>
    /// The client_revoked_certificate attribute.
    /// </summary>
    [TerraformProperty("client_revoked_certificate")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> ClientRevokedCertificate { get; }

    /// <summary>
    /// The client_root_certificate attribute.
    /// </summary>
    [TerraformProperty("client_root_certificate")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> ClientRootCertificate { get; }

    /// <summary>
    /// The ipsec_policy attribute.
    /// </summary>
    [TerraformProperty("ipsec_policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> IpsecPolicy { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The radius attribute.
    /// </summary>
    [TerraformProperty("radius")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Radius { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The vpn_authentication_types attribute.
    /// </summary>
    [TerraformProperty("vpn_authentication_types")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> VpnAuthenticationTypes { get; }

    /// <summary>
    /// The vpn_protocols attribute.
    /// </summary>
    [TerraformProperty("vpn_protocols")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> VpnProtocols { get; }

}
