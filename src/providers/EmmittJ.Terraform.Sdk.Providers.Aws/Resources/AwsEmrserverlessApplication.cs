using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_start_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsEmrserverlessApplicationAutoStartConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

}

/// <summary>
/// Block type for auto_stop_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsEmrserverlessApplicationAutoStopConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The idle_timeout_minutes attribute.
    /// </summary>
    [TerraformProperty("idle_timeout_minutes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? IdleTimeoutMinutes { get; set; }

}

/// <summary>
/// Block type for image_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsEmrserverlessApplicationImageConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageUri is required")]
    [TerraformProperty("image_uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ImageUri { get; set; }

}

/// <summary>
/// Block type for initial_capacity in .
/// Nesting mode: set
/// </summary>
public partial class AwsEmrserverlessApplicationInitialCapacityBlock : TerraformBlockBase
{
    /// <summary>
    /// The initial_capacity_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InitialCapacityType is required")]
    [TerraformProperty("initial_capacity_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InitialCapacityType { get; set; }

}

/// <summary>
/// Block type for interactive_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsEmrserverlessApplicationInteractiveConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The livy_endpoint_enabled attribute.
    /// </summary>
    [TerraformProperty("livy_endpoint_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> LivyEndpointEnabled { get; set; }

    /// <summary>
    /// The studio_enabled attribute.
    /// </summary>
    [TerraformProperty("studio_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> StudioEnabled { get; set; }

}

/// <summary>
/// Block type for maximum_capacity in .
/// Nesting mode: list
/// </summary>
public partial class AwsEmrserverlessApplicationMaximumCapacityBlock : TerraformBlockBase
{
    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cpu is required")]
    [TerraformProperty("cpu")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Cpu { get; set; }

    /// <summary>
    /// The disk attribute.
    /// </summary>
    [TerraformProperty("disk")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Disk { get; set; }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Memory is required")]
    [TerraformProperty("memory")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Memory { get; set; }

}

/// <summary>
/// Block type for monitoring_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsEmrserverlessApplicationMonitoringConfigurationBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for network_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsEmrserverlessApplicationNetworkConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformProperty("subnet_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SubnetIds { get; set; }

}

/// <summary>
/// Block type for runtime_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsEmrserverlessApplicationRuntimeConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The classification attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Classification is required")]
    [TerraformProperty("classification")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Classification { get; set; }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    [TerraformProperty("properties")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Properties { get; set; }

}

/// <summary>
/// Block type for scheduler_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsEmrserverlessApplicationSchedulerConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The max_concurrent_runs attribute.
    /// </summary>
    [TerraformProperty("max_concurrent_runs")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxConcurrentRuns { get; set; }

    /// <summary>
    /// The queue_timeout_minutes attribute.
    /// </summary>
    [TerraformProperty("queue_timeout_minutes")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> QueueTimeoutMinutes { get; set; }

}

/// <summary>
/// Manages a aws_emrserverless_application resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsEmrserverlessApplication : TerraformResource
{
    public AwsEmrserverlessApplication(string name) : base("aws_emrserverless_application", name)
    {
    }

    /// <summary>
    /// The architecture attribute.
    /// </summary>
    [TerraformProperty("architecture")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Architecture { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The release_label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReleaseLabel is required")]
    [TerraformProperty("release_label")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ReleaseLabel { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for auto_start_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoStartConfiguration block(s) allowed")]
    [TerraformProperty("auto_start_configuration")]
    public partial TerraformList<TerraformBlock<AwsEmrserverlessApplicationAutoStartConfigurationBlock>>? AutoStartConfiguration { get; set; }

    /// <summary>
    /// Block for auto_stop_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoStopConfiguration block(s) allowed")]
    [TerraformProperty("auto_stop_configuration")]
    public partial TerraformList<TerraformBlock<AwsEmrserverlessApplicationAutoStopConfigurationBlock>>? AutoStopConfiguration { get; set; }

    /// <summary>
    /// Block for image_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageConfiguration block(s) allowed")]
    [TerraformProperty("image_configuration")]
    public partial TerraformList<TerraformBlock<AwsEmrserverlessApplicationImageConfigurationBlock>>? ImageConfiguration { get; set; }

    /// <summary>
    /// Block for initial_capacity.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("initial_capacity")]
    public partial TerraformSet<TerraformBlock<AwsEmrserverlessApplicationInitialCapacityBlock>>? InitialCapacity { get; set; }

    /// <summary>
    /// Block for interactive_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InteractiveConfiguration block(s) allowed")]
    [TerraformProperty("interactive_configuration")]
    public partial TerraformList<TerraformBlock<AwsEmrserverlessApplicationInteractiveConfigurationBlock>>? InteractiveConfiguration { get; set; }

    /// <summary>
    /// Block for maximum_capacity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaximumCapacity block(s) allowed")]
    [TerraformProperty("maximum_capacity")]
    public partial TerraformList<TerraformBlock<AwsEmrserverlessApplicationMaximumCapacityBlock>>? MaximumCapacity { get; set; }

    /// <summary>
    /// Block for monitoring_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitoringConfiguration block(s) allowed")]
    [TerraformProperty("monitoring_configuration")]
    public partial TerraformList<TerraformBlock<AwsEmrserverlessApplicationMonitoringConfigurationBlock>>? MonitoringConfiguration { get; set; }

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    [TerraformProperty("network_configuration")]
    public partial TerraformList<TerraformBlock<AwsEmrserverlessApplicationNetworkConfigurationBlock>>? NetworkConfiguration { get; set; }

    /// <summary>
    /// Block for runtime_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("runtime_configuration")]
    public partial TerraformList<TerraformBlock<AwsEmrserverlessApplicationRuntimeConfigurationBlock>>? RuntimeConfiguration { get; set; }

    /// <summary>
    /// Block for scheduler_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchedulerConfiguration block(s) allowed")]
    [TerraformProperty("scheduler_configuration")]
    public partial TerraformList<TerraformBlock<AwsEmrserverlessApplicationSchedulerConfigurationBlock>>? SchedulerConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
