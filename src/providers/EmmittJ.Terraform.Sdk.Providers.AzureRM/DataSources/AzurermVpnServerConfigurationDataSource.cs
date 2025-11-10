using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVpnServerConfigurationDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    public TerraformBlock<AzurermVpnServerConfigurationDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The azure_active_directory_authentication attribute.
    /// </summary>
    [TerraformPropertyName("azure_active_directory_authentication")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AzureActiveDirectoryAuthentication => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "azure_active_directory_authentication");

    /// <summary>
    /// The client_revoked_certificate attribute.
    /// </summary>
    [TerraformPropertyName("client_revoked_certificate")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> ClientRevokedCertificate => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "client_revoked_certificate");

    /// <summary>
    /// The client_root_certificate attribute.
    /// </summary>
    [TerraformPropertyName("client_root_certificate")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> ClientRootCertificate => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "client_root_certificate");

    /// <summary>
    /// The ipsec_policy attribute.
    /// </summary>
    [TerraformPropertyName("ipsec_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> IpsecPolicy => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "ipsec_policy");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The radius attribute.
    /// </summary>
    [TerraformPropertyName("radius")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Radius => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "radius");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The vpn_authentication_types attribute.
    /// </summary>
    [TerraformPropertyName("vpn_authentication_types")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> VpnAuthenticationTypes => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "vpn_authentication_types");

    /// <summary>
    /// The vpn_protocols attribute.
    /// </summary>
    [TerraformPropertyName("vpn_protocols")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> VpnProtocols => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "vpn_protocols");

}
