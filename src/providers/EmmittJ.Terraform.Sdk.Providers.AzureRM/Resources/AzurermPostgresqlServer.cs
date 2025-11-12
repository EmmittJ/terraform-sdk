using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermPostgresqlServerIdentityBlock() : TerraformBlock("identity")
{


    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for threat_detection_policy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermPostgresqlServerThreatDetectionPolicyBlock() : TerraformBlock("threat_detection_policy")
{
    /// <summary>
    /// The disabled_alerts attribute.
    /// </summary>
    [TerraformProperty("disabled_alerts")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? DisabledAlerts { get; set; }

    /// <summary>
    /// The email_account_admins attribute.
    /// </summary>
    [TerraformProperty("email_account_admins")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EmailAccountAdmins { get; set; }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    [TerraformProperty("email_addresses")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? EmailAddresses { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The retention_days attribute.
    /// </summary>
    [TerraformProperty("retention_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RetentionDays { get; set; }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    [TerraformProperty("storage_account_access_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageAccountAccessKey { get; set; }

    /// <summary>
    /// The storage_endpoint attribute.
    /// </summary>
    [TerraformProperty("storage_endpoint")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageEndpoint { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermPostgresqlServerTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_postgresql_server resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermPostgresqlServer : TerraformResource
{
    public AzurermPostgresqlServer(string name) : base("azurerm_postgresql_server", name)
    {
    }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    [TerraformProperty("administrator_login")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AdministratorLogin { get; set; }

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    [TerraformProperty("administrator_login_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AdministratorLoginPassword { get; set; }

    /// <summary>
    /// The administrator_login_password_wo attribute.
    /// </summary>
    [TerraformProperty("administrator_login_password_wo")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AdministratorLoginPasswordWo { get; set; }

    /// <summary>
    /// The administrator_login_password_wo_version attribute.
    /// </summary>
    [TerraformProperty("administrator_login_password_wo_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AdministratorLoginPasswordWoVersion { get; set; }

    /// <summary>
    /// The auto_grow_enabled attribute.
    /// </summary>
    [TerraformProperty("auto_grow_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutoGrowEnabled { get; set; }

    /// <summary>
    /// The backup_retention_days attribute.
    /// </summary>
    [TerraformProperty("backup_retention_days")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> BackupRetentionDays { get; set; }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    [TerraformProperty("create_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CreateMode { get; set; }

    /// <summary>
    /// The creation_source_server_id attribute.
    /// </summary>
    [TerraformProperty("creation_source_server_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CreationSourceServerId { get; set; }

    /// <summary>
    /// The geo_redundant_backup_enabled attribute.
    /// </summary>
    [TerraformProperty("geo_redundant_backup_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? GeoRedundantBackupEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    [TerraformProperty("infrastructure_encryption_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? InfrastructureEncryptionEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The restore_point_in_time attribute.
    /// </summary>
    [TerraformProperty("restore_point_in_time")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RestorePointInTime { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformProperty("sku_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SkuName { get; set; }

    /// <summary>
    /// The ssl_enforcement_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SslEnforcementEnabled is required")]
    [TerraformProperty("ssl_enforcement_enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> SslEnforcementEnabled { get; set; }

    /// <summary>
    /// The ssl_minimal_tls_version_enforced attribute.
    /// </summary>
    [TerraformProperty("ssl_minimal_tls_version_enforced")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SslMinimalTlsVersionEnforced { get; set; }

    /// <summary>
    /// The storage_mb attribute.
    /// </summary>
    [TerraformProperty("storage_mb")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> StorageMb { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformProperty("version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Version { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<AzurermPostgresqlServerIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for threat_detection_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThreatDetectionPolicy block(s) allowed")]
    [TerraformProperty("threat_detection_policy")]
    public TerraformList<AzurermPostgresqlServerThreatDetectionPolicyBlock> ThreatDetectionPolicy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermPostgresqlServerTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformProperty("fqdn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Fqdn { get; }

}
