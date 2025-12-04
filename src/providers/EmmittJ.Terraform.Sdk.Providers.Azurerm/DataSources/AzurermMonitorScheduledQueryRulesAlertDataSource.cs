using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermMonitorScheduledQueryRulesAlertDataSource.
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
        get => GetArgument<TerraformValue<string>>("read");
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
    /// The action attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Action
        => AsReference("action");

    /// <summary>
    /// The authorized_resource_ids attribute.
    /// </summary>
    public TerraformSet<string> AuthorizedResourceIds
        => AsReference("authorized_resource_ids");

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    public TerraformValue<string> DataSourceId
        => AsReference("data_source_id");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
        => AsReference("enabled");

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public TerraformValue<double> Frequency
        => AsReference("frequency");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The query attribute.
    /// </summary>
    public TerraformValue<string> Query
        => AsReference("query");

    /// <summary>
    /// The query_type attribute.
    /// </summary>
    public TerraformValue<string> QueryType
        => AsReference("query_type");

    /// <summary>
    /// The severity attribute.
    /// </summary>
    public TerraformValue<double> Severity
        => AsReference("severity");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The throttling attribute.
    /// </summary>
    public TerraformValue<double> Throttling
        => AsReference("throttling");

    /// <summary>
    /// The time_window attribute.
    /// </summary>
    public TerraformValue<double> TimeWindow
        => AsReference("time_window");

    /// <summary>
    /// The trigger attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Trigger
        => AsReference("trigger");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMonitorScheduledQueryRulesAlertDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMonitorScheduledQueryRulesAlertDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
