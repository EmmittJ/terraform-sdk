using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_cosmosdb_postgresql_cluster resource.
/// </summary>
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
    public string? AdministratorLoginPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("administrator_login_password")?.Value;
        set => this.WithProperty("administrator_login_password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The citus_version attribute.
    /// </summary>
    public string? CitusVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("citus_version")?.Value;
        set => this.WithProperty("citus_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The coordinator_public_ip_access_enabled attribute.
    /// </summary>
    public bool? CoordinatorPublicIpAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("coordinator_public_ip_access_enabled")?.Value;
        set => this.WithProperty("coordinator_public_ip_access_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The coordinator_server_edition attribute.
    /// </summary>
    public string? CoordinatorServerEdition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("coordinator_server_edition")?.Value;
        set => this.WithProperty("coordinator_server_edition", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The coordinator_storage_quota_in_mb attribute.
    /// </summary>
    public double? CoordinatorStorageQuotaInMb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("coordinator_storage_quota_in_mb")?.Value;
        set => this.WithProperty("coordinator_storage_quota_in_mb", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The coordinator_vcore_count attribute.
    /// </summary>
    public double? CoordinatorVcoreCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("coordinator_vcore_count")?.Value;
        set => this.WithProperty("coordinator_vcore_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The ha_enabled attribute.
    /// </summary>
    public bool? HaEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ha_enabled")?.Value;
        set => this.WithProperty("ha_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    public double? NodeCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("node_count")?.Value;
        set => this.WithProperty("node_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The node_public_ip_access_enabled attribute.
    /// </summary>
    public bool? NodePublicIpAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("node_public_ip_access_enabled")?.Value;
        set => this.WithProperty("node_public_ip_access_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The node_server_edition attribute.
    /// </summary>
    public string? NodeServerEdition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_server_edition")?.Value;
        set => this.WithProperty("node_server_edition", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The node_storage_quota_in_mb attribute.
    /// </summary>
    public double? NodeStorageQuotaInMb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("node_storage_quota_in_mb")?.Value;
        set => this.WithProperty("node_storage_quota_in_mb", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The node_vcores attribute.
    /// </summary>
    public double? NodeVcores
    {
        get => GetProperty<TerraformLiteralProperty<double>>("node_vcores")?.Value;
        set => this.WithProperty("node_vcores", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The point_in_time_in_utc attribute.
    /// </summary>
    public string? PointInTimeInUtc
    {
        get => GetProperty<TerraformLiteralProperty<string>>("point_in_time_in_utc")?.Value;
        set => this.WithProperty("point_in_time_in_utc", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The preferred_primary_zone attribute.
    /// </summary>
    public string? PreferredPrimaryZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("preferred_primary_zone")?.Value;
        set => this.WithProperty("preferred_primary_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The shards_on_coordinator_enabled attribute.
    /// </summary>
    public bool? ShardsOnCoordinatorEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("shards_on_coordinator_enabled")?.Value;
        set => this.WithProperty("shards_on_coordinator_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The source_location attribute.
    /// </summary>
    public string? SourceLocation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_location")?.Value;
        set => this.WithProperty("source_location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    public string? SourceResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_resource_id")?.Value;
        set => this.WithProperty("source_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sql_version attribute.
    /// </summary>
    public string? SqlVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sql_version")?.Value;
        set => this.WithProperty("sql_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
