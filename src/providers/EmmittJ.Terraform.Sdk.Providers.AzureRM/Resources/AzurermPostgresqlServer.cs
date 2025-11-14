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
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermPostgresqlServerIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for threat_detection_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermPostgresqlServerThreatDetectionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "threat_detection_policy";

    /// <summary>
    /// The disabled_alerts attribute.
    /// </summary>
    [TerraformArgument("disabled_alerts")]
    public TerraformSet<string>? DisabledAlerts
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "disabled_alerts").ResolveNodes(ctx));
        set => SetArgument("disabled_alerts", value);
    }

    /// <summary>
    /// The email_account_admins attribute.
    /// </summary>
    [TerraformArgument("email_account_admins")]
    public TerraformValue<bool>? EmailAccountAdmins
    {
        get => new TerraformReference<bool>(this, "email_account_admins");
        set => SetArgument("email_account_admins", value);
    }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    [TerraformArgument("email_addresses")]
    public TerraformSet<string>? EmailAddresses
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "email_addresses").ResolveNodes(ctx));
        set => SetArgument("email_addresses", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The retention_days attribute.
    /// </summary>
    [TerraformArgument("retention_days")]
    public TerraformValue<double>? RetentionDays
    {
        get => new TerraformReference<double>(this, "retention_days");
        set => SetArgument("retention_days", value);
    }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    [TerraformArgument("storage_account_access_key")]
    public TerraformValue<string>? StorageAccountAccessKey
    {
        get => new TerraformReference<string>(this, "storage_account_access_key");
        set => SetArgument("storage_account_access_key", value);
    }

    /// <summary>
    /// The storage_endpoint attribute.
    /// </summary>
    [TerraformArgument("storage_endpoint")]
    public TerraformValue<string>? StorageEndpoint
    {
        get => new TerraformReference<string>(this, "storage_endpoint");
        set => SetArgument("storage_endpoint", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPostgresqlServerTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_postgresql_server resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermPostgresqlServer : TerraformResource
{
    public AzurermPostgresqlServer(string name) : base("azurerm_postgresql_server", name)
    {
    }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    [TerraformArgument("administrator_login")]
    public TerraformValue<string> AdministratorLogin
    {
        get => new TerraformReference<string>(this, "administrator_login");
        set => SetArgument("administrator_login", value);
    }

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    [TerraformArgument("administrator_login_password")]
    public TerraformValue<string>? AdministratorLoginPassword
    {
        get => new TerraformReference<string>(this, "administrator_login_password");
        set => SetArgument("administrator_login_password", value);
    }

    /// <summary>
    /// The administrator_login_password_wo attribute.
    /// </summary>
    [TerraformArgument("administrator_login_password_wo")]
    public TerraformValue<string>? AdministratorLoginPasswordWo
    {
        get => new TerraformReference<string>(this, "administrator_login_password_wo");
        set => SetArgument("administrator_login_password_wo", value);
    }

    /// <summary>
    /// The administrator_login_password_wo_version attribute.
    /// </summary>
    [TerraformArgument("administrator_login_password_wo_version")]
    public TerraformValue<double>? AdministratorLoginPasswordWoVersion
    {
        get => new TerraformReference<double>(this, "administrator_login_password_wo_version");
        set => SetArgument("administrator_login_password_wo_version", value);
    }

    /// <summary>
    /// The auto_grow_enabled attribute.
    /// </summary>
    [TerraformArgument("auto_grow_enabled")]
    public TerraformValue<bool>? AutoGrowEnabled
    {
        get => new TerraformReference<bool>(this, "auto_grow_enabled");
        set => SetArgument("auto_grow_enabled", value);
    }

    /// <summary>
    /// The backup_retention_days attribute.
    /// </summary>
    [TerraformArgument("backup_retention_days")]
    public TerraformValue<double> BackupRetentionDays
    {
        get => new TerraformReference<double>(this, "backup_retention_days");
        set => SetArgument("backup_retention_days", value);
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    [TerraformArgument("create_mode")]
    public TerraformValue<string>? CreateMode
    {
        get => new TerraformReference<string>(this, "create_mode");
        set => SetArgument("create_mode", value);
    }

    /// <summary>
    /// The creation_source_server_id attribute.
    /// </summary>
    [TerraformArgument("creation_source_server_id")]
    public TerraformValue<string>? CreationSourceServerId
    {
        get => new TerraformReference<string>(this, "creation_source_server_id");
        set => SetArgument("creation_source_server_id", value);
    }

    /// <summary>
    /// The geo_redundant_backup_enabled attribute.
    /// </summary>
    [TerraformArgument("geo_redundant_backup_enabled")]
    public TerraformValue<bool>? GeoRedundantBackupEnabled
    {
        get => new TerraformReference<bool>(this, "geo_redundant_backup_enabled");
        set => SetArgument("geo_redundant_backup_enabled", value);
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
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    [TerraformArgument("infrastructure_encryption_enabled")]
    public TerraformValue<bool>? InfrastructureEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "infrastructure_encryption_enabled");
        set => SetArgument("infrastructure_encryption_enabled", value);
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
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformArgument("public_network_access_enabled")]
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
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
    /// The restore_point_in_time attribute.
    /// </summary>
    [TerraformArgument("restore_point_in_time")]
    public TerraformValue<string>? RestorePointInTime
    {
        get => new TerraformReference<string>(this, "restore_point_in_time");
        set => SetArgument("restore_point_in_time", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformArgument("sku_name")]
    public required TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The ssl_enforcement_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SslEnforcementEnabled is required")]
    [TerraformArgument("ssl_enforcement_enabled")]
    public required TerraformValue<bool> SslEnforcementEnabled
    {
        get => new TerraformReference<bool>(this, "ssl_enforcement_enabled");
        set => SetArgument("ssl_enforcement_enabled", value);
    }

    /// <summary>
    /// The ssl_minimal_tls_version_enforced attribute.
    /// </summary>
    [TerraformArgument("ssl_minimal_tls_version_enforced")]
    public TerraformValue<string>? SslMinimalTlsVersionEnforced
    {
        get => new TerraformReference<string>(this, "ssl_minimal_tls_version_enforced");
        set => SetArgument("ssl_minimal_tls_version_enforced", value);
    }

    /// <summary>
    /// The storage_mb attribute.
    /// </summary>
    [TerraformArgument("storage_mb")]
    public TerraformValue<double> StorageMb
    {
        get => new TerraformReference<double>(this, "storage_mb");
        set => SetArgument("storage_mb", value);
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
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformArgument("version")]
    public required TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermPostgresqlServerIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for threat_detection_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThreatDetectionPolicy block(s) allowed")]
    [TerraformArgument("threat_detection_policy")]
    public TerraformList<AzurermPostgresqlServerThreatDetectionPolicyBlock> ThreatDetectionPolicy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermPostgresqlServerTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformArgument("fqdn")]
    public TerraformValue<string> Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
    }

}
