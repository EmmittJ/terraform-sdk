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
    public TerraformProperty<string>? ClusterName
    {
        get => GetProperty<TerraformProperty<string>>("cluster_name");
        set => this.WithProperty("cluster_name", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformProperty<string>? Interval
    {
        get => GetProperty<TerraformProperty<string>>("interval");
        set => this.WithProperty("interval", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The rule_group_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RuleGroupEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("rule_group_enabled");
        set => this.WithProperty("rule_group_enabled", value);
    }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    public TerraformProperty<List<string>>? Scopes
    {
        get => GetProperty<TerraformProperty<List<string>>>("scopes");
        set => this.WithProperty("scopes", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

}
