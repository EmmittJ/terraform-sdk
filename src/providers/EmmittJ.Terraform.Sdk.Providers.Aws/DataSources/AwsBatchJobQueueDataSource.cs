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
        SetOutput("arn");
        SetOutput("compute_environment_order");
        SetOutput("job_state_time_limit_action");
        SetOutput("priority");
        SetOutput("scheduling_policy_arn");
        SetOutput("state");
        SetOutput("status");
        SetOutput("status_reason");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
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
