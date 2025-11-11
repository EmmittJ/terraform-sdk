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
    public TerraformValue<string>? Arn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The revision attribute.
    /// </summary>
    [TerraformPropertyName("revision")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Revision { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Status { get; set; }

    /// <summary>
    /// The arn_prefix attribute.
    /// </summary>
    [TerraformPropertyName("arn_prefix")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ArnPrefix => new TerraformReference(this, "arn_prefix");

    /// <summary>
    /// The container_orchestration_type attribute.
    /// </summary>
    [TerraformPropertyName("container_orchestration_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ContainerOrchestrationType => new TerraformReference(this, "container_orchestration_type");

    /// <summary>
    /// The eks_properties attribute.
    /// </summary>
    [TerraformPropertyName("eks_properties")]
    // Output-only attribute - read-only reference
    public TerraformList<object> EksProperties => new TerraformReference(this, "eks_properties");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The node_properties attribute.
    /// </summary>
    [TerraformPropertyName("node_properties")]
    // Output-only attribute - read-only reference
    public TerraformList<object> NodeProperties => new TerraformReference(this, "node_properties");

    /// <summary>
    /// The retry_strategy attribute.
    /// </summary>
    [TerraformPropertyName("retry_strategy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RetryStrategy => new TerraformReference(this, "retry_strategy");

    /// <summary>
    /// The scheduling_priority attribute.
    /// </summary>
    [TerraformPropertyName("scheduling_priority")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> SchedulingPriority => new TerraformReference(this, "scheduling_priority");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformPropertyName("timeout")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Timeout => new TerraformReference(this, "timeout");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Type => new TerraformReference(this, "type");

}
