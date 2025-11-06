using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("administrator_login");
        this.DeclareOutput("backup_retention_days");
        this.DeclareOutput("delegated_subnet_id");
        this.DeclareOutput("fqdn");
        this.DeclareOutput("geo_redundant_backup_enabled");
        this.DeclareOutput("high_availability");
        this.DeclareOutput("location");
        this.DeclareOutput("maintenance_window");
        this.DeclareOutput("private_dns_zone_id");
        this.DeclareOutput("public_network_access_enabled");
        this.DeclareOutput("replica_capacity");
        this.DeclareOutput("replication_role");
        this.DeclareOutput("restore_point_in_time");
        this.DeclareOutput("sku_name");
        this.DeclareOutput("storage");
        this.DeclareOutput("tags");
        this.DeclareOutput("version");
        this.DeclareOutput("zone");
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
