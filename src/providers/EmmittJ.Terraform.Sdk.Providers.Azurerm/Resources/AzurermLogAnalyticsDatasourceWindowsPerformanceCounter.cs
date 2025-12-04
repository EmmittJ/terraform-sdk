using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermLogAnalyticsDatasourceWindowsPerformanceCounter.
/// Nesting mode: single
/// </summary>
public class AzurermLogAnalyticsDatasourceWindowsPerformanceCounterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_log_analytics_datasource_windows_performance_counter Terraform resource.
/// Manages a azurerm_log_analytics_datasource_windows_performance_counter resource.
/// </summary>
public partial class AzurermLogAnalyticsDatasourceWindowsPerformanceCounter(string name) : TerraformResource("azurerm_log_analytics_datasource_windows_performance_counter", name)
{
    /// <summary>
    /// The counter_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CounterName is required")]
    public required TerraformValue<string> CounterName
    {
        get => GetRequiredArgument<TerraformValue<string>>("counter_name");
        set => SetArgument("counter_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceName is required")]
    public required TerraformValue<string> InstanceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance_name");
        set => SetArgument("instance_name", value);
    }

    /// <summary>
    /// The interval_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntervalSeconds is required")]
    public required TerraformValue<double> IntervalSeconds
    {
        get => GetRequiredArgument<TerraformValue<double>>("interval_seconds");
        set => SetArgument("interval_seconds", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The object_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectName is required")]
    public required TerraformValue<string> ObjectName
    {
        get => GetRequiredArgument<TerraformValue<string>>("object_name");
        set => SetArgument("object_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The workspace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceName is required")]
    public required TerraformValue<string> WorkspaceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("workspace_name");
        set => SetArgument("workspace_name", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLogAnalyticsDatasourceWindowsPerformanceCounterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLogAnalyticsDatasourceWindowsPerformanceCounterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
