using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetappActiveDirectoryTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_netapp_active_directory resource.
/// </summary>
public class GoogleNetappActiveDirectory : TerraformResource
{
    public GoogleNetappActiveDirectory(string name) : base("google_netapp_active_directory", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("create_time");
        this.WithOutput("effective_labels");
        this.WithOutput("state");
        this.WithOutput("state_details");
        this.WithOutput("terraform_labels");
    }

    /// <summary>
    /// Domain user accounts to be added to the local Administrators group of the SMB service. Comma-separated list of domain users or groups. The Domain Admin group is automatically added when the service joins your domain as a hidden group.
    /// </summary>
    public List<TerraformProperty<string>>? Administrators
    {
        get => GetProperty<List<TerraformProperty<string>>>("administrators");
        set => this.WithProperty("administrators", value);
    }

    /// <summary>
    /// Enables AES-128 and AES-256 encryption for Kerberos-based communication with Active Directory.
    /// </summary>
    public TerraformProperty<bool>? AesEncryption
    {
        get => GetProperty<TerraformProperty<bool>>("aes_encryption");
        set => this.WithProperty("aes_encryption", value);
    }

    /// <summary>
    /// Domain user/group accounts to be added to the Backup Operators group of the SMB service. The Backup Operators group allows members to backup and restore files regardless of whether they have read or write access to the files. Comma-separated list.
    /// </summary>
    public List<TerraformProperty<string>>? BackupOperators
    {
        get => GetProperty<List<TerraformProperty<string>>>("backup_operators");
        set => this.WithProperty("backup_operators", value);
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Comma separated list of DNS server IP addresses for the Active Directory domain.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dns is required")]
    public required TerraformProperty<string> Dns
    {
        get => GetRequiredProperty<TerraformProperty<string>>("dns");
        set => this.WithProperty("dns", value);
    }

    /// <summary>
    /// Fully qualified domain name for the Active Directory domain.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    public required TerraformProperty<string> Domain
    {
        get => GetRequiredProperty<TerraformProperty<string>>("domain");
        set => this.WithProperty("domain", value);
    }

    /// <summary>
    /// If enabled, traffic between the SMB server to Domain Controller (DC) will be encrypted.
    /// </summary>
    public TerraformProperty<bool>? EncryptDcConnections
    {
        get => GetProperty<TerraformProperty<bool>>("encrypt_dc_connections");
        set => this.WithProperty("encrypt_dc_connections", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Hostname of the Active Directory server used as Kerberos Key Distribution Center. Only required for volumes using kerberized NFSv4.1
    /// </summary>
    public TerraformProperty<string>? KdcHostname
    {
        get => GetProperty<TerraformProperty<string>>("kdc_hostname");
        set => this.WithProperty("kdc_hostname", value);
    }

    /// <summary>
    /// IP address of the Active Directory server used as Kerberos Key Distribution Center.
    /// </summary>
    public TerraformProperty<string>? KdcIp
    {
        get => GetProperty<TerraformProperty<string>>("kdc_ip");
        set => this.WithProperty("kdc_ip", value);
    }

    /// <summary>
    /// Labels as key value pairs. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// Specifies whether or not the LDAP traffic needs to be signed.
    /// </summary>
    public TerraformProperty<bool>? LdapSigning
    {
        get => GetProperty<TerraformProperty<bool>>("ldap_signing");
        set => this.WithProperty("ldap_signing", value);
    }

    /// <summary>
    /// Name of the region for the policy to apply to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The resource name of the Active Directory pool. Needs to be unique per location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// NetBIOS name prefix of the server to be created.
    /// A five-character random ID is generated automatically, for example, -6f9a, and appended to the prefix. The full UNC share path will have the following format:
    /// &#39;\\NetBIOS_PREFIX-ABCD.DOMAIN_NAME\SHARE_NAME&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetBiosPrefix is required")]
    public required TerraformProperty<string> NetBiosPrefix
    {
        get => GetRequiredProperty<TerraformProperty<string>>("net_bios_prefix");
        set => this.WithProperty("net_bios_prefix", value);
    }

    /// <summary>
    /// Local UNIX users on clients without valid user information in Active Directory are blocked from access to LDAP enabled volumes.
    /// This option can be used to temporarily switch such volumes to AUTH_SYS authentication (user ID + 1-16 groups).
    /// </summary>
    public TerraformProperty<bool>? NfsUsersWithLdap
    {
        get => GetProperty<TerraformProperty<bool>>("nfs_users_with_ldap");
        set => this.WithProperty("nfs_users_with_ldap", value);
    }

    /// <summary>
    /// Name of the Organizational Unit where you intend to create the computer account for NetApp Volumes.
    /// Defaults to &#39;CN=Computers&#39; if left empty.
    /// </summary>
    public TerraformProperty<string>? OrganizationalUnit
    {
        get => GetProperty<TerraformProperty<string>>("organizational_unit");
        set => this.WithProperty("organizational_unit", value);
    }

    /// <summary>
    /// Password for specified username. Note - Manual changes done to the password will not be detected. Terraform will not re-apply the password, unless you use a new password in Terraform.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformProperty<string> Password
    {
        get => GetRequiredProperty<TerraformProperty<string>>("password");
        set => this.WithProperty("password", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Domain accounts that require elevated privileges such as &#39;SeSecurityPrivilege&#39; to manage security logs. Comma-separated list.
    /// </summary>
    public List<TerraformProperty<string>>? SecurityOperators
    {
        get => GetProperty<List<TerraformProperty<string>>>("security_operators");
        set => this.WithProperty("security_operators", value);
    }

    /// <summary>
    /// Specifies an Active Directory site to manage domain controller selection.
    /// Use when Active Directory domain controllers in multiple regions are configured. Defaults to &#39;Default-First-Site-Name&#39; if left empty.
    /// </summary>
    public TerraformProperty<string>? Site
    {
        get => GetProperty<TerraformProperty<string>>("site");
        set => this.WithProperty("site", value);
    }

    /// <summary>
    /// Username for the Active Directory account with permissions to create the compute account within the specified organizational unit.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetRequiredProperty<TerraformProperty<string>>("username");
        set => this.WithProperty("username", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetappActiveDirectoryTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleNetappActiveDirectoryTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Create time of the active directory. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format. Examples: &amp;quot;2023-06-22T09:13:01.617Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The state of the Active Directory policy (not the Active Directory itself).
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The state details of the Active Directory.
    /// </summary>
    public TerraformExpression StateDetails => this["state_details"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
