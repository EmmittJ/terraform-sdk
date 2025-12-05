using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for quota in AzurermSpringCloudContainerDeployment.
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudContainerDeploymentQuotaBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("cpu") ?? CreateReference("cpu");
        set => SetArgument("cpu", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformValue<string> Memory
    {
        get => GetArgument<TerraformValue<string>>("memory") ?? CreateReference("memory");
        set => SetArgument("memory", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermSpringCloudContainerDeployment.
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudContainerDeploymentTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_spring_cloud_container_deployment Terraform resource.
/// Manages a azurerm_spring_cloud_container_deployment resource.
/// </summary>
public partial class AzurermSpringCloudContainerDeployment(string name) : TerraformResource("azurerm_spring_cloud_container_deployment", name)
{
    /// <summary>
    /// The addon_json attribute.
    /// </summary>
    public TerraformValue<string> AddonJson
    {
        get => GetArgument<TerraformValue<string>>("addon_json") ?? CreateReference("addon_json");
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
    /// The arguments attribute.
    /// </summary>
    public TerraformList<string>? Arguments
    {
        get => GetArgument<TerraformList<string>>("arguments");
        set => SetArgument("arguments", value);
    }

    /// <summary>
    /// The commands attribute.
    /// </summary>
    public TerraformList<string>? Commands
    {
        get => GetArgument<TerraformList<string>>("commands");
        set => SetArgument("commands", value);
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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    public required TerraformValue<string> Image
    {
        get => GetRequiredArgument<TerraformValue<string>>("image");
        set => SetArgument("image", value);
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
    /// The language_framework attribute.
    /// </summary>
    public TerraformValue<string>? LanguageFramework
    {
        get => GetArgument<TerraformValue<string>>("language_framework");
        set => SetArgument("language_framework", value);
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
    /// The server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    public required TerraformValue<string> Server
    {
        get => GetRequiredArgument<TerraformValue<string>>("server");
        set => SetArgument("server", value);
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
    public TerraformList<AzurermSpringCloudContainerDeploymentQuotaBlock>? Quota
    {
        get => GetArgument<TerraformList<AzurermSpringCloudContainerDeploymentQuotaBlock>>("quota");
        set => SetArgument("quota", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSpringCloudContainerDeploymentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSpringCloudContainerDeploymentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
