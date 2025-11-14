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
public class AzurermMssqlManagedDatabaseDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_mssql_managed_database.
/// </summary>
public class AzurermMssqlManagedDatabaseDataSource : TerraformDataSource
{
    public AzurermMssqlManagedDatabaseDataSource(string name) : base("azurerm_mssql_managed_database", name)
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
    /// The managed_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedInstanceId is required")]
    [TerraformArgument("managed_instance_id")]
    public required TerraformValue<string> ManagedInstanceId
    {
        get => new TerraformReference<string>(this, "managed_instance_id");
        set => SetArgument("managed_instance_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMssqlManagedDatabaseDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The long_term_retention_policy attribute.
    /// </summary>
    [TerraformArgument("long_term_retention_policy")]
    public TerraformList<object> LongTermRetentionPolicy
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "long_term_retention_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The managed_instance_name attribute.
    /// </summary>
    [TerraformArgument("managed_instance_name")]
    public TerraformValue<string> ManagedInstanceName
    {
        get => new TerraformReference<string>(this, "managed_instance_name");
    }

    /// <summary>
    /// The point_in_time_restore attribute.
    /// </summary>
    [TerraformArgument("point_in_time_restore")]
    public TerraformList<object> PointInTimeRestore
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "point_in_time_restore").ResolveNodes(ctx));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [TerraformArgument("resource_group_name")]
    public TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
    }

    /// <summary>
    /// The short_term_retention_days attribute.
    /// </summary>
    [TerraformArgument("short_term_retention_days")]
    public TerraformValue<double> ShortTermRetentionDays
    {
        get => new TerraformReference<double>(this, "short_term_retention_days");
    }

}
