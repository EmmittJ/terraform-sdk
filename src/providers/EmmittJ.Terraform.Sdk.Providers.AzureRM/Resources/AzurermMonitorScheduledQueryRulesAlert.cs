using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for action in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertActionBlock : TerraformBlock
{
    /// <summary>
    /// The action_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionGroup is required")]
    public HashSet<TerraformProperty<string>>? ActionGroup
    {
        set => SetProperty("action_group", value);
    }

    /// <summary>
    /// The custom_webhook_payload attribute.
    /// </summary>
    public TerraformProperty<string>? CustomWebhookPayload
    {
        set => SetProperty("custom_webhook_payload", value);
    }

    /// <summary>
    /// The email_subject attribute.
    /// </summary>
    public TerraformProperty<string>? EmailSubject
    {
        set => SetProperty("email_subject", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Block type for trigger in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertTriggerBlock : TerraformBlock
{
    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operator is required")]
    public required TerraformProperty<string> Operator
    {
        set => SetProperty("operator", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    public required TerraformProperty<double> Threshold
    {
        set => SetProperty("threshold", value);
    }

}

/// <summary>
/// Manages a azurerm_monitor_scheduled_query_rules_alert resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMonitorScheduledQueryRulesAlert : TerraformResource
{
    public AzurermMonitorScheduledQueryRulesAlert(string name) : base("azurerm_monitor_scheduled_query_rules_alert", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("authorized_resource_ids");
        SetOutput("auto_mitigation_enabled");
        SetOutput("data_source_id");
        SetOutput("description");
        SetOutput("enabled");
        SetOutput("frequency");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("query");
        SetOutput("query_type");
        SetOutput("resource_group_name");
        SetOutput("severity");
        SetOutput("tags");
        SetOutput("throttling");
        SetOutput("time_window");
    }

    /// <summary>
    /// The authorized_resource_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AuthorizedResourceIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("authorized_resource_ids");
        set => SetProperty("authorized_resource_ids", value);
    }

    /// <summary>
    /// The auto_mitigation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AutoMitigationEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_mitigation_enabled");
        set => SetProperty("auto_mitigation_enabled", value);
    }

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceId is required")]
    public required TerraformProperty<string> DataSourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_source_id");
        set => SetProperty("data_source_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    public required TerraformProperty<double> Frequency
    {
        get => GetRequiredOutput<TerraformProperty<double>>("frequency");
        set => SetProperty("frequency", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// The query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    public required TerraformProperty<string> Query
    {
        get => GetRequiredOutput<TerraformProperty<string>>("query");
        set => SetProperty("query", value);
    }

    /// <summary>
    /// The query_type attribute.
    /// </summary>
    public TerraformProperty<string> QueryType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("query_type");
        set => SetProperty("query_type", value);
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
    /// The severity attribute.
    /// </summary>
    public TerraformProperty<double> Severity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("severity");
        set => SetProperty("severity", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The throttling attribute.
    /// </summary>
    public TerraformProperty<double> Throttling
    {
        get => GetRequiredOutput<TerraformProperty<double>>("throttling");
        set => SetProperty("throttling", value);
    }

    /// <summary>
    /// The time_window attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeWindow is required")]
    public required TerraformProperty<double> TimeWindow
    {
        get => GetRequiredOutput<TerraformProperty<double>>("time_window");
        set => SetProperty("time_window", value);
    }

    /// <summary>
    /// Block for action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Action block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    public List<AzurermMonitorScheduledQueryRulesAlertActionBlock>? Action
    {
        set => SetProperty("action", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMonitorScheduledQueryRulesAlertTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for trigger.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Trigger is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Trigger block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Trigger block(s) allowed")]
    public List<AzurermMonitorScheduledQueryRulesAlertTriggerBlock>? Trigger
    {
        set => SetProperty("trigger", value);
    }

}
