using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for alarm_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupAlarmConfigurationBlock
{
    /// <summary>
    /// The alarms attribute.
    /// </summary>
    [TerraformPropertyName("alarms")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Alarms { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The ignore_poll_alarm_failure attribute.
    /// </summary>
    [TerraformPropertyName("ignore_poll_alarm_failure")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IgnorePollAlarmFailure { get; set; }

}

/// <summary>
/// Block type for auto_rollback_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupAutoRollbackConfigurationBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The events attribute.
    /// </summary>
    [TerraformPropertyName("events")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Events { get; set; }

}

/// <summary>
/// Block type for blue_green_deployment_config in .
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupBlueGreenDeploymentConfigBlock
{
}

/// <summary>
/// Block type for deployment_style in .
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupDeploymentStyleBlock
{
    /// <summary>
    /// The deployment_option attribute.
    /// </summary>
    [TerraformPropertyName("deployment_option")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DeploymentOption { get; set; }

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    [TerraformPropertyName("deployment_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DeploymentType { get; set; }

}

/// <summary>
/// Block type for ec2_tag_filter in .
/// Nesting mode: set
/// </summary>
public class AwsCodedeployDeploymentGroupEc2TagFilterBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [TerraformPropertyName("key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Key { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for ec2_tag_set in .
/// Nesting mode: set
/// </summary>
public class AwsCodedeployDeploymentGroupEc2TagSetBlock
{
}

/// <summary>
/// Block type for ecs_service in .
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupEcsServiceBlock
{
    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformPropertyName("cluster_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ClusterName { get; set; }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    [TerraformPropertyName("service_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServiceName { get; set; }

}

/// <summary>
/// Block type for load_balancer_info in .
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupLoadBalancerInfoBlock
{
}

/// <summary>
/// Block type for on_premises_instance_tag_filter in .
/// Nesting mode: set
/// </summary>
public class AwsCodedeployDeploymentGroupOnPremisesInstanceTagFilterBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [TerraformPropertyName("key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Key { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for trigger_configuration in .
/// Nesting mode: set
/// </summary>
public class AwsCodedeployDeploymentGroupTriggerConfigurationBlock
{
    /// <summary>
    /// The trigger_events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerEvents is required")]
    [TerraformPropertyName("trigger_events")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> TriggerEvents { get; set; }

    /// <summary>
    /// The trigger_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerName is required")]
    [TerraformPropertyName("trigger_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TriggerName { get; set; }

    /// <summary>
    /// The trigger_target_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerTargetArn is required")]
    [TerraformPropertyName("trigger_target_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TriggerTargetArn { get; set; }

}

/// <summary>
/// Manages a aws_codedeploy_deployment_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCodedeployDeploymentGroup : TerraformResource
{
    public AwsCodedeployDeploymentGroup(string name) : base("aws_codedeploy_deployment_group", name)
    {
    }

    /// <summary>
    /// The app_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppName is required")]
    [TerraformPropertyName("app_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AppName { get; set; }

    /// <summary>
    /// The autoscaling_groups attribute.
    /// </summary>
    [TerraformPropertyName("autoscaling_groups")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? AutoscalingGroups { get; set; }

    /// <summary>
    /// The deployment_config_name attribute.
    /// </summary>
    [TerraformPropertyName("deployment_config_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DeploymentConfigName { get; set; }

    /// <summary>
    /// The deployment_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentGroupName is required")]
    [TerraformPropertyName("deployment_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DeploymentGroupName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The outdated_instances_strategy attribute.
    /// </summary>
    [TerraformPropertyName("outdated_instances_strategy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OutdatedInstancesStrategy { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The service_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRoleArn is required")]
    [TerraformPropertyName("service_role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServiceRoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The termination_hook_enabled attribute.
    /// </summary>
    [TerraformPropertyName("termination_hook_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? TerminationHookEnabled { get; set; }

    /// <summary>
    /// Block for alarm_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AlarmConfiguration block(s) allowed")]
    [TerraformPropertyName("alarm_configuration")]
    public TerraformList<TerraformBlock<AwsCodedeployDeploymentGroupAlarmConfigurationBlock>>? AlarmConfiguration { get; set; }

    /// <summary>
    /// Block for auto_rollback_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoRollbackConfiguration block(s) allowed")]
    [TerraformPropertyName("auto_rollback_configuration")]
    public TerraformList<TerraformBlock<AwsCodedeployDeploymentGroupAutoRollbackConfigurationBlock>>? AutoRollbackConfiguration { get; set; }

    /// <summary>
    /// Block for blue_green_deployment_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlueGreenDeploymentConfig block(s) allowed")]
    [TerraformPropertyName("blue_green_deployment_config")]
    public TerraformList<TerraformBlock<AwsCodedeployDeploymentGroupBlueGreenDeploymentConfigBlock>>? BlueGreenDeploymentConfig { get; set; }

    /// <summary>
    /// Block for deployment_style.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentStyle block(s) allowed")]
    [TerraformPropertyName("deployment_style")]
    public TerraformList<TerraformBlock<AwsCodedeployDeploymentGroupDeploymentStyleBlock>>? DeploymentStyle { get; set; }

    /// <summary>
    /// Block for ec2_tag_filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("ec2_tag_filter")]
    public TerraformSet<TerraformBlock<AwsCodedeployDeploymentGroupEc2TagFilterBlock>>? Ec2TagFilter { get; set; }

    /// <summary>
    /// Block for ec2_tag_set.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("ec2_tag_set")]
    public TerraformSet<TerraformBlock<AwsCodedeployDeploymentGroupEc2TagSetBlock>>? Ec2TagSet { get; set; }

    /// <summary>
    /// Block for ecs_service.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EcsService block(s) allowed")]
    [TerraformPropertyName("ecs_service")]
    public TerraformList<TerraformBlock<AwsCodedeployDeploymentGroupEcsServiceBlock>>? EcsService { get; set; }

    /// <summary>
    /// Block for load_balancer_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancerInfo block(s) allowed")]
    [TerraformPropertyName("load_balancer_info")]
    public TerraformList<TerraformBlock<AwsCodedeployDeploymentGroupLoadBalancerInfoBlock>>? LoadBalancerInfo { get; set; }

    /// <summary>
    /// Block for on_premises_instance_tag_filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("on_premises_instance_tag_filter")]
    public TerraformSet<TerraformBlock<AwsCodedeployDeploymentGroupOnPremisesInstanceTagFilterBlock>>? OnPremisesInstanceTagFilter { get; set; }

    /// <summary>
    /// Block for trigger_configuration.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("trigger_configuration")]
    public TerraformSet<TerraformBlock<AwsCodedeployDeploymentGroupTriggerConfigurationBlock>>? TriggerConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The compute_platform attribute.
    /// </summary>
    [TerraformPropertyName("compute_platform")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ComputePlatform => new TerraformReference(this, "compute_platform");

    /// <summary>
    /// The deployment_group_id attribute.
    /// </summary>
    [TerraformPropertyName("deployment_group_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeploymentGroupId => new TerraformReference(this, "deployment_group_id");

}
