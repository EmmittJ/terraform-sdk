using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for compute_environment_order in .
/// Nesting mode: list
/// </summary>
public class AwsBatchJobQueueComputeEnvironmentOrderBlock : TerraformBlock
{
    /// <summary>
    /// The compute_environment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeEnvironment is required")]
    public required TerraformProperty<string> ComputeEnvironment
    {
        get => GetProperty<TerraformProperty<string>>("compute_environment");
        set => WithProperty("compute_environment", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    public required TerraformProperty<double> Order
    {
        get => GetProperty<TerraformProperty<double>>("order");
        set => WithProperty("order", value);
    }

}

/// <summary>
/// Block type for job_state_time_limit_action in .
/// Nesting mode: list
/// </summary>
public class AwsBatchJobQueueJobStateTimeLimitActionBlock : TerraformBlock
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => WithProperty("action", value);
    }

    /// <summary>
    /// The max_time_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxTimeSeconds is required")]
    public required TerraformProperty<double> MaxTimeSeconds
    {
        get => GetProperty<TerraformProperty<double>>("max_time_seconds");
        set => WithProperty("max_time_seconds", value);
    }

    /// <summary>
    /// The reason attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Reason is required")]
    public required TerraformProperty<string> Reason
    {
        get => GetProperty<TerraformProperty<string>>("reason");
        set => WithProperty("reason", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    public required TerraformProperty<string> State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => WithProperty("state", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsBatchJobQueueTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_batch_job_queue resource.
/// </summary>
public class AwsBatchJobQueue : TerraformResource
{
    public AwsBatchJobQueue(string name) : base("aws_batch_job_queue", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("id");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The scheduling_policy_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SchedulingPolicyArn
    {
        get => GetProperty<TerraformProperty<string>>("scheduling_policy_arn");
        set => this.WithProperty("scheduling_policy_arn", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    public required TerraformProperty<string> State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => this.WithProperty("state", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for compute_environment_order.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBatchJobQueueComputeEnvironmentOrderBlock>? ComputeEnvironmentOrder
    {
        get => GetProperty<List<AwsBatchJobQueueComputeEnvironmentOrderBlock>>("compute_environment_order");
        set => this.WithProperty("compute_environment_order", value);
    }

    /// <summary>
    /// Block for job_state_time_limit_action.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBatchJobQueueJobStateTimeLimitActionBlock>? JobStateTimeLimitAction
    {
        get => GetProperty<List<AwsBatchJobQueueJobStateTimeLimitActionBlock>>("job_state_time_limit_action");
        set => this.WithProperty("job_state_time_limit_action", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsBatchJobQueueTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsBatchJobQueueTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
