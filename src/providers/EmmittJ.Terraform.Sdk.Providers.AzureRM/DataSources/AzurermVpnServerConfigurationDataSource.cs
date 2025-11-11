using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVpnServerConfigurationDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_vpn_server_configuration.
/// </summary>
public class AzurermVpnServerConfigurationDataSource : TerraformDataSource
{
    public AzurermVpnServerConfigurationDataSource(string name) : base("azurerm_vpn_server_configuration", name)
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
    public TerraformBlock<AzurermVpnServerConfigurationDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The azure_active_directory_authentication attribute.
    /// </summary>
    [TerraformPropertyName("azure_active_directory_authentication")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AzureActiveDirectoryAuthentication => new TerraformReference(this, "azure_active_directory_authentication");

    /// <summary>
    /// The client_revoked_certificate attribute.
    /// </summary>
    [TerraformPropertyName("client_revoked_certificate")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> ClientRevokedCertificate => new TerraformReference(this, "client_revoked_certificate");

    /// <summary>
    /// The client_root_certificate attribute.
    /// </summary>
    [TerraformPropertyName("client_root_certificate")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> ClientRootCertificate => new TerraformReference(this, "client_root_certificate");

    /// <summary>
    /// The ipsec_policy attribute.
    /// </summary>
    [TerraformPropertyName("ipsec_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> IpsecPolicy => new TerraformReference(this, "ipsec_policy");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The radius attribute.
    /// </summary>
    [TerraformPropertyName("radius")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Radius => new TerraformReference(this, "radius");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The vpn_authentication_types attribute.
    /// </summary>
    [TerraformPropertyName("vpn_authentication_types")]
    // Output-only attribute - read-only reference
    public TerraformList<string> VpnAuthenticationTypes => new TerraformReference(this, "vpn_authentication_types");

    /// <summary>
    /// The vpn_protocols attribute.
    /// </summary>
    [TerraformPropertyName("vpn_protocols")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> VpnProtocols => new TerraformReference(this, "vpn_protocols");

}
