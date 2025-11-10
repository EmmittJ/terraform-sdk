using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetappActiveDirectoryTimeoutsBlock : ITerraformBlock
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
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_netapp_active_directory resource.
/// </summary>
public class GoogleNetappActiveDirectory : TerraformResource
{
    public GoogleNetappActiveDirectory(string name) : base("google_netapp_active_directory", name)
    {
    }

    /// <summary>
    /// Domain user accounts to be added to the local Administrators group of the SMB service. Comma-separated list of domain users or groups. The Domain Admin group is automatically added when the service joins your domain as a hidden group.
    /// </summary>
    [TerraformPropertyName("administrators")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Administrators { get; set; }

    /// <summary>
    /// Enables AES-128 and AES-256 encryption for Kerberos-based communication with Active Directory.
    /// </summary>
    [TerraformPropertyName("aes_encryption")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AesEncryption { get; set; }

    /// <summary>
    /// Domain user/group accounts to be added to the Backup Operators group of the SMB service. The Backup Operators group allows members to backup and restore files regardless of whether they have read or write access to the files. Comma-separated list.
    /// </summary>
    [TerraformPropertyName("backup_operators")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? BackupOperators { get; set; }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Comma separated list of DNS server IP addresses for the Active Directory domain.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dns is required")]
    [TerraformPropertyName("dns")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Dns { get; set; }

    /// <summary>
    /// Fully qualified domain name for the Active Directory domain.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    [TerraformPropertyName("domain")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Domain { get; set; }

    /// <summary>
    /// If enabled, traffic between the SMB server to Domain Controller (DC) will be encrypted.
    /// </summary>
    [TerraformPropertyName("encrypt_dc_connections")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EncryptDcConnections { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Hostname of the Active Directory server used as Kerberos Key Distribution Center. Only required for volumes using kerberized NFSv4.1
    /// </summary>
    [TerraformPropertyName("kdc_hostname")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KdcHostname { get; set; }

    /// <summary>
    /// IP address of the Active Directory server used as Kerberos Key Distribution Center.
    /// </summary>
    [TerraformPropertyName("kdc_ip")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KdcIp { get; set; }

    /// <summary>
    /// Labels as key value pairs. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// Specifies whether or not the LDAP traffic needs to be signed.
    /// </summary>
    [TerraformPropertyName("ldap_signing")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LdapSigning { get; set; }

    /// <summary>
    /// Name of the region for the policy to apply to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The resource name of the Active Directory pool. Needs to be unique per location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// NetBIOS name prefix of the server to be created.
    /// A five-character random ID is generated automatically, for example, -6f9a, and appended to the prefix. The full UNC share path will have the following format:
    /// &#39;\\NetBIOS_PREFIX-ABCD.DOMAIN_NAME\SHARE_NAME&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetBiosPrefix is required")]
    [TerraformPropertyName("net_bios_prefix")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NetBiosPrefix { get; set; }

    /// <summary>
    /// Local UNIX users on clients without valid user information in Active Directory are blocked from access to LDAP enabled volumes.
    /// This option can be used to temporarily switch such volumes to AUTH_SYS authentication (user ID + 1-16 groups).
    /// </summary>
    [TerraformPropertyName("nfs_users_with_ldap")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? NfsUsersWithLdap { get; set; }

    /// <summary>
    /// Name of the Organizational Unit where you intend to create the computer account for NetApp Volumes.
    /// Defaults to &#39;CN=Computers&#39; if left empty.
    /// </summary>
    [TerraformPropertyName("organizational_unit")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OrganizationalUnit { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "organizational_unit");

    /// <summary>
    /// Password for specified username. Note - Manual changes done to the password will not be detected. Terraform will not re-apply the password, unless you use a new password in Terraform.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformPropertyName("password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Password { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Domain accounts that require elevated privileges such as &#39;SeSecurityPrivilege&#39; to manage security logs. Comma-separated list.
    /// </summary>
    [TerraformPropertyName("security_operators")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? SecurityOperators { get; set; }

    /// <summary>
    /// Specifies an Active Directory site to manage domain controller selection.
    /// Use when Active Directory domain controllers in multiple regions are configured. Defaults to &#39;Default-First-Site-Name&#39; if left empty.
    /// </summary>
    [TerraformPropertyName("site")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Site { get; set; }

    /// <summary>
    /// Username for the Active Directory account with permissions to create the compute account within the specified organizational unit.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformPropertyName("username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Username { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleNetappActiveDirectoryTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Create time of the active directory. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format. Examples: &amp;quot;2023-06-22T09:13:01.617Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The state of the Active Directory policy (not the Active Directory itself).
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The state details of the Active Directory.
    /// </summary>
    [TerraformPropertyName("state_details")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StateDetails => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state_details");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

}
