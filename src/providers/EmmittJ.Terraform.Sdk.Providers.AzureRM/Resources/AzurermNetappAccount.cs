using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for active_directory in .
/// Nesting mode: list
/// </summary>
public class AzurermNetappAccountActiveDirectoryBlock : ITerraformBlock
{
    /// <summary>
    /// If enabled, AES encryption will be enabled for SMB communication.
    /// </summary>
    [TerraformPropertyName("aes_encryption_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AesEncryptionEnabled { get; set; }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsServers is required")]
    [TerraformPropertyName("dns_servers")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? DnsServers { get; set; }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    [TerraformPropertyName("domain")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Domain { get; set; }

    /// <summary>
    /// Name of the active directory machine. This optional parameter is used only while creating kerberos volume.
    /// </summary>
    [TerraformPropertyName("kerberos_ad_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KerberosAdName { get; set; }

    /// <summary>
    /// IP address of the KDC server (usually same the DC). This optional parameter is used only while creating kerberos volume.
    /// </summary>
    [TerraformPropertyName("kerberos_kdc_ip")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KerberosKdcIp { get; set; }

    /// <summary>
    /// Specifies whether or not the LDAP traffic needs to be secured via TLS.
    /// </summary>
    [TerraformPropertyName("ldap_over_tls_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LdapOverTlsEnabled { get; set; }

    /// <summary>
    /// Specifies whether or not the LDAP traffic needs to be signed.
    /// </summary>
    [TerraformPropertyName("ldap_signing_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LdapSigningEnabled { get; set; }

    /// <summary>
    /// If enabled, NFS client local users can also (in addition to LDAP users) access the NFS volumes.
    /// </summary>
    [TerraformPropertyName("local_nfs_users_with_ldap_allowed")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LocalNfsUsersWithLdapAllowed { get; set; }

    /// <summary>
    /// The Organizational Unit (OU) within the Windows Active Directory where machines will be created. If blank, defaults to &#39;CN=Computers&#39;
    /// </summary>
    [TerraformPropertyName("organizational_unit")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OrganizationalUnit { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformPropertyName("password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Password { get; set; }

    /// <summary>
    /// When LDAP over SSL/TLS is enabled, the LDAP client is required to have base64 encoded Active Directory Certificate Service&#39;s self-signed root CA certificate, this optional parameter is used only for dual protocol with LDAP user-mapping volumes.
    /// </summary>
    [TerraformPropertyName("server_root_ca_certificate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServerRootCaCertificate { get; set; }

    /// <summary>
    /// The Active Directory site the service will limit Domain Controller discovery to. If blank, defaults to &#39;Default-First-Site-Name&#39;
    /// </summary>
    [TerraformPropertyName("site_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SiteName { get; set; }

    /// <summary>
    /// The smb_server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SmbServerName is required")]
    [TerraformPropertyName("smb_server_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SmbServerName { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformPropertyName("username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Username { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermNetappAccountIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IdentityIds { get; set; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformPropertyName("principal_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrincipalId => new TerraformReferenceProperty<TerraformProperty<string>>("", "principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantId => new TerraformReferenceProperty<TerraformProperty<string>>("", "tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetappAccountTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for active_directory.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveDirectory block(s) allowed")]
    [TerraformPropertyName("active_directory")]
    public TerraformList<TerraformBlock<AzurermNetappAccountActiveDirectoryBlock>>? ActiveDirectory { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermNetappAccountIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermNetappAccountTimeoutsBlock>? Timeouts { get; set; } = new();

}
