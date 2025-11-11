using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_batch_job_definition.
/// </summary>
public partial class AwsBatchJobDefinitionDataSource : TerraformDataSource
{
    public AwsBatchJobDefinitionDataSource(string name) : base("aws_batch_job_definition", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Arn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    [TerraformProperty("revision")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Revision { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Status { get; set; }

    /// <summary>
    /// The arn_prefix attribute.
    /// </summary>
    [TerraformProperty("arn_prefix")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ArnPrefix { get; }

    /// <summary>
    /// The container_orchestration_type attribute.
    /// </summary>
    [TerraformProperty("container_orchestration_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ContainerOrchestrationType { get; }

    /// <summary>
    /// The eks_properties attribute.
    /// </summary>
    [TerraformProperty("eks_properties")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> EksProperties { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The node_properties attribute.
    /// </summary>
    [TerraformProperty("node_properties")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> NodeProperties { get; }

    /// <summary>
    /// The retry_strategy attribute.
    /// </summary>
    [TerraformProperty("retry_strategy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> RetryStrategy { get; }

    /// <summary>
    /// The scheduling_priority attribute.
    /// </summary>
    [TerraformProperty("scheduling_priority")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> SchedulingPriority { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformProperty("timeout")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Timeout { get; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Type { get; }

}
