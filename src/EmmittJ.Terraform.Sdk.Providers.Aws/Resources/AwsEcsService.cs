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
    public TerraformProperty<string>? AvailabilityZoneRebalancing
    {
        get => GetProperty<TerraformProperty<string>>("availability_zone_rebalancing");
        set => this.WithProperty("availability_zone_rebalancing", value);
    }

    /// <summary>
    /// The cluster attribute.
    /// </summary>
    public TerraformProperty<string>? Cluster
    {
        get => GetProperty<TerraformProperty<string>>("cluster");
        set => this.WithProperty("cluster", value);
    }

    /// <summary>
    /// The deployment_maximum_percent attribute.
    /// </summary>
    public TerraformProperty<double>? DeploymentMaximumPercent
    {
        get => GetProperty<TerraformProperty<double>>("deployment_maximum_percent");
        set => this.WithProperty("deployment_maximum_percent", value);
    }

    /// <summary>
    /// The deployment_minimum_healthy_percent attribute.
    /// </summary>
    public TerraformProperty<double>? DeploymentMinimumHealthyPercent
    {
        get => GetProperty<TerraformProperty<double>>("deployment_minimum_healthy_percent");
        set => this.WithProperty("deployment_minimum_healthy_percent", value);
    }

    /// <summary>
    /// The desired_count attribute.
    /// </summary>
    public TerraformProperty<double>? DesiredCount
    {
        get => GetProperty<TerraformProperty<double>>("desired_count");
        set => this.WithProperty("desired_count", value);
    }

    /// <summary>
    /// The enable_ecs_managed_tags attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableEcsManagedTags
    {
        get => GetProperty<TerraformProperty<bool>>("enable_ecs_managed_tags");
        set => this.WithProperty("enable_ecs_managed_tags", value);
    }

    /// <summary>
    /// The enable_execute_command attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableExecuteCommand
    {
        get => GetProperty<TerraformProperty<bool>>("enable_execute_command");
        set => this.WithProperty("enable_execute_command", value);
    }

    /// <summary>
    /// The force_delete attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceDelete
    {
        get => GetProperty<TerraformProperty<bool>>("force_delete");
        set => this.WithProperty("force_delete", value);
    }

    /// <summary>
    /// The force_new_deployment attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceNewDeployment
    {
        get => GetProperty<TerraformProperty<bool>>("force_new_deployment");
        set => this.WithProperty("force_new_deployment", value);
    }

    /// <summary>
    /// The health_check_grace_period_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? HealthCheckGracePeriodSeconds
    {
        get => GetProperty<TerraformProperty<double>>("health_check_grace_period_seconds");
        set => this.WithProperty("health_check_grace_period_seconds", value);
    }

    /// <summary>
    /// The iam_role attribute.
    /// </summary>
    public TerraformProperty<string>? IamRole
    {
        get => GetProperty<TerraformProperty<string>>("iam_role");
        set => this.WithProperty("iam_role", value);
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
    /// The launch_type attribute.
    /// </summary>
    public TerraformProperty<string>? LaunchType
    {
        get => GetProperty<TerraformProperty<string>>("launch_type");
        set => this.WithProperty("launch_type", value);
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
    /// The platform_version attribute.
    /// </summary>
    public TerraformProperty<string>? PlatformVersion
    {
        get => GetProperty<TerraformProperty<string>>("platform_version");
        set => this.WithProperty("platform_version", value);
    }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    public TerraformProperty<string>? PropagateTags
    {
        get => GetProperty<TerraformProperty<string>>("propagate_tags");
        set => this.WithProperty("propagate_tags", value);
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
    /// The scheduling_strategy attribute.
    /// </summary>
    public TerraformProperty<string>? SchedulingStrategy
    {
        get => GetProperty<TerraformProperty<string>>("scheduling_strategy");
        set => this.WithProperty("scheduling_strategy", value);
    }

    /// <summary>
    /// The sigint_rollback attribute.
    /// </summary>
    public TerraformProperty<bool>? SigintRollback
    {
        get => GetProperty<TerraformProperty<bool>>("sigint_rollback");
        set => this.WithProperty("sigint_rollback", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    public TerraformProperty<string>? TaskDefinition
    {
        get => GetProperty<TerraformProperty<string>>("task_definition");
        set => this.WithProperty("task_definition", value);
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public TerraformMapProperty<string>? Triggers
    {
        get => GetProperty<TerraformMapProperty<string>>("triggers");
        set => this.WithProperty("triggers", value);
    }

    /// <summary>
    /// The wait_for_steady_state attribute.
    /// </summary>
    public TerraformProperty<bool>? WaitForSteadyState
    {
        get => GetProperty<TerraformProperty<bool>>("wait_for_steady_state");
        set => this.WithProperty("wait_for_steady_state", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
