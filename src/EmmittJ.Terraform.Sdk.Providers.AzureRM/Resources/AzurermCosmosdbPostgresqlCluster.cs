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
        get => GetProperty<TerraformProperty<double>>("day_of_week");
        set => WithProperty("day_of_week", value);
    }

    /// <summary>
    /// The start_hour attribute.
    /// </summary>
    public TerraformProperty<double>? StartHour
    {
        get => GetProperty<TerraformProperty<double>>("start_hour");
        set => WithProperty("start_hour", value);
    }

    /// <summary>
    /// The start_minute attribute.
    /// </summary>
    public TerraformProperty<double>? StartMinute
    {
        get => GetProperty<TerraformProperty<double>>("start_minute");
        set => WithProperty("start_minute", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        this.DeclareOutput("earliest_restore_time");
        this.DeclareOutput("servers");
    }

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    public TerraformProperty<string>? AdministratorLoginPassword
    {
        get => GetProperty<TerraformProperty<string>>("administrator_login_password");
        set => this.WithProperty("administrator_login_password", value);
    }

    /// <summary>
    /// The citus_version attribute.
    /// </summary>
    public TerraformProperty<string>? CitusVersion
    {
        get => GetProperty<TerraformProperty<string>>("citus_version");
        set => this.WithProperty("citus_version", value);
    }

    /// <summary>
    /// The coordinator_public_ip_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CoordinatorPublicIpAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("coordinator_public_ip_access_enabled");
        set => this.WithProperty("coordinator_public_ip_access_enabled", value);
    }

    /// <summary>
    /// The coordinator_server_edition attribute.
    /// </summary>
    public TerraformProperty<string>? CoordinatorServerEdition
    {
        get => GetProperty<TerraformProperty<string>>("coordinator_server_edition");
        set => this.WithProperty("coordinator_server_edition", value);
    }

    /// <summary>
    /// The coordinator_storage_quota_in_mb attribute.
    /// </summary>
    public TerraformProperty<double>? CoordinatorStorageQuotaInMb
    {
        get => GetProperty<TerraformProperty<double>>("coordinator_storage_quota_in_mb");
        set => this.WithProperty("coordinator_storage_quota_in_mb", value);
    }

    /// <summary>
    /// The coordinator_vcore_count attribute.
    /// </summary>
    public TerraformProperty<double>? CoordinatorVcoreCount
    {
        get => GetProperty<TerraformProperty<double>>("coordinator_vcore_count");
        set => this.WithProperty("coordinator_vcore_count", value);
    }

    /// <summary>
    /// The ha_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? HaEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("ha_enabled");
        set => this.WithProperty("ha_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeCount is required")]
    public required TerraformProperty<double> NodeCount
    {
        get => GetRequiredProperty<TerraformProperty<double>>("node_count");
        set => this.WithProperty("node_count", value);
    }

    /// <summary>
    /// The node_public_ip_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? NodePublicIpAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("node_public_ip_access_enabled");
        set => this.WithProperty("node_public_ip_access_enabled", value);
    }

    /// <summary>
    /// The node_server_edition attribute.
    /// </summary>
    public TerraformProperty<string>? NodeServerEdition
    {
        get => GetProperty<TerraformProperty<string>>("node_server_edition");
        set => this.WithProperty("node_server_edition", value);
    }

    /// <summary>
    /// The node_storage_quota_in_mb attribute.
    /// </summary>
    public TerraformProperty<double>? NodeStorageQuotaInMb
    {
        get => GetProperty<TerraformProperty<double>>("node_storage_quota_in_mb");
        set => this.WithProperty("node_storage_quota_in_mb", value);
    }

    /// <summary>
    /// The node_vcores attribute.
    /// </summary>
    public TerraformProperty<double>? NodeVcores
    {
        get => GetProperty<TerraformProperty<double>>("node_vcores");
        set => this.WithProperty("node_vcores", value);
    }

    /// <summary>
    /// The point_in_time_in_utc attribute.
    /// </summary>
    public TerraformProperty<string>? PointInTimeInUtc
    {
        get => GetProperty<TerraformProperty<string>>("point_in_time_in_utc");
        set => this.WithProperty("point_in_time_in_utc", value);
    }

    /// <summary>
    /// The preferred_primary_zone attribute.
    /// </summary>
    public TerraformProperty<string>? PreferredPrimaryZone
    {
        get => GetProperty<TerraformProperty<string>>("preferred_primary_zone");
        set => this.WithProperty("preferred_primary_zone", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The shards_on_coordinator_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ShardsOnCoordinatorEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("shards_on_coordinator_enabled");
        set => this.WithProperty("shards_on_coordinator_enabled", value);
    }

    /// <summary>
    /// The source_location attribute.
    /// </summary>
    public TerraformProperty<string>? SourceLocation
    {
        get => GetProperty<TerraformProperty<string>>("source_location");
        set => this.WithProperty("source_location", value);
    }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourceResourceId
    {
        get => GetProperty<TerraformProperty<string>>("source_resource_id");
        set => this.WithProperty("source_resource_id", value);
    }

    /// <summary>
    /// The sql_version attribute.
    /// </summary>
    public TerraformProperty<string>? SqlVersion
    {
        get => GetProperty<TerraformProperty<string>>("sql_version");
        set => this.WithProperty("sql_version", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    public List<AzurermCosmosdbPostgresqlClusterMaintenanceWindowBlock>? MaintenanceWindow
    {
        get => GetProperty<List<AzurermCosmosdbPostgresqlClusterMaintenanceWindowBlock>>("maintenance_window");
        set => this.WithProperty("maintenance_window", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCosmosdbPostgresqlClusterTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermCosmosdbPostgresqlClusterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
