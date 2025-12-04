using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSpringCloudApplicationInsightsApplicationPerformanceMonitoring.
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudApplicationInsightsApplicationPerformanceMonitoringTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_spring_cloud_application_insights_application_performance_monitoring Terraform resource.
/// Manages a azurerm_spring_cloud_application_insights_application_performance_monitoring resource.
/// </summary>
public partial class AzurermSpringCloudApplicationInsightsApplicationPerformanceMonitoring(string name) : TerraformResource("azurerm_spring_cloud_application_insights_application_performance_monitoring", name)
{
    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformValue<string>? ConnectionString
    {
        get => GetArgument<TerraformValue<string>>("connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// The globally_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? GloballyEnabled
    {
        get => GetArgument<TerraformValue<bool>>("globally_enabled");
        set => SetArgument("globally_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The role_instance attribute.
    /// </summary>
    public TerraformValue<string>? RoleInstance
    {
        get => GetArgument<TerraformValue<string>>("role_instance");
        set => SetArgument("role_instance", value);
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    public TerraformValue<string>? RoleName
    {
        get => GetArgument<TerraformValue<string>>("role_name");
        set => SetArgument("role_name", value);
    }

    /// <summary>
    /// The sampling_percentage attribute.
    /// </summary>
    public TerraformValue<double>? SamplingPercentage
    {
        get => GetArgument<TerraformValue<double>>("sampling_percentage");
        set => SetArgument("sampling_percentage", value);
    }

    /// <summary>
    /// The sampling_requests_per_second attribute.
    /// </summary>
    public TerraformValue<double>? SamplingRequestsPerSecond
    {
        get => GetArgument<TerraformValue<double>>("sampling_requests_per_second");
        set => SetArgument("sampling_requests_per_second", value);
    }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    public required TerraformValue<string> SpringCloudServiceId
    {
        get => GetArgument<TerraformValue<string>>("spring_cloud_service_id");
        set => SetArgument("spring_cloud_service_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSpringCloudApplicationInsightsApplicationPerformanceMonitoringTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSpringCloudApplicationInsightsApplicationPerformanceMonitoringTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
