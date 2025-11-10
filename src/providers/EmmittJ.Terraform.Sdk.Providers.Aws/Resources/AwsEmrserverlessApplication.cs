using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_start_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationAutoStartConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

}

/// <summary>
/// Block type for auto_stop_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationAutoStopConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The idle_timeout_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? IdleTimeoutMinutes
    {
        set => SetProperty("idle_timeout_minutes", value);
    }

}

/// <summary>
/// Block type for image_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationImageConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageUri is required")]
    public required TerraformProperty<string> ImageUri
    {
        set => SetProperty("image_uri", value);
    }

}

/// <summary>
/// Block type for initial_capacity in .
/// Nesting mode: set
/// </summary>
public class AwsEmrserverlessApplicationInitialCapacityBlock : TerraformBlock
{
    /// <summary>
    /// The initial_capacity_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InitialCapacityType is required")]
    public required TerraformProperty<string> InitialCapacityType
    {
        set => SetProperty("initial_capacity_type", value);
    }

}

/// <summary>
/// Block type for interactive_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationInteractiveConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The livy_endpoint_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LivyEndpointEnabled
    {
        set => SetProperty("livy_endpoint_enabled", value);
    }

    /// <summary>
    /// The studio_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? StudioEnabled
    {
        set => SetProperty("studio_enabled", value);
    }

}

/// <summary>
/// Block type for maximum_capacity in .
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationMaximumCapacityBlock : TerraformBlock
{
    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cpu is required")]
    public required TerraformProperty<string> Cpu
    {
        set => SetProperty("cpu", value);
    }

    /// <summary>
    /// The disk attribute.
    /// </summary>
    public TerraformProperty<string>? Disk
    {
        set => SetProperty("disk", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Memory is required")]
    public required TerraformProperty<string> Memory
    {
        set => SetProperty("memory", value);
    }

}

/// <summary>
/// Block type for monitoring_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationMonitoringConfigurationBlock : TerraformBlock
{
}

/// <summary>
/// Block type for network_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationNetworkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        set => SetProperty("subnet_ids", value);
    }

}

/// <summary>
/// Block type for runtime_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationRuntimeConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The classification attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Classification is required")]
    public required TerraformProperty<string> Classification
    {
        set => SetProperty("classification", value);
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Properties
    {
        set => SetProperty("properties", value);
    }

}

/// <summary>
/// Block type for scheduler_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationSchedulerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The max_concurrent_runs attribute.
    /// </summary>
    public TerraformProperty<double>? MaxConcurrentRuns
    {
        set => SetProperty("max_concurrent_runs", value);
    }

    /// <summary>
    /// The queue_timeout_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? QueueTimeoutMinutes
    {
        set => SetProperty("queue_timeout_minutes", value);
    }

}

/// <summary>
/// Manages a aws_emrserverless_application resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEmrserverlessApplication : TerraformResource
{
    public AwsEmrserverlessApplication(string name) : base("aws_emrserverless_application", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("architecture");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("release_label");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("type");
    }

    /// <summary>
    /// The architecture attribute.
    /// </summary>
    public TerraformProperty<string> Architecture
    {
        get => GetRequiredOutput<TerraformProperty<string>>("architecture");
        set => SetProperty("architecture", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The release_label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReleaseLabel is required")]
    public required TerraformProperty<string> ReleaseLabel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("release_label");
        set => SetProperty("release_label", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// Block for auto_start_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoStartConfiguration block(s) allowed")]
    public List<AwsEmrserverlessApplicationAutoStartConfigurationBlock>? AutoStartConfiguration
    {
        set => SetProperty("auto_start_configuration", value);
    }

    /// <summary>
    /// Block for auto_stop_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoStopConfiguration block(s) allowed")]
    public List<AwsEmrserverlessApplicationAutoStopConfigurationBlock>? AutoStopConfiguration
    {
        set => SetProperty("auto_stop_configuration", value);
    }

    /// <summary>
    /// Block for image_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageConfiguration block(s) allowed")]
    public List<AwsEmrserverlessApplicationImageConfigurationBlock>? ImageConfiguration
    {
        set => SetProperty("image_configuration", value);
    }

    /// <summary>
    /// Block for initial_capacity.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEmrserverlessApplicationInitialCapacityBlock>? InitialCapacity
    {
        set => SetProperty("initial_capacity", value);
    }

    /// <summary>
    /// Block for interactive_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InteractiveConfiguration block(s) allowed")]
    public List<AwsEmrserverlessApplicationInteractiveConfigurationBlock>? InteractiveConfiguration
    {
        set => SetProperty("interactive_configuration", value);
    }

    /// <summary>
    /// Block for maximum_capacity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaximumCapacity block(s) allowed")]
    public List<AwsEmrserverlessApplicationMaximumCapacityBlock>? MaximumCapacity
    {
        set => SetProperty("maximum_capacity", value);
    }

    /// <summary>
    /// Block for monitoring_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitoringConfiguration block(s) allowed")]
    public List<AwsEmrserverlessApplicationMonitoringConfigurationBlock>? MonitoringConfiguration
    {
        set => SetProperty("monitoring_configuration", value);
    }

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    public List<AwsEmrserverlessApplicationNetworkConfigurationBlock>? NetworkConfiguration
    {
        set => SetProperty("network_configuration", value);
    }

    /// <summary>
    /// Block for runtime_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsEmrserverlessApplicationRuntimeConfigurationBlock>? RuntimeConfiguration
    {
        set => SetProperty("runtime_configuration", value);
    }

    /// <summary>
    /// Block for scheduler_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchedulerConfiguration block(s) allowed")]
    public List<AwsEmrserverlessApplicationSchedulerConfigurationBlock>? SchedulerConfiguration
    {
        set => SetProperty("scheduler_configuration", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
