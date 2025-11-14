using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMysqlFlexibleServerDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_mysql_flexible_server.
/// </summary>
public class AzurermMysqlFlexibleServerDataSource : TerraformDataSource
{
    public AzurermMysqlFlexibleServerDataSource(string name) : base("azurerm_mysql_flexible_server", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMysqlFlexibleServerDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    [TerraformArgument("administrator_login")]
    public TerraformValue<string> AdministratorLogin
    {
        get => new TerraformReference<string>(this, "administrator_login");
    }

    /// <summary>
    /// The backup_retention_days attribute.
    /// </summary>
    [TerraformArgument("backup_retention_days")]
    public TerraformValue<double> BackupRetentionDays
    {
        get => new TerraformReference<double>(this, "backup_retention_days");
    }

    /// <summary>
    /// The delegated_subnet_id attribute.
    /// </summary>
    [TerraformArgument("delegated_subnet_id")]
    public TerraformValue<string> DelegatedSubnetId
    {
        get => new TerraformReference<string>(this, "delegated_subnet_id");
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformArgument("fqdn")]
    public TerraformValue<string> Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
    }

    /// <summary>
    /// The geo_redundant_backup_enabled attribute.
    /// </summary>
    [TerraformArgument("geo_redundant_backup_enabled")]
    public TerraformValue<bool> GeoRedundantBackupEnabled
    {
        get => new TerraformReference<bool>(this, "geo_redundant_backup_enabled");
    }

    /// <summary>
    /// The high_availability attribute.
    /// </summary>
    [TerraformArgument("high_availability")]
    public TerraformList<object> HighAvailability
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "high_availability").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformArgument("maintenance_window")]
    public TerraformList<object> MaintenanceWindow
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "maintenance_window").ResolveNodes(ctx));
    }

    /// <summary>
    /// The private_dns_zone_id attribute.
    /// </summary>
    [TerraformArgument("private_dns_zone_id")]
    public TerraformValue<string> PrivateDnsZoneId
    {
        get => new TerraformReference<string>(this, "private_dns_zone_id");
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformArgument("public_network_access_enabled")]
    public TerraformValue<bool> PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
    }

    /// <summary>
    /// The replica_capacity attribute.
    /// </summary>
    [TerraformArgument("replica_capacity")]
    public TerraformValue<double> ReplicaCapacity
    {
        get => new TerraformReference<double>(this, "replica_capacity");
    }

    /// <summary>
    /// The replication_role attribute.
    /// </summary>
    [TerraformArgument("replication_role")]
    public TerraformValue<string> ReplicationRole
    {
        get => new TerraformReference<string>(this, "replication_role");
    }

    /// <summary>
    /// The restore_point_in_time attribute.
    /// </summary>
    [TerraformArgument("restore_point_in_time")]
    public TerraformValue<string> RestorePointInTime
    {
        get => new TerraformReference<string>(this, "restore_point_in_time");
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformArgument("sku_name")]
    public TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
    }

    /// <summary>
    /// The storage attribute.
    /// </summary>
    [TerraformArgument("storage")]
    public TerraformList<object> Storage
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "storage").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformArgument("version")]
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    [TerraformArgument("zone")]
    public TerraformValue<string> Zone
    {
        get => new TerraformReference<string>(this, "zone");
    }

}
