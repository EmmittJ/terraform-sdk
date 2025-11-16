using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbPostgresqlClusterMaintenanceWindowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_window";

    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    public TerraformValue<double>? DayOfWeek
    {
        get => new TerraformReference<double>(this, "day_of_week");
        set => SetArgument("day_of_week", value);
    }

    /// <summary>
    /// The start_hour attribute.
    /// </summary>
    public TerraformValue<double>? StartHour
    {
        get => new TerraformReference<double>(this, "start_hour");
        set => SetArgument("start_hour", value);
    }

    /// <summary>
    /// The start_minute attribute.
    /// </summary>
    public TerraformValue<double>? StartMinute
    {
        get => new TerraformReference<double>(this, "start_minute");
        set => SetArgument("start_minute", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbPostgresqlClusterTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_cosmosdb_postgresql_cluster Terraform resource.
/// Manages a azurerm_cosmosdb_postgresql_cluster resource.
/// </summary>
public partial class AzurermCosmosdbPostgresqlCluster(string name) : TerraformResource("azurerm_cosmosdb_postgresql_cluster", name)
{
    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    public TerraformValue<string>? AdministratorLoginPassword
    {
        get => new TerraformReference<string>(this, "administrator_login_password");
        set => SetArgument("administrator_login_password", value);
    }

    /// <summary>
    /// The citus_version attribute.
    /// </summary>
    public TerraformValue<string> CitusVersion
    {
        get => new TerraformReference<string>(this, "citus_version");
        set => SetArgument("citus_version", value);
    }

    /// <summary>
    /// The coordinator_public_ip_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CoordinatorPublicIpAccessEnabled
    {
        get => new TerraformReference<bool>(this, "coordinator_public_ip_access_enabled");
        set => SetArgument("coordinator_public_ip_access_enabled", value);
    }

    /// <summary>
    /// The coordinator_server_edition attribute.
    /// </summary>
    public TerraformValue<string>? CoordinatorServerEdition
    {
        get => new TerraformReference<string>(this, "coordinator_server_edition");
        set => SetArgument("coordinator_server_edition", value);
    }

    /// <summary>
    /// The coordinator_storage_quota_in_mb attribute.
    /// </summary>
    public TerraformValue<double>? CoordinatorStorageQuotaInMb
    {
        get => new TerraformReference<double>(this, "coordinator_storage_quota_in_mb");
        set => SetArgument("coordinator_storage_quota_in_mb", value);
    }

    /// <summary>
    /// The coordinator_vcore_count attribute.
    /// </summary>
    public TerraformValue<double>? CoordinatorVcoreCount
    {
        get => new TerraformReference<double>(this, "coordinator_vcore_count");
        set => SetArgument("coordinator_vcore_count", value);
    }

    /// <summary>
    /// The ha_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? HaEnabled
    {
        get => new TerraformReference<bool>(this, "ha_enabled");
        set => SetArgument("ha_enabled", value);
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
    /// The node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeCount is required")]
    public required TerraformValue<double> NodeCount
    {
        get => new TerraformReference<double>(this, "node_count");
        set => SetArgument("node_count", value);
    }

    /// <summary>
    /// The node_public_ip_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? NodePublicIpAccessEnabled
    {
        get => new TerraformReference<bool>(this, "node_public_ip_access_enabled");
        set => SetArgument("node_public_ip_access_enabled", value);
    }

    /// <summary>
    /// The node_server_edition attribute.
    /// </summary>
    public TerraformValue<string>? NodeServerEdition
    {
        get => new TerraformReference<string>(this, "node_server_edition");
        set => SetArgument("node_server_edition", value);
    }

    /// <summary>
    /// The node_storage_quota_in_mb attribute.
    /// </summary>
    public TerraformValue<double> NodeStorageQuotaInMb
    {
        get => new TerraformReference<double>(this, "node_storage_quota_in_mb");
        set => SetArgument("node_storage_quota_in_mb", value);
    }

    /// <summary>
    /// The node_vcores attribute.
    /// </summary>
    public TerraformValue<double> NodeVcores
    {
        get => new TerraformReference<double>(this, "node_vcores");
        set => SetArgument("node_vcores", value);
    }

    /// <summary>
    /// The point_in_time_in_utc attribute.
    /// </summary>
    public TerraformValue<string>? PointInTimeInUtc
    {
        get => new TerraformReference<string>(this, "point_in_time_in_utc");
        set => SetArgument("point_in_time_in_utc", value);
    }

    /// <summary>
    /// The preferred_primary_zone attribute.
    /// </summary>
    public TerraformValue<string>? PreferredPrimaryZone
    {
        get => new TerraformReference<string>(this, "preferred_primary_zone");
        set => SetArgument("preferred_primary_zone", value);
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
    /// The shards_on_coordinator_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ShardsOnCoordinatorEnabled
    {
        get => new TerraformReference<bool>(this, "shards_on_coordinator_enabled");
        set => SetArgument("shards_on_coordinator_enabled", value);
    }

    /// <summary>
    /// The source_location attribute.
    /// </summary>
    public TerraformValue<string>? SourceLocation
    {
        get => new TerraformReference<string>(this, "source_location");
        set => SetArgument("source_location", value);
    }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    public TerraformValue<string>? SourceResourceId
    {
        get => new TerraformReference<string>(this, "source_resource_id");
        set => SetArgument("source_resource_id", value);
    }

    /// <summary>
    /// The sql_version attribute.
    /// </summary>
    public TerraformValue<string> SqlVersion
    {
        get => new TerraformReference<string>(this, "sql_version");
        set => SetArgument("sql_version", value);
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
    /// MaintenanceWindow block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    public AzurermCosmosdbPostgresqlClusterMaintenanceWindowBlock? MaintenanceWindow
    {
        get => GetArgument<AzurermCosmosdbPostgresqlClusterMaintenanceWindowBlock>("maintenance_window");
        set => SetArgument("maintenance_window", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCosmosdbPostgresqlClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCosmosdbPostgresqlClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
