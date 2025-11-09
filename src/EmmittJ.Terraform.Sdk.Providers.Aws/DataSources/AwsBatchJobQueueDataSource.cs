using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_batch_job_queue.
/// </summary>
public class AwsBatchJobQueueDataSource : TerraformDataSource
{
    public AwsBatchJobQueueDataSource(string name) : base("aws_batch_job_queue", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("compute_environment_order");
        this.DeclareOutput("job_state_time_limit_action");
        this.DeclareOutput("priority");
        this.DeclareOutput("scheduling_policy_arn");
        this.DeclareOutput("state");
        this.DeclareOutput("status");
        this.DeclareOutput("status_reason");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The compute_environment_order attribute.
    /// </summary>
    public TerraformExpression ComputeEnvironmentOrder => this["compute_environment_order"];

    /// <summary>
    /// The job_state_time_limit_action attribute.
    /// </summary>
    public TerraformExpression JobStateTimeLimitAction => this["job_state_time_limit_action"];

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformExpression Priority => this["priority"];

    /// <summary>
    /// The scheduling_policy_arn attribute.
    /// </summary>
    public TerraformExpression SchedulingPolicyArn => this["scheduling_policy_arn"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    public TerraformExpression StatusReason => this["status_reason"];

}
