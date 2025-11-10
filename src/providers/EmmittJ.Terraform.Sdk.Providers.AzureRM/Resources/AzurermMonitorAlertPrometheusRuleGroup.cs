using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for rule in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAlertPrometheusRuleGroupRuleBlock : TerraformBlock
{
    /// <summary>
    /// The alert attribute.
    /// </summary>
    public TerraformProperty<string>? Alert
    {
        set => SetProperty("alert", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Annotations
    {
        set => SetProperty("annotations", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    public required TerraformProperty<string> Expression
    {
        set => SetProperty("expression", value);
    }

    /// <summary>
    /// The for attribute.
    /// </summary>
    public TerraformProperty<string>? For
    {
        set => SetProperty("for", value);
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The record attribute.
    /// </summary>
    public TerraformProperty<string>? Record
    {
        set => SetProperty("record", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    public TerraformProperty<double>? Severity
    {
        set => SetProperty("severity", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorAlertPrometheusRuleGroupTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_monitor_alert_prometheus_rule_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMonitorAlertPrometheusRuleGroup : TerraformResource
{
    public AzurermMonitorAlertPrometheusRuleGroup(string name) : base("azurerm_monitor_alert_prometheus_rule_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("cluster_name");
        SetOutput("description");
        SetOutput("id");
        SetOutput("interval");
        SetOutput("location");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("rule_group_enabled");
        SetOutput("scopes");
        SetOutput("tags");
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    public TerraformProperty<string> ClusterName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_name");
        set => SetProperty("cluster_name", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformProperty<string> Interval
    {
        get => GetRequiredOutput<TerraformProperty<string>>("interval");
        set => SetProperty("interval", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The rule_group_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> RuleGroupEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("rule_group_enabled");
        set => SetProperty("rule_group_enabled", value);
    }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    public List<TerraformProperty<string>> Scopes
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("scopes");
        set => SetProperty("scopes", value);
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
    /// Block for rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    public List<AzurermMonitorAlertPrometheusRuleGroupRuleBlock>? Rule
    {
        set => SetProperty("rule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMonitorAlertPrometheusRuleGroupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
