using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for quota in .
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
        get => new TerraformReference<string>(this, "cpu");
        set => SetArgument("cpu", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformValue<string> Memory
    {
        get => new TerraformReference<string>(this, "memory");
        set => SetArgument("memory", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "addon_json");
        set => SetArgument("addon_json", value);
    }

    /// <summary>
    /// The application_performance_monitoring_ids attribute.
    /// </summary>
    public TerraformList<string>? ApplicationPerformanceMonitoringIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "application_performance_monitoring_ids").ResolveNodes(ctx));
        set => SetArgument("application_performance_monitoring_ids", value);
    }

    /// <summary>
    /// The build_result_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BuildResultId is required")]
    public required TerraformValue<string> BuildResultId
    {
        get => new TerraformReference<string>(this, "build_result_id");
        set => SetArgument("build_result_id", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public TerraformMap<string>? EnvironmentVariables
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "environment_variables").ResolveNodes(ctx));
        set => SetArgument("environment_variables", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    public TerraformValue<double>? InstanceCount
    {
        get => new TerraformReference<double>(this, "instance_count");
        set => SetArgument("instance_count", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The spring_cloud_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudAppId is required")]
    public required TerraformValue<string> SpringCloudAppId
    {
        get => new TerraformReference<string>(this, "spring_cloud_app_id");
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
