using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSentinelAlertRuleMsSecurityIncidentTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_sentinel_alert_rule_ms_security_incident resource.
/// </summary>
public class AzurermSentinelAlertRuleMsSecurityIncident : TerraformResource
{
    public AzurermSentinelAlertRuleMsSecurityIncident(string name) : base("azurerm_sentinel_alert_rule_ms_security_incident", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("alert_rule_template_guid");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("display_name_exclude_filter");
        SetOutput("display_name_filter");
        SetOutput("enabled");
        SetOutput("id");
        SetOutput("log_analytics_workspace_id");
        SetOutput("name");
        SetOutput("product_filter");
        SetOutput("severity_filter");
    }

    /// <summary>
    /// The alert_rule_template_guid attribute.
    /// </summary>
    public TerraformProperty<string> AlertRuleTemplateGuid
    {
        get => GetRequiredOutput<TerraformProperty<string>>("alert_rule_template_guid");
        set => SetProperty("alert_rule_template_guid", value);
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
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The display_name_exclude_filter attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> DisplayNameExcludeFilter
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("display_name_exclude_filter");
        set => SetProperty("display_name_exclude_filter", value);
    }

    /// <summary>
    /// The display_name_filter attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> DisplayNameFilter
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("display_name_filter");
        set => SetProperty("display_name_filter", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The product_filter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductFilter is required")]
    public required TerraformProperty<string> ProductFilter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("product_filter");
        set => SetProperty("product_filter", value);
    }

    /// <summary>
    /// The severity_filter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SeverityFilter is required")]
    public HashSet<TerraformProperty<string>> SeverityFilter
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("severity_filter");
        set => SetProperty("severity_filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSentinelAlertRuleMsSecurityIncidentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
