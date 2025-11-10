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
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("state");
        SetOutput("state_details");
        SetOutput("terraform_labels");
        SetOutput("administrators");
        SetOutput("aes_encryption");
        SetOutput("backup_operators");
        SetOutput("description");
        SetOutput("dns");
        SetOutput("domain");
        SetOutput("encrypt_dc_connections");
        SetOutput("id");
        SetOutput("kdc_hostname");
        SetOutput("kdc_ip");
        SetOutput("labels");
        SetOutput("ldap_signing");
        SetOutput("location");
        SetOutput("name");
        SetOutput("net_bios_prefix");
        SetOutput("nfs_users_with_ldap");
        SetOutput("organizational_unit");
        SetOutput("password");
        SetOutput("project");
        SetOutput("security_operators");
        SetOutput("site");
        SetOutput("username");
    }

    /// <summary>
    /// Domain user accounts to be added to the local Administrators group of the SMB service. Comma-separated list of domain users or groups. The Domain Admin group is automatically added when the service joins your domain as a hidden group.
    /// </summary>
    public List<TerraformProperty<string>> Administrators
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("administrators");
        set => SetProperty("administrators", value);
    }

    /// <summary>
    /// Enables AES-128 and AES-256 encryption for Kerberos-based communication with Active Directory.
    /// </summary>
    public TerraformProperty<bool> AesEncryption
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("aes_encryption");
        set => SetProperty("aes_encryption", value);
    }

    /// <summary>
    /// Domain user/group accounts to be added to the Backup Operators group of the SMB service. The Backup Operators group allows members to backup and restore files regardless of whether they have read or write access to the files. Comma-separated list.
    /// </summary>
    public List<TerraformProperty<string>> BackupOperators
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("backup_operators");
        set => SetProperty("backup_operators", value);
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Comma separated list of DNS server IP addresses for the Active Directory domain.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dns is required")]
    public required TerraformProperty<string> Dns
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dns");
        set => SetProperty("dns", value);
    }

    /// <summary>
    /// Fully qualified domain name for the Active Directory domain.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    public required TerraformProperty<string> Domain
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain");
        set => SetProperty("domain", value);
    }

    /// <summary>
    /// If enabled, traffic between the SMB server to Domain Controller (DC) will be encrypted.
    /// </summary>
    public TerraformProperty<bool> EncryptDcConnections
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("encrypt_dc_connections");
        set => SetProperty("encrypt_dc_connections", value);
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
    /// Hostname of the Active Directory server used as Kerberos Key Distribution Center. Only required for volumes using kerberized NFSv4.1
    /// </summary>
    public TerraformProperty<string> KdcHostname
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kdc_hostname");
        set => SetProperty("kdc_hostname", value);
    }

    /// <summary>
    /// IP address of the Active Directory server used as Kerberos Key Distribution Center.
    /// </summary>
    public TerraformProperty<string> KdcIp
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kdc_ip");
        set => SetProperty("kdc_ip", value);
    }

    /// <summary>
    /// Labels as key value pairs. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// Specifies whether or not the LDAP traffic needs to be signed.
    /// </summary>
    public TerraformProperty<bool> LdapSigning
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ldap_signing");
        set => SetProperty("ldap_signing", value);
    }

    /// <summary>
    /// Name of the region for the policy to apply to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The resource name of the Active Directory pool. Needs to be unique per location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// NetBIOS name prefix of the server to be created.
    /// A five-character random ID is generated automatically, for example, -6f9a, and appended to the prefix. The full UNC share path will have the following format:
    /// &#39;\\NetBIOS_PREFIX-ABCD.DOMAIN_NAME\SHARE_NAME&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetBiosPrefix is required")]
    public required TerraformProperty<string> NetBiosPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("net_bios_prefix");
        set => SetProperty("net_bios_prefix", value);
    }

    /// <summary>
    /// Local UNIX users on clients without valid user information in Active Directory are blocked from access to LDAP enabled volumes.
    /// This option can be used to temporarily switch such volumes to AUTH_SYS authentication (user ID + 1-16 groups).
    /// </summary>
    public TerraformProperty<bool> NfsUsersWithLdap
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("nfs_users_with_ldap");
        set => SetProperty("nfs_users_with_ldap", value);
    }

    /// <summary>
    /// Name of the Organizational Unit where you intend to create the computer account for NetApp Volumes.
    /// Defaults to &#39;CN=Computers&#39; if left empty.
    /// </summary>
    public TerraformProperty<string> OrganizationalUnit
    {
        get => GetRequiredOutput<TerraformProperty<string>>("organizational_unit");
        set => SetProperty("organizational_unit", value);
    }

    /// <summary>
    /// Password for specified username. Note - Manual changes done to the password will not be detected. Terraform will not re-apply the password, unless you use a new password in Terraform.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformProperty<string> Password
    {
        get => GetRequiredOutput<TerraformProperty<string>>("password");
        set => SetProperty("password", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Domain accounts that require elevated privileges such as &#39;SeSecurityPrivilege&#39; to manage security logs. Comma-separated list.
    /// </summary>
    public List<TerraformProperty<string>> SecurityOperators
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("security_operators");
        set => SetProperty("security_operators", value);
    }

    /// <summary>
    /// Specifies an Active Directory site to manage domain controller selection.
    /// Use when Active Directory domain controllers in multiple regions are configured. Defaults to &#39;Default-First-Site-Name&#39; if left empty.
    /// </summary>
    public TerraformProperty<string> Site
    {
        get => GetRequiredOutput<TerraformProperty<string>>("site");
        set => SetProperty("site", value);
    }

    /// <summary>
    /// Username for the Active Directory account with permissions to create the compute account within the specified organizational unit.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetRequiredOutput<TerraformProperty<string>>("username");
        set => SetProperty("username", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetappActiveDirectoryTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
