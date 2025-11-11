using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbPostgresqlClusterMaintenanceWindowBlock
{
    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [TerraformPropertyName("day_of_week")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DayOfWeek { get; set; }

    /// <summary>
    /// The start_hour attribute.
    /// </summary>
    [TerraformPropertyName("start_hour")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? StartHour { get; set; }

    /// <summary>
    /// The start_minute attribute.
    /// </summary>
    [TerraformPropertyName("start_minute")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? StartMinute { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbPostgresqlClusterTimeoutsBlock
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
    public TerraformValue<string>? AdministratorLoginPassword { get; set; }

    /// <summary>
    /// The citus_version attribute.
    /// </summary>
    [TerraformPropertyName("citus_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CitusVersion { get; set; } = default!;

    /// <summary>
    /// The coordinator_public_ip_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("coordinator_public_ip_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CoordinatorPublicIpAccessEnabled { get; set; }

    /// <summary>
    /// The coordinator_server_edition attribute.
    /// </summary>
    [TerraformPropertyName("coordinator_server_edition")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CoordinatorServerEdition { get; set; }

    /// <summary>
    /// The coordinator_storage_quota_in_mb attribute.
    /// </summary>
    [TerraformPropertyName("coordinator_storage_quota_in_mb")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? CoordinatorStorageQuotaInMb { get; set; }

    /// <summary>
    /// The coordinator_vcore_count attribute.
    /// </summary>
    [TerraformPropertyName("coordinator_vcore_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? CoordinatorVcoreCount { get; set; }

    /// <summary>
    /// The ha_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ha_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? HaEnabled { get; set; }

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
    /// The node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeCount is required")]
    [TerraformPropertyName("node_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> NodeCount { get; set; }

    /// <summary>
    /// The node_public_ip_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("node_public_ip_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? NodePublicIpAccessEnabled { get; set; }

    /// <summary>
    /// The node_server_edition attribute.
    /// </summary>
    [TerraformPropertyName("node_server_edition")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NodeServerEdition { get; set; }

    /// <summary>
    /// The node_storage_quota_in_mb attribute.
    /// </summary>
    [TerraformPropertyName("node_storage_quota_in_mb")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> NodeStorageQuotaInMb { get; set; } = default!;

    /// <summary>
    /// The node_vcores attribute.
    /// </summary>
    [TerraformPropertyName("node_vcores")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> NodeVcores { get; set; } = default!;

    /// <summary>
    /// The point_in_time_in_utc attribute.
    /// </summary>
    [TerraformPropertyName("point_in_time_in_utc")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PointInTimeInUtc { get; set; }

    /// <summary>
    /// The preferred_primary_zone attribute.
    /// </summary>
    [TerraformPropertyName("preferred_primary_zone")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PreferredPrimaryZone { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The shards_on_coordinator_enabled attribute.
    /// </summary>
    [TerraformPropertyName("shards_on_coordinator_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> ShardsOnCoordinatorEnabled { get; set; } = default!;

    /// <summary>
    /// The source_location attribute.
    /// </summary>
    [TerraformPropertyName("source_location")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceLocation { get; set; }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("source_resource_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceResourceId { get; set; }

    /// <summary>
    /// The sql_version attribute.
    /// </summary>
    [TerraformPropertyName("sql_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SqlVersion { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    [TerraformPropertyName("maintenance_window")]
    public TerraformList<TerraformBlock<AzurermCosmosdbPostgresqlClusterMaintenanceWindowBlock>>? MaintenanceWindow { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermCosmosdbPostgresqlClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The earliest_restore_time attribute.
    /// </summary>
    [TerraformPropertyName("earliest_restore_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EarliestRestoreTime => new TerraformReference(this, "earliest_restore_time");

    /// <summary>
    /// The servers attribute.
    /// </summary>
    [TerraformPropertyName("servers")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Servers => new TerraformReference(this, "servers");

}
