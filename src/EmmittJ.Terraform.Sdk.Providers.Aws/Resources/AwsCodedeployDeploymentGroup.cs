using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for alarm_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupAlarmConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The alarms attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Alarms
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("alarms");
        set => WithProperty("alarms", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The ignore_poll_alarm_failure attribute.
    /// </summary>
    public TerraformProperty<bool>? IgnorePollAlarmFailure
    {
        get => GetProperty<TerraformProperty<bool>>("ignore_poll_alarm_failure");
        set => WithProperty("ignore_poll_alarm_failure", value);
    }

}

/// <summary>
/// Block type for auto_rollback_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupAutoRollbackConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The events attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Events
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("events");
        set => WithProperty("events", value);
    }

}

/// <summary>
/// Block type for blue_green_deployment_config in .
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupBlueGreenDeploymentConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for deployment_style in .
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupDeploymentStyleBlock : TerraformBlock
{
    /// <summary>
    /// The deployment_option attribute.
    /// </summary>
    public TerraformProperty<string>? DeploymentOption
    {
        get => GetProperty<TerraformProperty<string>>("deployment_option");
        set => WithProperty("deployment_option", value);
    }

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    public TerraformProperty<string>? DeploymentType
    {
        get => GetProperty<TerraformProperty<string>>("deployment_type");
        set => WithProperty("deployment_type", value);
    }

}

/// <summary>
/// Block type for ec2_tag_filter in .
/// Nesting mode: set
/// </summary>
public class AwsCodedeployDeploymentGroupEc2TagFilterBlock : TerraformBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformProperty<string>? Key
    {
        get => GetProperty<TerraformProperty<string>>("key");
        set => WithProperty("key", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for ec2_tag_set in .
/// Nesting mode: set
/// </summary>
public class AwsCodedeployDeploymentGroupEc2TagSetBlock : TerraformBlock
{
}

/// <summary>
/// Block type for ecs_service in .
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupEcsServiceBlock : TerraformBlock
{
    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformProperty<string> ClusterName
    {
        get => GetProperty<TerraformProperty<string>>("cluster_name");
        set => WithProperty("cluster_name", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformProperty<string> ServiceName
    {
        get => GetProperty<TerraformProperty<string>>("service_name");
        set => WithProperty("service_name", value);
    }

}

/// <summary>
/// Block type for load_balancer_info in .
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupLoadBalancerInfoBlock : TerraformBlock
{
}

/// <summary>
/// Block type for on_premises_instance_tag_filter in .
/// Nesting mode: set
/// </summary>
public class AwsCodedeployDeploymentGroupOnPremisesInstanceTagFilterBlock : TerraformBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformProperty<string>? Key
    {
        get => GetProperty<TerraformProperty<string>>("key");
        set => WithProperty("key", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for trigger_configuration in .
/// Nesting mode: set
/// </summary>
public class AwsCodedeployDeploymentGroupTriggerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The trigger_events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerEvents is required")]
    public HashSet<TerraformProperty<string>>? TriggerEvents
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("trigger_events");
        set => WithProperty("trigger_events", value);
    }

    /// <summary>
    /// The trigger_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerName is required")]
    public required TerraformProperty<string> TriggerName
    {
        get => GetProperty<TerraformProperty<string>>("trigger_name");
        set => WithProperty("trigger_name", value);
    }

    /// <summary>
    /// The trigger_target_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerTargetArn is required")]
    public required TerraformProperty<string> TriggerTargetArn
    {
        get => GetProperty<TerraformProperty<string>>("trigger_target_arn");
        set => WithProperty("trigger_target_arn", value);
    }

}

/// <summary>
/// Manages a aws_codedeploy_deployment_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCodedeployDeploymentGroup : TerraformResource
{
    public AwsCodedeployDeploymentGroup(string name) : base("aws_codedeploy_deployment_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("compute_platform");
        this.DeclareOutput("deployment_group_id");
    }

    /// <summary>
    /// The app_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppName is required")]
    public required TerraformProperty<string> AppName
    {
        get => GetProperty<TerraformProperty<string>>("app_name");
        set => this.WithProperty("app_name", value);
    }

    /// <summary>
    /// The autoscaling_groups attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AutoscalingGroups
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("autoscaling_groups");
        set => this.WithProperty("autoscaling_groups", value);
    }

    /// <summary>
    /// The deployment_config_name attribute.
    /// </summary>
    public TerraformProperty<string>? DeploymentConfigName
    {
        get => GetProperty<TerraformProperty<string>>("deployment_config_name");
        set => this.WithProperty("deployment_config_name", value);
    }

    /// <summary>
    /// The deployment_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentGroupName is required")]
    public required TerraformProperty<string> DeploymentGroupName
    {
        get => GetProperty<TerraformProperty<string>>("deployment_group_name");
        set => this.WithProperty("deployment_group_name", value);
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
    /// The outdated_instances_strategy attribute.
    /// </summary>
    public TerraformProperty<string>? OutdatedInstancesStrategy
    {
        get => GetProperty<TerraformProperty<string>>("outdated_instances_strategy");
        set => this.WithProperty("outdated_instances_strategy", value);
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
    /// The service_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRoleArn is required")]
    public required TerraformProperty<string> ServiceRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("service_role_arn");
        set => this.WithProperty("service_role_arn", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The termination_hook_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TerminationHookEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("termination_hook_enabled");
        set => this.WithProperty("termination_hook_enabled", value);
    }

    /// <summary>
    /// Block for alarm_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AlarmConfiguration block(s) allowed")]
    public List<AwsCodedeployDeploymentGroupAlarmConfigurationBlock>? AlarmConfiguration
    {
        get => GetProperty<List<AwsCodedeployDeploymentGroupAlarmConfigurationBlock>>("alarm_configuration");
        set => this.WithProperty("alarm_configuration", value);
    }

    /// <summary>
    /// Block for auto_rollback_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoRollbackConfiguration block(s) allowed")]
    public List<AwsCodedeployDeploymentGroupAutoRollbackConfigurationBlock>? AutoRollbackConfiguration
    {
        get => GetProperty<List<AwsCodedeployDeploymentGroupAutoRollbackConfigurationBlock>>("auto_rollback_configuration");
        set => this.WithProperty("auto_rollback_configuration", value);
    }

    /// <summary>
    /// Block for blue_green_deployment_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlueGreenDeploymentConfig block(s) allowed")]
    public List<AwsCodedeployDeploymentGroupBlueGreenDeploymentConfigBlock>? BlueGreenDeploymentConfig
    {
        get => GetProperty<List<AwsCodedeployDeploymentGroupBlueGreenDeploymentConfigBlock>>("blue_green_deployment_config");
        set => this.WithProperty("blue_green_deployment_config", value);
    }

    /// <summary>
    /// Block for deployment_style.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentStyle block(s) allowed")]
    public List<AwsCodedeployDeploymentGroupDeploymentStyleBlock>? DeploymentStyle
    {
        get => GetProperty<List<AwsCodedeployDeploymentGroupDeploymentStyleBlock>>("deployment_style");
        set => this.WithProperty("deployment_style", value);
    }

    /// <summary>
    /// Block for ec2_tag_filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCodedeployDeploymentGroupEc2TagFilterBlock>? Ec2TagFilter
    {
        get => GetProperty<HashSet<AwsCodedeployDeploymentGroupEc2TagFilterBlock>>("ec2_tag_filter");
        set => this.WithProperty("ec2_tag_filter", value);
    }

    /// <summary>
    /// Block for ec2_tag_set.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCodedeployDeploymentGroupEc2TagSetBlock>? Ec2TagSet
    {
        get => GetProperty<HashSet<AwsCodedeployDeploymentGroupEc2TagSetBlock>>("ec2_tag_set");
        set => this.WithProperty("ec2_tag_set", value);
    }

    /// <summary>
    /// Block for ecs_service.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EcsService block(s) allowed")]
    public List<AwsCodedeployDeploymentGroupEcsServiceBlock>? EcsService
    {
        get => GetProperty<List<AwsCodedeployDeploymentGroupEcsServiceBlock>>("ecs_service");
        set => this.WithProperty("ecs_service", value);
    }

    /// <summary>
    /// Block for load_balancer_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancerInfo block(s) allowed")]
    public List<AwsCodedeployDeploymentGroupLoadBalancerInfoBlock>? LoadBalancerInfo
    {
        get => GetProperty<List<AwsCodedeployDeploymentGroupLoadBalancerInfoBlock>>("load_balancer_info");
        set => this.WithProperty("load_balancer_info", value);
    }

    /// <summary>
    /// Block for on_premises_instance_tag_filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCodedeployDeploymentGroupOnPremisesInstanceTagFilterBlock>? OnPremisesInstanceTagFilter
    {
        get => GetProperty<HashSet<AwsCodedeployDeploymentGroupOnPremisesInstanceTagFilterBlock>>("on_premises_instance_tag_filter");
        set => this.WithProperty("on_premises_instance_tag_filter", value);
    }

    /// <summary>
    /// Block for trigger_configuration.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCodedeployDeploymentGroupTriggerConfigurationBlock>? TriggerConfiguration
    {
        get => GetProperty<HashSet<AwsCodedeployDeploymentGroupTriggerConfigurationBlock>>("trigger_configuration");
        set => this.WithProperty("trigger_configuration", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The compute_platform attribute.
    /// </summary>
    public TerraformExpression ComputePlatform => this["compute_platform"];

    /// <summary>
    /// The deployment_group_id attribute.
    /// </summary>
    public TerraformExpression DeploymentGroupId => this["deployment_group_id"];

}
