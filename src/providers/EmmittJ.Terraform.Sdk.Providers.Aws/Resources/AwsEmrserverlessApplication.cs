using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_start_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationAutoStartConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

}

/// <summary>
/// Block type for auto_stop_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationAutoStopConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The idle_timeout_minutes attribute.
    /// </summary>
    [TerraformPropertyName("idle_timeout_minutes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? IdleTimeoutMinutes { get; set; }

}

/// <summary>
/// Block type for image_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationImageConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageUri is required")]
    [TerraformPropertyName("image_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ImageUri { get; set; }

}

/// <summary>
/// Block type for initial_capacity in .
/// Nesting mode: set
/// </summary>
public class AwsEmrserverlessApplicationInitialCapacityBlock : ITerraformBlock
{
    /// <summary>
    /// The initial_capacity_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InitialCapacityType is required")]
    [TerraformPropertyName("initial_capacity_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InitialCapacityType { get; set; }

}

/// <summary>
/// Block type for interactive_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationInteractiveConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The livy_endpoint_enabled attribute.
    /// </summary>
    [TerraformPropertyName("livy_endpoint_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> LivyEndpointEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "livy_endpoint_enabled");

    /// <summary>
    /// The studio_enabled attribute.
    /// </summary>
    [TerraformPropertyName("studio_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> StudioEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "studio_enabled");

}

/// <summary>
/// Block type for maximum_capacity in .
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationMaximumCapacityBlock : ITerraformBlock
{
    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cpu is required")]
    [TerraformPropertyName("cpu")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Cpu { get; set; }

    /// <summary>
    /// The disk attribute.
    /// </summary>
    [TerraformPropertyName("disk")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Disk { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "disk");

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Memory is required")]
    [TerraformPropertyName("memory")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Memory { get; set; }

}

/// <summary>
/// Block type for monitoring_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationMonitoringConfigurationBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for network_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationNetworkConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SubnetIds { get; set; }

}

/// <summary>
/// Block type for runtime_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationRuntimeConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The classification attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Classification is required")]
    [TerraformPropertyName("classification")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Classification { get; set; }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    [TerraformPropertyName("properties")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Properties { get; set; }

}

/// <summary>
/// Block type for scheduler_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationSchedulerConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The max_concurrent_runs attribute.
    /// </summary>
    [TerraformPropertyName("max_concurrent_runs")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxConcurrentRuns { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "max_concurrent_runs");

    /// <summary>
    /// The queue_timeout_minutes attribute.
    /// </summary>
    [TerraformPropertyName("queue_timeout_minutes")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> QueueTimeoutMinutes { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "queue_timeout_minutes");

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
    public TerraformProperty<TerraformProperty<string>>? Architecture { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The release_label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReleaseLabel is required")]
    [TerraformPropertyName("release_label")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ReleaseLabel { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// Block for auto_start_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoStartConfiguration block(s) allowed")]
    [TerraformPropertyName("auto_start_configuration")]
    public TerraformList<TerraformBlock<AwsEmrserverlessApplicationAutoStartConfigurationBlock>>? AutoStartConfiguration { get; set; } = new();

    /// <summary>
    /// Block for auto_stop_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoStopConfiguration block(s) allowed")]
    [TerraformPropertyName("auto_stop_configuration")]
    public TerraformList<TerraformBlock<AwsEmrserverlessApplicationAutoStopConfigurationBlock>>? AutoStopConfiguration { get; set; } = new();

    /// <summary>
    /// Block for image_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageConfiguration block(s) allowed")]
    [TerraformPropertyName("image_configuration")]
    public TerraformList<TerraformBlock<AwsEmrserverlessApplicationImageConfigurationBlock>>? ImageConfiguration { get; set; } = new();

    /// <summary>
    /// Block for initial_capacity.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("initial_capacity")]
    public TerraformSet<TerraformBlock<AwsEmrserverlessApplicationInitialCapacityBlock>>? InitialCapacity { get; set; } = new();

    /// <summary>
    /// Block for interactive_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InteractiveConfiguration block(s) allowed")]
    [TerraformPropertyName("interactive_configuration")]
    public TerraformList<TerraformBlock<AwsEmrserverlessApplicationInteractiveConfigurationBlock>>? InteractiveConfiguration { get; set; } = new();

    /// <summary>
    /// Block for maximum_capacity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaximumCapacity block(s) allowed")]
    [TerraformPropertyName("maximum_capacity")]
    public TerraformList<TerraformBlock<AwsEmrserverlessApplicationMaximumCapacityBlock>>? MaximumCapacity { get; set; } = new();

    /// <summary>
    /// Block for monitoring_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitoringConfiguration block(s) allowed")]
    [TerraformPropertyName("monitoring_configuration")]
    public TerraformList<TerraformBlock<AwsEmrserverlessApplicationMonitoringConfigurationBlock>>? MonitoringConfiguration { get; set; } = new();

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    [TerraformPropertyName("network_configuration")]
    public TerraformList<TerraformBlock<AwsEmrserverlessApplicationNetworkConfigurationBlock>>? NetworkConfiguration { get; set; } = new();

    /// <summary>
    /// Block for runtime_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("runtime_configuration")]
    public TerraformList<TerraformBlock<AwsEmrserverlessApplicationRuntimeConfigurationBlock>>? RuntimeConfiguration { get; set; } = new();

    /// <summary>
    /// Block for scheduler_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchedulerConfiguration block(s) allowed")]
    [TerraformPropertyName("scheduler_configuration")]
    public TerraformList<TerraformBlock<AwsEmrserverlessApplicationSchedulerConfigurationBlock>>? SchedulerConfiguration { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
