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
    public TerraformLiteralProperty<HashSet<string>>? AuthorizedResourceIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("authorized_resource_ids");
        set => this.WithProperty("authorized_resource_ids", value);
    }

    /// <summary>
    /// The auto_mitigation_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AutoMitigationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_mitigation_enabled");
        set => this.WithProperty("auto_mitigation_enabled", value);
    }

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DataSourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_source_id");
        set => this.WithProperty("data_source_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Frequency
    {
        get => GetProperty<TerraformLiteralProperty<double>>("frequency");
        set => this.WithProperty("frequency", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The query attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Query
    {
        get => GetProperty<TerraformLiteralProperty<string>>("query");
        set => this.WithProperty("query", value);
    }

    /// <summary>
    /// The query_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? QueryType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("query_type");
        set => this.WithProperty("query_type", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Severity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("severity");
        set => this.WithProperty("severity", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The throttling attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Throttling
    {
        get => GetProperty<TerraformLiteralProperty<double>>("throttling");
        set => this.WithProperty("throttling", value);
    }

    /// <summary>
    /// The time_window attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? TimeWindow
    {
        get => GetProperty<TerraformLiteralProperty<double>>("time_window");
        set => this.WithProperty("time_window", value);
    }

}
