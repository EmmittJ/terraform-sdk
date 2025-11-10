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
        set => SetProperty("alarms", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The ignore_poll_alarm_failure attribute.
    /// </summary>
    public TerraformProperty<bool>? IgnorePollAlarmFailure
    {
        set => SetProperty("ignore_poll_alarm_failure", value);
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
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The events attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Events
    {
        set => SetProperty("events", value);
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
        set => SetProperty("deployment_option", value);
    }

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    public TerraformProperty<string>? DeploymentType
    {
        set => SetProperty("deployment_type", value);
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
        set => SetProperty("key", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        set => SetProperty("value", value);
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
        set => SetProperty("cluster_name", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformProperty<string> ServiceName
    {
        set => SetProperty("service_name", value);
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
        set => SetProperty("key", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        set => SetProperty("value", value);
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
        set => SetProperty("trigger_events", value);
    }

    /// <summary>
    /// The trigger_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerName is required")]
    public required TerraformProperty<string> TriggerName
    {
        set => SetProperty("trigger_name", value);
    }

    /// <summary>
    /// The trigger_target_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerTargetArn is required")]
    public required TerraformProperty<string> TriggerTargetArn
    {
        set => SetProperty("trigger_target_arn", value);
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
        SetOutput("arn");
        SetOutput("compute_platform");
        SetOutput("deployment_group_id");
        SetOutput("app_name");
        SetOutput("autoscaling_groups");
        SetOutput("deployment_config_name");
        SetOutput("deployment_group_name");
        SetOutput("id");
        SetOutput("outdated_instances_strategy");
        SetOutput("region");
        SetOutput("service_role_arn");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("termination_hook_enabled");
    }

    /// <summary>
    /// The app_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppName is required")]
    public required TerraformProperty<string> AppName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("app_name");
        set => SetProperty("app_name", value);
    }

    /// <summary>
    /// The autoscaling_groups attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AutoscalingGroups
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("autoscaling_groups");
        set => SetProperty("autoscaling_groups", value);
    }

    /// <summary>
    /// The deployment_config_name attribute.
    /// </summary>
    public TerraformProperty<string> DeploymentConfigName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deployment_config_name");
        set => SetProperty("deployment_config_name", value);
    }

    /// <summary>
    /// The deployment_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentGroupName is required")]
    public required TerraformProperty<string> DeploymentGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deployment_group_name");
        set => SetProperty("deployment_group_name", value);
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
    /// The outdated_instances_strategy attribute.
    /// </summary>
    public TerraformProperty<string> OutdatedInstancesStrategy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("outdated_instances_strategy");
        set => SetProperty("outdated_instances_strategy", value);
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
    /// The service_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRoleArn is required")]
    public required TerraformProperty<string> ServiceRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_role_arn");
        set => SetProperty("service_role_arn", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The termination_hook_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> TerminationHookEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("termination_hook_enabled");
        set => SetProperty("termination_hook_enabled", value);
    }

    /// <summary>
    /// Block for alarm_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AlarmConfiguration block(s) allowed")]
    public List<AwsCodedeployDeploymentGroupAlarmConfigurationBlock>? AlarmConfiguration
    {
        set => SetProperty("alarm_configuration", value);
    }

    /// <summary>
    /// Block for auto_rollback_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoRollbackConfiguration block(s) allowed")]
    public List<AwsCodedeployDeploymentGroupAutoRollbackConfigurationBlock>? AutoRollbackConfiguration
    {
        set => SetProperty("auto_rollback_configuration", value);
    }

    /// <summary>
    /// Block for blue_green_deployment_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlueGreenDeploymentConfig block(s) allowed")]
    public List<AwsCodedeployDeploymentGroupBlueGreenDeploymentConfigBlock>? BlueGreenDeploymentConfig
    {
        set => SetProperty("blue_green_deployment_config", value);
    }

    /// <summary>
    /// Block for deployment_style.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentStyle block(s) allowed")]
    public List<AwsCodedeployDeploymentGroupDeploymentStyleBlock>? DeploymentStyle
    {
        set => SetProperty("deployment_style", value);
    }

    /// <summary>
    /// Block for ec2_tag_filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCodedeployDeploymentGroupEc2TagFilterBlock>? Ec2TagFilter
    {
        set => SetProperty("ec2_tag_filter", value);
    }

    /// <summary>
    /// Block for ec2_tag_set.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCodedeployDeploymentGroupEc2TagSetBlock>? Ec2TagSet
    {
        set => SetProperty("ec2_tag_set", value);
    }

    /// <summary>
    /// Block for ecs_service.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EcsService block(s) allowed")]
    public List<AwsCodedeployDeploymentGroupEcsServiceBlock>? EcsService
    {
        set => SetProperty("ecs_service", value);
    }

    /// <summary>
    /// Block for load_balancer_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancerInfo block(s) allowed")]
    public List<AwsCodedeployDeploymentGroupLoadBalancerInfoBlock>? LoadBalancerInfo
    {
        set => SetProperty("load_balancer_info", value);
    }

    /// <summary>
    /// Block for on_premises_instance_tag_filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCodedeployDeploymentGroupOnPremisesInstanceTagFilterBlock>? OnPremisesInstanceTagFilter
    {
        set => SetProperty("on_premises_instance_tag_filter", value);
    }

    /// <summary>
    /// Block for trigger_configuration.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCodedeployDeploymentGroupTriggerConfigurationBlock>? TriggerConfiguration
    {
        set => SetProperty("trigger_configuration", value);
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
