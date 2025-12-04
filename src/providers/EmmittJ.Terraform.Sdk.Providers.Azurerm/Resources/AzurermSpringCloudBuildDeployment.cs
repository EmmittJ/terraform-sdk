using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for quota in AzurermSpringCloudBuildDeployment.
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudBuildDeploymentQuotaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "quota";

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    public TerraformValue<string> Cpu
    {
        get => GetArgument<TerraformValue<string>>("cpu") ?? AsReference("cpu");
        set => SetArgument("cpu", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformValue<string> Memory
    {
        get => GetArgument<TerraformValue<string>>("memory") ?? AsReference("memory");
        set => SetArgument("memory", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermSpringCloudBuildDeployment.
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudBuildDeploymentTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_spring_cloud_build_deployment Terraform resource.
/// Manages a azurerm_spring_cloud_build_deployment resource.
/// </summary>
public partial class AzurermSpringCloudBuildDeployment(string name) : TerraformResource("azurerm_spring_cloud_build_deployment", name)
{
    /// <summary>
    /// The addon_json attribute.
    /// </summary>
    public TerraformValue<string> AddonJson
    {
        get => GetArgument<TerraformValue<string>>("addon_json") ?? AsReference("addon_json");
        set => SetArgument("addon_json", value);
    }

    /// <summary>
    /// The application_performance_monitoring_ids attribute.
    /// </summary>
    public TerraformList<string>? ApplicationPerformanceMonitoringIds
    {
        get => GetArgument<TerraformList<string>>("application_performance_monitoring_ids");
        set => SetArgument("application_performance_monitoring_ids", value);
    }

    /// <summary>
    /// The build_result_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BuildResultId is required")]
    public required TerraformValue<string> BuildResultId
    {
        get => GetRequiredArgument<TerraformValue<string>>("build_result_id");
        set => SetArgument("build_result_id", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public TerraformMap<string>? EnvironmentVariables
    {
        get => GetArgument<TerraformMap<string>>("environment_variables");
        set => SetArgument("environment_variables", value);
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
    /// The instance_count attribute.
    /// </summary>
    public TerraformValue<double>? InstanceCount
    {
        get => GetArgument<TerraformValue<double>>("instance_count");
        set => SetArgument("instance_count", value);
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
    /// The spring_cloud_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudAppId is required")]
    public required TerraformValue<string> SpringCloudAppId
    {
        get => GetRequiredArgument<TerraformValue<string>>("spring_cloud_app_id");
        set => SetArgument("spring_cloud_app_id", value);
    }

    /// <summary>
    /// Quota block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Quota block(s) allowed")]
    public TerraformList<AzurermSpringCloudBuildDeploymentQuotaBlock>? Quota
    {
        get => GetArgument<TerraformList<AzurermSpringCloudBuildDeploymentQuotaBlock>>("quota");
        set => SetArgument("quota", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSpringCloudBuildDeploymentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSpringCloudBuildDeploymentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
