using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for alarm_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupAlarmConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The alarms attribute.
    /// </summary>
    [TerraformPropertyName("alarms")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Alarms { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The ignore_poll_alarm_failure attribute.
    /// </summary>
    [TerraformPropertyName("ignore_poll_alarm_failure")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IgnorePollAlarmFailure { get; set; }

}

/// <summary>
/// Block type for auto_rollback_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupAutoRollbackConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The events attribute.
    /// </summary>
    [TerraformPropertyName("events")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Events { get; set; }

}

/// <summary>
/// Block type for blue_green_deployment_config in .
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupBlueGreenDeploymentConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for deployment_style in .
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupDeploymentStyleBlock : ITerraformBlock
{
    /// <summary>
    /// The deployment_option attribute.
    /// </summary>
    [TerraformPropertyName("deployment_option")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeploymentOption { get; set; }

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    [TerraformPropertyName("deployment_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeploymentType { get; set; }

}

/// <summary>
/// Block type for ec2_tag_filter in .
/// Nesting mode: set
/// </summary>
public class AwsCodedeployDeploymentGroupEc2TagFilterBlock : ITerraformBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [TerraformPropertyName("key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Key { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Value { get; set; }

}

/// <summary>
/// Block type for ec2_tag_set in .
/// Nesting mode: set
/// </summary>
public class AwsCodedeployDeploymentGroupEc2TagSetBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for ecs_service in .
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupEcsServiceBlock : ITerraformBlock
{
    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformPropertyName("cluster_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterName { get; set; }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    [TerraformPropertyName("service_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServiceName { get; set; }

}

/// <summary>
/// Block type for load_balancer_info in .
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentGroupLoadBalancerInfoBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for on_premises_instance_tag_filter in .
/// Nesting mode: set
/// </summary>
public class AwsCodedeployDeploymentGroupOnPremisesInstanceTagFilterBlock : ITerraformBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [TerraformPropertyName("key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Key { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Value { get; set; }

}

/// <summary>
/// Block type for trigger_configuration in .
/// Nesting mode: set
/// </summary>
public class AwsCodedeployDeploymentGroupTriggerConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The trigger_events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerEvents is required")]
    [TerraformPropertyName("trigger_events")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? TriggerEvents { get; set; }

    /// <summary>
    /// The trigger_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerName is required")]
    [TerraformPropertyName("trigger_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TriggerName { get; set; }

    /// <summary>
    /// The trigger_target_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerTargetArn is required")]
    [TerraformPropertyName("trigger_target_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TriggerTargetArn { get; set; }

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
    public required TerraformProperty<TerraformProperty<string>> AppName { get; set; }

    /// <summary>
    /// The autoscaling_groups attribute.
    /// </summary>
    [TerraformPropertyName("autoscaling_groups")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AutoscalingGroups { get; set; }

    /// <summary>
    /// The deployment_config_name attribute.
    /// </summary>
    [TerraformPropertyName("deployment_config_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeploymentConfigName { get; set; }

    /// <summary>
    /// The deployment_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentGroupName is required")]
    [TerraformPropertyName("deployment_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DeploymentGroupName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The outdated_instances_strategy attribute.
    /// </summary>
    [TerraformPropertyName("outdated_instances_strategy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OutdatedInstancesStrategy { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The service_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRoleArn is required")]
    [TerraformPropertyName("service_role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServiceRoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The termination_hook_enabled attribute.
    /// </summary>
    [TerraformPropertyName("termination_hook_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? TerminationHookEnabled { get; set; }

    /// <summary>
    /// Block for alarm_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AlarmConfiguration block(s) allowed")]
    [TerraformPropertyName("alarm_configuration")]
    public TerraformList<TerraformBlock<AwsCodedeployDeploymentGroupAlarmConfigurationBlock>>? AlarmConfiguration { get; set; } = new();

    /// <summary>
    /// Block for auto_rollback_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoRollbackConfiguration block(s) allowed")]
    [TerraformPropertyName("auto_rollback_configuration")]
    public TerraformList<TerraformBlock<AwsCodedeployDeploymentGroupAutoRollbackConfigurationBlock>>? AutoRollbackConfiguration { get; set; } = new();

    /// <summary>
    /// Block for blue_green_deployment_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlueGreenDeploymentConfig block(s) allowed")]
    [TerraformPropertyName("blue_green_deployment_config")]
    public TerraformList<TerraformBlock<AwsCodedeployDeploymentGroupBlueGreenDeploymentConfigBlock>>? BlueGreenDeploymentConfig { get; set; } = new();

    /// <summary>
    /// Block for deployment_style.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentStyle block(s) allowed")]
    [TerraformPropertyName("deployment_style")]
    public TerraformList<TerraformBlock<AwsCodedeployDeploymentGroupDeploymentStyleBlock>>? DeploymentStyle { get; set; } = new();

    /// <summary>
    /// Block for ec2_tag_filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("ec2_tag_filter")]
    public TerraformSet<TerraformBlock<AwsCodedeployDeploymentGroupEc2TagFilterBlock>>? Ec2TagFilter { get; set; } = new();

    /// <summary>
    /// Block for ec2_tag_set.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("ec2_tag_set")]
    public TerraformSet<TerraformBlock<AwsCodedeployDeploymentGroupEc2TagSetBlock>>? Ec2TagSet { get; set; } = new();

    /// <summary>
    /// Block for ecs_service.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EcsService block(s) allowed")]
    [TerraformPropertyName("ecs_service")]
    public TerraformList<TerraformBlock<AwsCodedeployDeploymentGroupEcsServiceBlock>>? EcsService { get; set; } = new();

    /// <summary>
    /// Block for load_balancer_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancerInfo block(s) allowed")]
    [TerraformPropertyName("load_balancer_info")]
    public TerraformList<TerraformBlock<AwsCodedeployDeploymentGroupLoadBalancerInfoBlock>>? LoadBalancerInfo { get; set; } = new();

    /// <summary>
    /// Block for on_premises_instance_tag_filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("on_premises_instance_tag_filter")]
    public TerraformSet<TerraformBlock<AwsCodedeployDeploymentGroupOnPremisesInstanceTagFilterBlock>>? OnPremisesInstanceTagFilter { get; set; } = new();

    /// <summary>
    /// Block for trigger_configuration.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("trigger_configuration")]
    public TerraformSet<TerraformBlock<AwsCodedeployDeploymentGroupTriggerConfigurationBlock>>? TriggerConfiguration { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The compute_platform attribute.
    /// </summary>
    [TerraformPropertyName("compute_platform")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ComputePlatform => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "compute_platform");

    /// <summary>
    /// The deployment_group_id attribute.
    /// </summary>
    [TerraformPropertyName("deployment_group_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeploymentGroupId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "deployment_group_id");

}
