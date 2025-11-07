using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ecs_service resource.
/// </summary>
public class AwsEcsService : TerraformResource
{
    public AwsEcsService(string name) : base("aws_ecs_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The availability_zone_rebalancing attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AvailabilityZoneRebalancing
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_zone_rebalancing");
        set => this.WithProperty("availability_zone_rebalancing", value);
    }

    /// <summary>
    /// The cluster attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Cluster
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster");
        set => this.WithProperty("cluster", value);
    }

    /// <summary>
    /// The deployment_maximum_percent attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DeploymentMaximumPercent
    {
        get => GetProperty<TerraformLiteralProperty<double>>("deployment_maximum_percent");
        set => this.WithProperty("deployment_maximum_percent", value);
    }

    /// <summary>
    /// The deployment_minimum_healthy_percent attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DeploymentMinimumHealthyPercent
    {
        get => GetProperty<TerraformLiteralProperty<double>>("deployment_minimum_healthy_percent");
        set => this.WithProperty("deployment_minimum_healthy_percent", value);
    }

    /// <summary>
    /// The desired_count attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DesiredCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("desired_count");
        set => this.WithProperty("desired_count", value);
    }

    /// <summary>
    /// The enable_ecs_managed_tags attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableEcsManagedTags
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_ecs_managed_tags");
        set => this.WithProperty("enable_ecs_managed_tags", value);
    }

    /// <summary>
    /// The enable_execute_command attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableExecuteCommand
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_execute_command");
        set => this.WithProperty("enable_execute_command", value);
    }

    /// <summary>
    /// The force_delete attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ForceDelete
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_delete");
        set => this.WithProperty("force_delete", value);
    }

    /// <summary>
    /// The force_new_deployment attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ForceNewDeployment
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_new_deployment");
        set => this.WithProperty("force_new_deployment", value);
    }

    /// <summary>
    /// The health_check_grace_period_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? HealthCheckGracePeriodSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("health_check_grace_period_seconds");
        set => this.WithProperty("health_check_grace_period_seconds", value);
    }

    /// <summary>
    /// The iam_role attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IamRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_role");
        set => this.WithProperty("iam_role", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The launch_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LaunchType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("launch_type");
        set => this.WithProperty("launch_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PlatformVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("platform_version");
        set => this.WithProperty("platform_version", value);
    }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PropagateTags
    {
        get => GetProperty<TerraformLiteralProperty<string>>("propagate_tags");
        set => this.WithProperty("propagate_tags", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The scheduling_strategy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SchedulingStrategy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scheduling_strategy");
        set => this.WithProperty("scheduling_strategy", value);
    }

    /// <summary>
    /// The sigint_rollback attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SigintRollback
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("sigint_rollback");
        set => this.WithProperty("sigint_rollback", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TaskDefinition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("task_definition");
        set => this.WithProperty("task_definition", value);
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Triggers
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("triggers");
        set => this.WithProperty("triggers", value);
    }

    /// <summary>
    /// The wait_for_steady_state attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? WaitForSteadyState
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("wait_for_steady_state");
        set => this.WithProperty("wait_for_steady_state", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
