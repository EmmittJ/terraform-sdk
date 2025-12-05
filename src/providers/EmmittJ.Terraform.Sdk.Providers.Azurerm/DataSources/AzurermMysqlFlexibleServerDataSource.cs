using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermMysqlFlexibleServerDataSource.
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
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_mysql_flexible_server Terraform data source.
/// Retrieves information about a azurerm_mysql_flexible_server.
/// </summary>
public partial class AzurermMysqlFlexibleServerDataSource(string name) : TerraformDataSource("azurerm_mysql_flexible_server", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    public TerraformValue<string> AdministratorLogin
        => CreateReference("administrator_login");

    /// <summary>
    /// The backup_retention_days attribute.
    /// </summary>
    public TerraformValue<double> BackupRetentionDays
        => CreateReference("backup_retention_days");

    /// <summary>
    /// The delegated_subnet_id attribute.
    /// </summary>
    public TerraformValue<string> DelegatedSubnetId
        => CreateReference("delegated_subnet_id");

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
        => CreateReference("fqdn");

    /// <summary>
    /// The geo_redundant_backup_enabled attribute.
    /// </summary>
    public TerraformValue<bool> GeoRedundantBackupEnabled
        => CreateReference("geo_redundant_backup_enabled");

    /// <summary>
    /// The high_availability attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> HighAvailability
        => CreateReference("high_availability");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenanceWindow
        => CreateReference("maintenance_window");

    /// <summary>
    /// The private_dns_zone_id attribute.
    /// </summary>
    public TerraformValue<string> PrivateDnsZoneId
        => CreateReference("private_dns_zone_id");

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PublicNetworkAccessEnabled
        => CreateReference("public_network_access_enabled");

    /// <summary>
    /// The replica_capacity attribute.
    /// </summary>
    public TerraformValue<double> ReplicaCapacity
        => CreateReference("replica_capacity");

    /// <summary>
    /// The replication_role attribute.
    /// </summary>
    public TerraformValue<string> ReplicationRole
        => CreateReference("replication_role");

    /// <summary>
    /// The restore_point_in_time attribute.
    /// </summary>
    public TerraformValue<string> RestorePointInTime
        => CreateReference("restore_point_in_time");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string> SkuName
        => CreateReference("sku_name");

    /// <summary>
    /// The storage attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Storage
        => CreateReference("storage");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
        => CreateReference("version");

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformValue<string> Zone
        => CreateReference("zone");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMysqlFlexibleServerDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMysqlFlexibleServerDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
