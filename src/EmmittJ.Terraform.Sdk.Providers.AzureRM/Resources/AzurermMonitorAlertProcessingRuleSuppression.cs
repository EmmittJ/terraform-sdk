using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for condition in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAlertProcessingRuleSuppressionConditionBlock : TerraformBlock
{
}

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAlertProcessingRuleSuppressionScheduleBlock : TerraformBlock
{
    /// <summary>
    /// The effective_from attribute.
    /// </summary>
    public TerraformProperty<string>? EffectiveFrom
    {
        get => GetProperty<TerraformProperty<string>>("effective_from");
        set => WithProperty("effective_from", value);
    }

    /// <summary>
    /// The effective_until attribute.
    /// </summary>
    public TerraformProperty<string>? EffectiveUntil
    {
        get => GetProperty<TerraformProperty<string>>("effective_until");
        set => WithProperty("effective_until", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformProperty<string>? TimeZone
    {
        get => GetProperty<TerraformProperty<string>>("time_zone");
        set => WithProperty("time_zone", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorAlertProcessingRuleSuppressionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_monitor_alert_processing_rule_suppression resource.
/// </summary>
public class AzurermMonitorAlertProcessingRuleSuppression : TerraformResource
{
    public AzurermMonitorAlertProcessingRuleSuppression(string name) : base("azurerm_monitor_alert_processing_rule_suppression", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    public List<TerraformProperty<string>>? Scopes
    {
        get => GetProperty<List<TerraformProperty<string>>>("scopes");
        set => this.WithProperty("scopes", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for condition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    public List<AzurermMonitorAlertProcessingRuleSuppressionConditionBlock>? Condition
    {
        get => GetProperty<List<AzurermMonitorAlertProcessingRuleSuppressionConditionBlock>>("condition");
        set => this.WithProperty("condition", value);
    }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public List<AzurermMonitorAlertProcessingRuleSuppressionScheduleBlock>? Schedule
    {
        get => GetProperty<List<AzurermMonitorAlertProcessingRuleSuppressionScheduleBlock>>("schedule");
        set => this.WithProperty("schedule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMonitorAlertProcessingRuleSuppressionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMonitorAlertProcessingRuleSuppressionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
