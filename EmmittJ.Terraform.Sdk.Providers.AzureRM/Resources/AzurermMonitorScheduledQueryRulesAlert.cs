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
    public HashSet<string>? AuthorizedResourceIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("authorized_resource_ids")?.Value;
        set => this.WithProperty("authorized_resource_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The auto_mitigation_enabled attribute.
    /// </summary>
    public bool? AutoMitigationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_mitigation_enabled")?.Value;
        set => this.WithProperty("auto_mitigation_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    public string? DataSourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_source_id")?.Value;
        set => this.WithProperty("data_source_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The enabled attribute.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public double? Frequency
    {
        get => GetProperty<TerraformLiteralProperty<double>>("frequency")?.Value;
        set => this.WithProperty("frequency", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The query attribute.
    /// </summary>
    public string? Query
    {
        get => GetProperty<TerraformLiteralProperty<string>>("query")?.Value;
        set => this.WithProperty("query", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The query_type attribute.
    /// </summary>
    public string? QueryType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("query_type")?.Value;
        set => this.WithProperty("query_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The severity attribute.
    /// </summary>
    public double? Severity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("severity")?.Value;
        set => this.WithProperty("severity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The throttling attribute.
    /// </summary>
    public double? Throttling
    {
        get => GetProperty<TerraformLiteralProperty<double>>("throttling")?.Value;
        set => this.WithProperty("throttling", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The time_window attribute.
    /// </summary>
    public double? TimeWindow
    {
        get => GetProperty<TerraformLiteralProperty<double>>("time_window")?.Value;
        set => this.WithProperty("time_window", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

}
