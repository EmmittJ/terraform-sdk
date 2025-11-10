using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for multi_select_observation in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleAnomalyDuplicateMultiSelectObservationBlock : TerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The supported_values attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SupportedValues
    {
        set => SetProperty("supported_values", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public List<TerraformProperty<string>>? Values
    {
        set => SetProperty("values", value);
    }

}

/// <summary>
/// Block type for prioritized_exclude_observation in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleAnomalyDuplicatePrioritizedExcludeObservationBlock : TerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The exclude attribute.
    /// </summary>
    public TerraformProperty<string>? Exclude
    {
        set => SetProperty("exclude", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The prioritize attribute.
    /// </summary>
    public TerraformProperty<string>? Prioritize
    {
        set => SetProperty("prioritize", value);
    }

}

/// <summary>
/// Block type for single_select_observation in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleAnomalyDuplicateSingleSelectObservationBlock : TerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The supported_values attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SupportedValues
    {
        set => SetProperty("supported_values", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        set => SetProperty("value", value);
    }

}

/// <summary>
/// Block type for threshold_observation in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleAnomalyDuplicateThresholdObservationBlock : TerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformProperty<string>? Max
    {
        set => SetProperty("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformProperty<string>? Min
    {
        set => SetProperty("min", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        set => SetProperty("value", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSentinelAlertRuleAnomalyDuplicateTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_sentinel_alert_rule_anomaly_duplicate resource.
/// </summary>
public class AzurermSentinelAlertRuleAnomalyDuplicate : TerraformResource
{
    public AzurermSentinelAlertRuleAnomalyDuplicate(string name) : base("azurerm_sentinel_alert_rule_anomaly_duplicate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("anomaly_settings_version");
        SetOutput("anomaly_version");
        SetOutput("description");
        SetOutput("frequency");
        SetOutput("is_default_settings");
        SetOutput("name");
        SetOutput("required_data_connector");
        SetOutput("settings_definition_id");
        SetOutput("tactics");
        SetOutput("techniques");
        SetOutput("built_in_rule_id");
        SetOutput("display_name");
        SetOutput("enabled");
        SetOutput("id");
        SetOutput("log_analytics_workspace_id");
        SetOutput("mode");
    }

    /// <summary>
    /// The built_in_rule_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BuiltInRuleId is required")]
    public required TerraformProperty<string> BuiltInRuleId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("built_in_rule_id");
        set => SetProperty("built_in_rule_id", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
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
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformProperty<string> LogAnalyticsWorkspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("log_analytics_workspace_id");
        set => SetProperty("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformProperty<string> Mode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mode");
        set => SetProperty("mode", value);
    }

    /// <summary>
    /// Block for multi_select_observation.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSentinelAlertRuleAnomalyDuplicateMultiSelectObservationBlock>? MultiSelectObservation
    {
        set => SetProperty("multi_select_observation", value);
    }

    /// <summary>
    /// Block for prioritized_exclude_observation.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSentinelAlertRuleAnomalyDuplicatePrioritizedExcludeObservationBlock>? PrioritizedExcludeObservation
    {
        set => SetProperty("prioritized_exclude_observation", value);
    }

    /// <summary>
    /// Block for single_select_observation.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSentinelAlertRuleAnomalyDuplicateSingleSelectObservationBlock>? SingleSelectObservation
    {
        set => SetProperty("single_select_observation", value);
    }

    /// <summary>
    /// Block for threshold_observation.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSentinelAlertRuleAnomalyDuplicateThresholdObservationBlock>? ThresholdObservation
    {
        set => SetProperty("threshold_observation", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSentinelAlertRuleAnomalyDuplicateTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The anomaly_settings_version attribute.
    /// </summary>
    public TerraformExpression AnomalySettingsVersion => this["anomaly_settings_version"];

    /// <summary>
    /// The anomaly_version attribute.
    /// </summary>
    public TerraformExpression AnomalyVersion => this["anomaly_version"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public TerraformExpression Frequency => this["frequency"];

    /// <summary>
    /// The is_default_settings attribute.
    /// </summary>
    public TerraformExpression IsDefaultSettings => this["is_default_settings"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The required_data_connector attribute.
    /// </summary>
    public TerraformExpression RequiredDataConnector => this["required_data_connector"];

    /// <summary>
    /// The settings_definition_id attribute.
    /// </summary>
    public TerraformExpression SettingsDefinitionId => this["settings_definition_id"];

    /// <summary>
    /// The tactics attribute.
    /// </summary>
    public TerraformExpression Tactics => this["tactics"];

    /// <summary>
    /// The techniques attribute.
    /// </summary>
    public TerraformExpression Techniques => this["techniques"];

}
