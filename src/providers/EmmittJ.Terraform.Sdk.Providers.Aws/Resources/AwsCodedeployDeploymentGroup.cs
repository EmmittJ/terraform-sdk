using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for alarm_configuration in AwsCodedeployDeploymentGroup.
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupAlarmConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "alarm_configuration";

    /// <summary>
    /// The alarms attribute.
    /// </summary>
    public TerraformSet<string>? Alarms
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "alarms").ResolveNodes(ctx));
        set => SetArgument("alarms", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The ignore_poll_alarm_failure attribute.
    /// </summary>
    public TerraformValue<bool>? IgnorePollAlarmFailure
    {
        get => new TerraformReference<bool>(this, "ignore_poll_alarm_failure");
        set => SetArgument("ignore_poll_alarm_failure", value);
    }

}


/// <summary>
/// Block type for auto_rollback_configuration in AwsCodedeployDeploymentGroup.
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupAutoRollbackConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_rollback_configuration";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The events attribute.
    /// </summary>
    public TerraformSet<string>? Events
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "events").ResolveNodes(ctx));
        set => SetArgument("events", value);
    }

}


/// <summary>
/// Block type for blue_green_deployment_config in AwsCodedeployDeploymentGroup.
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupBlueGreenDeploymentConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "blue_green_deployment_config";

    /// <summary>
    /// DeploymentReadyOption block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentReadyOption block(s) allowed")]
    public TerraformList<AwsCodedeployDeploymentGroupBlueGreenDeploymentConfigBlockDeploymentReadyOptionBlock>? DeploymentReadyOption
    {
        get => GetArgument<TerraformList<AwsCodedeployDeploymentGroupBlueGreenDeploymentConfigBlockDeploymentReadyOptionBlock>>("deployment_ready_option");
        set => SetArgument("deployment_ready_option", value);
    }

    /// <summary>
    /// GreenFleetProvisioningOption block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GreenFleetProvisioningOption block(s) allowed")]
    public TerraformList<AwsCodedeployDeploymentGroupBlueGreenDeploymentConfigBlockGreenFleetProvisioningOptionBlock>? GreenFleetProvisioningOption
    {
        get => GetArgument<TerraformList<AwsCodedeployDeploymentGroupBlueGreenDeploymentConfigBlockGreenFleetProvisioningOptionBlock>>("green_fleet_provisioning_option");
        set => SetArgument("green_fleet_provisioning_option", value);
    }

    /// <summary>
    /// TerminateBlueInstancesOnDeploymentSuccess block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TerminateBlueInstancesOnDeploymentSuccess block(s) allowed")]
    public TerraformList<AwsCodedeployDeploymentGroupBlueGreenDeploymentConfigBlockTerminateBlueInstancesOnDeploymentSuccessBlock>? TerminateBlueInstancesOnDeploymentSuccess
    {
        get => GetArgument<TerraformList<AwsCodedeployDeploymentGroupBlueGreenDeploymentConfigBlockTerminateBlueInstancesOnDeploymentSuccessBlock>>("terminate_blue_instances_on_deployment_success");
        set => SetArgument("terminate_blue_instances_on_deployment_success", value);
    }

}

/// <summary>
/// Block type for deployment_ready_option in AwsCodedeployDeploymentGroupBlueGreenDeploymentConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupBlueGreenDeploymentConfigBlockDeploymentReadyOptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "deployment_ready_option";

    /// <summary>
    /// The action_on_timeout attribute.
    /// </summary>
    public TerraformValue<string>? ActionOnTimeout
    {
        get => new TerraformReference<string>(this, "action_on_timeout");
        set => SetArgument("action_on_timeout", value);
    }

    /// <summary>
    /// The wait_time_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? WaitTimeInMinutes
    {
        get => new TerraformReference<double>(this, "wait_time_in_minutes");
        set => SetArgument("wait_time_in_minutes", value);
    }

}

/// <summary>
/// Block type for green_fleet_provisioning_option in AwsCodedeployDeploymentGroupBlueGreenDeploymentConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupBlueGreenDeploymentConfigBlockGreenFleetProvisioningOptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "green_fleet_provisioning_option";

    /// <summary>
    /// The action attribute.
    /// </summary>
    public TerraformValue<string>? Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

}

/// <summary>
/// Block type for terminate_blue_instances_on_deployment_success in AwsCodedeployDeploymentGroupBlueGreenDeploymentConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupBlueGreenDeploymentConfigBlockTerminateBlueInstancesOnDeploymentSuccessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "terminate_blue_instances_on_deployment_success";

    /// <summary>
    /// The action attribute.
    /// </summary>
    public TerraformValue<string>? Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The termination_wait_time_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? TerminationWaitTimeInMinutes
    {
        get => new TerraformReference<double>(this, "termination_wait_time_in_minutes");
        set => SetArgument("termination_wait_time_in_minutes", value);
    }

}


/// <summary>
/// Block type for deployment_style in AwsCodedeployDeploymentGroup.
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupDeploymentStyleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "deployment_style";

    /// <summary>
    /// The deployment_option attribute.
    /// </summary>
    public TerraformValue<string>? DeploymentOption
    {
        get => new TerraformReference<string>(this, "deployment_option");
        set => SetArgument("deployment_option", value);
    }

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    public TerraformValue<string>? DeploymentType
    {
        get => new TerraformReference<string>(this, "deployment_type");
        set => SetArgument("deployment_type", value);
    }

}


/// <summary>
/// Block type for ec2_tag_filter in AwsCodedeployDeploymentGroup.
/// Nesting mode: set
/// </summary>
public class AwsCodedeployDeploymentGroupEc2TagFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ec2_tag_filter";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for ec2_tag_set in AwsCodedeployDeploymentGroup.
/// Nesting mode: set
/// </summary>
public class AwsCodedeployDeploymentGroupEc2TagSetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ec2_tag_set";

    /// <summary>
    /// Ec2TagFilter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCodedeployDeploymentGroupEc2TagSetBlockEc2TagFilterBlock>? Ec2TagFilter
    {
        get => GetArgument<TerraformSet<AwsCodedeployDeploymentGroupEc2TagSetBlockEc2TagFilterBlock>>("ec2_tag_filter");
        set => SetArgument("ec2_tag_filter", value);
    }

}

/// <summary>
/// Block type for ec2_tag_filter in AwsCodedeployDeploymentGroupEc2TagSetBlock.
/// Nesting mode: set
/// </summary>
public class AwsCodedeployDeploymentGroupEc2TagSetBlockEc2TagFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ec2_tag_filter";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for ecs_service in AwsCodedeployDeploymentGroup.
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupEcsServiceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ecs_service";

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformValue<string> ClusterName
    {
        get => new TerraformReference<string>(this, "cluster_name");
        set => SetArgument("cluster_name", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformValue<string> ServiceName
    {
        get => new TerraformReference<string>(this, "service_name");
        set => SetArgument("service_name", value);
    }

}


/// <summary>
/// Block type for load_balancer_info in AwsCodedeployDeploymentGroup.
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupLoadBalancerInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "load_balancer_info";

    /// <summary>
    /// ElbInfo block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCodedeployDeploymentGroupLoadBalancerInfoBlockElbInfoBlock>? ElbInfo
    {
        get => GetArgument<TerraformSet<AwsCodedeployDeploymentGroupLoadBalancerInfoBlockElbInfoBlock>>("elb_info");
        set => SetArgument("elb_info", value);
    }

    /// <summary>
    /// TargetGroupInfo block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCodedeployDeploymentGroupLoadBalancerInfoBlockTargetGroupInfoBlock>? TargetGroupInfo
    {
        get => GetArgument<TerraformSet<AwsCodedeployDeploymentGroupLoadBalancerInfoBlockTargetGroupInfoBlock>>("target_group_info");
        set => SetArgument("target_group_info", value);
    }

    /// <summary>
    /// TargetGroupPairInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetGroupPairInfo block(s) allowed")]
    public TerraformList<AwsCodedeployDeploymentGroupLoadBalancerInfoBlockTargetGroupPairInfoBlock>? TargetGroupPairInfo
    {
        get => GetArgument<TerraformList<AwsCodedeployDeploymentGroupLoadBalancerInfoBlockTargetGroupPairInfoBlock>>("target_group_pair_info");
        set => SetArgument("target_group_pair_info", value);
    }

}

/// <summary>
/// Block type for elb_info in AwsCodedeployDeploymentGroupLoadBalancerInfoBlock.
/// Nesting mode: set
/// </summary>
public class AwsCodedeployDeploymentGroupLoadBalancerInfoBlockElbInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "elb_info";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for target_group_info in AwsCodedeployDeploymentGroupLoadBalancerInfoBlock.
/// Nesting mode: set
/// </summary>
public class AwsCodedeployDeploymentGroupLoadBalancerInfoBlockTargetGroupInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_group_info";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for target_group_pair_info in AwsCodedeployDeploymentGroupLoadBalancerInfoBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupLoadBalancerInfoBlockTargetGroupPairInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_group_pair_info";

    /// <summary>
    /// ProdTrafficRoute block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProdTrafficRoute is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ProdTrafficRoute block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProdTrafficRoute block(s) allowed")]
    public required TerraformList<AwsCodedeployDeploymentGroupLoadBalancerInfoBlockTargetGroupPairInfoBlockProdTrafficRouteBlock> ProdTrafficRoute
    {
        get => GetRequiredArgument<TerraformList<AwsCodedeployDeploymentGroupLoadBalancerInfoBlockTargetGroupPairInfoBlockProdTrafficRouteBlock>>("prod_traffic_route");
        set => SetArgument("prod_traffic_route", value);
    }

    /// <summary>
    /// TargetGroup block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetGroup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 TargetGroup block(s) allowed")]
    public required TerraformList<AwsCodedeployDeploymentGroupLoadBalancerInfoBlockTargetGroupPairInfoBlockTargetGroupBlock> TargetGroup
    {
        get => GetRequiredArgument<TerraformList<AwsCodedeployDeploymentGroupLoadBalancerInfoBlockTargetGroupPairInfoBlockTargetGroupBlock>>("target_group");
        set => SetArgument("target_group", value);
    }

    /// <summary>
    /// TestTrafficRoute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TestTrafficRoute block(s) allowed")]
    public TerraformList<AwsCodedeployDeploymentGroupLoadBalancerInfoBlockTargetGroupPairInfoBlockTestTrafficRouteBlock>? TestTrafficRoute
    {
        get => GetArgument<TerraformList<AwsCodedeployDeploymentGroupLoadBalancerInfoBlockTargetGroupPairInfoBlockTestTrafficRouteBlock>>("test_traffic_route");
        set => SetArgument("test_traffic_route", value);
    }

}

/// <summary>
/// Block type for prod_traffic_route in AwsCodedeployDeploymentGroupLoadBalancerInfoBlockTargetGroupPairInfoBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupLoadBalancerInfoBlockTargetGroupPairInfoBlockProdTrafficRouteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "prod_traffic_route";

    /// <summary>
    /// The listener_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListenerArns is required")]
    public required TerraformSet<string> ListenerArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "listener_arns").ResolveNodes(ctx));
        set => SetArgument("listener_arns", value);
    }

}

/// <summary>
/// Block type for target_group in AwsCodedeployDeploymentGroupLoadBalancerInfoBlockTargetGroupPairInfoBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupLoadBalancerInfoBlockTargetGroupPairInfoBlockTargetGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_group";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for test_traffic_route in AwsCodedeployDeploymentGroupLoadBalancerInfoBlockTargetGroupPairInfoBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupLoadBalancerInfoBlockTargetGroupPairInfoBlockTestTrafficRouteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "test_traffic_route";

    /// <summary>
    /// The listener_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListenerArns is required")]
    public required TerraformSet<string> ListenerArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "listener_arns").ResolveNodes(ctx));
        set => SetArgument("listener_arns", value);
    }

}


/// <summary>
/// Block type for on_premises_instance_tag_filter in AwsCodedeployDeploymentGroup.
/// Nesting mode: set
/// </summary>
public class AwsCodedeployDeploymentGroupOnPremisesInstanceTagFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "on_premises_instance_tag_filter";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for trigger_configuration in AwsCodedeployDeploymentGroup.
/// Nesting mode: set
/// </summary>
public class AwsCodedeployDeploymentGroupTriggerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trigger_configuration";

    /// <summary>
    /// The trigger_events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerEvents is required")]
    public required TerraformSet<string> TriggerEvents
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "trigger_events").ResolveNodes(ctx));
        set => SetArgument("trigger_events", value);
    }

    /// <summary>
    /// The trigger_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerName is required")]
    public required TerraformValue<string> TriggerName
    {
        get => new TerraformReference<string>(this, "trigger_name");
        set => SetArgument("trigger_name", value);
    }

    /// <summary>
    /// The trigger_target_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerTargetArn is required")]
    public required TerraformValue<string> TriggerTargetArn
    {
        get => new TerraformReference<string>(this, "trigger_target_arn");
        set => SetArgument("trigger_target_arn", value);
    }

}


/// <summary>
/// Represents a aws_codedeploy_deployment_group Terraform resource.
/// Manages a aws_codedeploy_deployment_group resource.
/// </summary>
public partial class AwsCodedeployDeploymentGroup(string name) : TerraformResource("aws_codedeploy_deployment_group", name)
{
    /// <summary>
    /// The app_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppName is required")]
    public required TerraformValue<string> AppName
    {
        get => new TerraformReference<string>(this, "app_name");
        set => SetArgument("app_name", value);
    }

    /// <summary>
    /// The autoscaling_groups attribute.
    /// </summary>
    public TerraformSet<string>? AutoscalingGroups
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "autoscaling_groups").ResolveNodes(ctx));
        set => SetArgument("autoscaling_groups", value);
    }

    /// <summary>
    /// The deployment_config_name attribute.
    /// </summary>
    public TerraformValue<string>? DeploymentConfigName
    {
        get => new TerraformReference<string>(this, "deployment_config_name");
        set => SetArgument("deployment_config_name", value);
    }

    /// <summary>
    /// The deployment_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentGroupName is required")]
    public required TerraformValue<string> DeploymentGroupName
    {
        get => new TerraformReference<string>(this, "deployment_group_name");
        set => SetArgument("deployment_group_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The outdated_instances_strategy attribute.
    /// </summary>
    public TerraformValue<string>? OutdatedInstancesStrategy
    {
        get => new TerraformReference<string>(this, "outdated_instances_strategy");
        set => SetArgument("outdated_instances_strategy", value);
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
    /// The service_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRoleArn is required")]
    public required TerraformValue<string> ServiceRoleArn
    {
        get => new TerraformReference<string>(this, "service_role_arn");
        set => SetArgument("service_role_arn", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The termination_hook_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TerminationHookEnabled
    {
        get => new TerraformReference<bool>(this, "termination_hook_enabled");
        set => SetArgument("termination_hook_enabled", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The compute_platform attribute.
    /// </summary>
    public TerraformValue<string> ComputePlatform
    {
        get => new TerraformReference<string>(this, "compute_platform");
    }

    /// <summary>
    /// The deployment_group_id attribute.
    /// </summary>
    public TerraformValue<string> DeploymentGroupId
    {
        get => new TerraformReference<string>(this, "deployment_group_id");
    }

    /// <summary>
    /// AlarmConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AlarmConfiguration block(s) allowed")]
    public TerraformList<AwsCodedeployDeploymentGroupAlarmConfigurationBlock>? AlarmConfiguration
    {
        get => GetArgument<TerraformList<AwsCodedeployDeploymentGroupAlarmConfigurationBlock>>("alarm_configuration");
        set => SetArgument("alarm_configuration", value);
    }

    /// <summary>
    /// AutoRollbackConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoRollbackConfiguration block(s) allowed")]
    public TerraformList<AwsCodedeployDeploymentGroupAutoRollbackConfigurationBlock>? AutoRollbackConfiguration
    {
        get => GetArgument<TerraformList<AwsCodedeployDeploymentGroupAutoRollbackConfigurationBlock>>("auto_rollback_configuration");
        set => SetArgument("auto_rollback_configuration", value);
    }

    /// <summary>
    /// BlueGreenDeploymentConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlueGreenDeploymentConfig block(s) allowed")]
    public TerraformList<AwsCodedeployDeploymentGroupBlueGreenDeploymentConfigBlock>? BlueGreenDeploymentConfig
    {
        get => GetArgument<TerraformList<AwsCodedeployDeploymentGroupBlueGreenDeploymentConfigBlock>>("blue_green_deployment_config");
        set => SetArgument("blue_green_deployment_config", value);
    }

    /// <summary>
    /// DeploymentStyle block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentStyle block(s) allowed")]
    public TerraformList<AwsCodedeployDeploymentGroupDeploymentStyleBlock>? DeploymentStyle
    {
        get => GetArgument<TerraformList<AwsCodedeployDeploymentGroupDeploymentStyleBlock>>("deployment_style");
        set => SetArgument("deployment_style", value);
    }

    /// <summary>
    /// Ec2TagFilter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCodedeployDeploymentGroupEc2TagFilterBlock>? Ec2TagFilter
    {
        get => GetArgument<TerraformSet<AwsCodedeployDeploymentGroupEc2TagFilterBlock>>("ec2_tag_filter");
        set => SetArgument("ec2_tag_filter", value);
    }

    /// <summary>
    /// Ec2TagSet block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCodedeployDeploymentGroupEc2TagSetBlock>? Ec2TagSet
    {
        get => GetArgument<TerraformSet<AwsCodedeployDeploymentGroupEc2TagSetBlock>>("ec2_tag_set");
        set => SetArgument("ec2_tag_set", value);
    }

    /// <summary>
    /// EcsService block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EcsService block(s) allowed")]
    public TerraformList<AwsCodedeployDeploymentGroupEcsServiceBlock>? EcsService
    {
        get => GetArgument<TerraformList<AwsCodedeployDeploymentGroupEcsServiceBlock>>("ecs_service");
        set => SetArgument("ecs_service", value);
    }

    /// <summary>
    /// LoadBalancerInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancerInfo block(s) allowed")]
    public TerraformList<AwsCodedeployDeploymentGroupLoadBalancerInfoBlock>? LoadBalancerInfo
    {
        get => GetArgument<TerraformList<AwsCodedeployDeploymentGroupLoadBalancerInfoBlock>>("load_balancer_info");
        set => SetArgument("load_balancer_info", value);
    }

    /// <summary>
    /// OnPremisesInstanceTagFilter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCodedeployDeploymentGroupOnPremisesInstanceTagFilterBlock>? OnPremisesInstanceTagFilter
    {
        get => GetArgument<TerraformSet<AwsCodedeployDeploymentGroupOnPremisesInstanceTagFilterBlock>>("on_premises_instance_tag_filter");
        set => SetArgument("on_premises_instance_tag_filter", value);
    }

    /// <summary>
    /// TriggerConfiguration block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCodedeployDeploymentGroupTriggerConfigurationBlock>? TriggerConfiguration
    {
        get => GetArgument<TerraformSet<AwsCodedeployDeploymentGroupTriggerConfigurationBlock>>("trigger_configuration");
        set => SetArgument("trigger_configuration", value);
    }

}
