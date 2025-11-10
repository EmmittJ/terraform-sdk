using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSentinelAlertRuleAnomalyBuiltInTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_sentinel_alert_rule_anomaly_built_in resource.
/// </summary>
public class AzurermSentinelAlertRuleAnomalyBuiltIn : TerraformResource
{
    public AzurermSentinelAlertRuleAnomalyBuiltIn(string name) : base("azurerm_sentinel_alert_rule_anomaly_built_in", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutputnomaly_settings_version");
        this.WithOutputnomaly_version");
        this.WithOutputescription");
        this.WithOutputrequency");
        this.WithOutputulti_select_observation");
        this.WithOutputrioritized_exclude_observation");
        this.WithOutputequired_data_connector");
        this.WithOutputettings_definition_id");
        this.WithOutputingle_select_observation");
        this.WithOutputactics");
        this.WithOutputechniques");
        this.WithOutputhreshold_observation");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
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
        get => GetRequiredProperty<TerraformProperty<bool>>("enabled");
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
        get => GetRequiredProperty<TerraformProperty<string>>("log_analytics_workspace_id");
        set => this.WithProperty("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformProperty<string> Mode
    {
        get => GetRequiredProperty<TerraformProperty<string>>("mode");
        set => this.WithProperty("mode", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSentinelAlertRuleAnomalyBuiltInTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSentinelAlertRuleAnomalyBuiltInTimeoutsBlock>("timeouts");
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
    /// The multi_select_observation attribute.
    /// </summary>
    public TerraformExpression MultiSelectObservation => this["multi_select_observation"];

    /// <summary>
    /// The prioritized_exclude_observation attribute.
    /// </summary>
    public TerraformExpression PrioritizedExcludeObservation => this["prioritized_exclude_observation"];

    /// <summary>
    /// The required_data_connector attribute.
    /// </summary>
    public TerraformExpression RequiredDataConnector => this["required_data_connector"];

    /// <summary>
    /// The settings_definition_id attribute.
    /// </summary>
    public TerraformExpression SettingsDefinitionId => this["settings_definition_id"];

    /// <summary>
    /// The single_select_observation attribute.
    /// </summary>
    public TerraformExpression SingleSelectObservation => this["single_select_observation"];

    /// <summary>
    /// The tactics attribute.
    /// </summary>
    public TerraformExpression Tactics => this["tactics"];

    /// <summary>
    /// The techniques attribute.
    /// </summary>
    public TerraformExpression Techniques => this["techniques"];

    /// <summary>
    /// The threshold_observation attribute.
    /// </summary>
    public TerraformExpression ThresholdObservation => this["threshold_observation"];

}
