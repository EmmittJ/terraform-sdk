using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_batch_job_queue Terraform data source.
/// Retrieves information about a aws_batch_job_queue.
/// </summary>
public partial class AwsBatchJobQueueDataSource(string name) : TerraformDataSource("aws_batch_job_queue", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The compute_environment_order attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ComputeEnvironmentOrder
        => CreateReference("compute_environment_order");

    /// <summary>
    /// The job_state_time_limit_action attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> JobStateTimeLimitAction
        => CreateReference("job_state_time_limit_action");

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<double> Priority
        => CreateReference("priority");

    /// <summary>
    /// The scheduling_policy_arn attribute.
    /// </summary>
    public TerraformValue<string> SchedulingPolicyArn
        => CreateReference("scheduling_policy_arn");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    public TerraformValue<string> StatusReason
        => CreateReference("status_reason");

}
