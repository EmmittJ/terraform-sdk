using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMysqlFlexibleServerDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_mysql_flexible_server.
/// </summary>
public class AzurermMysqlFlexibleServerDataSource : TerraformDataSource
{
    public AzurermMysqlFlexibleServerDataSource(string name) : base("azurerm_mysql_flexible_server", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("administrator_login");
        SetOutput("backup_retention_days");
        SetOutput("delegated_subnet_id");
        SetOutput("fqdn");
        SetOutput("geo_redundant_backup_enabled");
        SetOutput("high_availability");
        SetOutput("location");
        SetOutput("maintenance_window");
        SetOutput("private_dns_zone_id");
        SetOutput("public_network_access_enabled");
        SetOutput("replica_capacity");
        SetOutput("replication_role");
        SetOutput("restore_point_in_time");
        SetOutput("sku_name");
        SetOutput("storage");
        SetOutput("tags");
        SetOutput("version");
        SetOutput("zone");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMysqlFlexibleServerDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    public TerraformExpression AdministratorLogin => this["administrator_login"];

    /// <summary>
    /// The backup_retention_days attribute.
    /// </summary>
    public TerraformExpression BackupRetentionDays => this["backup_retention_days"];

    /// <summary>
    /// The delegated_subnet_id attribute.
    /// </summary>
    public TerraformExpression DelegatedSubnetId => this["delegated_subnet_id"];

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

    /// <summary>
    /// The geo_redundant_backup_enabled attribute.
    /// </summary>
    public TerraformExpression GeoRedundantBackupEnabled => this["geo_redundant_backup_enabled"];

    /// <summary>
    /// The high_availability attribute.
    /// </summary>
    public TerraformExpression HighAvailability => this["high_availability"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformExpression MaintenanceWindow => this["maintenance_window"];

    /// <summary>
    /// The private_dns_zone_id attribute.
    /// </summary>
    public TerraformExpression PrivateDnsZoneId => this["private_dns_zone_id"];

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformExpression PublicNetworkAccessEnabled => this["public_network_access_enabled"];

    /// <summary>
    /// The replica_capacity attribute.
    /// </summary>
    public TerraformExpression ReplicaCapacity => this["replica_capacity"];

    /// <summary>
    /// The replication_role attribute.
    /// </summary>
    public TerraformExpression ReplicationRole => this["replication_role"];

    /// <summary>
    /// The restore_point_in_time attribute.
    /// </summary>
    public TerraformExpression RestorePointInTime => this["restore_point_in_time"];

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformExpression SkuName => this["sku_name"];

    /// <summary>
    /// The storage attribute.
    /// </summary>
    public TerraformExpression Storage => this["storage"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformExpression Zone => this["zone"];

}
