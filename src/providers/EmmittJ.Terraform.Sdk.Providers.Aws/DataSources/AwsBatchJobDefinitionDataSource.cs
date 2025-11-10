using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_batch_job_definition.
/// </summary>
public class AwsBatchJobDefinitionDataSource : TerraformDataSource
{
    public AwsBatchJobDefinitionDataSource(string name) : base("aws_batch_job_definition", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Arn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The revision attribute.
    /// </summary>
    [TerraformPropertyName("revision")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Revision { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Status { get; set; }

    /// <summary>
    /// The arn_prefix attribute.
    /// </summary>
    [TerraformPropertyName("arn_prefix")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ArnPrefix => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn_prefix");

    /// <summary>
    /// The container_orchestration_type attribute.
    /// </summary>
    [TerraformPropertyName("container_orchestration_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ContainerOrchestrationType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "container_orchestration_type");

    /// <summary>
    /// The eks_properties attribute.
    /// </summary>
    [TerraformPropertyName("eks_properties")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EksProperties => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "eks_properties");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The node_properties attribute.
    /// </summary>
    [TerraformPropertyName("node_properties")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> NodeProperties => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "node_properties");

    /// <summary>
    /// The retry_strategy attribute.
    /// </summary>
    [TerraformPropertyName("retry_strategy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RetryStrategy => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "retry_strategy");

    /// <summary>
    /// The scheduling_priority attribute.
    /// </summary>
    [TerraformPropertyName("scheduling_priority")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> SchedulingPriority => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "scheduling_priority");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformPropertyName("timeout")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Timeout => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "timeout");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

}
