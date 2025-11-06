using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_postgresql_flexible_server resource.
/// </summary>
public class AzurermPostgresqlFlexibleServer : TerraformResource
{
    public AzurermPostgresqlFlexibleServer(string name) : base("azurerm_postgresql_flexible_server", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("fqdn");
    }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    public string? AdministratorLogin
    {
        get => GetProperty<TerraformLiteralProperty<string>>("administrator_login")?.Value;
        set => this.WithProperty("administrator_login", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The administrator_password attribute.
    /// </summary>
    public string? AdministratorPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("administrator_password")?.Value;
        set => this.WithProperty("administrator_password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The administrator_password_wo attribute.
    /// </summary>
    public string? AdministratorPasswordWo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("administrator_password_wo")?.Value;
        set => this.WithProperty("administrator_password_wo", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The administrator_password_wo_version attribute.
    /// </summary>
    public double? AdministratorPasswordWoVersion
    {
        get => GetProperty<TerraformLiteralProperty<double>>("administrator_password_wo_version")?.Value;
        set => this.WithProperty("administrator_password_wo_version", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The auto_grow_enabled attribute.
    /// </summary>
    public bool? AutoGrowEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_grow_enabled")?.Value;
        set => this.WithProperty("auto_grow_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The backup_retention_days attribute.
    /// </summary>
    public double? BackupRetentionDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("backup_retention_days")?.Value;
        set => this.WithProperty("backup_retention_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    public string? CreateMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("create_mode")?.Value;
        set => this.WithProperty("create_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The delegated_subnet_id attribute.
    /// </summary>
    public string? DelegatedSubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("delegated_subnet_id")?.Value;
        set => this.WithProperty("delegated_subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The geo_redundant_backup_enabled attribute.
    /// </summary>
    public bool? GeoRedundantBackupEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("geo_redundant_backup_enabled")?.Value;
        set => this.WithProperty("geo_redundant_backup_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The point_in_time_restore_time_in_utc attribute.
    /// </summary>
    public string? PointInTimeRestoreTimeInUtc
    {
        get => GetProperty<TerraformLiteralProperty<string>>("point_in_time_restore_time_in_utc")?.Value;
        set => this.WithProperty("point_in_time_restore_time_in_utc", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The private_dns_zone_id attribute.
    /// </summary>
    public string? PrivateDnsZoneId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_dns_zone_id")?.Value;
        set => this.WithProperty("private_dns_zone_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public bool? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_network_access_enabled")?.Value;
        set => this.WithProperty("public_network_access_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The replication_role attribute.
    /// </summary>
    public string? ReplicationRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("replication_role")?.Value;
        set => this.WithProperty("replication_role", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The sku_name attribute.
    /// </summary>
    public string? SkuName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku_name")?.Value;
        set => this.WithProperty("sku_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_server_id attribute.
    /// </summary>
    public string? SourceServerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_server_id")?.Value;
        set => this.WithProperty("source_server_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_mb attribute.
    /// </summary>
    public double? StorageMb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("storage_mb")?.Value;
        set => this.WithProperty("storage_mb", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The storage_tier attribute.
    /// </summary>
    public string? StorageTier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_tier")?.Value;
        set => this.WithProperty("storage_tier", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The version attribute.
    /// </summary>
    public string? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version")?.Value;
        set => this.WithProperty("version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public string? Zone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zone")?.Value;
        set => this.WithProperty("zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

}
