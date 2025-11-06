using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_monitor_alert_prometheus_rule_group resource.
/// </summary>
public class AzurermMonitorAlertPrometheusRuleGroup : TerraformResource
{
    public AzurermMonitorAlertPrometheusRuleGroup(string name) : base("azurerm_monitor_alert_prometheus_rule_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    public string? ClusterName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_name")?.Value;
        set => this.WithProperty("cluster_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public string? Interval
    {
        get => GetProperty<TerraformLiteralProperty<string>>("interval")?.Value;
        set => this.WithProperty("interval", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The rule_group_enabled attribute.
    /// </summary>
    public bool? RuleGroupEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("rule_group_enabled")?.Value;
        set => this.WithProperty("rule_group_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    public List<string>? Scopes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("scopes")?.Value;
        set => this.WithProperty("scopes", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
