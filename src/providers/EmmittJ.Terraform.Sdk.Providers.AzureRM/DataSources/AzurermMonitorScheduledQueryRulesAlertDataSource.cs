using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_monitor_scheduled_query_rules_alert Terraform data source.
/// Retrieves information about a azurerm_monitor_scheduled_query_rules_alert.
/// </summary>
public partial class AzurermMonitorScheduledQueryRulesAlertDataSource(string name) : TerraformDataSource("azurerm_monitor_scheduled_query_rules_alert", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Action
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "action").ResolveNodes(ctx));
    }

    /// <summary>
    /// The authorized_resource_ids attribute.
    /// </summary>
    public TerraformSet<string> AuthorizedResourceIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "authorized_resource_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    public TerraformValue<string> DataSourceId
    {
        get => new TerraformReference<string>(this, "data_source_id");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public TerraformValue<double> Frequency
    {
        get => new TerraformReference<double>(this, "frequency");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The query attribute.
    /// </summary>
    public TerraformValue<string> Query
    {
        get => new TerraformReference<string>(this, "query");
    }

    /// <summary>
    /// The query_type attribute.
    /// </summary>
    public TerraformValue<string> QueryType
    {
        get => new TerraformReference<string>(this, "query_type");
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    public TerraformValue<double> Severity
    {
        get => new TerraformReference<double>(this, "severity");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The throttling attribute.
    /// </summary>
    public TerraformValue<double> Throttling
    {
        get => new TerraformReference<double>(this, "throttling");
    }

    /// <summary>
    /// The time_window attribute.
    /// </summary>
    public TerraformValue<double> TimeWindow
    {
        get => new TerraformReference<double>(this, "time_window");
    }

    /// <summary>
    /// The trigger attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Trigger
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "trigger").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMonitorScheduledQueryRulesAlertDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMonitorScheduledQueryRulesAlertDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
