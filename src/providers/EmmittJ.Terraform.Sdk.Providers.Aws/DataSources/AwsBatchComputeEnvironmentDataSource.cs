using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_batch_compute_environment.
/// </summary>
public partial class AwsBatchComputeEnvironmentDataSource : TerraformDataSource
{
    public AwsBatchComputeEnvironmentDataSource(string name) : base("aws_batch_compute_environment", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The ecs_cluster_arn attribute.
    /// </summary>
    [TerraformProperty("ecs_cluster_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EcsClusterArn { get; }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [TerraformProperty("service_role")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServiceRole { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    [TerraformProperty("status_reason")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> StatusReason { get; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Type { get; }

    /// <summary>
    /// The update_policy attribute.
    /// </summary>
    [TerraformProperty("update_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> UpdatePolicy { get; }

}
