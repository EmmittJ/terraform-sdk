using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for initial_replica_set in .
/// Nesting mode: list
/// </summary>
public class AzurermActiveDirectoryDomainServiceInitialReplicaSetBlock : TerraformBlock
{
    /// <summary>
    /// The domain_controller_ip_addresses attribute.
    /// </summary>
    public List<TerraformProperty<string>>? DomainControllerIpAddresses
    {
        get => GetProperty<List<TerraformProperty<string>>>("domain_controller_ip_addresses");
        set => WithProperty("domain_controller_ip_addresses", value);
    }

    /// <summary>
    /// The external_access_ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? ExternalAccessIpAddress
    {
        get => GetProperty<TerraformProperty<string>>("external_access_ip_address");
        set => WithProperty("external_access_ip_address", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => WithProperty("location", value);
    }

    /// <summary>
    /// The service_status attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceStatus
    {
        get => GetProperty<TerraformProperty<string>>("service_status");
        set => WithProperty("service_status", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
    }

}

/// <summary>
/// Block type for notifications in .
/// Nesting mode: list
/// </summary>
public class AzurermActiveDirectoryDomainServiceNotificationsBlock : TerraformBlock
{
    /// <summary>
    /// The additional_recipients attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AdditionalRecipients
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("additional_recipients");
        set => WithProperty("additional_recipients", value);
    }

    /// <summary>
    /// The notify_dc_admins attribute.
    /// </summary>
    public TerraformProperty<bool>? NotifyDcAdmins
    {
        get => GetProperty<TerraformProperty<bool>>("notify_dc_admins");
        set => WithProperty("notify_dc_admins", value);
    }

    /// <summary>
    /// The notify_global_admins attribute.
    /// </summary>
    public TerraformProperty<bool>? NotifyGlobalAdmins
    {
        get => GetProperty<TerraformProperty<bool>>("notify_global_admins");
        set => WithProperty("notify_global_admins", value);
    }

}

/// <summary>
/// Block type for secure_ldap in .
/// Nesting mode: list
/// </summary>
public class AzurermActiveDirectoryDomainServiceSecureLdapBlock : TerraformBlock
{
    /// <summary>
    /// The certificate_expiry attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateExpiry
    {
        get => GetProperty<TerraformProperty<string>>("certificate_expiry");
        set => WithProperty("certificate_expiry", value);
    }

    /// <summary>
    /// The certificate_thumbprint attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateThumbprint
    {
        get => GetProperty<TerraformProperty<string>>("certificate_thumbprint");
        set => WithProperty("certificate_thumbprint", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The external_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ExternalAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("external_access_enabled");
        set => WithProperty("external_access_enabled", value);
    }

    /// <summary>
    /// The pfx_certificate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PfxCertificate is required")]
    public required TerraformProperty<string> PfxCertificate
    {
        get => GetProperty<TerraformProperty<string>>("pfx_certificate");
        set => WithProperty("pfx_certificate", value);
    }

    /// <summary>
    /// The pfx_certificate_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PfxCertificatePassword is required")]
    public required TerraformProperty<string> PfxCertificatePassword
    {
        get => GetProperty<TerraformProperty<string>>("pfx_certificate_password");
        set => WithProperty("pfx_certificate_password", value);
    }

    /// <summary>
    /// The public_certificate attribute.
    /// </summary>
    public TerraformProperty<string>? PublicCertificate
    {
        get => GetProperty<TerraformProperty<string>>("public_certificate");
        set => WithProperty("public_certificate", value);
    }

}

/// <summary>
/// Block type for security in .
/// Nesting mode: list
/// </summary>
public class AzurermActiveDirectoryDomainServiceSecurityBlock : TerraformBlock
{
    /// <summary>
    /// The kerberos_armoring_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? KerberosArmoringEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("kerberos_armoring_enabled");
        set => WithProperty("kerberos_armoring_enabled", value);
    }

    /// <summary>
    /// The kerberos_rc4_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? KerberosRc4EncryptionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("kerberos_rc4_encryption_enabled");
        set => WithProperty("kerberos_rc4_encryption_enabled", value);
    }

    /// <summary>
    /// The ntlm_v1_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? NtlmV1Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("ntlm_v1_enabled");
        set => WithProperty("ntlm_v1_enabled", value);
    }

    /// <summary>
    /// The sync_kerberos_passwords attribute.
    /// </summary>
    public TerraformProperty<bool>? SyncKerberosPasswords
    {
        get => GetProperty<TerraformProperty<bool>>("sync_kerberos_passwords");
        set => WithProperty("sync_kerberos_passwords", value);
    }

    /// <summary>
    /// The sync_ntlm_passwords attribute.
    /// </summary>
    public TerraformProperty<bool>? SyncNtlmPasswords
    {
        get => GetProperty<TerraformProperty<bool>>("sync_ntlm_passwords");
        set => WithProperty("sync_ntlm_passwords", value);
    }

    /// <summary>
    /// The sync_on_prem_passwords attribute.
    /// </summary>
    public TerraformProperty<bool>? SyncOnPremPasswords
    {
        get => GetProperty<TerraformProperty<bool>>("sync_on_prem_passwords");
        set => WithProperty("sync_on_prem_passwords", value);
    }

    /// <summary>
    /// The tls_v1_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TlsV1Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("tls_v1_enabled");
        set => WithProperty("tls_v1_enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermActiveDirectoryDomainServiceTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
/// Manages a azurerm_active_directory_domain_service resource.
/// </summary>
public class AzurermActiveDirectoryDomainService : TerraformResource
{
    public AzurermActiveDirectoryDomainService(string name) : base("azurerm_active_directory_domain_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("deployment_id");
        this.DeclareOutput("resource_id");
        this.DeclareOutput("sync_owner");
        this.DeclareOutput("tenant_id");
        this.DeclareOutput("version");
    }

    /// <summary>
    /// The domain_configuration_type attribute.
    /// </summary>
    public TerraformProperty<string>? DomainConfigurationType
    {
        get => GetProperty<TerraformProperty<string>>("domain_configuration_type");
        set => this.WithProperty("domain_configuration_type", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetProperty<TerraformProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
    }

    /// <summary>
    /// The filtered_sync_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? FilteredSyncEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("filtered_sync_enabled");
        set => this.WithProperty("filtered_sync_enabled", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformProperty<string> Sku
    {
        get => GetProperty<TerraformProperty<string>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for initial_replica_set.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InitialReplicaSet block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InitialReplicaSet block(s) allowed")]
    public List<AzurermActiveDirectoryDomainServiceInitialReplicaSetBlock>? InitialReplicaSet
    {
        get => GetProperty<List<AzurermActiveDirectoryDomainServiceInitialReplicaSetBlock>>("initial_replica_set");
        set => this.WithProperty("initial_replica_set", value);
    }

    /// <summary>
    /// Block for notifications.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Notifications block(s) allowed")]
    public List<AzurermActiveDirectoryDomainServiceNotificationsBlock>? Notifications
    {
        get => GetProperty<List<AzurermActiveDirectoryDomainServiceNotificationsBlock>>("notifications");
        set => this.WithProperty("notifications", value);
    }

    /// <summary>
    /// Block for secure_ldap.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecureLdap block(s) allowed")]
    public List<AzurermActiveDirectoryDomainServiceSecureLdapBlock>? SecureLdap
    {
        get => GetProperty<List<AzurermActiveDirectoryDomainServiceSecureLdapBlock>>("secure_ldap");
        set => this.WithProperty("secure_ldap", value);
    }

    /// <summary>
    /// Block for security.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Security block(s) allowed")]
    public List<AzurermActiveDirectoryDomainServiceSecurityBlock>? Security
    {
        get => GetProperty<List<AzurermActiveDirectoryDomainServiceSecurityBlock>>("security");
        set => this.WithProperty("security", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermActiveDirectoryDomainServiceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermActiveDirectoryDomainServiceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The deployment_id attribute.
    /// </summary>
    public TerraformExpression DeploymentId => this["deployment_id"];

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformExpression ResourceId => this["resource_id"];

    /// <summary>
    /// The sync_owner attribute.
    /// </summary>
    public TerraformExpression SyncOwner => this["sync_owner"];

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformExpression TenantId => this["tenant_id"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
