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
public class AzurermDynatraceMonitorDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_dynatrace_monitor.
/// </summary>
public class AzurermDynatraceMonitorDataSource : TerraformDataSource
{
    public AzurermDynatraceMonitorDataSource(string name) : base("azurerm_dynatrace_monitor", name)
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
    public AzurermDynatraceMonitorDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The environment_properties attribute.
    /// </summary>
    [TerraformArgument("environment_properties")]
    public TerraformList<object> EnvironmentProperties
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "environment_properties").ResolveNodes(ctx));
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformArgument("identity")]
    public TerraformList<object> Identity
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "identity").ResolveNodes(ctx));
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
    /// The marketplace_subscription attribute.
    /// </summary>
    [TerraformArgument("marketplace_subscription")]
    public TerraformValue<string> MarketplaceSubscription
    {
        get => new TerraformReference<string>(this, "marketplace_subscription");
    }

    /// <summary>
    /// The monitoring_enabled attribute.
    /// </summary>
    [TerraformArgument("monitoring_enabled")]
    public TerraformValue<bool> MonitoringEnabled
    {
        get => new TerraformReference<bool>(this, "monitoring_enabled");
    }

    /// <summary>
    /// The plan attribute.
    /// </summary>
    [TerraformArgument("plan")]
    public TerraformList<object> Plan
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "plan").ResolveNodes(ctx));
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
    /// The user attribute.
    /// </summary>
    [TerraformArgument("user")]
    public TerraformList<object> User
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "user").ResolveNodes(ctx));
    }

}
