using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for active_directory in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNetappAccountActiveDirectoryBlock : TerraformBlockBase
{
    /// <summary>
    /// If enabled, AES encryption will be enabled for SMB communication.
    /// </summary>
    [TerraformProperty("aes_encryption_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AesEncryptionEnabled { get; set; }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsServers is required")]
    [TerraformProperty("dns_servers")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? DnsServers { get; set; }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    [TerraformProperty("domain")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Domain { get; set; }

    /// <summary>
    /// Name of the active directory machine. This optional parameter is used only while creating kerberos volume.
    /// </summary>
    [TerraformProperty("kerberos_ad_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KerberosAdName { get; set; }

    /// <summary>
    /// IP address of the KDC server (usually same the DC). This optional parameter is used only while creating kerberos volume.
    /// </summary>
    [TerraformProperty("kerberos_kdc_ip")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KerberosKdcIp { get; set; }

    /// <summary>
    /// Specifies whether or not the LDAP traffic needs to be secured via TLS.
    /// </summary>
    [TerraformProperty("ldap_over_tls_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? LdapOverTlsEnabled { get; set; }

    /// <summary>
    /// Specifies whether or not the LDAP traffic needs to be signed.
    /// </summary>
    [TerraformProperty("ldap_signing_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? LdapSigningEnabled { get; set; }

    /// <summary>
    /// If enabled, NFS client local users can also (in addition to LDAP users) access the NFS volumes.
    /// </summary>
    [TerraformProperty("local_nfs_users_with_ldap_allowed")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? LocalNfsUsersWithLdapAllowed { get; set; }

    /// <summary>
    /// The Organizational Unit (OU) within the Windows Active Directory where machines will be created. If blank, defaults to &#39;CN=Computers&#39;
    /// </summary>
    [TerraformProperty("organizational_unit")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OrganizationalUnit { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformProperty("password")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Password { get; set; }

    /// <summary>
    /// When LDAP over SSL/TLS is enabled, the LDAP client is required to have base64 encoded Active Directory Certificate Service&#39;s self-signed root CA certificate, this optional parameter is used only for dual protocol with LDAP user-mapping volumes.
    /// </summary>
    [TerraformProperty("server_root_ca_certificate")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ServerRootCaCertificate { get; set; }

    /// <summary>
    /// The Active Directory site the service will limit Domain Controller discovery to. If blank, defaults to &#39;Default-First-Site-Name&#39;
    /// </summary>
    [TerraformProperty("site_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SiteName { get; set; }

    /// <summary>
    /// The smb_server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SmbServerName is required")]
    [TerraformProperty("smb_server_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SmbServerName { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformProperty("username")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Username { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNetappAccountIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNetappAccountTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_netapp_account resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermNetappAccount : TerraformResource
{
    public AzurermNetappAccount(string name) : base("azurerm_netapp_account", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for active_directory.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveDirectory block(s) allowed")]
    [TerraformProperty("active_directory")]
    public TerraformList<TerraformBlock<AzurermNetappAccountActiveDirectoryBlock>>? ActiveDirectory { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<TerraformBlock<AzurermNetappAccountIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermNetappAccountTimeoutsBlock>? Timeouts { get; set; }

}
