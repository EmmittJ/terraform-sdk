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
    }

    /// <summary>
    /// The availability_zone_rebalancing attribute.
    /// </summary>
    public string? AvailabilityZoneRebalancing
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_zone_rebalancing")?.Value;
        set => this.WithProperty("availability_zone_rebalancing", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cluster attribute.
    /// </summary>
    public string? Cluster
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster")?.Value;
        set => this.WithProperty("cluster", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The deployment_maximum_percent attribute.
    /// </summary>
    public double? DeploymentMaximumPercent
    {
        get => GetProperty<TerraformLiteralProperty<double>>("deployment_maximum_percent")?.Value;
        set => this.WithProperty("deployment_maximum_percent", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The deployment_minimum_healthy_percent attribute.
    /// </summary>
    public double? DeploymentMinimumHealthyPercent
    {
        get => GetProperty<TerraformLiteralProperty<double>>("deployment_minimum_healthy_percent")?.Value;
        set => this.WithProperty("deployment_minimum_healthy_percent", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The desired_count attribute.
    /// </summary>
    public double? DesiredCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("desired_count")?.Value;
        set => this.WithProperty("desired_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The enable_ecs_managed_tags attribute.
    /// </summary>
    public bool? EnableEcsManagedTags
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_ecs_managed_tags")?.Value;
        set => this.WithProperty("enable_ecs_managed_tags", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enable_execute_command attribute.
    /// </summary>
    public bool? EnableExecuteCommand
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_execute_command")?.Value;
        set => this.WithProperty("enable_execute_command", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The force_delete attribute.
    /// </summary>
    public bool? ForceDelete
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_delete")?.Value;
        set => this.WithProperty("force_delete", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The force_new_deployment attribute.
    /// </summary>
    public bool? ForceNewDeployment
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_new_deployment")?.Value;
        set => this.WithProperty("force_new_deployment", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The health_check_grace_period_seconds attribute.
    /// </summary>
    public double? HealthCheckGracePeriodSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("health_check_grace_period_seconds")?.Value;
        set => this.WithProperty("health_check_grace_period_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The iam_role attribute.
    /// </summary>
    public string? IamRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_role")?.Value;
        set => this.WithProperty("iam_role", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The launch_type attribute.
    /// </summary>
    public string? LaunchType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("launch_type")?.Value;
        set => this.WithProperty("launch_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    public string? PlatformVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("platform_version")?.Value;
        set => this.WithProperty("platform_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    public string? PropagateTags
    {
        get => GetProperty<TerraformLiteralProperty<string>>("propagate_tags")?.Value;
        set => this.WithProperty("propagate_tags", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The scheduling_strategy attribute.
    /// </summary>
    public string? SchedulingStrategy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scheduling_strategy")?.Value;
        set => this.WithProperty("scheduling_strategy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    public string? TaskDefinition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("task_definition")?.Value;
        set => this.WithProperty("task_definition", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public Dictionary<string, string>? Triggers
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("triggers")?.Value;
        set => this.WithProperty("triggers", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The wait_for_steady_state attribute.
    /// </summary>
    public bool? WaitForSteadyState
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("wait_for_steady_state")?.Value;
        set => this.WithProperty("wait_for_steady_state", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

}
