using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbPostgresqlClusterMaintenanceWindowBlock : TerraformBlock
{
    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    public TerraformProperty<double>? DayOfWeek
    {
        set => SetProperty("day_of_week", value);
    }

    /// <summary>
    /// The start_hour attribute.
    /// </summary>
    public TerraformProperty<double>? StartHour
    {
        set => SetProperty("start_hour", value);
    }

    /// <summary>
    /// The start_minute attribute.
    /// </summary>
    public TerraformProperty<double>? StartMinute
    {
        set => SetProperty("start_minute", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbPostgresqlClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_cosmosdb_postgresql_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermCosmosdbPostgresqlCluster : TerraformResource
{
    public AzurermCosmosdbPostgresqlCluster(string name) : base("azurerm_cosmosdb_postgresql_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("earliest_restore_time");
        SetOutput("servers");
        SetOutput("administrator_login_password");
        SetOutput("citus_version");
        SetOutput("coordinator_public_ip_access_enabled");
        SetOutput("coordinator_server_edition");
        SetOutput("coordinator_storage_quota_in_mb");
        SetOutput("coordinator_vcore_count");
        SetOutput("ha_enabled");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("node_count");
        SetOutput("node_public_ip_access_enabled");
        SetOutput("node_server_edition");
        SetOutput("node_storage_quota_in_mb");
        SetOutput("node_vcores");
        SetOutput("point_in_time_in_utc");
        SetOutput("preferred_primary_zone");
        SetOutput("resource_group_name");
        SetOutput("shards_on_coordinator_enabled");
        SetOutput("source_location");
        SetOutput("source_resource_id");
        SetOutput("sql_version");
        SetOutput("tags");
    }

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    public TerraformProperty<string> AdministratorLoginPassword
    {
        get => GetRequiredOutput<TerraformProperty<string>>("administrator_login_password");
        set => SetProperty("administrator_login_password", value);
    }

    /// <summary>
    /// The citus_version attribute.
    /// </summary>
    public TerraformProperty<string> CitusVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("citus_version");
        set => SetProperty("citus_version", value);
    }

    /// <summary>
    /// The coordinator_public_ip_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> CoordinatorPublicIpAccessEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("coordinator_public_ip_access_enabled");
        set => SetProperty("coordinator_public_ip_access_enabled", value);
    }

    /// <summary>
    /// The coordinator_server_edition attribute.
    /// </summary>
    public TerraformProperty<string> CoordinatorServerEdition
    {
        get => GetRequiredOutput<TerraformProperty<string>>("coordinator_server_edition");
        set => SetProperty("coordinator_server_edition", value);
    }

    /// <summary>
    /// The coordinator_storage_quota_in_mb attribute.
    /// </summary>
    public TerraformProperty<double> CoordinatorStorageQuotaInMb
    {
        get => GetRequiredOutput<TerraformProperty<double>>("coordinator_storage_quota_in_mb");
        set => SetProperty("coordinator_storage_quota_in_mb", value);
    }

    /// <summary>
    /// The coordinator_vcore_count attribute.
    /// </summary>
    public TerraformProperty<double> CoordinatorVcoreCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("coordinator_vcore_count");
        set => SetProperty("coordinator_vcore_count", value);
    }

    /// <summary>
    /// The ha_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> HaEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ha_enabled");
        set => SetProperty("ha_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeCount is required")]
    public required TerraformProperty<double> NodeCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("node_count");
        set => SetProperty("node_count", value);
    }

    /// <summary>
    /// The node_public_ip_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> NodePublicIpAccessEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("node_public_ip_access_enabled");
        set => SetProperty("node_public_ip_access_enabled", value);
    }

    /// <summary>
    /// The node_server_edition attribute.
    /// </summary>
    public TerraformProperty<string> NodeServerEdition
    {
        get => GetRequiredOutput<TerraformProperty<string>>("node_server_edition");
        set => SetProperty("node_server_edition", value);
    }

    /// <summary>
    /// The node_storage_quota_in_mb attribute.
    /// </summary>
    public TerraformProperty<double> NodeStorageQuotaInMb
    {
        get => GetRequiredOutput<TerraformProperty<double>>("node_storage_quota_in_mb");
        set => SetProperty("node_storage_quota_in_mb", value);
    }

    /// <summary>
    /// The node_vcores attribute.
    /// </summary>
    public TerraformProperty<double> NodeVcores
    {
        get => GetRequiredOutput<TerraformProperty<double>>("node_vcores");
        set => SetProperty("node_vcores", value);
    }

    /// <summary>
    /// The point_in_time_in_utc attribute.
    /// </summary>
    public TerraformProperty<string> PointInTimeInUtc
    {
        get => GetRequiredOutput<TerraformProperty<string>>("point_in_time_in_utc");
        set => SetProperty("point_in_time_in_utc", value);
    }

    /// <summary>
    /// The preferred_primary_zone attribute.
    /// </summary>
    public TerraformProperty<string> PreferredPrimaryZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("preferred_primary_zone");
        set => SetProperty("preferred_primary_zone", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The shards_on_coordinator_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ShardsOnCoordinatorEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("shards_on_coordinator_enabled");
        set => SetProperty("shards_on_coordinator_enabled", value);
    }

    /// <summary>
    /// The source_location attribute.
    /// </summary>
    public TerraformProperty<string> SourceLocation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_location");
        set => SetProperty("source_location", value);
    }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    public TerraformProperty<string> SourceResourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_resource_id");
        set => SetProperty("source_resource_id", value);
    }

    /// <summary>
    /// The sql_version attribute.
    /// </summary>
    public TerraformProperty<string> SqlVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sql_version");
        set => SetProperty("sql_version", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    public List<AzurermCosmosdbPostgresqlClusterMaintenanceWindowBlock>? MaintenanceWindow
    {
        set => SetProperty("maintenance_window", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCosmosdbPostgresqlClusterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The earliest_restore_time attribute.
    /// </summary>
    public TerraformExpression EarliestRestoreTime => this["earliest_restore_time"];

    /// <summary>
    /// The servers attribute.
    /// </summary>
    public TerraformExpression Servers => this["servers"];

}
