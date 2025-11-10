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
        set => SetProperty("domain_controller_ip_addresses", value);
    }

    /// <summary>
    /// The external_access_ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? ExternalAccessIpAddress
    {
        set => SetProperty("external_access_ip_address", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The service_status attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceStatus
    {
        set => SetProperty("service_status", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        set => SetProperty("subnet_id", value);
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
        set => SetProperty("additional_recipients", value);
    }

    /// <summary>
    /// The notify_dc_admins attribute.
    /// </summary>
    public TerraformProperty<bool>? NotifyDcAdmins
    {
        set => SetProperty("notify_dc_admins", value);
    }

    /// <summary>
    /// The notify_global_admins attribute.
    /// </summary>
    public TerraformProperty<bool>? NotifyGlobalAdmins
    {
        set => SetProperty("notify_global_admins", value);
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
        set => SetProperty("certificate_expiry", value);
    }

    /// <summary>
    /// The certificate_thumbprint attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateThumbprint
    {
        set => SetProperty("certificate_thumbprint", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The external_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ExternalAccessEnabled
    {
        set => SetProperty("external_access_enabled", value);
    }

    /// <summary>
    /// The pfx_certificate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PfxCertificate is required")]
    public required TerraformProperty<string> PfxCertificate
    {
        set => SetProperty("pfx_certificate", value);
    }

    /// <summary>
    /// The pfx_certificate_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PfxCertificatePassword is required")]
    public required TerraformProperty<string> PfxCertificatePassword
    {
        set => SetProperty("pfx_certificate_password", value);
    }

    /// <summary>
    /// The public_certificate attribute.
    /// </summary>
    public TerraformProperty<string>? PublicCertificate
    {
        set => SetProperty("public_certificate", value);
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
        set => SetProperty("kerberos_armoring_enabled", value);
    }

    /// <summary>
    /// The kerberos_rc4_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? KerberosRc4EncryptionEnabled
    {
        set => SetProperty("kerberos_rc4_encryption_enabled", value);
    }

    /// <summary>
    /// The ntlm_v1_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? NtlmV1Enabled
    {
        set => SetProperty("ntlm_v1_enabled", value);
    }

    /// <summary>
    /// The sync_kerberos_passwords attribute.
    /// </summary>
    public TerraformProperty<bool>? SyncKerberosPasswords
    {
        set => SetProperty("sync_kerberos_passwords", value);
    }

    /// <summary>
    /// The sync_ntlm_passwords attribute.
    /// </summary>
    public TerraformProperty<bool>? SyncNtlmPasswords
    {
        set => SetProperty("sync_ntlm_passwords", value);
    }

    /// <summary>
    /// The sync_on_prem_passwords attribute.
    /// </summary>
    public TerraformProperty<bool>? SyncOnPremPasswords
    {
        set => SetProperty("sync_on_prem_passwords", value);
    }

    /// <summary>
    /// The tls_v1_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TlsV1Enabled
    {
        set => SetProperty("tls_v1_enabled", value);
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
/// Manages a azurerm_active_directory_domain_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermActiveDirectoryDomainService : TerraformResource
{
    public AzurermActiveDirectoryDomainService(string name) : base("azurerm_active_directory_domain_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("deployment_id");
        SetOutput("resource_id");
        SetOutput("sync_owner");
        SetOutput("tenant_id");
        SetOutput("version");
        SetOutput("domain_configuration_type");
        SetOutput("domain_name");
        SetOutput("filtered_sync_enabled");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("sku");
        SetOutput("tags");
    }

    /// <summary>
    /// The domain_configuration_type attribute.
    /// </summary>
    public TerraformProperty<string> DomainConfigurationType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_configuration_type");
        set => SetProperty("domain_configuration_type", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_name");
        set => SetProperty("domain_name", value);
    }

    /// <summary>
    /// The filtered_sync_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> FilteredSyncEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("filtered_sync_enabled");
        set => SetProperty("filtered_sync_enabled", value);
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
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformProperty<string> Sku
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku");
        set => SetProperty("sku", value);
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
    /// Block for initial_replica_set.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InitialReplicaSet is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InitialReplicaSet block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InitialReplicaSet block(s) allowed")]
    public List<AzurermActiveDirectoryDomainServiceInitialReplicaSetBlock>? InitialReplicaSet
    {
        set => SetProperty("initial_replica_set", value);
    }

    /// <summary>
    /// Block for notifications.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Notifications block(s) allowed")]
    public List<AzurermActiveDirectoryDomainServiceNotificationsBlock>? Notifications
    {
        set => SetProperty("notifications", value);
    }

    /// <summary>
    /// Block for secure_ldap.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecureLdap block(s) allowed")]
    public List<AzurermActiveDirectoryDomainServiceSecureLdapBlock>? SecureLdap
    {
        set => SetProperty("secure_ldap", value);
    }

    /// <summary>
    /// Block for security.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Security block(s) allowed")]
    public List<AzurermActiveDirectoryDomainServiceSecurityBlock>? Security
    {
        set => SetProperty("security", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermActiveDirectoryDomainServiceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
