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
    public TerraformLiteralProperty<string>? AdministratorLoginPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("administrator_login_password");
        set => this.WithProperty("administrator_login_password", value);
    }

    /// <summary>
    /// The citus_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CitusVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("citus_version");
        set => this.WithProperty("citus_version", value);
    }

    /// <summary>
    /// The coordinator_public_ip_access_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? CoordinatorPublicIpAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("coordinator_public_ip_access_enabled");
        set => this.WithProperty("coordinator_public_ip_access_enabled", value);
    }

    /// <summary>
    /// The coordinator_server_edition attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CoordinatorServerEdition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("coordinator_server_edition");
        set => this.WithProperty("coordinator_server_edition", value);
    }

    /// <summary>
    /// The coordinator_storage_quota_in_mb attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? CoordinatorStorageQuotaInMb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("coordinator_storage_quota_in_mb");
        set => this.WithProperty("coordinator_storage_quota_in_mb", value);
    }

    /// <summary>
    /// The coordinator_vcore_count attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? CoordinatorVcoreCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("coordinator_vcore_count");
        set => this.WithProperty("coordinator_vcore_count", value);
    }

    /// <summary>
    /// The ha_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? HaEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ha_enabled");
        set => this.WithProperty("ha_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? NodeCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("node_count");
        set => this.WithProperty("node_count", value);
    }

    /// <summary>
    /// The node_public_ip_access_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? NodePublicIpAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("node_public_ip_access_enabled");
        set => this.WithProperty("node_public_ip_access_enabled", value);
    }

    /// <summary>
    /// The node_server_edition attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NodeServerEdition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_server_edition");
        set => this.WithProperty("node_server_edition", value);
    }

    /// <summary>
    /// The node_storage_quota_in_mb attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? NodeStorageQuotaInMb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("node_storage_quota_in_mb");
        set => this.WithProperty("node_storage_quota_in_mb", value);
    }

    /// <summary>
    /// The node_vcores attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? NodeVcores
    {
        get => GetProperty<TerraformLiteralProperty<double>>("node_vcores");
        set => this.WithProperty("node_vcores", value);
    }

    /// <summary>
    /// The point_in_time_in_utc attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PointInTimeInUtc
    {
        get => GetProperty<TerraformLiteralProperty<string>>("point_in_time_in_utc");
        set => this.WithProperty("point_in_time_in_utc", value);
    }

    /// <summary>
    /// The preferred_primary_zone attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PreferredPrimaryZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("preferred_primary_zone");
        set => this.WithProperty("preferred_primary_zone", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The shards_on_coordinator_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ShardsOnCoordinatorEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("shards_on_coordinator_enabled");
        set => this.WithProperty("shards_on_coordinator_enabled", value);
    }

    /// <summary>
    /// The source_location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceLocation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_location");
        set => this.WithProperty("source_location", value);
    }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_resource_id");
        set => this.WithProperty("source_resource_id", value);
    }

    /// <summary>
    /// The sql_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SqlVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sql_version");
        set => this.WithProperty("sql_version", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
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
