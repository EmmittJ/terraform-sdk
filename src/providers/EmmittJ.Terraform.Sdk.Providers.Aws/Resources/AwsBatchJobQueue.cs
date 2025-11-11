using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for compute_environment_order in .
/// Nesting mode: list
/// </summary>
public partial class AwsBatchJobQueueComputeEnvironmentOrderBlock : TerraformBlockBase
{
    /// <summary>
    /// The compute_environment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeEnvironment is required")]
    [TerraformProperty("compute_environment")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ComputeEnvironment { get; set; }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    [TerraformProperty("order")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Order { get; set; }

}

/// <summary>
/// Block type for job_state_time_limit_action in .
/// Nesting mode: list
/// </summary>
public partial class AwsBatchJobQueueJobStateTimeLimitActionBlock : TerraformBlockBase
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformProperty("action")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Action { get; set; }

    /// <summary>
    /// The max_time_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxTimeSeconds is required")]
    [TerraformProperty("max_time_seconds")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MaxTimeSeconds { get; set; }

    /// <summary>
    /// The reason attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Reason is required")]
    [TerraformProperty("reason")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Reason { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    [TerraformProperty("state")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> State { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsBatchJobQueueTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_batch_job_queue resource.
/// </summary>
public partial class AwsBatchJobQueue : TerraformResource
{
    public AwsBatchJobQueue(string name) : base("aws_batch_job_queue", name)
    {
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformProperty("priority")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Priority { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The scheduling_policy_arn attribute.
    /// </summary>
    [TerraformProperty("scheduling_policy_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SchedulingPolicyArn { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    [TerraformProperty("state")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> State { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for compute_environment_order.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("compute_environment_order")]
    public TerraformList<TerraformBlock<AwsBatchJobQueueComputeEnvironmentOrderBlock>>? ComputeEnvironmentOrder { get; set; }

    /// <summary>
    /// Block for job_state_time_limit_action.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("job_state_time_limit_action")]
    public TerraformList<TerraformBlock<AwsBatchJobQueueJobStateTimeLimitActionBlock>>? JobStateTimeLimitAction { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsBatchJobQueueTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TagsAll { get; }

}
