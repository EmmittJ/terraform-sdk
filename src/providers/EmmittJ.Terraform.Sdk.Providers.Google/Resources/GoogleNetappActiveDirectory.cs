using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleNetappActiveDirectory.
/// Nesting mode: single
/// </summary>
public class GoogleNetappActiveDirectoryTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_netapp_active_directory Terraform resource.
/// Manages a google_netapp_active_directory resource.
/// </summary>
public partial class GoogleNetappActiveDirectory(string name) : TerraformResource("google_netapp_active_directory", name)
{
    /// <summary>
    /// Domain user accounts to be added to the local Administrators group of the SMB service. Comma-separated list of domain users or groups. The Domain Admin group is automatically added when the service joins your domain as a hidden group.
    /// </summary>
    public TerraformList<string>? Administrators
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "administrators").ResolveNodes(ctx));
        set => SetArgument("administrators", value);
    }

    /// <summary>
    /// Enables AES-128 and AES-256 encryption for Kerberos-based communication with Active Directory.
    /// </summary>
    public TerraformValue<bool>? AesEncryption
    {
        get => new TerraformReference<bool>(this, "aes_encryption");
        set => SetArgument("aes_encryption", value);
    }

    /// <summary>
    /// Domain user/group accounts to be added to the Backup Operators group of the SMB service. The Backup Operators group allows members to backup and restore files regardless of whether they have read or write access to the files. Comma-separated list.
    /// </summary>
    public TerraformList<string>? BackupOperators
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "backup_operators").ResolveNodes(ctx));
        set => SetArgument("backup_operators", value);
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Comma separated list of DNS server IP addresses for the Active Directory domain.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dns is required")]
    public required TerraformValue<string> Dns
    {
        get => new TerraformReference<string>(this, "dns");
        set => SetArgument("dns", value);
    }

    /// <summary>
    /// Fully qualified domain name for the Active Directory domain.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    public required TerraformValue<string> Domain
    {
        get => new TerraformReference<string>(this, "domain");
        set => SetArgument("domain", value);
    }

    /// <summary>
    /// If enabled, traffic between the SMB server to Domain Controller (DC) will be encrypted.
    /// </summary>
    public TerraformValue<bool>? EncryptDcConnections
    {
        get => new TerraformReference<bool>(this, "encrypt_dc_connections");
        set => SetArgument("encrypt_dc_connections", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Hostname of the Active Directory server used as Kerberos Key Distribution Center. Only required for volumes using kerberized NFSv4.1
    /// </summary>
    public TerraformValue<string>? KdcHostname
    {
        get => new TerraformReference<string>(this, "kdc_hostname");
        set => SetArgument("kdc_hostname", value);
    }

    /// <summary>
    /// IP address of the Active Directory server used as Kerberos Key Distribution Center.
    /// </summary>
    public TerraformValue<string>? KdcIp
    {
        get => new TerraformReference<string>(this, "kdc_ip");
        set => SetArgument("kdc_ip", value);
    }

    /// <summary>
    /// Labels as key value pairs. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Specifies whether or not the LDAP traffic needs to be signed.
    /// </summary>
    public TerraformValue<bool>? LdapSigning
    {
        get => new TerraformReference<bool>(this, "ldap_signing");
        set => SetArgument("ldap_signing", value);
    }

    /// <summary>
    /// Name of the region for the policy to apply to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The resource name of the Active Directory pool. Needs to be unique per location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// NetBIOS name prefix of the server to be created.
    /// A five-character random ID is generated automatically, for example, -6f9a, and appended to the prefix. The full UNC share path will have the following format:
    /// &#39;\\NetBIOS_PREFIX-ABCD.DOMAIN_NAME\SHARE_NAME&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetBiosPrefix is required")]
    public required TerraformValue<string> NetBiosPrefix
    {
        get => new TerraformReference<string>(this, "net_bios_prefix");
        set => SetArgument("net_bios_prefix", value);
    }

    /// <summary>
    /// Local UNIX users on clients without valid user information in Active Directory are blocked from access to LDAP enabled volumes.
    /// This option can be used to temporarily switch such volumes to AUTH_SYS authentication (user ID + 1-16 groups).
    /// </summary>
    public TerraformValue<bool>? NfsUsersWithLdap
    {
        get => new TerraformReference<bool>(this, "nfs_users_with_ldap");
        set => SetArgument("nfs_users_with_ldap", value);
    }

    /// <summary>
    /// Name of the Organizational Unit where you intend to create the computer account for NetApp Volumes.
    /// Defaults to &#39;CN=Computers&#39; if left empty.
    /// </summary>
    public TerraformValue<string> OrganizationalUnit
    {
        get => new TerraformReference<string>(this, "organizational_unit");
        set => SetArgument("organizational_unit", value);
    }

    /// <summary>
    /// Password for specified username. Note - Manual changes done to the password will not be detected. Terraform will not re-apply the password, unless you use a new password in Terraform.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Domain accounts that require elevated privileges such as &#39;SeSecurityPrivilege&#39; to manage security logs. Comma-separated list.
    /// </summary>
    public TerraformList<string>? SecurityOperators
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "security_operators").ResolveNodes(ctx));
        set => SetArgument("security_operators", value);
    }

    /// <summary>
    /// Specifies an Active Directory site to manage domain controller selection.
    /// Use when Active Directory domain controllers in multiple regions are configured. Defaults to &#39;Default-First-Site-Name&#39; if left empty.
    /// </summary>
    public TerraformValue<string>? Site
    {
        get => new TerraformReference<string>(this, "site");
        set => SetArgument("site", value);
    }

    /// <summary>
    /// Username for the Active Directory account with permissions to create the compute account within the specified organizational unit.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// Create time of the active directory. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format. Examples: &amp;quot;2023-06-22T09:13:01.617Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The state of the Active Directory policy (not the Active Directory itself).
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// The state details of the Active Directory.
    /// </summary>
    public TerraformValue<string> StateDetails
    {
        get => new TerraformReference<string>(this, "state_details");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetappActiveDirectoryTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetappActiveDirectoryTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
