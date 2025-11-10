using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSentinelAlertRuleAnomalyDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_sentinel_alert_rule_anomaly.
/// </summary>
public class AzurermSentinelAlertRuleAnomalyDataSource : TerraformDataSource
{
    public AzurermSentinelAlertRuleAnomalyDataSource(string name) : base("azurerm_sentinel_alert_rule_anomaly", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("anomaly_settings_version");
        SetOutput("anomaly_version");
        SetOutput("description");
        SetOutput("enabled");
        SetOutput("frequency");
        SetOutput("mode");
        SetOutput("multi_select_observation");
        SetOutput("prioritized_exclude_observation");
        SetOutput("required_data_connector");
        SetOutput("settings_definition_id");
        SetOutput("single_select_observation");
        SetOutput("tactics");
        SetOutput("techniques");
        SetOutput("threshold_observation");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("log_analytics_workspace_id");
        SetOutput("name");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSentinelAlertRuleAnomalyDataSourceTimeoutsBlock? Timeouts
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
    /// The enabled attribute.
    /// </summary>
    public TerraformExpression Enabled => this["enabled"];

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public TerraformExpression Frequency => this["frequency"];

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformExpression Mode => this["mode"];

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
