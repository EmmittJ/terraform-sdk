using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for initial_replica_set in .
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
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "domain_controller_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The external_access_ip_address attribute.
    /// </summary>
    public TerraformValue<string> ExternalAccessIpAddress
    {
        get => new TerraformReference<string>(this, "external_access_ip_address");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The service_status attribute.
    /// </summary>
    public TerraformValue<string> ServiceStatus
    {
        get => new TerraformReference<string>(this, "service_status");
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

}

/// <summary>
/// Block type for notifications in .
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "additional_recipients").ResolveNodes(ctx));
        set => SetArgument("additional_recipients", value);
    }

    /// <summary>
    /// The notify_dc_admins attribute.
    /// </summary>
    public TerraformValue<bool>? NotifyDcAdmins
    {
        get => new TerraformReference<bool>(this, "notify_dc_admins");
        set => SetArgument("notify_dc_admins", value);
    }

    /// <summary>
    /// The notify_global_admins attribute.
    /// </summary>
    public TerraformValue<bool>? NotifyGlobalAdmins
    {
        get => new TerraformReference<bool>(this, "notify_global_admins");
        set => SetArgument("notify_global_admins", value);
    }

}

/// <summary>
/// Block type for secure_ldap in .
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
    {
        get => new TerraformReference<string>(this, "certificate_expiry");
    }

    /// <summary>
    /// The certificate_thumbprint attribute.
    /// </summary>
    public TerraformValue<string> CertificateThumbprint
    {
        get => new TerraformReference<string>(this, "certificate_thumbprint");
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The external_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ExternalAccessEnabled
    {
        get => new TerraformReference<bool>(this, "external_access_enabled");
        set => SetArgument("external_access_enabled", value);
    }

    /// <summary>
    /// The pfx_certificate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PfxCertificate is required")]
    public required TerraformValue<string> PfxCertificate
    {
        get => new TerraformReference<string>(this, "pfx_certificate");
        set => SetArgument("pfx_certificate", value);
    }

    /// <summary>
    /// The pfx_certificate_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PfxCertificatePassword is required")]
    public required TerraformValue<string> PfxCertificatePassword
    {
        get => new TerraformReference<string>(this, "pfx_certificate_password");
        set => SetArgument("pfx_certificate_password", value);
    }

    /// <summary>
    /// The public_certificate attribute.
    /// </summary>
    public TerraformValue<string> PublicCertificate
    {
        get => new TerraformReference<string>(this, "public_certificate");
    }

}

/// <summary>
/// Block type for security in .
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
        get => new TerraformReference<bool>(this, "kerberos_armoring_enabled");
        set => SetArgument("kerberos_armoring_enabled", value);
    }

    /// <summary>
    /// The kerberos_rc4_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? KerberosRc4EncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "kerberos_rc4_encryption_enabled");
        set => SetArgument("kerberos_rc4_encryption_enabled", value);
    }

    /// <summary>
    /// The ntlm_v1_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? NtlmV1Enabled
    {
        get => new TerraformReference<bool>(this, "ntlm_v1_enabled");
        set => SetArgument("ntlm_v1_enabled", value);
    }

    /// <summary>
    /// The sync_kerberos_passwords attribute.
    /// </summary>
    public TerraformValue<bool>? SyncKerberosPasswords
    {
        get => new TerraformReference<bool>(this, "sync_kerberos_passwords");
        set => SetArgument("sync_kerberos_passwords", value);
    }

    /// <summary>
    /// The sync_ntlm_passwords attribute.
    /// </summary>
    public TerraformValue<bool>? SyncNtlmPasswords
    {
        get => new TerraformReference<bool>(this, "sync_ntlm_passwords");
        set => SetArgument("sync_ntlm_passwords", value);
    }

    /// <summary>
    /// The sync_on_prem_passwords attribute.
    /// </summary>
    public TerraformValue<bool>? SyncOnPremPasswords
    {
        get => new TerraformReference<bool>(this, "sync_on_prem_passwords");
        set => SetArgument("sync_on_prem_passwords", value);
    }

    /// <summary>
    /// The tls_v1_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TlsV1Enabled
    {
        get => new TerraformReference<bool>(this, "tls_v1_enabled");
        set => SetArgument("tls_v1_enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
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
        get => new TerraformReference<string>(this, "domain_configuration_type");
        set => SetArgument("domain_configuration_type", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => new TerraformReference<string>(this, "domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The filtered_sync_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? FilteredSyncEnabled
    {
        get => new TerraformReference<bool>(this, "filtered_sync_enabled");
        set => SetArgument("filtered_sync_enabled", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

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
