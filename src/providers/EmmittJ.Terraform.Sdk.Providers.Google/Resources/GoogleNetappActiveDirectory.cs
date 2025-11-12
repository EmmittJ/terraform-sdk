using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleNetappActiveDirectoryTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_netapp_active_directory resource.
/// </summary>
public partial class GoogleNetappActiveDirectory : TerraformResource
{
    public GoogleNetappActiveDirectory(string name) : base("google_netapp_active_directory", name)
    {
    }

    /// <summary>
    /// Domain user accounts to be added to the local Administrators group of the SMB service. Comma-separated list of domain users or groups. The Domain Admin group is automatically added when the service joins your domain as a hidden group.
    /// </summary>
    [TerraformProperty("administrators")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Administrators { get; set; }

    /// <summary>
    /// Enables AES-128 and AES-256 encryption for Kerberos-based communication with Active Directory.
    /// </summary>
    [TerraformProperty("aes_encryption")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AesEncryption { get; set; }

    /// <summary>
    /// Domain user/group accounts to be added to the Backup Operators group of the SMB service. The Backup Operators group allows members to backup and restore files regardless of whether they have read or write access to the files. Comma-separated list.
    /// </summary>
    [TerraformProperty("backup_operators")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? BackupOperators { get; set; }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Comma separated list of DNS server IP addresses for the Active Directory domain.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dns is required")]
    [TerraformProperty("dns")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Dns { get; set; }

    /// <summary>
    /// Fully qualified domain name for the Active Directory domain.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    [TerraformProperty("domain")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Domain { get; set; }

    /// <summary>
    /// If enabled, traffic between the SMB server to Domain Controller (DC) will be encrypted.
    /// </summary>
    [TerraformProperty("encrypt_dc_connections")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EncryptDcConnections { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Hostname of the Active Directory server used as Kerberos Key Distribution Center. Only required for volumes using kerberized NFSv4.1
    /// </summary>
    [TerraformProperty("kdc_hostname")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KdcHostname { get; set; }

    /// <summary>
    /// IP address of the Active Directory server used as Kerberos Key Distribution Center.
    /// </summary>
    [TerraformProperty("kdc_ip")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KdcIp { get; set; }

    /// <summary>
    /// Labels as key value pairs. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Specifies whether or not the LDAP traffic needs to be signed.
    /// </summary>
    [TerraformProperty("ldap_signing")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LdapSigning { get; set; }

    /// <summary>
    /// Name of the region for the policy to apply to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The resource name of the Active Directory pool. Needs to be unique per location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// NetBIOS name prefix of the server to be created.
    /// A five-character random ID is generated automatically, for example, -6f9a, and appended to the prefix. The full UNC share path will have the following format:
    /// &#39;\\NetBIOS_PREFIX-ABCD.DOMAIN_NAME\SHARE_NAME&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetBiosPrefix is required")]
    [TerraformProperty("net_bios_prefix")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NetBiosPrefix { get; set; }

    /// <summary>
    /// Local UNIX users on clients without valid user information in Active Directory are blocked from access to LDAP enabled volumes.
    /// This option can be used to temporarily switch such volumes to AUTH_SYS authentication (user ID + 1-16 groups).
    /// </summary>
    [TerraformProperty("nfs_users_with_ldap")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? NfsUsersWithLdap { get; set; }

    /// <summary>
    /// Name of the Organizational Unit where you intend to create the computer account for NetApp Volumes.
    /// Defaults to &#39;CN=Computers&#39; if left empty.
    /// </summary>
    [TerraformProperty("organizational_unit")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> OrganizationalUnit { get; set; }

    /// <summary>
    /// Password for specified username. Note - Manual changes done to the password will not be detected. Terraform will not re-apply the password, unless you use a new password in Terraform.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformProperty("password")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Password { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Domain accounts that require elevated privileges such as &#39;SeSecurityPrivilege&#39; to manage security logs. Comma-separated list.
    /// </summary>
    [TerraformProperty("security_operators")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? SecurityOperators { get; set; }

    /// <summary>
    /// Specifies an Active Directory site to manage domain controller selection.
    /// Use when Active Directory domain controllers in multiple regions are configured. Defaults to &#39;Default-First-Site-Name&#39; if left empty.
    /// </summary>
    [TerraformProperty("site")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Site { get; set; }

    /// <summary>
    /// Username for the Active Directory account with permissions to create the compute account within the specified organizational unit.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformProperty("username")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Username { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleNetappActiveDirectoryTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Create time of the active directory. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format. Examples: &amp;quot;2023-06-22T09:13:01.617Z&amp;quot;.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The state of the Active Directory policy (not the Active Directory itself).
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The state details of the Active Directory.
    /// </summary>
    [TerraformProperty("state_details")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StateDetails { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}
