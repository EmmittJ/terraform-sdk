using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_start_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationAutoStartConfigurationBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

}

/// <summary>
/// Block type for auto_stop_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationAutoStopConfigurationBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The idle_timeout_minutes attribute.
    /// </summary>
    [TerraformPropertyName("idle_timeout_minutes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? IdleTimeoutMinutes { get; set; }

}

/// <summary>
/// Block type for image_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationImageConfigurationBlock
{
    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageUri is required")]
    [TerraformPropertyName("image_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ImageUri { get; set; }

}

/// <summary>
/// Block type for initial_capacity in .
/// Nesting mode: set
/// </summary>
public class AwsEmrserverlessApplicationInitialCapacityBlock
{
    /// <summary>
    /// The initial_capacity_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InitialCapacityType is required")]
    [TerraformPropertyName("initial_capacity_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> InitialCapacityType { get; set; }

}

/// <summary>
/// Block type for interactive_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationInteractiveConfigurationBlock
{
    /// <summary>
    /// The livy_endpoint_enabled attribute.
    /// </summary>
    [TerraformPropertyName("livy_endpoint_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> LivyEndpointEnabled { get; set; } = default!;

    /// <summary>
    /// The studio_enabled attribute.
    /// </summary>
    [TerraformPropertyName("studio_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> StudioEnabled { get; set; } = default!;

}

/// <summary>
/// Block type for maximum_capacity in .
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationMaximumCapacityBlock
{
    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cpu is required")]
    [TerraformPropertyName("cpu")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Cpu { get; set; }

    /// <summary>
    /// The disk attribute.
    /// </summary>
    [TerraformPropertyName("disk")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Disk { get; set; } = default!;

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Memory is required")]
    [TerraformPropertyName("memory")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Memory { get; set; }

}

/// <summary>
/// Block type for monitoring_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationMonitoringConfigurationBlock
{
}

/// <summary>
/// Block type for network_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationNetworkConfigurationBlock
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SubnetIds { get; set; }

}

/// <summary>
/// Block type for runtime_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationRuntimeConfigurationBlock
{
    /// <summary>
    /// The classification attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Classification is required")]
    [TerraformPropertyName("classification")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Classification { get; set; }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    [TerraformPropertyName("properties")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Properties { get; set; }

}

/// <summary>
/// Block type for scheduler_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationSchedulerConfigurationBlock
{
    /// <summary>
    /// The max_concurrent_runs attribute.
    /// </summary>
    [TerraformPropertyName("max_concurrent_runs")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxConcurrentRuns { get; set; } = default!;

    /// <summary>
    /// The queue_timeout_minutes attribute.
    /// </summary>
    [TerraformPropertyName("queue_timeout_minutes")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> QueueTimeoutMinutes { get; set; } = default!;

}

/// <summary>
/// Manages a aws_emrserverless_application resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEmrserverlessApplication : TerraformResource
{
    public AwsEmrserverlessApplication(string name) : base("aws_emrserverless_application", name)
    {
    }

    /// <summary>
    /// The architecture attribute.
    /// </summary>
    [TerraformPropertyName("architecture")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Architecture { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The release_label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReleaseLabel is required")]
    [TerraformPropertyName("release_label")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ReleaseLabel { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for auto_start_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoStartConfiguration block(s) allowed")]
    [TerraformPropertyName("auto_start_configuration")]
    public TerraformList<TerraformBlock<AwsEmrserverlessApplicationAutoStartConfigurationBlock>>? AutoStartConfiguration { get; set; }

    /// <summary>
    /// Block for auto_stop_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoStopConfiguration block(s) allowed")]
    [TerraformPropertyName("auto_stop_configuration")]
    public TerraformList<TerraformBlock<AwsEmrserverlessApplicationAutoStopConfigurationBlock>>? AutoStopConfiguration { get; set; }

    /// <summary>
    /// Block for image_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageConfiguration block(s) allowed")]
    [TerraformPropertyName("image_configuration")]
    public TerraformList<TerraformBlock<AwsEmrserverlessApplicationImageConfigurationBlock>>? ImageConfiguration { get; set; }

    /// <summary>
    /// Block for initial_capacity.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("initial_capacity")]
    public TerraformSet<TerraformBlock<AwsEmrserverlessApplicationInitialCapacityBlock>>? InitialCapacity { get; set; }

    /// <summary>
    /// Block for interactive_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InteractiveConfiguration block(s) allowed")]
    [TerraformPropertyName("interactive_configuration")]
    public TerraformList<TerraformBlock<AwsEmrserverlessApplicationInteractiveConfigurationBlock>>? InteractiveConfiguration { get; set; }

    /// <summary>
    /// Block for maximum_capacity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaximumCapacity block(s) allowed")]
    [TerraformPropertyName("maximum_capacity")]
    public TerraformList<TerraformBlock<AwsEmrserverlessApplicationMaximumCapacityBlock>>? MaximumCapacity { get; set; }

    /// <summary>
    /// Block for monitoring_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitoringConfiguration block(s) allowed")]
    [TerraformPropertyName("monitoring_configuration")]
    public TerraformList<TerraformBlock<AwsEmrserverlessApplicationMonitoringConfigurationBlock>>? MonitoringConfiguration { get; set; }

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    [TerraformPropertyName("network_configuration")]
    public TerraformList<TerraformBlock<AwsEmrserverlessApplicationNetworkConfigurationBlock>>? NetworkConfiguration { get; set; }

    /// <summary>
    /// Block for runtime_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("runtime_configuration")]
    public TerraformList<TerraformBlock<AwsEmrserverlessApplicationRuntimeConfigurationBlock>>? RuntimeConfiguration { get; set; }

    /// <summary>
    /// Block for scheduler_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchedulerConfiguration block(s) allowed")]
    [TerraformPropertyName("scheduler_configuration")]
    public TerraformList<TerraformBlock<AwsEmrserverlessApplicationSchedulerConfigurationBlock>>? SchedulerConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
