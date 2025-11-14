using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("cpu")]
    public TerraformValue<string> Cpu
    {
        get => new TerraformReference<string>(this, "cpu");
        set => SetArgument("cpu", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [TerraformArgument("memory")]
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_spring_cloud_build_deployment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSpringCloudBuildDeployment : TerraformResource
{
    public AzurermSpringCloudBuildDeployment(string name) : base("azurerm_spring_cloud_build_deployment", name)
    {
    }

    /// <summary>
    /// The addon_json attribute.
    /// </summary>
    [TerraformArgument("addon_json")]
    public TerraformValue<string> AddonJson
    {
        get => new TerraformReference<string>(this, "addon_json");
        set => SetArgument("addon_json", value);
    }

    /// <summary>
    /// The application_performance_monitoring_ids attribute.
    /// </summary>
    [TerraformArgument("application_performance_monitoring_ids")]
    public TerraformList<string>? ApplicationPerformanceMonitoringIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "application_performance_monitoring_ids").ResolveNodes(ctx));
        set => SetArgument("application_performance_monitoring_ids", value);
    }

    /// <summary>
    /// The build_result_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BuildResultId is required")]
    [TerraformArgument("build_result_id")]
    public required TerraformValue<string> BuildResultId
    {
        get => new TerraformReference<string>(this, "build_result_id");
        set => SetArgument("build_result_id", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    [TerraformArgument("environment_variables")]
    public TerraformMap<string>? EnvironmentVariables
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "environment_variables").ResolveNodes(ctx));
        set => SetArgument("environment_variables", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [TerraformArgument("instance_count")]
    public TerraformValue<double>? InstanceCount
    {
        get => new TerraformReference<double>(this, "instance_count");
        set => SetArgument("instance_count", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The spring_cloud_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudAppId is required")]
    [TerraformArgument("spring_cloud_app_id")]
    public required TerraformValue<string> SpringCloudAppId
    {
        get => new TerraformReference<string>(this, "spring_cloud_app_id");
        set => SetArgument("spring_cloud_app_id", value);
    }

    /// <summary>
    /// Block for quota.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Quota block(s) allowed")]
    [TerraformArgument("quota")]
    public TerraformList<AzurermSpringCloudBuildDeploymentQuotaBlock> Quota { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSpringCloudBuildDeploymentTimeoutsBlock Timeouts { get; set; } = new();

}
