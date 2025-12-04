using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for azure_active_directory_authentication in AzurermVpnServerConfiguration.
/// Nesting mode: list
/// </summary>
public class AzurermVpnServerConfigurationAzureActiveDirectoryAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_active_directory_authentication";

    /// <summary>
    /// The audience attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Audience is required")]
    public required TerraformValue<string> Audience
    {
        get => GetRequiredArgument<TerraformValue<string>>("audience");
        set => SetArgument("audience", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    public required TerraformValue<string> Issuer
    {
        get => GetRequiredArgument<TerraformValue<string>>("issuer");
        set => SetArgument("issuer", value);
    }

    /// <summary>
    /// The tenant attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tenant is required")]
    public required TerraformValue<string> Tenant
    {
        get => GetRequiredArgument<TerraformValue<string>>("tenant");
        set => SetArgument("tenant", value);
    }

}


/// <summary>
/// Block type for client_revoked_certificate in AzurermVpnServerConfiguration.
/// Nesting mode: set
/// </summary>
public class AzurermVpnServerConfigurationClientRevokedCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_revoked_certificate";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Thumbprint is required")]
    public required TerraformValue<string> Thumbprint
    {
        get => GetRequiredArgument<TerraformValue<string>>("thumbprint");
        set => SetArgument("thumbprint", value);
    }

}


/// <summary>
/// Block type for client_root_certificate in AzurermVpnServerConfiguration.
/// Nesting mode: set
/// </summary>
public class AzurermVpnServerConfigurationClientRootCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_root_certificate";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The public_cert_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicCertData is required")]
    public required TerraformValue<string> PublicCertData
    {
        get => GetRequiredArgument<TerraformValue<string>>("public_cert_data");
        set => SetArgument("public_cert_data", value);
    }

}


/// <summary>
/// Block type for ipsec_policy in AzurermVpnServerConfiguration.
/// Nesting mode: list
/// </summary>
public class AzurermVpnServerConfigurationIpsecPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ipsec_policy";

    /// <summary>
    /// The dh_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DhGroup is required")]
    public required TerraformValue<string> DhGroup
    {
        get => GetRequiredArgument<TerraformValue<string>>("dh_group");
        set => SetArgument("dh_group", value);
    }

    /// <summary>
    /// The ike_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IkeEncryption is required")]
    public required TerraformValue<string> IkeEncryption
    {
        get => GetRequiredArgument<TerraformValue<string>>("ike_encryption");
        set => SetArgument("ike_encryption", value);
    }

    /// <summary>
    /// The ike_integrity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IkeIntegrity is required")]
    public required TerraformValue<string> IkeIntegrity
    {
        get => GetRequiredArgument<TerraformValue<string>>("ike_integrity");
        set => SetArgument("ike_integrity", value);
    }

    /// <summary>
    /// The ipsec_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpsecEncryption is required")]
    public required TerraformValue<string> IpsecEncryption
    {
        get => GetRequiredArgument<TerraformValue<string>>("ipsec_encryption");
        set => SetArgument("ipsec_encryption", value);
    }

    /// <summary>
    /// The ipsec_integrity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpsecIntegrity is required")]
    public required TerraformValue<string> IpsecIntegrity
    {
        get => GetRequiredArgument<TerraformValue<string>>("ipsec_integrity");
        set => SetArgument("ipsec_integrity", value);
    }

    /// <summary>
    /// The pfs_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PfsGroup is required")]
    public required TerraformValue<string> PfsGroup
    {
        get => GetRequiredArgument<TerraformValue<string>>("pfs_group");
        set => SetArgument("pfs_group", value);
    }

    /// <summary>
    /// The sa_data_size_kilobytes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SaDataSizeKilobytes is required")]
    public required TerraformValue<double> SaDataSizeKilobytes
    {
        get => GetRequiredArgument<TerraformValue<double>>("sa_data_size_kilobytes");
        set => SetArgument("sa_data_size_kilobytes", value);
    }

    /// <summary>
    /// The sa_lifetime_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SaLifetimeSeconds is required")]
    public required TerraformValue<double> SaLifetimeSeconds
    {
        get => GetRequiredArgument<TerraformValue<double>>("sa_lifetime_seconds");
        set => SetArgument("sa_lifetime_seconds", value);
    }

}


/// <summary>
/// Block type for radius in AzurermVpnServerConfiguration.
/// Nesting mode: list
/// </summary>
public class AzurermVpnServerConfigurationRadiusBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "radius";

    /// <summary>
    /// ClientRootCertificate block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermVpnServerConfigurationRadiusBlockClientRootCertificateBlock>? ClientRootCertificate
    {
        get => GetArgument<TerraformSet<AzurermVpnServerConfigurationRadiusBlockClientRootCertificateBlock>>("client_root_certificate");
        set => SetArgument("client_root_certificate", value);
    }

    /// <summary>
    /// Server block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermVpnServerConfigurationRadiusBlockServerBlock>? Server
    {
        get => GetArgument<TerraformList<AzurermVpnServerConfigurationRadiusBlockServerBlock>>("server");
        set => SetArgument("server", value);
    }

    /// <summary>
    /// ServerRootCertificate block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermVpnServerConfigurationRadiusBlockServerRootCertificateBlock>? ServerRootCertificate
    {
        get => GetArgument<TerraformSet<AzurermVpnServerConfigurationRadiusBlockServerRootCertificateBlock>>("server_root_certificate");
        set => SetArgument("server_root_certificate", value);
    }

}

/// <summary>
/// Block type for client_root_certificate in AzurermVpnServerConfigurationRadiusBlock.
/// Nesting mode: set
/// </summary>
public class AzurermVpnServerConfigurationRadiusBlockClientRootCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_root_certificate";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Thumbprint is required")]
    public required TerraformValue<string> Thumbprint
    {
        get => GetRequiredArgument<TerraformValue<string>>("thumbprint");
        set => SetArgument("thumbprint", value);
    }

}

/// <summary>
/// Block type for server in AzurermVpnServerConfigurationRadiusBlock.
/// Nesting mode: list
/// </summary>
public class AzurermVpnServerConfigurationRadiusBlockServerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "server";

    /// <summary>
    /// The address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Address is required")]
    public required TerraformValue<string> Address
    {
        get => GetRequiredArgument<TerraformValue<string>>("address");
        set => SetArgument("address", value);
    }

    /// <summary>
    /// The score attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Score is required")]
    public required TerraformValue<double> Score
    {
        get => GetRequiredArgument<TerraformValue<double>>("score");
        set => SetArgument("score", value);
    }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    public required TerraformValue<string> Secret
    {
        get => GetRequiredArgument<TerraformValue<string>>("secret");
        set => SetArgument("secret", value);
    }

}

/// <summary>
/// Block type for server_root_certificate in AzurermVpnServerConfigurationRadiusBlock.
/// Nesting mode: set
/// </summary>
public class AzurermVpnServerConfigurationRadiusBlockServerRootCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "server_root_certificate";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The public_cert_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicCertData is required")]
    public required TerraformValue<string> PublicCertData
    {
        get => GetRequiredArgument<TerraformValue<string>>("public_cert_data");
        set => SetArgument("public_cert_data", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermVpnServerConfiguration.
/// Nesting mode: single
/// </summary>
public class AzurermVpnServerConfigurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_vpn_server_configuration Terraform resource.
/// Manages a azurerm_vpn_server_configuration resource.
/// </summary>
public partial class AzurermVpnServerConfiguration(string name) : TerraformResource("azurerm_vpn_server_configuration", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The vpn_authentication_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnAuthenticationTypes is required")]
    public TerraformList<string>? VpnAuthenticationTypes
    {
        get => GetArgument<TerraformList<string>>("vpn_authentication_types");
        set => SetArgument("vpn_authentication_types", value);
    }

    /// <summary>
    /// The vpn_protocols attribute.
    /// </summary>
    public TerraformSet<string> VpnProtocols
    {
        get => GetArgument<TerraformSet<string>>("vpn_protocols") ?? AsReference("vpn_protocols");
        set => SetArgument("vpn_protocols", value);
    }

    /// <summary>
    /// AzureActiveDirectoryAuthentication block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermVpnServerConfigurationAzureActiveDirectoryAuthenticationBlock>? AzureActiveDirectoryAuthentication
    {
        get => GetArgument<TerraformList<AzurermVpnServerConfigurationAzureActiveDirectoryAuthenticationBlock>>("azure_active_directory_authentication");
        set => SetArgument("azure_active_directory_authentication", value);
    }

    /// <summary>
    /// ClientRevokedCertificate block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermVpnServerConfigurationClientRevokedCertificateBlock>? ClientRevokedCertificate
    {
        get => GetArgument<TerraformSet<AzurermVpnServerConfigurationClientRevokedCertificateBlock>>("client_revoked_certificate");
        set => SetArgument("client_revoked_certificate", value);
    }

    /// <summary>
    /// ClientRootCertificate block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermVpnServerConfigurationClientRootCertificateBlock>? ClientRootCertificate
    {
        get => GetArgument<TerraformSet<AzurermVpnServerConfigurationClientRootCertificateBlock>>("client_root_certificate");
        set => SetArgument("client_root_certificate", value);
    }

    /// <summary>
    /// IpsecPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpsecPolicy block(s) allowed")]
    public TerraformList<AzurermVpnServerConfigurationIpsecPolicyBlock>? IpsecPolicy
    {
        get => GetArgument<TerraformList<AzurermVpnServerConfigurationIpsecPolicyBlock>>("ipsec_policy");
        set => SetArgument("ipsec_policy", value);
    }

    /// <summary>
    /// Radius block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Radius block(s) allowed")]
    public TerraformList<AzurermVpnServerConfigurationRadiusBlock>? Radius
    {
        get => GetArgument<TerraformList<AzurermVpnServerConfigurationRadiusBlock>>("radius");
        set => SetArgument("radius", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVpnServerConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVpnServerConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
