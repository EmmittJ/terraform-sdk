using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_dynatrace_monitor.
/// </summary>
public class AzurermDynatraceMonitorDataSource : TerraformDataSource
{
    public AzurermDynatraceMonitorDataSource(string name) : base("azurerm_dynatrace_monitor", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("environment_properties");
        this.DeclareOutput("identity");
        this.DeclareOutput("location");
        this.DeclareOutput("marketplace_subscription");
        this.DeclareOutput("monitoring_enabled");
        this.DeclareOutput("plan");
        this.DeclareOutput("tags");
        this.DeclareOutput("user");
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
    /// The environment_properties attribute.
    /// </summary>
    public TerraformExpression EnvironmentProperties => this["environment_properties"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The marketplace_subscription attribute.
    /// </summary>
    public TerraformExpression MarketplaceSubscription => this["marketplace_subscription"];

    /// <summary>
    /// The monitoring_enabled attribute.
    /// </summary>
    public TerraformExpression MonitoringEnabled => this["monitoring_enabled"];

    /// <summary>
    /// The plan attribute.
    /// </summary>
    public TerraformExpression Plan => this["plan"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The user attribute.
    /// </summary>
    public TerraformExpression User => this["user"];

}
