using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermPostgresqlFlexibleServerDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermPostgresqlFlexibleServerDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_postgresql_flexible_server Terraform data source.
/// Retrieves information about a azurerm_postgresql_flexible_server.
/// </summary>
public partial class AzurermPostgresqlFlexibleServerDataSource(string name) : TerraformDataSource("azurerm_postgresql_flexible_server", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    public TerraformValue<string> AdministratorLogin
        => AsReference("administrator_login");

    /// <summary>
    /// The auto_grow_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AutoGrowEnabled
        => AsReference("auto_grow_enabled");

    /// <summary>
    /// The backup_retention_days attribute.
    /// </summary>
    public TerraformValue<double> BackupRetentionDays
        => AsReference("backup_retention_days");

    /// <summary>
    /// The delegated_subnet_id attribute.
    /// </summary>
    public TerraformValue<string> DelegatedSubnetId
        => AsReference("delegated_subnet_id");

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
        => AsReference("fqdn");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PublicNetworkAccessEnabled
        => AsReference("public_network_access_enabled");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string> SkuName
        => AsReference("sku_name");

    /// <summary>
    /// The storage_mb attribute.
    /// </summary>
    public TerraformValue<double> StorageMb
        => AsReference("storage_mb");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
        => AsReference("version");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPostgresqlFlexibleServerDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPostgresqlFlexibleServerDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
