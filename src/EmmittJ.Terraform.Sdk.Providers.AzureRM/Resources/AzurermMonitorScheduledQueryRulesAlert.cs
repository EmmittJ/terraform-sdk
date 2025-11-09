using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_monitor_scheduled_query_rules_alert resource.
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlert : TerraformResource
{
    public AzurermMonitorScheduledQueryRulesAlert(string name) : base("azurerm_monitor_scheduled_query_rules_alert", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The authorized_resource_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? AuthorizedResourceIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("authorized_resource_ids");
        set => this.WithProperty("authorized_resource_ids", value);
    }

    /// <summary>
    /// The auto_mitigation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoMitigationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("auto_mitigation_enabled");
        set => this.WithProperty("auto_mitigation_enabled", value);
    }

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    public TerraformProperty<string>? DataSourceId
    {
        get => GetProperty<TerraformProperty<string>>("data_source_id");
        set => this.WithProperty("data_source_id", value);
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
    /// The frequency attribute.
    /// </summary>
    public TerraformProperty<double>? Frequency
    {
        get => GetProperty<TerraformProperty<double>>("frequency");
        set => this.WithProperty("frequency", value);
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
    /// The query attribute.
    /// </summary>
    public TerraformProperty<string>? Query
    {
        get => GetProperty<TerraformProperty<string>>("query");
        set => this.WithProperty("query", value);
    }

    /// <summary>
    /// The query_type attribute.
    /// </summary>
    public TerraformProperty<string>? QueryType
    {
        get => GetProperty<TerraformProperty<string>>("query_type");
        set => this.WithProperty("query_type", value);
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
    /// The severity attribute.
    /// </summary>
    public TerraformProperty<double>? Severity
    {
        get => GetProperty<TerraformProperty<double>>("severity");
        set => this.WithProperty("severity", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The throttling attribute.
    /// </summary>
    public TerraformProperty<double>? Throttling
    {
        get => GetProperty<TerraformProperty<double>>("throttling");
        set => this.WithProperty("throttling", value);
    }

    /// <summary>
    /// The time_window attribute.
    /// </summary>
    public TerraformProperty<double>? TimeWindow
    {
        get => GetProperty<TerraformProperty<double>>("time_window");
        set => this.WithProperty("time_window", value);
    }

}
