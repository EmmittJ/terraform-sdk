using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for compute_environment_order in AwsBatchJobQueue.
/// Nesting mode: list
/// </summary>
public class AwsBatchJobQueueComputeEnvironmentOrderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "compute_environment_order";

    /// <summary>
    /// The compute_environment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeEnvironment is required")]
    public required TerraformValue<string> ComputeEnvironment
    {
        get => GetArgument<TerraformValue<string>>("compute_environment");
        set => SetArgument("compute_environment", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    public required TerraformValue<double> Order
    {
        get => GetArgument<TerraformValue<double>>("order");
        set => SetArgument("order", value);
    }

}


/// <summary>
/// Block type for job_state_time_limit_action in AwsBatchJobQueue.
/// Nesting mode: list
/// </summary>
public class AwsBatchJobQueueJobStateTimeLimitActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "job_state_time_limit_action";

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => GetArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The max_time_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxTimeSeconds is required")]
    public required TerraformValue<double> MaxTimeSeconds
    {
        get => GetArgument<TerraformValue<double>>("max_time_seconds");
        set => SetArgument("max_time_seconds", value);
    }

    /// <summary>
    /// The reason attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Reason is required")]
    public required TerraformValue<string> Reason
    {
        get => GetArgument<TerraformValue<string>>("reason");
        set => SetArgument("reason", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    public required TerraformValue<string> State
    {
        get => GetArgument<TerraformValue<string>>("state");
        set => SetArgument("state", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsBatchJobQueue.
/// Nesting mode: single
/// </summary>
public class AwsBatchJobQueueTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_batch_job_queue Terraform resource.
/// Manages a aws_batch_job_queue resource.
/// </summary>
public partial class AwsBatchJobQueue(string name) : TerraformResource("aws_batch_job_queue", name)
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => GetArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The scheduling_policy_arn attribute.
    /// </summary>
    public TerraformValue<string>? SchedulingPolicyArn
    {
        get => GetArgument<TerraformValue<string>>("scheduling_policy_arn");
        set => SetArgument("scheduling_policy_arn", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    public required TerraformValue<string> State
    {
        get => GetArgument<TerraformValue<string>>("state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// ComputeEnvironmentOrder block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBatchJobQueueComputeEnvironmentOrderBlock>? ComputeEnvironmentOrder
    {
        get => GetArgument<TerraformList<AwsBatchJobQueueComputeEnvironmentOrderBlock>>("compute_environment_order");
        set => SetArgument("compute_environment_order", value);
    }

    /// <summary>
    /// JobStateTimeLimitAction block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBatchJobQueueJobStateTimeLimitActionBlock>? JobStateTimeLimitAction
    {
        get => GetArgument<TerraformList<AwsBatchJobQueueJobStateTimeLimitActionBlock>>("job_state_time_limit_action");
        set => SetArgument("job_state_time_limit_action", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsBatchJobQueueTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsBatchJobQueueTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
