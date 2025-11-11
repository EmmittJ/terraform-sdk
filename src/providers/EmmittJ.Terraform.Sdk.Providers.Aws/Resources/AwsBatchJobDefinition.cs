using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for eks_properties in .
/// Nesting mode: list
/// </summary>
public partial class AwsBatchJobDefinitionEksPropertiesBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for retry_strategy in .
/// Nesting mode: list
/// </summary>
public partial class AwsBatchJobDefinitionRetryStrategyBlock : TerraformBlockBase
{
    /// <summary>
    /// The attempts attribute.
    /// </summary>
    [TerraformProperty("attempts")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Attempts { get; set; }

}

/// <summary>
/// Block type for timeout in .
/// Nesting mode: list
/// </summary>
public partial class AwsBatchJobDefinitionTimeoutBlock : TerraformBlockBase
{
    /// <summary>
    /// The attempt_duration_seconds attribute.
    /// </summary>
    [TerraformProperty("attempt_duration_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AttemptDurationSeconds { get; set; }

}

/// <summary>
/// Manages a aws_batch_job_definition resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsBatchJobDefinition : TerraformResource
{
    public AwsBatchJobDefinition(string name) : base("aws_batch_job_definition", name)
    {
    }

    /// <summary>
    /// The container_properties attribute.
    /// </summary>
    [TerraformProperty("container_properties")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContainerProperties { get; set; }

    /// <summary>
    /// The deregister_on_new_revision attribute.
    /// </summary>
    [TerraformProperty("deregister_on_new_revision")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeregisterOnNewRevision { get; set; }

    /// <summary>
    /// The ecs_properties attribute.
    /// </summary>
    [TerraformProperty("ecs_properties")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EcsProperties { get; set; }

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
    /// The node_properties attribute.
    /// </summary>
    [TerraformProperty("node_properties")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NodeProperties { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Parameters { get; set; }

    /// <summary>
    /// The platform_capabilities attribute.
    /// </summary>
    [TerraformProperty("platform_capabilities")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? PlatformCapabilities { get; set; }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    [TerraformProperty("propagate_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PropagateTags { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The scheduling_priority attribute.
    /// </summary>
    [TerraformProperty("scheduling_priority")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SchedulingPriority { get; set; }

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
    /// Block for eks_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EksProperties block(s) allowed")]
    [TerraformProperty("eks_properties")]
    public partial TerraformList<TerraformBlock<AwsBatchJobDefinitionEksPropertiesBlock>>? EksProperties { get; set; }

    /// <summary>
    /// Block for retry_strategy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryStrategy block(s) allowed")]
    [TerraformProperty("retry_strategy")]
    public partial TerraformList<TerraformBlock<AwsBatchJobDefinitionRetryStrategyBlock>>? RetryStrategy { get; set; }

    /// <summary>
    /// Block for timeout.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Timeout block(s) allowed")]
    [TerraformProperty("timeout")]
    public partial TerraformList<TerraformBlock<AwsBatchJobDefinitionTimeoutBlock>>? Timeout { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The arn_prefix attribute.
    /// </summary>
    [TerraformProperty("arn_prefix")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ArnPrefix { get; }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    [TerraformProperty("revision")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Revision { get; }

}
