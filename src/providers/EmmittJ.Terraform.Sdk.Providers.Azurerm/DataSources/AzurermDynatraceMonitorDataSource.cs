using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDynatraceMonitorDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermDynatraceMonitorDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_dynatrace_monitor Terraform data source.
/// Retrieves information about a azurerm_dynatrace_monitor.
/// </summary>
public partial class AzurermDynatraceMonitorDataSource(string name) : TerraformDataSource("azurerm_dynatrace_monitor", name)
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
    /// The environment_properties attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EnvironmentProperties
        => CreateReference("environment_properties");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => CreateReference("identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The marketplace_subscription attribute.
    /// </summary>
    public TerraformValue<string> MarketplaceSubscription
        => CreateReference("marketplace_subscription");

    /// <summary>
    /// The monitoring_enabled attribute.
    /// </summary>
    public TerraformValue<bool> MonitoringEnabled
        => CreateReference("monitoring_enabled");

    /// <summary>
    /// The plan attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Plan
        => CreateReference("plan");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The user attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> User
        => CreateReference("user");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDynatraceMonitorDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDynatraceMonitorDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
