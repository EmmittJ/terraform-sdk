using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for initial_replica_set in .
/// Nesting mode: list
/// </summary>
public class AzurermActiveDirectoryDomainServiceInitialReplicaSetBlock : ITerraformBlock
{
    /// <summary>
    /// The domain_controller_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("domain_controller_ip_addresses")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> DomainControllerIpAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "domain_controller_ip_addresses");

    /// <summary>
    /// The external_access_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("external_access_ip_address")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExternalAccessIpAddress => new TerraformReferenceProperty<TerraformProperty<string>>("", "external_access_ip_address");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>("", "location");

    /// <summary>
    /// The service_status attribute.
    /// </summary>
    [TerraformPropertyName("service_status")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceStatus => new TerraformReferenceProperty<TerraformProperty<string>>("", "service_status");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformPropertyName("subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SubnetId { get; set; }

}

/// <summary>
/// Block type for notifications in .
/// Nesting mode: list
/// </summary>
public class AzurermActiveDirectoryDomainServiceNotificationsBlock : ITerraformBlock
{
    /// <summary>
    /// The additional_recipients attribute.
    /// </summary>
    [TerraformPropertyName("additional_recipients")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AdditionalRecipients { get; set; }

    /// <summary>
    /// The notify_dc_admins attribute.
    /// </summary>
    [TerraformPropertyName("notify_dc_admins")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? NotifyDcAdmins { get; set; }

    /// <summary>
    /// The notify_global_admins attribute.
    /// </summary>
    [TerraformPropertyName("notify_global_admins")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? NotifyGlobalAdmins { get; set; }

}

/// <summary>
/// Block type for secure_ldap in .
/// Nesting mode: list
/// </summary>
public class AzurermActiveDirectoryDomainServiceSecureLdapBlock : ITerraformBlock
{
    /// <summary>
    /// The certificate_expiry attribute.
    /// </summary>
    [TerraformPropertyName("certificate_expiry")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateExpiry => new TerraformReferenceProperty<TerraformProperty<string>>("", "certificate_expiry");

    /// <summary>
    /// The certificate_thumbprint attribute.
    /// </summary>
    [TerraformPropertyName("certificate_thumbprint")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateThumbprint => new TerraformReferenceProperty<TerraformProperty<string>>("", "certificate_thumbprint");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

    /// <summary>
    /// The external_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("external_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ExternalAccessEnabled { get; set; }

    /// <summary>
    /// The pfx_certificate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PfxCertificate is required")]
    [TerraformPropertyName("pfx_certificate")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PfxCertificate { get; set; }

    /// <summary>
    /// The pfx_certificate_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PfxCertificatePassword is required")]
    [TerraformPropertyName("pfx_certificate_password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PfxCertificatePassword { get; set; }

    /// <summary>
    /// The public_certificate attribute.
    /// </summary>
    [TerraformPropertyName("public_certificate")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublicCertificate => new TerraformReferenceProperty<TerraformProperty<string>>("", "public_certificate");

}

/// <summary>
/// Block type for security in .
/// Nesting mode: list
/// </summary>
public class AzurermActiveDirectoryDomainServiceSecurityBlock : ITerraformBlock
{
    /// <summary>
    /// The kerberos_armoring_enabled attribute.
    /// </summary>
    [TerraformPropertyName("kerberos_armoring_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? KerberosArmoringEnabled { get; set; }

    /// <summary>
    /// The kerberos_rc4_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("kerberos_rc4_encryption_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? KerberosRc4EncryptionEnabled { get; set; }

    /// <summary>
    /// The ntlm_v1_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ntlm_v1_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? NtlmV1Enabled { get; set; }

    /// <summary>
    /// The sync_kerberos_passwords attribute.
    /// </summary>
    [TerraformPropertyName("sync_kerberos_passwords")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SyncKerberosPasswords { get; set; }

    /// <summary>
    /// The sync_ntlm_passwords attribute.
    /// </summary>
    [TerraformPropertyName("sync_ntlm_passwords")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SyncNtlmPasswords { get; set; }

    /// <summary>
    /// The sync_on_prem_passwords attribute.
    /// </summary>
    [TerraformPropertyName("sync_on_prem_passwords")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SyncOnPremPasswords { get; set; }

    /// <summary>
    /// The tls_v1_enabled attribute.
    /// </summary>
    [TerraformPropertyName("tls_v1_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? TlsV1Enabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermActiveDirectoryDomainServiceTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_active_directory_domain_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermActiveDirectoryDomainService : TerraformResource
{
    public AzurermActiveDirectoryDomainService(string name) : base("azurerm_active_directory_domain_service", name)
    {
    }

    /// <summary>
    /// The domain_configuration_type attribute.
    /// </summary>
    [TerraformPropertyName("domain_configuration_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DomainConfigurationType { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DomainName { get; set; }

    /// <summary>
    /// The filtered_sync_enabled attribute.
    /// </summary>
    [TerraformPropertyName("filtered_sync_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? FilteredSyncEnabled { get; set; }

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
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformPropertyName("sku")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Sku { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for initial_replica_set.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InitialReplicaSet is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InitialReplicaSet block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InitialReplicaSet block(s) allowed")]
    [TerraformPropertyName("initial_replica_set")]
    public TerraformList<TerraformBlock<AzurermActiveDirectoryDomainServiceInitialReplicaSetBlock>>? InitialReplicaSet { get; set; } = new();

    /// <summary>
    /// Block for notifications.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Notifications block(s) allowed")]
    [TerraformPropertyName("notifications")]
    public TerraformList<TerraformBlock<AzurermActiveDirectoryDomainServiceNotificationsBlock>>? Notifications { get; set; } = new();

    /// <summary>
    /// Block for secure_ldap.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecureLdap block(s) allowed")]
    [TerraformPropertyName("secure_ldap")]
    public TerraformList<TerraformBlock<AzurermActiveDirectoryDomainServiceSecureLdapBlock>>? SecureLdap { get; set; } = new();

    /// <summary>
    /// Block for security.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Security block(s) allowed")]
    [TerraformPropertyName("security")]
    public TerraformList<TerraformBlock<AzurermActiveDirectoryDomainServiceSecurityBlock>>? Security { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermActiveDirectoryDomainServiceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The deployment_id attribute.
    /// </summary>
    [TerraformPropertyName("deployment_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeploymentId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "deployment_id");

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ResourceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_id");

    /// <summary>
    /// The sync_owner attribute.
    /// </summary>
    [TerraformPropertyName("sync_owner")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SyncOwner => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sync_owner");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tenant_id");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Version => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "version");

}
