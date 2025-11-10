using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogAnalyticsDatasourceWindowsPerformanceCounterTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_log_analytics_datasource_windows_performance_counter resource.
/// </summary>
public class AzurermLogAnalyticsDatasourceWindowsPerformanceCounter : TerraformResource
{
    public AzurermLogAnalyticsDatasourceWindowsPerformanceCounter(string name) : base("azurerm_log_analytics_datasource_windows_performance_counter", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("counter_name");
        SetOutput("id");
        SetOutput("instance_name");
        SetOutput("interval_seconds");
        SetOutput("name");
        SetOutput("object_name");
        SetOutput("resource_group_name");
        SetOutput("workspace_name");
    }

    /// <summary>
    /// The counter_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CounterName is required")]
    public required TerraformProperty<string> CounterName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("counter_name");
        set => SetProperty("counter_name", value);
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
    /// The instance_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceName is required")]
    public required TerraformProperty<string> InstanceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_name");
        set => SetProperty("instance_name", value);
    }

    /// <summary>
    /// The interval_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntervalSeconds is required")]
    public required TerraformProperty<double> IntervalSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("interval_seconds");
        set => SetProperty("interval_seconds", value);
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
    /// The object_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectName is required")]
    public required TerraformProperty<string> ObjectName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("object_name");
        set => SetProperty("object_name", value);
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
    /// The workspace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceName is required")]
    public required TerraformProperty<string> WorkspaceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workspace_name");
        set => SetProperty("workspace_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLogAnalyticsDatasourceWindowsPerformanceCounterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
