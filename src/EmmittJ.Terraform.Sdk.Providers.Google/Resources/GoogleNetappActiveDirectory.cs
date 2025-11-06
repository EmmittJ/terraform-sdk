using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("state");
        this.DeclareOutput("state_details");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// Domain user accounts to be added to the local Administrators group of the SMB service. Comma-separated list of domain users or groups. The Domain Admin group is automatically added when the service joins your domain as a hidden group.
    /// </summary>
    public List<string>? Administrators
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("administrators")?.Value;
        set => this.WithProperty("administrators", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Enables AES-128 and AES-256 encryption for Kerberos-based communication with Active Directory.
    /// </summary>
    public bool? AesEncryption
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("aes_encryption")?.Value;
        set => this.WithProperty("aes_encryption", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Domain user/group accounts to be added to the Backup Operators group of the SMB service. The Backup Operators group allows members to backup and restore files regardless of whether they have read or write access to the files. Comma-separated list.
    /// </summary>
    public List<string>? BackupOperators
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("backup_operators")?.Value;
        set => this.WithProperty("backup_operators", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Comma separated list of DNS server IP addresses for the Active Directory domain.
    /// </summary>
    public string? Dns
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dns")?.Value;
        set => this.WithProperty("dns", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Fully qualified domain name for the Active Directory domain.
    /// </summary>
    public string? Domain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain")?.Value;
        set => this.WithProperty("domain", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If enabled, traffic between the SMB server to Domain Controller (DC) will be encrypted.
    /// </summary>
    public bool? EncryptDcConnections
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("encrypt_dc_connections")?.Value;
        set => this.WithProperty("encrypt_dc_connections", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Hostname of the Active Directory server used as Kerberos Key Distribution Center. Only required for volumes using kerberized NFSv4.1
    /// </summary>
    public string? KdcHostname
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kdc_hostname")?.Value;
        set => this.WithProperty("kdc_hostname", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// IP address of the Active Directory server used as Kerberos Key Distribution Center.
    /// </summary>
    public string? KdcIp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kdc_ip")?.Value;
        set => this.WithProperty("kdc_ip", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Labels as key value pairs. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// Specifies whether or not the LDAP traffic needs to be signed.
    /// </summary>
    public bool? LdapSigning
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ldap_signing")?.Value;
        set => this.WithProperty("ldap_signing", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Name of the region for the policy to apply to.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource name of the Active Directory pool. Needs to be unique per location.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// NetBIOS name prefix of the server to be created.
    /// A five-character random ID is generated automatically, for example, -6f9a, and appended to the prefix. The full UNC share path will have the following format:
    /// &#39;\\NetBIOS_PREFIX-ABCD.DOMAIN_NAME\SHARE_NAME&#39;
    /// </summary>
    public string? NetBiosPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("net_bios_prefix")?.Value;
        set => this.WithProperty("net_bios_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Local UNIX users on clients without valid user information in Active Directory are blocked from access to LDAP enabled volumes.
    /// This option can be used to temporarily switch such volumes to AUTH_SYS authentication (user ID + 1-16 groups).
    /// </summary>
    public bool? NfsUsersWithLdap
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("nfs_users_with_ldap")?.Value;
        set => this.WithProperty("nfs_users_with_ldap", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Name of the Organizational Unit where you intend to create the computer account for NetApp Volumes.
    /// Defaults to &#39;CN=Computers&#39; if left empty.
    /// </summary>
    public string? OrganizationalUnit
    {
        get => GetProperty<TerraformLiteralProperty<string>>("organizational_unit")?.Value;
        set => this.WithProperty("organizational_unit", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Password for specified username. Note - Manual changes done to the password will not be detected. Terraform will not re-apply the password, unless you use a new password in Terraform.
    /// </summary>
    public string? Password
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password")?.Value;
        set => this.WithProperty("password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Domain accounts that require elevated privileges such as &#39;SeSecurityPrivilege&#39; to manage security logs. Comma-separated list.
    /// </summary>
    public List<string>? SecurityOperators
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("security_operators")?.Value;
        set => this.WithProperty("security_operators", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Specifies an Active Directory site to manage domain controller selection.
    /// Use when Active Directory domain controllers in multiple regions are configured. Defaults to &#39;Default-First-Site-Name&#39; if left empty.
    /// </summary>
    public string? Site
    {
        get => GetProperty<TerraformLiteralProperty<string>>("site")?.Value;
        set => this.WithProperty("site", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Username for the Active Directory account with permissions to create the compute account within the specified organizational unit.
    /// </summary>
    public string? Username
    {
        get => GetProperty<TerraformLiteralProperty<string>>("username")?.Value;
        set => this.WithProperty("username", value == null ? null : new TerraformLiteralProperty<string>(value));
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
