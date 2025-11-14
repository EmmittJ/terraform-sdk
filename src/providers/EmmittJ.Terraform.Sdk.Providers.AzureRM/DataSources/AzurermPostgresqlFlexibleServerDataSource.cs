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
public class AzurermPostgresqlFlexibleServerDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_postgresql_flexible_server.
/// </summary>
public class AzurermPostgresqlFlexibleServerDataSource : TerraformDataSource
{
    public AzurermPostgresqlFlexibleServerDataSource(string name) : base("azurerm_postgresql_flexible_server", name)
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
    public AzurermPostgresqlFlexibleServerDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    [TerraformArgument("administrator_login")]
    public TerraformValue<string> AdministratorLogin
    {
        get => new TerraformReference<string>(this, "administrator_login");
    }

    /// <summary>
    /// The auto_grow_enabled attribute.
    /// </summary>
    [TerraformArgument("auto_grow_enabled")]
    public TerraformValue<bool> AutoGrowEnabled
    {
        get => new TerraformReference<bool>(this, "auto_grow_enabled");
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
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
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
    /// The sku_name attribute.
    /// </summary>
    [TerraformArgument("sku_name")]
    public TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
    }

    /// <summary>
    /// The storage_mb attribute.
    /// </summary>
    [TerraformArgument("storage_mb")]
    public TerraformValue<double> StorageMb
    {
        get => new TerraformReference<double>(this, "storage_mb");
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

}
