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
public class AzurermMonitorScheduledQueryRulesAlertDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_monitor_scheduled_query_rules_alert.
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertDataSource : TerraformDataSource
{
    public AzurermMonitorScheduledQueryRulesAlertDataSource(string name) : base("azurerm_monitor_scheduled_query_rules_alert", name)
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
    public AzurermMonitorScheduledQueryRulesAlertDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The action attribute.
    /// </summary>
    [TerraformArgument("action")]
    public TerraformSet<object> Action
    {
        get => TerraformSet<object>.Lazy(ctx => new TerraformReference<TerraformSet<object>>(this, "action").ResolveNodes(ctx));
    }

    /// <summary>
    /// The authorized_resource_ids attribute.
    /// </summary>
    [TerraformArgument("authorized_resource_ids")]
    public TerraformSet<string> AuthorizedResourceIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "authorized_resource_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    [TerraformArgument("data_source_id")]
    public TerraformValue<string> DataSourceId
    {
        get => new TerraformReference<string>(this, "data_source_id");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [TerraformArgument("frequency")]
    public TerraformValue<double> Frequency
    {
        get => new TerraformReference<double>(this, "frequency");
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
    /// The query attribute.
    /// </summary>
    [TerraformArgument("query")]
    public TerraformValue<string> Query
    {
        get => new TerraformReference<string>(this, "query");
    }

    /// <summary>
    /// The query_type attribute.
    /// </summary>
    [TerraformArgument("query_type")]
    public TerraformValue<string> QueryType
    {
        get => new TerraformReference<string>(this, "query_type");
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [TerraformArgument("severity")]
    public TerraformValue<double> Severity
    {
        get => new TerraformReference<double>(this, "severity");
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
    /// The throttling attribute.
    /// </summary>
    [TerraformArgument("throttling")]
    public TerraformValue<double> Throttling
    {
        get => new TerraformReference<double>(this, "throttling");
    }

    /// <summary>
    /// The time_window attribute.
    /// </summary>
    [TerraformArgument("time_window")]
    public TerraformValue<double> TimeWindow
    {
        get => new TerraformReference<double>(this, "time_window");
    }

    /// <summary>
    /// The trigger attribute.
    /// </summary>
    [TerraformArgument("trigger")]
    public TerraformSet<object> Trigger
    {
        get => TerraformSet<object>.Lazy(ctx => new TerraformReference<TerraformSet<object>>(this, "trigger").ResolveNodes(ctx));
    }

}
