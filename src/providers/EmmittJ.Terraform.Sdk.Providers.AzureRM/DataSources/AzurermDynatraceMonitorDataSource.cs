using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDynatraceMonitorDataSourceTimeoutsBlock : TerraformBlock
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
        SetOutput("environment_properties");
        SetOutput("identity");
        SetOutput("location");
        SetOutput("marketplace_subscription");
        SetOutput("monitoring_enabled");
        SetOutput("plan");
        SetOutput("tags");
        SetOutput("user");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDynatraceMonitorDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
