using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformArgument("subnet_id")]
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
    [TerraformArgument("additional_recipients")]
    public TerraformSet<string>? AdditionalRecipients
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "additional_recipients").ResolveNodes(ctx));
        set => SetArgument("additional_recipients", value);
    }

    /// <summary>
    /// The notify_dc_admins attribute.
    /// </summary>
    [TerraformArgument("notify_dc_admins")]
    public TerraformValue<bool>? NotifyDcAdmins
    {
        get => new TerraformReference<bool>(this, "notify_dc_admins");
        set => SetArgument("notify_dc_admins", value);
    }

    /// <summary>
    /// The notify_global_admins attribute.
    /// </summary>
    [TerraformArgument("notify_global_admins")]
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
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformArgument("enabled")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The external_access_enabled attribute.
    /// </summary>
    [TerraformArgument("external_access_enabled")]
    public TerraformValue<bool>? ExternalAccessEnabled
    {
        get => new TerraformReference<bool>(this, "external_access_enabled");
        set => SetArgument("external_access_enabled", value);
    }

    /// <summary>
    /// The pfx_certificate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PfxCertificate is required")]
    [TerraformArgument("pfx_certificate")]
    public required TerraformValue<string> PfxCertificate
    {
        get => new TerraformReference<string>(this, "pfx_certificate");
        set => SetArgument("pfx_certificate", value);
    }

    /// <summary>
    /// The pfx_certificate_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PfxCertificatePassword is required")]
    [TerraformArgument("pfx_certificate_password")]
    public required TerraformValue<string> PfxCertificatePassword
    {
        get => new TerraformReference<string>(this, "pfx_certificate_password");
        set => SetArgument("pfx_certificate_password", value);
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
    [TerraformArgument("kerberos_armoring_enabled")]
    public TerraformValue<bool>? KerberosArmoringEnabled
    {
        get => new TerraformReference<bool>(this, "kerberos_armoring_enabled");
        set => SetArgument("kerberos_armoring_enabled", value);
    }

    /// <summary>
    /// The kerberos_rc4_encryption_enabled attribute.
    /// </summary>
    [TerraformArgument("kerberos_rc4_encryption_enabled")]
    public TerraformValue<bool>? KerberosRc4EncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "kerberos_rc4_encryption_enabled");
        set => SetArgument("kerberos_rc4_encryption_enabled", value);
    }

    /// <summary>
    /// The ntlm_v1_enabled attribute.
    /// </summary>
    [TerraformArgument("ntlm_v1_enabled")]
    public TerraformValue<bool>? NtlmV1Enabled
    {
        get => new TerraformReference<bool>(this, "ntlm_v1_enabled");
        set => SetArgument("ntlm_v1_enabled", value);
    }

    /// <summary>
    /// The sync_kerberos_passwords attribute.
    /// </summary>
    [TerraformArgument("sync_kerberos_passwords")]
    public TerraformValue<bool>? SyncKerberosPasswords
    {
        get => new TerraformReference<bool>(this, "sync_kerberos_passwords");
        set => SetArgument("sync_kerberos_passwords", value);
    }

    /// <summary>
    /// The sync_ntlm_passwords attribute.
    /// </summary>
    [TerraformArgument("sync_ntlm_passwords")]
    public TerraformValue<bool>? SyncNtlmPasswords
    {
        get => new TerraformReference<bool>(this, "sync_ntlm_passwords");
        set => SetArgument("sync_ntlm_passwords", value);
    }

    /// <summary>
    /// The sync_on_prem_passwords attribute.
    /// </summary>
    [TerraformArgument("sync_on_prem_passwords")]
    public TerraformValue<bool>? SyncOnPremPasswords
    {
        get => new TerraformReference<bool>(this, "sync_on_prem_passwords");
        set => SetArgument("sync_on_prem_passwords", value);
    }

    /// <summary>
    /// The tls_v1_enabled attribute.
    /// </summary>
    [TerraformArgument("tls_v1_enabled")]
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
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
    }

    /// <summary>
    /// The domain_configuration_type attribute.
    /// </summary>
    [TerraformArgument("domain_configuration_type")]
    public TerraformValue<string>? DomainConfigurationType
    {
        get => new TerraformReference<string>(this, "domain_configuration_type");
        set => SetArgument("domain_configuration_type", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformArgument("domain_name")]
    public required TerraformValue<string> DomainName
    {
        get => new TerraformReference<string>(this, "domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The filtered_sync_enabled attribute.
    /// </summary>
    [TerraformArgument("filtered_sync_enabled")]
    public TerraformValue<bool>? FilteredSyncEnabled
    {
        get => new TerraformReference<bool>(this, "filtered_sync_enabled");
        set => SetArgument("filtered_sync_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformArgument("sku")]
    public required TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for initial_replica_set.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InitialReplicaSet is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InitialReplicaSet block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InitialReplicaSet block(s) allowed")]
    [TerraformArgument("initial_replica_set")]
    public required TerraformList<AzurermActiveDirectoryDomainServiceInitialReplicaSetBlock> InitialReplicaSet { get; set; } = new();

    /// <summary>
    /// Block for notifications.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Notifications block(s) allowed")]
    [TerraformArgument("notifications")]
    public TerraformList<AzurermActiveDirectoryDomainServiceNotificationsBlock> Notifications { get; set; } = new();

    /// <summary>
    /// Block for secure_ldap.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecureLdap block(s) allowed")]
    [TerraformArgument("secure_ldap")]
    public TerraformList<AzurermActiveDirectoryDomainServiceSecureLdapBlock> SecureLdap { get; set; } = new();

    /// <summary>
    /// Block for security.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Security block(s) allowed")]
    [TerraformArgument("security")]
    public TerraformList<AzurermActiveDirectoryDomainServiceSecurityBlock> Security { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermActiveDirectoryDomainServiceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The deployment_id attribute.
    /// </summary>
    [TerraformArgument("deployment_id")]
    public TerraformValue<string> DeploymentId
    {
        get => new TerraformReference<string>(this, "deployment_id");
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformArgument("resource_id")]
    public TerraformValue<string> ResourceId
    {
        get => new TerraformReference<string>(this, "resource_id");
    }

    /// <summary>
    /// The sync_owner attribute.
    /// </summary>
    [TerraformArgument("sync_owner")]
    public TerraformValue<string> SyncOwner
    {
        get => new TerraformReference<string>(this, "sync_owner");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformArgument("tenant_id")]
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformArgument("version")]
    public TerraformValue<double> Version
    {
        get => new TerraformReference<double>(this, "version");
    }

}
