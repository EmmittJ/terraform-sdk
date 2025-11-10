using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for eks_properties in .
/// Nesting mode: list
/// </summary>
public class AwsBatchJobDefinitionEksPropertiesBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for retry_strategy in .
/// Nesting mode: list
/// </summary>
public class AwsBatchJobDefinitionRetryStrategyBlock : ITerraformBlock
{
    /// <summary>
    /// The attempts attribute.
    /// </summary>
    [TerraformPropertyName("attempts")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Attempts { get; set; }

}

/// <summary>
/// Block type for timeout in .
/// Nesting mode: list
/// </summary>
public class AwsBatchJobDefinitionTimeoutBlock : ITerraformBlock
{
    /// <summary>
    /// The attempt_duration_seconds attribute.
    /// </summary>
    [TerraformPropertyName("attempt_duration_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? AttemptDurationSeconds { get; set; }

}

/// <summary>
/// Manages a aws_batch_job_definition resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsBatchJobDefinition : TerraformResource
{
    public AwsBatchJobDefinition(string name) : base("aws_batch_job_definition", name)
    {
    }

    /// <summary>
    /// The container_properties attribute.
    /// </summary>
    [TerraformPropertyName("container_properties")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContainerProperties { get; set; }

    /// <summary>
    /// The deregister_on_new_revision attribute.
    /// </summary>
    [TerraformPropertyName("deregister_on_new_revision")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeregisterOnNewRevision { get; set; }

    /// <summary>
    /// The ecs_properties attribute.
    /// </summary>
    [TerraformPropertyName("ecs_properties")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EcsProperties { get; set; }

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
    /// The node_properties attribute.
    /// </summary>
    [TerraformPropertyName("node_properties")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NodeProperties { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Parameters { get; set; }

    /// <summary>
    /// The platform_capabilities attribute.
    /// </summary>
    [TerraformPropertyName("platform_capabilities")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? PlatformCapabilities { get; set; }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    [TerraformPropertyName("propagate_tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PropagateTags { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The scheduling_priority attribute.
    /// </summary>
    [TerraformPropertyName("scheduling_priority")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? SchedulingPriority { get; set; }

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
    /// Block for eks_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EksProperties block(s) allowed")]
    [TerraformPropertyName("eks_properties")]
    public TerraformList<TerraformBlock<AwsBatchJobDefinitionEksPropertiesBlock>>? EksProperties { get; set; } = new();

    /// <summary>
    /// Block for retry_strategy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryStrategy block(s) allowed")]
    [TerraformPropertyName("retry_strategy")]
    public TerraformList<TerraformBlock<AwsBatchJobDefinitionRetryStrategyBlock>>? RetryStrategy { get; set; } = new();

    /// <summary>
    /// Block for timeout.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Timeout block(s) allowed")]
    [TerraformPropertyName("timeout")]
    public TerraformList<TerraformBlock<AwsBatchJobDefinitionTimeoutBlock>>? Timeout { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The arn_prefix attribute.
    /// </summary>
    [TerraformPropertyName("arn_prefix")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ArnPrefix => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn_prefix");

    /// <summary>
    /// The revision attribute.
    /// </summary>
    [TerraformPropertyName("revision")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Revision => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "revision");

}
