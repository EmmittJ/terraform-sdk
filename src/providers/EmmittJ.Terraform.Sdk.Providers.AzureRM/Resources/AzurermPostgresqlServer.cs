using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermPostgresqlServerIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformPropertyName("principal_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrincipalId => new TerraformReferenceProperty<TerraformProperty<string>>("", "principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantId => new TerraformReferenceProperty<TerraformProperty<string>>("", "tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for threat_detection_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermPostgresqlServerThreatDetectionPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// The disabled_alerts attribute.
    /// </summary>
    [TerraformPropertyName("disabled_alerts")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? DisabledAlerts { get; set; }

    /// <summary>
    /// The email_account_admins attribute.
    /// </summary>
    [TerraformPropertyName("email_account_admins")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EmailAccountAdmins { get; set; }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    [TerraformPropertyName("email_addresses")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? EmailAddresses { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The retention_days attribute.
    /// </summary>
    [TerraformPropertyName("retention_days")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RetentionDays { get; set; }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_access_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageAccountAccessKey { get; set; }

    /// <summary>
    /// The storage_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("storage_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageEndpoint { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPostgresqlServerTimeoutsBlock : ITerraformBlock
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
    [TerraformPropertyName("administrator_login")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AdministratorLogin { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "administrator_login");

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    [TerraformPropertyName("administrator_login_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AdministratorLoginPassword { get; set; }

    /// <summary>
    /// The administrator_login_password_wo attribute.
    /// </summary>
    [TerraformPropertyName("administrator_login_password_wo")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AdministratorLoginPasswordWo { get; set; }

    /// <summary>
    /// The administrator_login_password_wo_version attribute.
    /// </summary>
    [TerraformPropertyName("administrator_login_password_wo_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? AdministratorLoginPasswordWoVersion { get; set; }

    /// <summary>
    /// The auto_grow_enabled attribute.
    /// </summary>
    [TerraformPropertyName("auto_grow_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutoGrowEnabled { get; set; }

    /// <summary>
    /// The backup_retention_days attribute.
    /// </summary>
    [TerraformPropertyName("backup_retention_days")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> BackupRetentionDays { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "backup_retention_days");

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    [TerraformPropertyName("create_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CreateMode { get; set; }

    /// <summary>
    /// The creation_source_server_id attribute.
    /// </summary>
    [TerraformPropertyName("creation_source_server_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CreationSourceServerId { get; set; }

    /// <summary>
    /// The geo_redundant_backup_enabled attribute.
    /// </summary>
    [TerraformPropertyName("geo_redundant_backup_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? GeoRedundantBackupEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("infrastructure_encryption_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? InfrastructureEncryptionEnabled { get; set; }

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
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The restore_point_in_time attribute.
    /// </summary>
    [TerraformPropertyName("restore_point_in_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RestorePointInTime { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformPropertyName("sku_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SkuName { get; set; }

    /// <summary>
    /// The ssl_enforcement_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SslEnforcementEnabled is required")]
    [TerraformPropertyName("ssl_enforcement_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> SslEnforcementEnabled { get; set; }

    /// <summary>
    /// The ssl_minimal_tls_version_enforced attribute.
    /// </summary>
    [TerraformPropertyName("ssl_minimal_tls_version_enforced")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SslMinimalTlsVersionEnforced { get; set; }

    /// <summary>
    /// The storage_mb attribute.
    /// </summary>
    [TerraformPropertyName("storage_mb")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> StorageMb { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "storage_mb");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformPropertyName("version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Version { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermPostgresqlServerIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for threat_detection_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThreatDetectionPolicy block(s) allowed")]
    [TerraformPropertyName("threat_detection_policy")]
    public TerraformList<TerraformBlock<AzurermPostgresqlServerThreatDetectionPolicyBlock>>? ThreatDetectionPolicy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermPostgresqlServerTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformPropertyName("fqdn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Fqdn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "fqdn");

}
