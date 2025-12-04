using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSpringCloudElasticApplicationPerformanceMonitoring.
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudElasticApplicationPerformanceMonitoringTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_spring_cloud_elastic_application_performance_monitoring Terraform resource.
/// Manages a azurerm_spring_cloud_elastic_application_performance_monitoring resource.
/// </summary>
public partial class AzurermSpringCloudElasticApplicationPerformanceMonitoring(string name) : TerraformResource("azurerm_spring_cloud_elastic_application_performance_monitoring", name)
{
    /// <summary>
    /// The application_packages attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationPackages is required")]
    public TerraformList<string>? ApplicationPackages
    {
        get => GetArgument<TerraformList<string>>("application_packages");
        set => SetArgument("application_packages", value);
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
    /// The server_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerUrl is required")]
    public required TerraformValue<string> ServerUrl
    {
        get => GetArgument<TerraformValue<string>>("server_url");
        set => SetArgument("server_url", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformValue<string> ServiceName
    {
        get => GetArgument<TerraformValue<string>>("service_name");
        set => SetArgument("service_name", value);
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
    public AzurermSpringCloudElasticApplicationPerformanceMonitoringTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSpringCloudElasticApplicationPerformanceMonitoringTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
