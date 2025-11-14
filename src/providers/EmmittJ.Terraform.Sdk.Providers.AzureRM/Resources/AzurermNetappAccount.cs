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
/// Block type for active_directory in .
/// Nesting mode: list
/// </summary>
public class AzurermNetappAccountActiveDirectoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "active_directory";

    /// <summary>
    /// If enabled, AES encryption will be enabled for SMB communication.
    /// </summary>
    [TerraformArgument("aes_encryption_enabled")]
    public TerraformValue<bool>? AesEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "aes_encryption_enabled");
        set => SetArgument("aes_encryption_enabled", value);
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsServers is required")]
    [TerraformArgument("dns_servers")]
    public TerraformList<string>? DnsServers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "dns_servers").ResolveNodes(ctx));
        set => SetArgument("dns_servers", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    [TerraformArgument("domain")]
    public required TerraformValue<string> Domain
    {
        get => new TerraformReference<string>(this, "domain");
        set => SetArgument("domain", value);
    }

    /// <summary>
    /// Name of the active directory machine. This optional parameter is used only while creating kerberos volume.
    /// </summary>
    [TerraformArgument("kerberos_ad_name")]
    public TerraformValue<string>? KerberosAdName
    {
        get => new TerraformReference<string>(this, "kerberos_ad_name");
        set => SetArgument("kerberos_ad_name", value);
    }

    /// <summary>
    /// IP address of the KDC server (usually same the DC). This optional parameter is used only while creating kerberos volume.
    /// </summary>
    [TerraformArgument("kerberos_kdc_ip")]
    public TerraformValue<string>? KerberosKdcIp
    {
        get => new TerraformReference<string>(this, "kerberos_kdc_ip");
        set => SetArgument("kerberos_kdc_ip", value);
    }

    /// <summary>
    /// Specifies whether or not the LDAP traffic needs to be secured via TLS.
    /// </summary>
    [TerraformArgument("ldap_over_tls_enabled")]
    public TerraformValue<bool>? LdapOverTlsEnabled
    {
        get => new TerraformReference<bool>(this, "ldap_over_tls_enabled");
        set => SetArgument("ldap_over_tls_enabled", value);
    }

    /// <summary>
    /// Specifies whether or not the LDAP traffic needs to be signed.
    /// </summary>
    [TerraformArgument("ldap_signing_enabled")]
    public TerraformValue<bool>? LdapSigningEnabled
    {
        get => new TerraformReference<bool>(this, "ldap_signing_enabled");
        set => SetArgument("ldap_signing_enabled", value);
    }

    /// <summary>
    /// If enabled, NFS client local users can also (in addition to LDAP users) access the NFS volumes.
    /// </summary>
    [TerraformArgument("local_nfs_users_with_ldap_allowed")]
    public TerraformValue<bool>? LocalNfsUsersWithLdapAllowed
    {
        get => new TerraformReference<bool>(this, "local_nfs_users_with_ldap_allowed");
        set => SetArgument("local_nfs_users_with_ldap_allowed", value);
    }

    /// <summary>
    /// The Organizational Unit (OU) within the Windows Active Directory where machines will be created. If blank, defaults to &#39;CN=Computers&#39;
    /// </summary>
    [TerraformArgument("organizational_unit")]
    public TerraformValue<string>? OrganizationalUnit
    {
        get => new TerraformReference<string>(this, "organizational_unit");
        set => SetArgument("organizational_unit", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformArgument("password")]
    public required TerraformValue<string> Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// When LDAP over SSL/TLS is enabled, the LDAP client is required to have base64 encoded Active Directory Certificate Service&#39;s self-signed root CA certificate, this optional parameter is used only for dual protocol with LDAP user-mapping volumes.
    /// </summary>
    [TerraformArgument("server_root_ca_certificate")]
    public TerraformValue<string>? ServerRootCaCertificate
    {
        get => new TerraformReference<string>(this, "server_root_ca_certificate");
        set => SetArgument("server_root_ca_certificate", value);
    }

    /// <summary>
    /// The Active Directory site the service will limit Domain Controller discovery to. If blank, defaults to &#39;Default-First-Site-Name&#39;
    /// </summary>
    [TerraformArgument("site_name")]
    public TerraformValue<string>? SiteName
    {
        get => new TerraformReference<string>(this, "site_name");
        set => SetArgument("site_name", value);
    }

    /// <summary>
    /// The smb_server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SmbServerName is required")]
    [TerraformArgument("smb_server_name")]
    public required TerraformValue<string> SmbServerName
    {
        get => new TerraformReference<string>(this, "smb_server_name");
        set => SetArgument("smb_server_name", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformArgument("username")]
    public required TerraformValue<string> Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermNetappAccountIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetappAccountTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_netapp_account resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermNetappAccount : TerraformResource
{
    public AzurermNetappAccount(string name) : base("azurerm_netapp_account", name)
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
    /// Block for active_directory.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveDirectory block(s) allowed")]
    [TerraformArgument("active_directory")]
    public TerraformList<AzurermNetappAccountActiveDirectoryBlock> ActiveDirectory { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermNetappAccountIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermNetappAccountTimeoutsBlock Timeouts { get; set; } = new();

}
