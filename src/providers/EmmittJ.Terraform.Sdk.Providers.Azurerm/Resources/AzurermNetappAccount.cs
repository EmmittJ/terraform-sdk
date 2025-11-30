using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for active_directory in AzurermNetappAccount.
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
    public TerraformValue<bool>? AesEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "aes_encryption_enabled");
        set => SetArgument("aes_encryption_enabled", value);
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsServers is required")]
    public TerraformList<string>? DnsServers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "dns_servers").ResolveNodes(ctx));
        set => SetArgument("dns_servers", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    public required TerraformValue<string> Domain
    {
        get => new TerraformReference<string>(this, "domain");
        set => SetArgument("domain", value);
    }

    /// <summary>
    /// Name of the active directory machine. This optional parameter is used only while creating kerberos volume.
    /// </summary>
    public TerraformValue<string>? KerberosAdName
    {
        get => new TerraformReference<string>(this, "kerberos_ad_name");
        set => SetArgument("kerberos_ad_name", value);
    }

    /// <summary>
    /// IP address of the KDC server (usually same the DC). This optional parameter is used only while creating kerberos volume.
    /// </summary>
    public TerraformValue<string>? KerberosKdcIp
    {
        get => new TerraformReference<string>(this, "kerberos_kdc_ip");
        set => SetArgument("kerberos_kdc_ip", value);
    }

    /// <summary>
    /// Specifies whether or not the LDAP traffic needs to be secured via TLS.
    /// </summary>
    public TerraformValue<bool>? LdapOverTlsEnabled
    {
        get => new TerraformReference<bool>(this, "ldap_over_tls_enabled");
        set => SetArgument("ldap_over_tls_enabled", value);
    }

    /// <summary>
    /// Specifies whether or not the LDAP traffic needs to be signed.
    /// </summary>
    public TerraformValue<bool>? LdapSigningEnabled
    {
        get => new TerraformReference<bool>(this, "ldap_signing_enabled");
        set => SetArgument("ldap_signing_enabled", value);
    }

    /// <summary>
    /// If enabled, NFS client local users can also (in addition to LDAP users) access the NFS volumes.
    /// </summary>
    public TerraformValue<bool>? LocalNfsUsersWithLdapAllowed
    {
        get => new TerraformReference<bool>(this, "local_nfs_users_with_ldap_allowed");
        set => SetArgument("local_nfs_users_with_ldap_allowed", value);
    }

    /// <summary>
    /// The Organizational Unit (OU) within the Windows Active Directory where machines will be created. If blank, defaults to &#39;CN=Computers&#39;
    /// </summary>
    public TerraformValue<string>? OrganizationalUnit
    {
        get => new TerraformReference<string>(this, "organizational_unit");
        set => SetArgument("organizational_unit", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// When LDAP over SSL/TLS is enabled, the LDAP client is required to have base64 encoded Active Directory Certificate Service&#39;s self-signed root CA certificate, this optional parameter is used only for dual protocol with LDAP user-mapping volumes.
    /// </summary>
    public TerraformValue<string>? ServerRootCaCertificate
    {
        get => new TerraformReference<string>(this, "server_root_ca_certificate");
        set => SetArgument("server_root_ca_certificate", value);
    }

    /// <summary>
    /// The Active Directory site the service will limit Domain Controller discovery to. If blank, defaults to &#39;Default-First-Site-Name&#39;
    /// </summary>
    public TerraformValue<string>? SiteName
    {
        get => new TerraformReference<string>(this, "site_name");
        set => SetArgument("site_name", value);
    }

    /// <summary>
    /// The smb_server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SmbServerName is required")]
    public required TerraformValue<string> SmbServerName
    {
        get => new TerraformReference<string>(this, "smb_server_name");
        set => SetArgument("smb_server_name", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Block type for identity in AzurermNetappAccount.
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
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermNetappAccount.
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_netapp_account Terraform resource.
/// Manages a azurerm_netapp_account resource.
/// </summary>
public partial class AzurermNetappAccount(string name) : TerraformResource("azurerm_netapp_account", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// ActiveDirectory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveDirectory block(s) allowed")]
    public TerraformList<AzurermNetappAccountActiveDirectoryBlock>? ActiveDirectory
    {
        get => GetArgument<TerraformList<AzurermNetappAccountActiveDirectoryBlock>>("active_directory");
        set => SetArgument("active_directory", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermNetappAccountIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermNetappAccountIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetappAccountTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetappAccountTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
