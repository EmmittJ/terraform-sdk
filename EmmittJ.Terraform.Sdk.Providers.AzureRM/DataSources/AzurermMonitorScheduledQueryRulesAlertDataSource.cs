using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_monitor_scheduled_query_rules_alert.
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertDataSource : TerraformDataSource
{
    public AzurermMonitorScheduledQueryRulesAlertDataSource(string name) : base("azurerm_monitor_scheduled_query_rules_alert", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("action");
        this.DeclareOutput("authorized_resource_ids");
        this.DeclareOutput("data_source_id");
        this.DeclareOutput("description");
        this.DeclareOutput("enabled");
        this.DeclareOutput("frequency");
        this.DeclareOutput("location");
        this.DeclareOutput("query");
        this.DeclareOutput("query_type");
        this.DeclareOutput("severity");
        this.DeclareOutput("tags");
        this.DeclareOutput("throttling");
        this.DeclareOutput("time_window");
        this.DeclareOutput("trigger");
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
    /// The action attribute.
    /// </summary>
    public TerraformExpression Action => this["action"];

    /// <summary>
    /// The authorized_resource_ids attribute.
    /// </summary>
    public TerraformExpression AuthorizedResourceIds => this["authorized_resource_ids"];

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    public TerraformExpression DataSourceId => this["data_source_id"];

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
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The query attribute.
    /// </summary>
    public TerraformExpression Query => this["query"];

    /// <summary>
    /// The query_type attribute.
    /// </summary>
    public TerraformExpression QueryType => this["query_type"];

    /// <summary>
    /// The severity attribute.
    /// </summary>
    public TerraformExpression Severity => this["severity"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The throttling attribute.
    /// </summary>
    public TerraformExpression Throttling => this["throttling"];

    /// <summary>
    /// The time_window attribute.
    /// </summary>
    public TerraformExpression TimeWindow => this["time_window"];

    /// <summary>
    /// The trigger attribute.
    /// </summary>
    public TerraformExpression Trigger => this["trigger"];

}
