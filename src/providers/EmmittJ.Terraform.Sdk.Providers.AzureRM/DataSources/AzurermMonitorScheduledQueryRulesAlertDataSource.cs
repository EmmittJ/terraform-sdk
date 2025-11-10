using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_monitor_scheduled_query_rules_alert.
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertDataSource : TerraformDataSource
{
    public AzurermMonitorScheduledQueryRulesAlertDataSource(string name) : base("azurerm_monitor_scheduled_query_rules_alert", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("action");
        SetOutput("authorized_resource_ids");
        SetOutput("data_source_id");
        SetOutput("description");
        SetOutput("enabled");
        SetOutput("frequency");
        SetOutput("location");
        SetOutput("query");
        SetOutput("query_type");
        SetOutput("severity");
        SetOutput("tags");
        SetOutput("throttling");
        SetOutput("time_window");
        SetOutput("trigger");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMonitorScheduledQueryRulesAlertDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    public TerraformExpression Action => this["action"];

    /// <summary>
    /// The authorized_resource_ids attribute.
    /// </summary>
    public TerraformExpression AuthorizedResourceIds => this["authorized_resource_ids"];

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    public TerraformExpression DataSourceId => this["data_source_id"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformExpression Enabled => this["enabled"];

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public TerraformExpression Frequency => this["frequency"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The query attribute.
    /// </summary>
    public TerraformExpression Query => this["query"];

    /// <summary>
    /// The query_type attribute.
    /// </summary>
    public TerraformExpression QueryType => this["query_type"];

    /// <summary>
    /// The severity attribute.
    /// </summary>
    public TerraformExpression Severity => this["severity"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The throttling attribute.
    /// </summary>
    public TerraformExpression Throttling => this["throttling"];

    /// <summary>
    /// The time_window attribute.
    /// </summary>
    public TerraformExpression TimeWindow => this["time_window"];

    /// <summary>
    /// The trigger attribute.
    /// </summary>
    public TerraformExpression Trigger => this["trigger"];

}
