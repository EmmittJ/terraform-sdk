using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_mysql_flexible_server resource.
/// </summary>
public class AzurermMysqlFlexibleServer : TerraformResource
{
    public AzurermMysqlFlexibleServer(string name) : base("azurerm_mysql_flexible_server", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("fqdn");
        this.DeclareOutput("public_network_access_enabled");
        this.DeclareOutput("replica_capacity");
    }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    public TerraformProperty<string>? AdministratorLogin
    {
        get => GetProperty<TerraformProperty<string>>("administrator_login");
        set => this.WithProperty("administrator_login", value);
    }

    /// <summary>
    /// The administrator_password attribute.
    /// </summary>
    public TerraformProperty<string>? AdministratorPassword
    {
        get => GetProperty<TerraformProperty<string>>("administrator_password");
        set => this.WithProperty("administrator_password", value);
    }

    /// <summary>
    /// The administrator_password_wo attribute.
    /// </summary>
    public TerraformProperty<string>? AdministratorPasswordWo
    {
        get => GetProperty<TerraformProperty<string>>("administrator_password_wo");
        set => this.WithProperty("administrator_password_wo", value);
    }

    /// <summary>
    /// The administrator_password_wo_version attribute.
    /// </summary>
    public TerraformProperty<double>? AdministratorPasswordWoVersion
    {
        get => GetProperty<TerraformProperty<double>>("administrator_password_wo_version");
        set => this.WithProperty("administrator_password_wo_version", value);
    }

    /// <summary>
    /// The backup_retention_days attribute.
    /// </summary>
    public TerraformProperty<double>? BackupRetentionDays
    {
        get => GetProperty<TerraformProperty<double>>("backup_retention_days");
        set => this.WithProperty("backup_retention_days", value);
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    public TerraformProperty<string>? CreateMode
    {
        get => GetProperty<TerraformProperty<string>>("create_mode");
        set => this.WithProperty("create_mode", value);
    }

    /// <summary>
    /// The delegated_subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? DelegatedSubnetId
    {
        get => GetProperty<TerraformProperty<string>>("delegated_subnet_id");
        set => this.WithProperty("delegated_subnet_id", value);
    }

    /// <summary>
    /// The geo_redundant_backup_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? GeoRedundantBackupEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("geo_redundant_backup_enabled");
        set => this.WithProperty("geo_redundant_backup_enabled", value);
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
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The point_in_time_restore_time_in_utc attribute.
    /// </summary>
    public TerraformProperty<string>? PointInTimeRestoreTimeInUtc
    {
        get => GetProperty<TerraformProperty<string>>("point_in_time_restore_time_in_utc");
        set => this.WithProperty("point_in_time_restore_time_in_utc", value);
    }

    /// <summary>
    /// The private_dns_zone_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateDnsZoneId
    {
        get => GetProperty<TerraformProperty<string>>("private_dns_zone_id");
        set => this.WithProperty("private_dns_zone_id", value);
    }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    public TerraformProperty<string>? PublicNetworkAccess
    {
        get => GetProperty<TerraformProperty<string>>("public_network_access");
        set => this.WithProperty("public_network_access", value);
    }

    /// <summary>
    /// The replication_role attribute.
    /// </summary>
    public TerraformProperty<string>? ReplicationRole
    {
        get => GetProperty<TerraformProperty<string>>("replication_role");
        set => this.WithProperty("replication_role", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformProperty<string>? SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The source_server_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourceServerId
    {
        get => GetProperty<TerraformProperty<string>>("source_server_id");
        set => this.WithProperty("source_server_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformExpression PublicNetworkAccessEnabled => this["public_network_access_enabled"];

    /// <summary>
    /// The replica_capacity attribute.
    /// </summary>
    public TerraformExpression ReplicaCapacity => this["replica_capacity"];

}
