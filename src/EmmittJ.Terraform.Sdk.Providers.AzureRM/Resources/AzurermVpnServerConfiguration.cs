using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azure_active_directory_authentication in .
/// Nesting mode: list
/// </summary>
public class AzurermVpnServerConfigurationAzureActiveDirectoryAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// The audience attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Audience is required")]
    public required TerraformProperty<string> Audience
    {
        get => GetProperty<TerraformProperty<string>>("audience");
        set => WithProperty("audience", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    public required TerraformProperty<string> Issuer
    {
        get => GetProperty<TerraformProperty<string>>("issuer");
        set => WithProperty("issuer", value);
    }

    /// <summary>
    /// The tenant attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tenant is required")]
    public required TerraformProperty<string> Tenant
    {
        get => GetProperty<TerraformProperty<string>>("tenant");
        set => WithProperty("tenant", value);
    }

}

/// <summary>
/// Block type for client_revoked_certificate in .
/// Nesting mode: set
/// </summary>
public class AzurermVpnServerConfigurationClientRevokedCertificateBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Thumbprint is required")]
    public required TerraformProperty<string> Thumbprint
    {
        get => GetProperty<TerraformProperty<string>>("thumbprint");
        set => WithProperty("thumbprint", value);
    }

}

/// <summary>
/// Block type for client_root_certificate in .
/// Nesting mode: set
/// </summary>
public class AzurermVpnServerConfigurationClientRootCertificateBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The public_cert_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicCertData is required")]
    public required TerraformProperty<string> PublicCertData
    {
        get => GetProperty<TerraformProperty<string>>("public_cert_data");
        set => WithProperty("public_cert_data", value);
    }

}

/// <summary>
/// Block type for ipsec_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermVpnServerConfigurationIpsecPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The dh_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DhGroup is required")]
    public required TerraformProperty<string> DhGroup
    {
        get => GetProperty<TerraformProperty<string>>("dh_group");
        set => WithProperty("dh_group", value);
    }

    /// <summary>
    /// The ike_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IkeEncryption is required")]
    public required TerraformProperty<string> IkeEncryption
    {
        get => GetProperty<TerraformProperty<string>>("ike_encryption");
        set => WithProperty("ike_encryption", value);
    }

    /// <summary>
    /// The ike_integrity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IkeIntegrity is required")]
    public required TerraformProperty<string> IkeIntegrity
    {
        get => GetProperty<TerraformProperty<string>>("ike_integrity");
        set => WithProperty("ike_integrity", value);
    }

    /// <summary>
    /// The ipsec_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpsecEncryption is required")]
    public required TerraformProperty<string> IpsecEncryption
    {
        get => GetProperty<TerraformProperty<string>>("ipsec_encryption");
        set => WithProperty("ipsec_encryption", value);
    }

    /// <summary>
    /// The ipsec_integrity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpsecIntegrity is required")]
    public required TerraformProperty<string> IpsecIntegrity
    {
        get => GetProperty<TerraformProperty<string>>("ipsec_integrity");
        set => WithProperty("ipsec_integrity", value);
    }

    /// <summary>
    /// The pfs_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PfsGroup is required")]
    public required TerraformProperty<string> PfsGroup
    {
        get => GetProperty<TerraformProperty<string>>("pfs_group");
        set => WithProperty("pfs_group", value);
    }

    /// <summary>
    /// The sa_data_size_kilobytes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SaDataSizeKilobytes is required")]
    public required TerraformProperty<double> SaDataSizeKilobytes
    {
        get => GetProperty<TerraformProperty<double>>("sa_data_size_kilobytes");
        set => WithProperty("sa_data_size_kilobytes", value);
    }

    /// <summary>
    /// The sa_lifetime_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SaLifetimeSeconds is required")]
    public required TerraformProperty<double> SaLifetimeSeconds
    {
        get => GetProperty<TerraformProperty<double>>("sa_lifetime_seconds");
        set => WithProperty("sa_lifetime_seconds", value);
    }

}

/// <summary>
/// Block type for radius in .
/// Nesting mode: list
/// </summary>
public class AzurermVpnServerConfigurationRadiusBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVpnServerConfigurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_vpn_server_configuration resource.
/// </summary>
public class AzurermVpnServerConfiguration : TerraformResource
{
    public AzurermVpnServerConfiguration(string name) : base("azurerm_vpn_server_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The vpn_authentication_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnAuthenticationTypes is required")]
    public List<TerraformProperty<string>>? VpnAuthenticationTypes
    {
        get => GetProperty<List<TerraformProperty<string>>>("vpn_authentication_types");
        set => this.WithProperty("vpn_authentication_types", value);
    }

    /// <summary>
    /// The vpn_protocols attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? VpnProtocols
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("vpn_protocols");
        set => this.WithProperty("vpn_protocols", value);
    }

    /// <summary>
    /// Block for azure_active_directory_authentication.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermVpnServerConfigurationAzureActiveDirectoryAuthenticationBlock>? AzureActiveDirectoryAuthentication
    {
        get => GetProperty<List<AzurermVpnServerConfigurationAzureActiveDirectoryAuthenticationBlock>>("azure_active_directory_authentication");
        set => this.WithProperty("azure_active_directory_authentication", value);
    }

    /// <summary>
    /// Block for client_revoked_certificate.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermVpnServerConfigurationClientRevokedCertificateBlock>? ClientRevokedCertificate
    {
        get => GetProperty<HashSet<AzurermVpnServerConfigurationClientRevokedCertificateBlock>>("client_revoked_certificate");
        set => this.WithProperty("client_revoked_certificate", value);
    }

    /// <summary>
    /// Block for client_root_certificate.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermVpnServerConfigurationClientRootCertificateBlock>? ClientRootCertificate
    {
        get => GetProperty<HashSet<AzurermVpnServerConfigurationClientRootCertificateBlock>>("client_root_certificate");
        set => this.WithProperty("client_root_certificate", value);
    }

    /// <summary>
    /// Block for ipsec_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpsecPolicy block(s) allowed")]
    public List<AzurermVpnServerConfigurationIpsecPolicyBlock>? IpsecPolicy
    {
        get => GetProperty<List<AzurermVpnServerConfigurationIpsecPolicyBlock>>("ipsec_policy");
        set => this.WithProperty("ipsec_policy", value);
    }

    /// <summary>
    /// Block for radius.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Radius block(s) allowed")]
    public List<AzurermVpnServerConfigurationRadiusBlock>? Radius
    {
        get => GetProperty<List<AzurermVpnServerConfigurationRadiusBlock>>("radius");
        set => this.WithProperty("radius", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVpnServerConfigurationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermVpnServerConfigurationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
