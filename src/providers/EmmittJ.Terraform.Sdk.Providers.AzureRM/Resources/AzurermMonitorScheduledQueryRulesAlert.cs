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
/// Block type for action in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// The action_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionGroup is required")]
    [TerraformArgument("action_group")]
    public required TerraformSet<string> ActionGroup
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "action_group").ResolveNodes(ctx));
        set => SetArgument("action_group", value);
    }

    /// <summary>
    /// The custom_webhook_payload attribute.
    /// </summary>
    [TerraformArgument("custom_webhook_payload")]
    public TerraformValue<string>? CustomWebhookPayload
    {
        get => new TerraformReference<string>(this, "custom_webhook_payload");
        set => SetArgument("custom_webhook_payload", value);
    }

    /// <summary>
    /// The email_subject attribute.
    /// </summary>
    [TerraformArgument("email_subject")]
    public TerraformValue<string>? EmailSubject
    {
        get => new TerraformReference<string>(this, "email_subject");
        set => SetArgument("email_subject", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Block type for trigger in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertTriggerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trigger";

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operator is required")]
    [TerraformArgument("operator")]
    public required TerraformValue<string> Operator
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    [TerraformArgument("threshold")]
    public required TerraformValue<double> Threshold
    {
        get => new TerraformReference<double>(this, "threshold");
        set => SetArgument("threshold", value);
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
    }

    /// <summary>
    /// The authorized_resource_ids attribute.
    /// </summary>
    [TerraformArgument("authorized_resource_ids")]
    public TerraformSet<string>? AuthorizedResourceIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "authorized_resource_ids").ResolveNodes(ctx));
        set => SetArgument("authorized_resource_ids", value);
    }

    /// <summary>
    /// The auto_mitigation_enabled attribute.
    /// </summary>
    [TerraformArgument("auto_mitigation_enabled")]
    public TerraformValue<bool>? AutoMitigationEnabled
    {
        get => new TerraformReference<bool>(this, "auto_mitigation_enabled");
        set => SetArgument("auto_mitigation_enabled", value);
    }

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceId is required")]
    [TerraformArgument("data_source_id")]
    public required TerraformValue<string> DataSourceId
    {
        get => new TerraformReference<string>(this, "data_source_id");
        set => SetArgument("data_source_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    [TerraformArgument("frequency")]
    public required TerraformValue<double> Frequency
    {
        get => new TerraformReference<double>(this, "frequency");
        set => SetArgument("frequency", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    [TerraformArgument("query")]
    public required TerraformValue<string> Query
    {
        get => new TerraformReference<string>(this, "query");
        set => SetArgument("query", value);
    }

    /// <summary>
    /// The query_type attribute.
    /// </summary>
    [TerraformArgument("query_type")]
    public TerraformValue<string>? QueryType
    {
        get => new TerraformReference<string>(this, "query_type");
        set => SetArgument("query_type", value);
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
    /// The severity attribute.
    /// </summary>
    [TerraformArgument("severity")]
    public TerraformValue<double>? Severity
    {
        get => new TerraformReference<double>(this, "severity");
        set => SetArgument("severity", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The throttling attribute.
    /// </summary>
    [TerraformArgument("throttling")]
    public TerraformValue<double>? Throttling
    {
        get => new TerraformReference<double>(this, "throttling");
        set => SetArgument("throttling", value);
    }

    /// <summary>
    /// The time_window attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeWindow is required")]
    [TerraformArgument("time_window")]
    public required TerraformValue<double> TimeWindow
    {
        get => new TerraformReference<double>(this, "time_window");
        set => SetArgument("time_window", value);
    }

    /// <summary>
    /// Block for action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Action block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    [TerraformArgument("action")]
    public required TerraformList<AzurermMonitorScheduledQueryRulesAlertActionBlock> Action { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMonitorScheduledQueryRulesAlertTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for trigger.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Trigger is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Trigger block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Trigger block(s) allowed")]
    [TerraformArgument("trigger")]
    public required TerraformList<AzurermMonitorScheduledQueryRulesAlertTriggerBlock> Trigger { get; set; } = new();

}
