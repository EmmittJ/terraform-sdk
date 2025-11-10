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
        set => SetProperty("audience", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    public required TerraformProperty<string> Issuer
    {
        set => SetProperty("issuer", value);
    }

    /// <summary>
    /// The tenant attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tenant is required")]
    public required TerraformProperty<string> Tenant
    {
        set => SetProperty("tenant", value);
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
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Thumbprint is required")]
    public required TerraformProperty<string> Thumbprint
    {
        set => SetProperty("thumbprint", value);
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
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The public_cert_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicCertData is required")]
    public required TerraformProperty<string> PublicCertData
    {
        set => SetProperty("public_cert_data", value);
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
        set => SetProperty("dh_group", value);
    }

    /// <summary>
    /// The ike_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IkeEncryption is required")]
    public required TerraformProperty<string> IkeEncryption
    {
        set => SetProperty("ike_encryption", value);
    }

    /// <summary>
    /// The ike_integrity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IkeIntegrity is required")]
    public required TerraformProperty<string> IkeIntegrity
    {
        set => SetProperty("ike_integrity", value);
    }

    /// <summary>
    /// The ipsec_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpsecEncryption is required")]
    public required TerraformProperty<string> IpsecEncryption
    {
        set => SetProperty("ipsec_encryption", value);
    }

    /// <summary>
    /// The ipsec_integrity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpsecIntegrity is required")]
    public required TerraformProperty<string> IpsecIntegrity
    {
        set => SetProperty("ipsec_integrity", value);
    }

    /// <summary>
    /// The pfs_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PfsGroup is required")]
    public required TerraformProperty<string> PfsGroup
    {
        set => SetProperty("pfs_group", value);
    }

    /// <summary>
    /// The sa_data_size_kilobytes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SaDataSizeKilobytes is required")]
    public required TerraformProperty<double> SaDataSizeKilobytes
    {
        set => SetProperty("sa_data_size_kilobytes", value);
    }

    /// <summary>
    /// The sa_lifetime_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SaLifetimeSeconds is required")]
    public required TerraformProperty<double> SaLifetimeSeconds
    {
        set => SetProperty("sa_lifetime_seconds", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_vpn_server_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermVpnServerConfiguration : TerraformResource
{
    public AzurermVpnServerConfiguration(string name) : base("azurerm_vpn_server_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("tags");
        SetOutput("vpn_authentication_types");
        SetOutput("vpn_protocols");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The vpn_authentication_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnAuthenticationTypes is required")]
    public List<TerraformProperty<string>> VpnAuthenticationTypes
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("vpn_authentication_types");
        set => SetProperty("vpn_authentication_types", value);
    }

    /// <summary>
    /// The vpn_protocols attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> VpnProtocols
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("vpn_protocols");
        set => SetProperty("vpn_protocols", value);
    }

    /// <summary>
    /// Block for azure_active_directory_authentication.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermVpnServerConfigurationAzureActiveDirectoryAuthenticationBlock>? AzureActiveDirectoryAuthentication
    {
        set => SetProperty("azure_active_directory_authentication", value);
    }

    /// <summary>
    /// Block for client_revoked_certificate.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermVpnServerConfigurationClientRevokedCertificateBlock>? ClientRevokedCertificate
    {
        set => SetProperty("client_revoked_certificate", value);
    }

    /// <summary>
    /// Block for client_root_certificate.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermVpnServerConfigurationClientRootCertificateBlock>? ClientRootCertificate
    {
        set => SetProperty("client_root_certificate", value);
    }

    /// <summary>
    /// Block for ipsec_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpsecPolicy block(s) allowed")]
    public List<AzurermVpnServerConfigurationIpsecPolicyBlock>? IpsecPolicy
    {
        set => SetProperty("ipsec_policy", value);
    }

    /// <summary>
    /// Block for radius.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Radius block(s) allowed")]
    public List<AzurermVpnServerConfigurationRadiusBlock>? Radius
    {
        set => SetProperty("radius", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVpnServerConfigurationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
