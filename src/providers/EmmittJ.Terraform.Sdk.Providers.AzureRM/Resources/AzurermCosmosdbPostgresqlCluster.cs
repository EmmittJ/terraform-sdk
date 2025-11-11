using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCosmosdbPostgresqlClusterMaintenanceWindowBlock : TerraformBlockBase
{
    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [TerraformProperty("day_of_week")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DayOfWeek { get; set; }

    /// <summary>
    /// The start_hour attribute.
    /// </summary>
    [TerraformProperty("start_hour")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? StartHour { get; set; }

    /// <summary>
    /// The start_minute attribute.
    /// </summary>
    [TerraformProperty("start_minute")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? StartMinute { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermCosmosdbPostgresqlClusterTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_cosmosdb_postgresql_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermCosmosdbPostgresqlCluster : TerraformResource
{
    public AzurermCosmosdbPostgresqlCluster(string name) : base("azurerm_cosmosdb_postgresql_cluster", name)
    {
    }

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    [TerraformProperty("administrator_login_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AdministratorLoginPassword { get; set; }

    /// <summary>
    /// The citus_version attribute.
    /// </summary>
    [TerraformProperty("citus_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CitusVersion { get; set; }

    /// <summary>
    /// The coordinator_public_ip_access_enabled attribute.
    /// </summary>
    [TerraformProperty("coordinator_public_ip_access_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CoordinatorPublicIpAccessEnabled { get; set; }

    /// <summary>
    /// The coordinator_server_edition attribute.
    /// </summary>
    [TerraformProperty("coordinator_server_edition")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CoordinatorServerEdition { get; set; }

    /// <summary>
    /// The coordinator_storage_quota_in_mb attribute.
    /// </summary>
    [TerraformProperty("coordinator_storage_quota_in_mb")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? CoordinatorStorageQuotaInMb { get; set; }

    /// <summary>
    /// The coordinator_vcore_count attribute.
    /// </summary>
    [TerraformProperty("coordinator_vcore_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? CoordinatorVcoreCount { get; set; }

    /// <summary>
    /// The ha_enabled attribute.
    /// </summary>
    [TerraformProperty("ha_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? HaEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    /// The node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeCount is required")]
    [TerraformProperty("node_count")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> NodeCount { get; set; }

    /// <summary>
    /// The node_public_ip_access_enabled attribute.
    /// </summary>
    [TerraformProperty("node_public_ip_access_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? NodePublicIpAccessEnabled { get; set; }

    /// <summary>
    /// The node_server_edition attribute.
    /// </summary>
    [TerraformProperty("node_server_edition")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NodeServerEdition { get; set; }

    /// <summary>
    /// The node_storage_quota_in_mb attribute.
    /// </summary>
    [TerraformProperty("node_storage_quota_in_mb")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> NodeStorageQuotaInMb { get; set; }

    /// <summary>
    /// The node_vcores attribute.
    /// </summary>
    [TerraformProperty("node_vcores")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> NodeVcores { get; set; }

    /// <summary>
    /// The point_in_time_in_utc attribute.
    /// </summary>
    [TerraformProperty("point_in_time_in_utc")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PointInTimeInUtc { get; set; }

    /// <summary>
    /// The preferred_primary_zone attribute.
    /// </summary>
    [TerraformProperty("preferred_primary_zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PreferredPrimaryZone { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The shards_on_coordinator_enabled attribute.
    /// </summary>
    [TerraformProperty("shards_on_coordinator_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> ShardsOnCoordinatorEnabled { get; set; }

    /// <summary>
    /// The source_location attribute.
    /// </summary>
    [TerraformProperty("source_location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceLocation { get; set; }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    [TerraformProperty("source_resource_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceResourceId { get; set; }

    /// <summary>
    /// The sql_version attribute.
    /// </summary>
    [TerraformProperty("sql_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SqlVersion { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    [TerraformProperty("maintenance_window")]
    public partial TerraformList<TerraformBlock<AzurermCosmosdbPostgresqlClusterMaintenanceWindowBlock>>? MaintenanceWindow { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermCosmosdbPostgresqlClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The earliest_restore_time attribute.
    /// </summary>
    [TerraformProperty("earliest_restore_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EarliestRestoreTime { get; }

    /// <summary>
    /// The servers attribute.
    /// </summary>
    [TerraformProperty("servers")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Servers { get; }

}
