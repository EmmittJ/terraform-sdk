using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for initial_replica_set in .
/// Nesting mode: list
/// </summary>
public partial class AzurermActiveDirectoryDomainServiceInitialReplicaSetBlock : TerraformBlockBase
{





    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformProperty("subnet_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SubnetId { get; set; }

}

/// <summary>
/// Block type for notifications in .
/// Nesting mode: list
/// </summary>
public partial class AzurermActiveDirectoryDomainServiceNotificationsBlock : TerraformBlockBase
{
    /// <summary>
    /// The additional_recipients attribute.
    /// </summary>
    [TerraformProperty("additional_recipients")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// The notify_dc_admins attribute.
    /// </summary>
    [TerraformProperty("notify_dc_admins")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? NotifyDcAdmins { get; set; }

    /// <summary>
    /// The notify_global_admins attribute.
    /// </summary>
    [TerraformProperty("notify_global_admins")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? NotifyGlobalAdmins { get; set; }

}

/// <summary>
/// Block type for secure_ldap in .
/// Nesting mode: list
/// </summary>
public partial class AzurermActiveDirectoryDomainServiceSecureLdapBlock : TerraformBlockBase
{


    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The external_access_enabled attribute.
    /// </summary>
    [TerraformProperty("external_access_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ExternalAccessEnabled { get; set; }

    /// <summary>
    /// The pfx_certificate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PfxCertificate is required")]
    [TerraformProperty("pfx_certificate")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PfxCertificate { get; set; }

    /// <summary>
    /// The pfx_certificate_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PfxCertificatePassword is required")]
    [TerraformProperty("pfx_certificate_password")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PfxCertificatePassword { get; set; }


}

/// <summary>
/// Block type for security in .
/// Nesting mode: list
/// </summary>
public partial class AzurermActiveDirectoryDomainServiceSecurityBlock : TerraformBlockBase
{
    /// <summary>
    /// The kerberos_armoring_enabled attribute.
    /// </summary>
    [TerraformProperty("kerberos_armoring_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? KerberosArmoringEnabled { get; set; }

    /// <summary>
    /// The kerberos_rc4_encryption_enabled attribute.
    /// </summary>
    [TerraformProperty("kerberos_rc4_encryption_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? KerberosRc4EncryptionEnabled { get; set; }

    /// <summary>
    /// The ntlm_v1_enabled attribute.
    /// </summary>
    [TerraformProperty("ntlm_v1_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? NtlmV1Enabled { get; set; }

    /// <summary>
    /// The sync_kerberos_passwords attribute.
    /// </summary>
    [TerraformProperty("sync_kerberos_passwords")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SyncKerberosPasswords { get; set; }

    /// <summary>
    /// The sync_ntlm_passwords attribute.
    /// </summary>
    [TerraformProperty("sync_ntlm_passwords")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SyncNtlmPasswords { get; set; }

    /// <summary>
    /// The sync_on_prem_passwords attribute.
    /// </summary>
    [TerraformProperty("sync_on_prem_passwords")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SyncOnPremPasswords { get; set; }

    /// <summary>
    /// The tls_v1_enabled attribute.
    /// </summary>
    [TerraformProperty("tls_v1_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? TlsV1Enabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermActiveDirectoryDomainServiceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_active_directory_domain_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermActiveDirectoryDomainService : TerraformResource
{
    public AzurermActiveDirectoryDomainService(string name) : base("azurerm_active_directory_domain_service", name)
    {
    }

    /// <summary>
    /// The domain_configuration_type attribute.
    /// </summary>
    [TerraformProperty("domain_configuration_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DomainConfigurationType { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformProperty("domain_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The filtered_sync_enabled attribute.
    /// </summary>
    [TerraformProperty("filtered_sync_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? FilteredSyncEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformProperty("sku")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Sku { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for initial_replica_set.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InitialReplicaSet is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InitialReplicaSet block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InitialReplicaSet block(s) allowed")]
    [TerraformProperty("initial_replica_set")]
    public TerraformList<TerraformBlock<AzurermActiveDirectoryDomainServiceInitialReplicaSetBlock>>? InitialReplicaSet { get; set; }

    /// <summary>
    /// Block for notifications.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Notifications block(s) allowed")]
    [TerraformProperty("notifications")]
    public TerraformList<TerraformBlock<AzurermActiveDirectoryDomainServiceNotificationsBlock>>? Notifications { get; set; }

    /// <summary>
    /// Block for secure_ldap.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecureLdap block(s) allowed")]
    [TerraformProperty("secure_ldap")]
    public TerraformList<TerraformBlock<AzurermActiveDirectoryDomainServiceSecureLdapBlock>>? SecureLdap { get; set; }

    /// <summary>
    /// Block for security.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Security block(s) allowed")]
    [TerraformProperty("security")]
    public TerraformList<TerraformBlock<AzurermActiveDirectoryDomainServiceSecurityBlock>>? Security { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermActiveDirectoryDomainServiceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The deployment_id attribute.
    /// </summary>
    [TerraformProperty("deployment_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DeploymentId { get; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformProperty("resource_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResourceId { get; }

    /// <summary>
    /// The sync_owner attribute.
    /// </summary>
    [TerraformProperty("sync_owner")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SyncOwner { get; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformProperty("tenant_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TenantId { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> Version { get; }

}
