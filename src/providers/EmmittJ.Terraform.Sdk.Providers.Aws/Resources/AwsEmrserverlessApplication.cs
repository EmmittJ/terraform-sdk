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
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
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
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The idle_timeout_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? IdleTimeoutMinutes
    {
        get => GetProperty<TerraformProperty<double>>("idle_timeout_minutes");
        set => WithProperty("idle_timeout_minutes", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("image_uri");
        set => WithProperty("image_uri", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("initial_capacity_type");
        set => WithProperty("initial_capacity_type", value);
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
        get => GetProperty<TerraformProperty<bool>>("livy_endpoint_enabled");
        set => WithProperty("livy_endpoint_enabled", value);
    }

    /// <summary>
    /// The studio_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? StudioEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("studio_enabled");
        set => WithProperty("studio_enabled", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("cpu");
        set => WithProperty("cpu", value);
    }

    /// <summary>
    /// The disk attribute.
    /// </summary>
    public TerraformProperty<string>? Disk
    {
        get => GetProperty<TerraformProperty<string>>("disk");
        set => WithProperty("disk", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Memory is required")]
    public required TerraformProperty<string> Memory
    {
        get => GetRequiredProperty<TerraformProperty<string>>("memory");
        set => WithProperty("memory", value);
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
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => WithProperty("subnet_ids", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("classification");
        set => WithProperty("classification", value);
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Properties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("properties");
        set => WithProperty("properties", value);
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
        get => GetProperty<TerraformProperty<double>>("max_concurrent_runs");
        set => WithProperty("max_concurrent_runs", value);
    }

    /// <summary>
    /// The queue_timeout_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? QueueTimeoutMinutes
    {
        get => GetProperty<TerraformProperty<double>>("queue_timeout_minutes");
        set => WithProperty("queue_timeout_minutes", value);
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
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The architecture attribute.
    /// </summary>
    public TerraformProperty<string>? Architecture
    {
        get => GetProperty<TerraformProperty<string>>("architecture");
        set => this.WithProperty("architecture", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The release_label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReleaseLabel is required")]
    public required TerraformProperty<string> ReleaseLabel
    {
        get => GetRequiredProperty<TerraformProperty<string>>("release_label");
        set => this.WithProperty("release_label", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Block for auto_start_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoStartConfiguration block(s) allowed")]
    public List<AwsEmrserverlessApplicationAutoStartConfigurationBlock>? AutoStartConfiguration
    {
        get => GetProperty<List<AwsEmrserverlessApplicationAutoStartConfigurationBlock>>("auto_start_configuration");
        set => this.WithProperty("auto_start_configuration", value);
    }

    /// <summary>
    /// Block for auto_stop_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoStopConfiguration block(s) allowed")]
    public List<AwsEmrserverlessApplicationAutoStopConfigurationBlock>? AutoStopConfiguration
    {
        get => GetProperty<List<AwsEmrserverlessApplicationAutoStopConfigurationBlock>>("auto_stop_configuration");
        set => this.WithProperty("auto_stop_configuration", value);
    }

    /// <summary>
    /// Block for image_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageConfiguration block(s) allowed")]
    public List<AwsEmrserverlessApplicationImageConfigurationBlock>? ImageConfiguration
    {
        get => GetProperty<List<AwsEmrserverlessApplicationImageConfigurationBlock>>("image_configuration");
        set => this.WithProperty("image_configuration", value);
    }

    /// <summary>
    /// Block for initial_capacity.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEmrserverlessApplicationInitialCapacityBlock>? InitialCapacity
    {
        get => GetProperty<HashSet<AwsEmrserverlessApplicationInitialCapacityBlock>>("initial_capacity");
        set => this.WithProperty("initial_capacity", value);
    }

    /// <summary>
    /// Block for interactive_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InteractiveConfiguration block(s) allowed")]
    public List<AwsEmrserverlessApplicationInteractiveConfigurationBlock>? InteractiveConfiguration
    {
        get => GetProperty<List<AwsEmrserverlessApplicationInteractiveConfigurationBlock>>("interactive_configuration");
        set => this.WithProperty("interactive_configuration", value);
    }

    /// <summary>
    /// Block for maximum_capacity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaximumCapacity block(s) allowed")]
    public List<AwsEmrserverlessApplicationMaximumCapacityBlock>? MaximumCapacity
    {
        get => GetProperty<List<AwsEmrserverlessApplicationMaximumCapacityBlock>>("maximum_capacity");
        set => this.WithProperty("maximum_capacity", value);
    }

    /// <summary>
    /// Block for monitoring_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitoringConfiguration block(s) allowed")]
    public List<AwsEmrserverlessApplicationMonitoringConfigurationBlock>? MonitoringConfiguration
    {
        get => GetProperty<List<AwsEmrserverlessApplicationMonitoringConfigurationBlock>>("monitoring_configuration");
        set => this.WithProperty("monitoring_configuration", value);
    }

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    public List<AwsEmrserverlessApplicationNetworkConfigurationBlock>? NetworkConfiguration
    {
        get => GetProperty<List<AwsEmrserverlessApplicationNetworkConfigurationBlock>>("network_configuration");
        set => this.WithProperty("network_configuration", value);
    }

    /// <summary>
    /// Block for runtime_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsEmrserverlessApplicationRuntimeConfigurationBlock>? RuntimeConfiguration
    {
        get => GetProperty<List<AwsEmrserverlessApplicationRuntimeConfigurationBlock>>("runtime_configuration");
        set => this.WithProperty("runtime_configuration", value);
    }

    /// <summary>
    /// Block for scheduler_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchedulerConfiguration block(s) allowed")]
    public List<AwsEmrserverlessApplicationSchedulerConfigurationBlock>? SchedulerConfiguration
    {
        get => GetProperty<List<AwsEmrserverlessApplicationSchedulerConfigurationBlock>>("scheduler_configuration");
        set => this.WithProperty("scheduler_configuration", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
