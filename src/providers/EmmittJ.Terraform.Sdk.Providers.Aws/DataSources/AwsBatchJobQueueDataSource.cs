using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_batch_job_queue.
/// </summary>
public partial class AwsBatchJobQueueDataSource : TerraformDataSource
{
    public AwsBatchJobQueueDataSource(string name) : base("aws_batch_job_queue", name)
    {
    }

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
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The compute_environment_order attribute.
    /// </summary>
    [TerraformProperty("compute_environment_order")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ComputeEnvironmentOrder { get; }

    /// <summary>
    /// The job_state_time_limit_action attribute.
    /// </summary>
    [TerraformProperty("job_state_time_limit_action")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> JobStateTimeLimitAction { get; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformProperty("priority")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Priority { get; }

    /// <summary>
    /// The scheduling_policy_arn attribute.
    /// </summary>
    [TerraformProperty("scheduling_policy_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SchedulingPolicyArn { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    [TerraformProperty("status_reason")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StatusReason { get; }

}
