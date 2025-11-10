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
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The supported_values attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SupportedValues
    {
        get => GetProperty<List<TerraformProperty<string>>>("supported_values");
        set => WithProperty("supported_values", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public List<TerraformProperty<string>>? Values
    {
        get => GetProperty<List<TerraformProperty<string>>>("values");
        set => WithProperty("values", value);
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
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The exclude attribute.
    /// </summary>
    public TerraformProperty<string>? Exclude
    {
        get => GetProperty<TerraformProperty<string>>("exclude");
        set => WithProperty("exclude", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The prioritize attribute.
    /// </summary>
    public TerraformProperty<string>? Prioritize
    {
        get => GetProperty<TerraformProperty<string>>("prioritize");
        set => WithProperty("prioritize", value);
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
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The supported_values attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SupportedValues
    {
        get => GetProperty<List<TerraformProperty<string>>>("supported_values");
        set => WithProperty("supported_values", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
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
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformProperty<string>? Max
    {
        get => GetProperty<TerraformProperty<string>>("max");
        set => WithProperty("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformProperty<string>? Min
    {
        get => GetProperty<TerraformProperty<string>>("min");
        set => WithProperty("min", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
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
        this.DeclareOutput("anomaly_settings_version");
        this.DeclareOutput("anomaly_version");
        this.DeclareOutput("description");
        this.DeclareOutput("frequency");
        this.DeclareOutput("is_default_settings");
        this.DeclareOutput("name");
        this.DeclareOutput("required_data_connector");
        this.DeclareOutput("settings_definition_id");
        this.DeclareOutput("tactics");
        this.DeclareOutput("techniques");
    }

    /// <summary>
    /// The built_in_rule_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BuiltInRuleId is required")]
    public required TerraformProperty<string> BuiltInRuleId
    {
        get => GetProperty<TerraformProperty<string>>("built_in_rule_id");
        set => this.WithProperty("built_in_rule_id", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
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
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformProperty<string> LogAnalyticsWorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("log_analytics_workspace_id");
        set => this.WithProperty("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformProperty<string> Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => this.WithProperty("mode", value);
    }

    /// <summary>
    /// Block for multi_select_observation.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSentinelAlertRuleAnomalyDuplicateMultiSelectObservationBlock>? MultiSelectObservation
    {
        get => GetProperty<List<AzurermSentinelAlertRuleAnomalyDuplicateMultiSelectObservationBlock>>("multi_select_observation");
        set => this.WithProperty("multi_select_observation", value);
    }

    /// <summary>
    /// Block for prioritized_exclude_observation.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSentinelAlertRuleAnomalyDuplicatePrioritizedExcludeObservationBlock>? PrioritizedExcludeObservation
    {
        get => GetProperty<List<AzurermSentinelAlertRuleAnomalyDuplicatePrioritizedExcludeObservationBlock>>("prioritized_exclude_observation");
        set => this.WithProperty("prioritized_exclude_observation", value);
    }

    /// <summary>
    /// Block for single_select_observation.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSentinelAlertRuleAnomalyDuplicateSingleSelectObservationBlock>? SingleSelectObservation
    {
        get => GetProperty<List<AzurermSentinelAlertRuleAnomalyDuplicateSingleSelectObservationBlock>>("single_select_observation");
        set => this.WithProperty("single_select_observation", value);
    }

    /// <summary>
    /// Block for threshold_observation.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSentinelAlertRuleAnomalyDuplicateThresholdObservationBlock>? ThresholdObservation
    {
        get => GetProperty<List<AzurermSentinelAlertRuleAnomalyDuplicateThresholdObservationBlock>>("threshold_observation");
        set => this.WithProperty("threshold_observation", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSentinelAlertRuleAnomalyDuplicateTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSentinelAlertRuleAnomalyDuplicateTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
