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
        get => new TerraformReference<string>(this, "compute_environment");
        set => SetArgument("compute_environment", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    public required TerraformValue<double> Order
    {
        get => new TerraformReference<double>(this, "order");
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
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The max_time_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxTimeSeconds is required")]
    public required TerraformValue<double> MaxTimeSeconds
    {
        get => new TerraformReference<double>(this, "max_time_seconds");
        set => SetArgument("max_time_seconds", value);
    }

    /// <summary>
    /// The reason attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Reason is required")]
    public required TerraformValue<string> Reason
    {
        get => new TerraformReference<string>(this, "reason");
        set => SetArgument("reason", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    public required TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The scheduling_policy_arn attribute.
    /// </summary>
    public TerraformValue<string>? SchedulingPolicyArn
    {
        get => new TerraformReference<string>(this, "scheduling_policy_arn");
        set => SetArgument("scheduling_policy_arn", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    public required TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

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
