using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_batch_job_queue.
/// </summary>
public class AwsBatchJobQueueDataSource : TerraformDataSource
{
    public AwsBatchJobQueueDataSource(string name) : base("aws_batch_job_queue", name)
    {
    }

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The compute_environment_order attribute.
    /// </summary>
    [TerraformPropertyName("compute_environment_order")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ComputeEnvironmentOrder => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "compute_environment_order");

    /// <summary>
    /// The job_state_time_limit_action attribute.
    /// </summary>
    [TerraformPropertyName("job_state_time_limit_action")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> JobStateTimeLimitAction => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "job_state_time_limit_action");

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformPropertyName("priority")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Priority => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "priority");

    /// <summary>
    /// The scheduling_policy_arn attribute.
    /// </summary>
    [TerraformPropertyName("scheduling_policy_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SchedulingPolicyArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "scheduling_policy_arn");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    [TerraformPropertyName("status_reason")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StatusReason => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status_reason");

}
