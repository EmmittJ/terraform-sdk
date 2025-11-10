using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for active_directory in .
/// Nesting mode: list
/// </summary>
public class AzurermNetappAccountActiveDirectoryBlock : TerraformBlock
{
    /// <summary>
    /// If enabled, AES encryption will be enabled for SMB communication.
    /// </summary>
    public TerraformProperty<bool>? AesEncryptionEnabled
    {
        set => SetProperty("aes_encryption_enabled", value);
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsServers is required")]
    public List<TerraformProperty<string>>? DnsServers
    {
        set => SetProperty("dns_servers", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    public required TerraformProperty<string> Domain
    {
        set => SetProperty("domain", value);
    }

    /// <summary>
    /// Name of the active directory machine. This optional parameter is used only while creating kerberos volume.
    /// </summary>
    public TerraformProperty<string>? KerberosAdName
    {
        set => SetProperty("kerberos_ad_name", value);
    }

    /// <summary>
    /// IP address of the KDC server (usually same the DC). This optional parameter is used only while creating kerberos volume.
    /// </summary>
    public TerraformProperty<string>? KerberosKdcIp
    {
        set => SetProperty("kerberos_kdc_ip", value);
    }

    /// <summary>
    /// Specifies whether or not the LDAP traffic needs to be secured via TLS.
    /// </summary>
    public TerraformProperty<bool>? LdapOverTlsEnabled
    {
        set => SetProperty("ldap_over_tls_enabled", value);
    }

    /// <summary>
    /// Specifies whether or not the LDAP traffic needs to be signed.
    /// </summary>
    public TerraformProperty<bool>? LdapSigningEnabled
    {
        set => SetProperty("ldap_signing_enabled", value);
    }

    /// <summary>
    /// If enabled, NFS client local users can also (in addition to LDAP users) access the NFS volumes.
    /// </summary>
    public TerraformProperty<bool>? LocalNfsUsersWithLdapAllowed
    {
        set => SetProperty("local_nfs_users_with_ldap_allowed", value);
    }

    /// <summary>
    /// The Organizational Unit (OU) within the Windows Active Directory where machines will be created. If blank, defaults to &#39;CN=Computers&#39;
    /// </summary>
    public TerraformProperty<string>? OrganizationalUnit
    {
        set => SetProperty("organizational_unit", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformProperty<string> Password
    {
        set => SetProperty("password", value);
    }

    /// <summary>
    /// When LDAP over SSL/TLS is enabled, the LDAP client is required to have base64 encoded Active Directory Certificate Service&#39;s self-signed root CA certificate, this optional parameter is used only for dual protocol with LDAP user-mapping volumes.
    /// </summary>
    public TerraformProperty<string>? ServerRootCaCertificate
    {
        set => SetProperty("server_root_ca_certificate", value);
    }

    /// <summary>
    /// The Active Directory site the service will limit Domain Controller discovery to. If blank, defaults to &#39;Default-First-Site-Name&#39;
    /// </summary>
    public TerraformProperty<string>? SiteName
    {
        set => SetProperty("site_name", value);
    }

    /// <summary>
    /// The smb_server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SmbServerName is required")]
    public required TerraformProperty<string> SmbServerName
    {
        set => SetProperty("smb_server_name", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        set => SetProperty("username", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermNetappAccountIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetappAccountTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_netapp_account resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermNetappAccount : TerraformResource
{
    public AzurermNetappAccount(string name) : base("azurerm_netapp_account", name)
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
    /// Block for active_directory.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveDirectory block(s) allowed")]
    public List<AzurermNetappAccountActiveDirectoryBlock>? ActiveDirectory
    {
        set => SetProperty("active_directory", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermNetappAccountIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetappAccountTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
