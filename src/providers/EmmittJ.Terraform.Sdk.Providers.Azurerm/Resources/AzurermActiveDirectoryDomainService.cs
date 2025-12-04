using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for initial_replica_set in AzurermActiveDirectoryDomainService.
/// Nesting mode: list
/// </summary>
public class AzurermActiveDirectoryDomainServiceInitialReplicaSetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "initial_replica_set";

    /// <summary>
    /// The domain_controller_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> DomainControllerIpAddresses
        => AsReference("domain_controller_ip_addresses");

    /// <summary>
    /// The external_access_ip_address attribute.
    /// </summary>
    public TerraformValue<string> ExternalAccessIpAddress
        => AsReference("external_access_ip_address");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The service_status attribute.
    /// </summary>
    public TerraformValue<string> ServiceStatus
        => AsReference("service_status");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

}


/// <summary>
/// Block type for notifications in AzurermActiveDirectoryDomainService.
/// Nesting mode: list
/// </summary>
public class AzurermActiveDirectoryDomainServiceNotificationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notifications";

    /// <summary>
    /// The additional_recipients attribute.
    /// </summary>
    public TerraformSet<string>? AdditionalRecipients
    {
        get => GetArgument<TerraformSet<string>>("additional_recipients");
        set => SetArgument("additional_recipients", value);
    }

    /// <summary>
    /// The notify_dc_admins attribute.
    /// </summary>
    public TerraformValue<bool>? NotifyDcAdmins
    {
        get => GetArgument<TerraformValue<bool>>("notify_dc_admins");
        set => SetArgument("notify_dc_admins", value);
    }

    /// <summary>
    /// The notify_global_admins attribute.
    /// </summary>
    public TerraformValue<bool>? NotifyGlobalAdmins
    {
        get => GetArgument<TerraformValue<bool>>("notify_global_admins");
        set => SetArgument("notify_global_admins", value);
    }

}


/// <summary>
/// Block type for secure_ldap in AzurermActiveDirectoryDomainService.
/// Nesting mode: list
/// </summary>
public class AzurermActiveDirectoryDomainServiceSecureLdapBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secure_ldap";

    /// <summary>
    /// The certificate_expiry attribute.
    /// </summary>
    public TerraformValue<string> CertificateExpiry
        => AsReference("certificate_expiry");

    /// <summary>
    /// The certificate_thumbprint attribute.
    /// </summary>
    public TerraformValue<string> CertificateThumbprint
        => AsReference("certificate_thumbprint");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The external_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ExternalAccessEnabled
    {
        get => GetArgument<TerraformValue<bool>>("external_access_enabled");
        set => SetArgument("external_access_enabled", value);
    }

    /// <summary>
    /// The pfx_certificate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PfxCertificate is required")]
    public required TerraformValue<string> PfxCertificate
    {
        get => GetRequiredArgument<TerraformValue<string>>("pfx_certificate");
        set => SetArgument("pfx_certificate", value);
    }

    /// <summary>
    /// The pfx_certificate_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PfxCertificatePassword is required")]
    public required TerraformValue<string> PfxCertificatePassword
    {
        get => GetRequiredArgument<TerraformValue<string>>("pfx_certificate_password");
        set => SetArgument("pfx_certificate_password", value);
    }

    /// <summary>
    /// The public_certificate attribute.
    /// </summary>
    public TerraformValue<string> PublicCertificate
        => AsReference("public_certificate");

}


/// <summary>
/// Block type for security in AzurermActiveDirectoryDomainService.
/// Nesting mode: list
/// </summary>
public class AzurermActiveDirectoryDomainServiceSecurityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "security";

    /// <summary>
    /// The kerberos_armoring_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? KerberosArmoringEnabled
    {
        get => GetArgument<TerraformValue<bool>>("kerberos_armoring_enabled");
        set => SetArgument("kerberos_armoring_enabled", value);
    }

    /// <summary>
    /// The kerberos_rc4_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? KerberosRc4EncryptionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("kerberos_rc4_encryption_enabled");
        set => SetArgument("kerberos_rc4_encryption_enabled", value);
    }

    /// <summary>
    /// The ntlm_v1_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? NtlmV1Enabled
    {
        get => GetArgument<TerraformValue<bool>>("ntlm_v1_enabled");
        set => SetArgument("ntlm_v1_enabled", value);
    }

    /// <summary>
    /// The sync_kerberos_passwords attribute.
    /// </summary>
    public TerraformValue<bool>? SyncKerberosPasswords
    {
        get => GetArgument<TerraformValue<bool>>("sync_kerberos_passwords");
        set => SetArgument("sync_kerberos_passwords", value);
    }

    /// <summary>
    /// The sync_ntlm_passwords attribute.
    /// </summary>
    public TerraformValue<bool>? SyncNtlmPasswords
    {
        get => GetArgument<TerraformValue<bool>>("sync_ntlm_passwords");
        set => SetArgument("sync_ntlm_passwords", value);
    }

    /// <summary>
    /// The sync_on_prem_passwords attribute.
    /// </summary>
    public TerraformValue<bool>? SyncOnPremPasswords
    {
        get => GetArgument<TerraformValue<bool>>("sync_on_prem_passwords");
        set => SetArgument("sync_on_prem_passwords", value);
    }

    /// <summary>
    /// The tls_v1_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TlsV1Enabled
    {
        get => GetArgument<TerraformValue<bool>>("tls_v1_enabled");
        set => SetArgument("tls_v1_enabled", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermActiveDirectoryDomainService.
/// Nesting mode: single
/// </summary>
public class AzurermActiveDirectoryDomainServiceTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_active_directory_domain_service Terraform resource.
/// Manages a azurerm_active_directory_domain_service resource.
/// </summary>
public partial class AzurermActiveDirectoryDomainService(string name) : TerraformResource("azurerm_active_directory_domain_service", name)
{
    /// <summary>
    /// The domain_configuration_type attribute.
    /// </summary>
    public TerraformValue<string>? DomainConfigurationType
    {
        get => GetArgument<TerraformValue<string>>("domain_configuration_type");
        set => SetArgument("domain_configuration_type", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => GetRequiredArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The filtered_sync_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? FilteredSyncEnabled
    {
        get => GetArgument<TerraformValue<bool>>("filtered_sync_enabled");
        set => SetArgument("filtered_sync_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformValue<string> Sku
    {
        get => GetRequiredArgument<TerraformValue<string>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The deployment_id attribute.
    /// </summary>
    public TerraformValue<string> DeploymentId
        => AsReference("deployment_id");

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformValue<string> ResourceId
        => AsReference("resource_id");

    /// <summary>
    /// The sync_owner attribute.
    /// </summary>
    public TerraformValue<string> SyncOwner
        => AsReference("sync_owner");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<double> Version
        => AsReference("version");

    /// <summary>
    /// InitialReplicaSet block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InitialReplicaSet is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InitialReplicaSet block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InitialReplicaSet block(s) allowed")]
    public required TerraformList<AzurermActiveDirectoryDomainServiceInitialReplicaSetBlock> InitialReplicaSet
    {
        get => GetRequiredArgument<TerraformList<AzurermActiveDirectoryDomainServiceInitialReplicaSetBlock>>("initial_replica_set");
        set => SetArgument("initial_replica_set", value);
    }

    /// <summary>
    /// Notifications block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Notifications block(s) allowed")]
    public TerraformList<AzurermActiveDirectoryDomainServiceNotificationsBlock>? Notifications
    {
        get => GetArgument<TerraformList<AzurermActiveDirectoryDomainServiceNotificationsBlock>>("notifications");
        set => SetArgument("notifications", value);
    }

    /// <summary>
    /// SecureLdap block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecureLdap block(s) allowed")]
    public TerraformList<AzurermActiveDirectoryDomainServiceSecureLdapBlock>? SecureLdap
    {
        get => GetArgument<TerraformList<AzurermActiveDirectoryDomainServiceSecureLdapBlock>>("secure_ldap");
        set => SetArgument("secure_ldap", value);
    }

    /// <summary>
    /// Security block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Security block(s) allowed")]
    public TerraformList<AzurermActiveDirectoryDomainServiceSecurityBlock>? Security
    {
        get => GetArgument<TerraformList<AzurermActiveDirectoryDomainServiceSecurityBlock>>("security");
        set => SetArgument("security", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermActiveDirectoryDomainServiceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermActiveDirectoryDomainServiceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
