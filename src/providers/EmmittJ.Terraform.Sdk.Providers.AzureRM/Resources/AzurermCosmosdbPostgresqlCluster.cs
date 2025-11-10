using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbPostgresqlClusterMaintenanceWindowBlock : ITerraformBlock
{
    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [TerraformPropertyName("day_of_week")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DayOfWeek { get; set; }

    /// <summary>
    /// The start_hour attribute.
    /// </summary>
    [TerraformPropertyName("start_hour")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? StartHour { get; set; }

    /// <summary>
    /// The start_minute attribute.
    /// </summary>
    [TerraformPropertyName("start_minute")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? StartMinute { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbPostgresqlClusterTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_cosmosdb_postgresql_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermCosmosdbPostgresqlCluster : TerraformResource
{
    public AzurermCosmosdbPostgresqlCluster(string name) : base("azurerm_cosmosdb_postgresql_cluster", name)
    {
    }

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    [TerraformPropertyName("administrator_login_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AdministratorLoginPassword { get; set; }

    /// <summary>
    /// The citus_version attribute.
    /// </summary>
    [TerraformPropertyName("citus_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CitusVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "citus_version");

    /// <summary>
    /// The coordinator_public_ip_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("coordinator_public_ip_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CoordinatorPublicIpAccessEnabled { get; set; }

    /// <summary>
    /// The coordinator_server_edition attribute.
    /// </summary>
    [TerraformPropertyName("coordinator_server_edition")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CoordinatorServerEdition { get; set; }

    /// <summary>
    /// The coordinator_storage_quota_in_mb attribute.
    /// </summary>
    [TerraformPropertyName("coordinator_storage_quota_in_mb")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? CoordinatorStorageQuotaInMb { get; set; }

    /// <summary>
    /// The coordinator_vcore_count attribute.
    /// </summary>
    [TerraformPropertyName("coordinator_vcore_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? CoordinatorVcoreCount { get; set; }

    /// <summary>
    /// The ha_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ha_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? HaEnabled { get; set; }

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
    /// The node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeCount is required")]
    [TerraformPropertyName("node_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> NodeCount { get; set; }

    /// <summary>
    /// The node_public_ip_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("node_public_ip_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? NodePublicIpAccessEnabled { get; set; }

    /// <summary>
    /// The node_server_edition attribute.
    /// </summary>
    [TerraformPropertyName("node_server_edition")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NodeServerEdition { get; set; }

    /// <summary>
    /// The node_storage_quota_in_mb attribute.
    /// </summary>
    [TerraformPropertyName("node_storage_quota_in_mb")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> NodeStorageQuotaInMb { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "node_storage_quota_in_mb");

    /// <summary>
    /// The node_vcores attribute.
    /// </summary>
    [TerraformPropertyName("node_vcores")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> NodeVcores { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "node_vcores");

    /// <summary>
    /// The point_in_time_in_utc attribute.
    /// </summary>
    [TerraformPropertyName("point_in_time_in_utc")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PointInTimeInUtc { get; set; }

    /// <summary>
    /// The preferred_primary_zone attribute.
    /// </summary>
    [TerraformPropertyName("preferred_primary_zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PreferredPrimaryZone { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The shards_on_coordinator_enabled attribute.
    /// </summary>
    [TerraformPropertyName("shards_on_coordinator_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ShardsOnCoordinatorEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "shards_on_coordinator_enabled");

    /// <summary>
    /// The source_location attribute.
    /// </summary>
    [TerraformPropertyName("source_location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceLocation { get; set; }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("source_resource_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceResourceId { get; set; }

    /// <summary>
    /// The sql_version attribute.
    /// </summary>
    [TerraformPropertyName("sql_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SqlVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sql_version");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    [TerraformPropertyName("maintenance_window")]
    public TerraformList<TerraformBlock<AzurermCosmosdbPostgresqlClusterMaintenanceWindowBlock>>? MaintenanceWindow { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermCosmosdbPostgresqlClusterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The earliest_restore_time attribute.
    /// </summary>
    [TerraformPropertyName("earliest_restore_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EarliestRestoreTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "earliest_restore_time");

    /// <summary>
    /// The servers attribute.
    /// </summary>
    [TerraformPropertyName("servers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Servers => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "servers");

}
