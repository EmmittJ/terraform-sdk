using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for initial_replica_set in .
/// Nesting mode: list
/// </summary>
public class AzurermActiveDirectoryDomainServiceInitialReplicaSetBlock
{





    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformPropertyName("subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SubnetId { get; set; }

}

/// <summary>
/// Block type for notifications in .
/// Nesting mode: list
/// </summary>
public class AzurermActiveDirectoryDomainServiceNotificationsBlock
{
    /// <summary>
    /// The additional_recipients attribute.
    /// </summary>
    [TerraformPropertyName("additional_recipients")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// The notify_dc_admins attribute.
    /// </summary>
    [TerraformPropertyName("notify_dc_admins")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? NotifyDcAdmins { get; set; }

    /// <summary>
    /// The notify_global_admins attribute.
    /// </summary>
    [TerraformPropertyName("notify_global_admins")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? NotifyGlobalAdmins { get; set; }

}

/// <summary>
/// Block type for secure_ldap in .
/// Nesting mode: list
/// </summary>
public class AzurermActiveDirectoryDomainServiceSecureLdapBlock
{


    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The external_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("external_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ExternalAccessEnabled { get; set; }

    /// <summary>
    /// The pfx_certificate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PfxCertificate is required")]
    [TerraformPropertyName("pfx_certificate")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PfxCertificate { get; set; }

    /// <summary>
    /// The pfx_certificate_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PfxCertificatePassword is required")]
    [TerraformPropertyName("pfx_certificate_password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PfxCertificatePassword { get; set; }


}

/// <summary>
/// Block type for security in .
/// Nesting mode: list
/// </summary>
public class AzurermActiveDirectoryDomainServiceSecurityBlock
{
    /// <summary>
    /// The kerberos_armoring_enabled attribute.
    /// </summary>
    [TerraformPropertyName("kerberos_armoring_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? KerberosArmoringEnabled { get; set; }

    /// <summary>
    /// The kerberos_rc4_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("kerberos_rc4_encryption_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? KerberosRc4EncryptionEnabled { get; set; }

    /// <summary>
    /// The ntlm_v1_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ntlm_v1_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? NtlmV1Enabled { get; set; }

    /// <summary>
    /// The sync_kerberos_passwords attribute.
    /// </summary>
    [TerraformPropertyName("sync_kerberos_passwords")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SyncKerberosPasswords { get; set; }

    /// <summary>
    /// The sync_ntlm_passwords attribute.
    /// </summary>
    [TerraformPropertyName("sync_ntlm_passwords")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SyncNtlmPasswords { get; set; }

    /// <summary>
    /// The sync_on_prem_passwords attribute.
    /// </summary>
    [TerraformPropertyName("sync_on_prem_passwords")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SyncOnPremPasswords { get; set; }

    /// <summary>
    /// The tls_v1_enabled attribute.
    /// </summary>
    [TerraformPropertyName("tls_v1_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? TlsV1Enabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermActiveDirectoryDomainServiceTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

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
    public TerraformValue<string>? DomainConfigurationType { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The filtered_sync_enabled attribute.
    /// </summary>
    [TerraformPropertyName("filtered_sync_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? FilteredSyncEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformPropertyName("sku")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Sku { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for initial_replica_set.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InitialReplicaSet is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InitialReplicaSet block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InitialReplicaSet block(s) allowed")]
    [TerraformPropertyName("initial_replica_set")]
    public TerraformList<TerraformBlock<AzurermActiveDirectoryDomainServiceInitialReplicaSetBlock>>? InitialReplicaSet { get; set; }

    /// <summary>
    /// Block for notifications.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Notifications block(s) allowed")]
    [TerraformPropertyName("notifications")]
    public TerraformList<TerraformBlock<AzurermActiveDirectoryDomainServiceNotificationsBlock>>? Notifications { get; set; }

    /// <summary>
    /// Block for secure_ldap.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecureLdap block(s) allowed")]
    [TerraformPropertyName("secure_ldap")]
    public TerraformList<TerraformBlock<AzurermActiveDirectoryDomainServiceSecureLdapBlock>>? SecureLdap { get; set; }

    /// <summary>
    /// Block for security.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Security block(s) allowed")]
    [TerraformPropertyName("security")]
    public TerraformList<TerraformBlock<AzurermActiveDirectoryDomainServiceSecurityBlock>>? Security { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermActiveDirectoryDomainServiceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The deployment_id attribute.
    /// </summary>
    [TerraformPropertyName("deployment_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeploymentId => new TerraformReference(this, "deployment_id");

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ResourceId => new TerraformReference(this, "resource_id");

    /// <summary>
    /// The sync_owner attribute.
    /// </summary>
    [TerraformPropertyName("sync_owner")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SyncOwner => new TerraformReference(this, "sync_owner");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TenantId => new TerraformReference(this, "tenant_id");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Version => new TerraformReference(this, "version");

}
