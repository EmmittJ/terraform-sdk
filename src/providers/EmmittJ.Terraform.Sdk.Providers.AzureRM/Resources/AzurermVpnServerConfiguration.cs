using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for azure_active_directory_authentication in .
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
    [TerraformArgument("audience")]
    public required TerraformValue<string> Audience
    {
        get => new TerraformReference<string>(this, "audience");
        set => SetArgument("audience", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    [TerraformArgument("issuer")]
    public required TerraformValue<string> Issuer
    {
        get => new TerraformReference<string>(this, "issuer");
        set => SetArgument("issuer", value);
    }

    /// <summary>
    /// The tenant attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tenant is required")]
    [TerraformArgument("tenant")]
    public required TerraformValue<string> Tenant
    {
        get => new TerraformReference<string>(this, "tenant");
        set => SetArgument("tenant", value);
    }

}

/// <summary>
/// Block type for client_revoked_certificate in .
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
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Thumbprint is required")]
    [TerraformArgument("thumbprint")]
    public required TerraformValue<string> Thumbprint
    {
        get => new TerraformReference<string>(this, "thumbprint");
        set => SetArgument("thumbprint", value);
    }

}

/// <summary>
/// Block type for client_root_certificate in .
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
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The public_cert_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicCertData is required")]
    [TerraformArgument("public_cert_data")]
    public required TerraformValue<string> PublicCertData
    {
        get => new TerraformReference<string>(this, "public_cert_data");
        set => SetArgument("public_cert_data", value);
    }

}

/// <summary>
/// Block type for ipsec_policy in .
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
    [TerraformArgument("dh_group")]
    public required TerraformValue<string> DhGroup
    {
        get => new TerraformReference<string>(this, "dh_group");
        set => SetArgument("dh_group", value);
    }

    /// <summary>
    /// The ike_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IkeEncryption is required")]
    [TerraformArgument("ike_encryption")]
    public required TerraformValue<string> IkeEncryption
    {
        get => new TerraformReference<string>(this, "ike_encryption");
        set => SetArgument("ike_encryption", value);
    }

    /// <summary>
    /// The ike_integrity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IkeIntegrity is required")]
    [TerraformArgument("ike_integrity")]
    public required TerraformValue<string> IkeIntegrity
    {
        get => new TerraformReference<string>(this, "ike_integrity");
        set => SetArgument("ike_integrity", value);
    }

    /// <summary>
    /// The ipsec_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpsecEncryption is required")]
    [TerraformArgument("ipsec_encryption")]
    public required TerraformValue<string> IpsecEncryption
    {
        get => new TerraformReference<string>(this, "ipsec_encryption");
        set => SetArgument("ipsec_encryption", value);
    }

    /// <summary>
    /// The ipsec_integrity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpsecIntegrity is required")]
    [TerraformArgument("ipsec_integrity")]
    public required TerraformValue<string> IpsecIntegrity
    {
        get => new TerraformReference<string>(this, "ipsec_integrity");
        set => SetArgument("ipsec_integrity", value);
    }

    /// <summary>
    /// The pfs_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PfsGroup is required")]
    [TerraformArgument("pfs_group")]
    public required TerraformValue<string> PfsGroup
    {
        get => new TerraformReference<string>(this, "pfs_group");
        set => SetArgument("pfs_group", value);
    }

    /// <summary>
    /// The sa_data_size_kilobytes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SaDataSizeKilobytes is required")]
    [TerraformArgument("sa_data_size_kilobytes")]
    public required TerraformValue<double> SaDataSizeKilobytes
    {
        get => new TerraformReference<double>(this, "sa_data_size_kilobytes");
        set => SetArgument("sa_data_size_kilobytes", value);
    }

    /// <summary>
    /// The sa_lifetime_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SaLifetimeSeconds is required")]
    [TerraformArgument("sa_lifetime_seconds")]
    public required TerraformValue<double> SaLifetimeSeconds
    {
        get => new TerraformReference<double>(this, "sa_lifetime_seconds");
        set => SetArgument("sa_lifetime_seconds", value);
    }

}

/// <summary>
/// Block type for radius in .
/// Nesting mode: list
/// </summary>
public class AzurermVpnServerConfigurationRadiusBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "radius";

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
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
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The vpn_authentication_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnAuthenticationTypes is required")]
    [TerraformArgument("vpn_authentication_types")]
    public TerraformList<string>? VpnAuthenticationTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "vpn_authentication_types").ResolveNodes(ctx));
        set => SetArgument("vpn_authentication_types", value);
    }

    /// <summary>
    /// The vpn_protocols attribute.
    /// </summary>
    [TerraformArgument("vpn_protocols")]
    public TerraformSet<string> VpnProtocols
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "vpn_protocols").ResolveNodes(ctx));
        set => SetArgument("vpn_protocols", value);
    }

    /// <summary>
    /// Block for azure_active_directory_authentication.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("azure_active_directory_authentication")]
    public TerraformList<AzurermVpnServerConfigurationAzureActiveDirectoryAuthenticationBlock> AzureActiveDirectoryAuthentication { get; set; } = new();

    /// <summary>
    /// Block for client_revoked_certificate.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("client_revoked_certificate")]
    public TerraformSet<AzurermVpnServerConfigurationClientRevokedCertificateBlock> ClientRevokedCertificate { get; set; } = new();

    /// <summary>
    /// Block for client_root_certificate.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("client_root_certificate")]
    public TerraformSet<AzurermVpnServerConfigurationClientRootCertificateBlock> ClientRootCertificate { get; set; } = new();

    /// <summary>
    /// Block for ipsec_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpsecPolicy block(s) allowed")]
    [TerraformArgument("ipsec_policy")]
    public TerraformList<AzurermVpnServerConfigurationIpsecPolicyBlock> IpsecPolicy { get; set; } = new();

    /// <summary>
    /// Block for radius.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Radius block(s) allowed")]
    [TerraformArgument("radius")]
    public TerraformList<AzurermVpnServerConfigurationRadiusBlock> Radius { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermVpnServerConfigurationTimeoutsBlock Timeouts { get; set; } = new();

}
