using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for alarm_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodedeployDeploymentGroupAlarmConfigurationBlock() : TerraformBlock("alarm_configuration")
{
    /// <summary>
    /// The alarms attribute.
    /// </summary>
    [TerraformProperty("alarms")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Alarms { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The ignore_poll_alarm_failure attribute.
    /// </summary>
    [TerraformProperty("ignore_poll_alarm_failure")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IgnorePollAlarmFailure { get; set; }

}

/// <summary>
/// Block type for auto_rollback_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodedeployDeploymentGroupAutoRollbackConfigurationBlock() : TerraformBlock("auto_rollback_configuration")
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The events attribute.
    /// </summary>
    [TerraformProperty("events")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Events { get; set; }

}

/// <summary>
/// Block type for blue_green_deployment_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodedeployDeploymentGroupBlueGreenDeploymentConfigBlock() : TerraformBlock("blue_green_deployment_config")
{
}

/// <summary>
/// Block type for deployment_style in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodedeployDeploymentGroupDeploymentStyleBlock() : TerraformBlock("deployment_style")
{
    /// <summary>
    /// The deployment_option attribute.
    /// </summary>
    [TerraformProperty("deployment_option")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeploymentOption { get; set; }

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    [TerraformProperty("deployment_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeploymentType { get; set; }

}

/// <summary>
/// Block type for ec2_tag_filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsCodedeployDeploymentGroupEc2TagFilterBlock() : TerraformBlock("ec2_tag_filter")
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [TerraformProperty("key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Key { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformProperty("value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for ec2_tag_set in .
/// Nesting mode: set
/// </summary>
public partial class AwsCodedeployDeploymentGroupEc2TagSetBlock() : TerraformBlock("ec2_tag_set")
{
}

/// <summary>
/// Block type for ecs_service in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodedeployDeploymentGroupEcsServiceBlock() : TerraformBlock("ecs_service")
{
    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformProperty("cluster_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterName { get; set; }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    [TerraformProperty("service_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceName { get; set; }

}

/// <summary>
/// Block type for load_balancer_info in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodedeployDeploymentGroupLoadBalancerInfoBlock() : TerraformBlock("load_balancer_info")
{
}

/// <summary>
/// Block type for on_premises_instance_tag_filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsCodedeployDeploymentGroupOnPremisesInstanceTagFilterBlock() : TerraformBlock("on_premises_instance_tag_filter")
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [TerraformProperty("key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Key { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformProperty("value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for trigger_configuration in .
/// Nesting mode: set
/// </summary>
public partial class AwsCodedeployDeploymentGroupTriggerConfigurationBlock() : TerraformBlock("trigger_configuration")
{
    /// <summary>
    /// The trigger_events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerEvents is required")]
    [TerraformProperty("trigger_events")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> TriggerEvents { get; set; }

    /// <summary>
    /// The trigger_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerName is required")]
    [TerraformProperty("trigger_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TriggerName { get; set; }

    /// <summary>
    /// The trigger_target_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerTargetArn is required")]
    [TerraformProperty("trigger_target_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TriggerTargetArn { get; set; }

}

/// <summary>
/// Manages a aws_codedeploy_deployment_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCodedeployDeploymentGroup : TerraformResource
{
    public AwsCodedeployDeploymentGroup(string name) : base("aws_codedeploy_deployment_group", name)
    {
    }

    /// <summary>
    /// The app_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppName is required")]
    [TerraformProperty("app_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AppName { get; set; }

    /// <summary>
    /// The autoscaling_groups attribute.
    /// </summary>
    [TerraformProperty("autoscaling_groups")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? AutoscalingGroups { get; set; }

    /// <summary>
    /// The deployment_config_name attribute.
    /// </summary>
    [TerraformProperty("deployment_config_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeploymentConfigName { get; set; }

    /// <summary>
    /// The deployment_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentGroupName is required")]
    [TerraformProperty("deployment_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DeploymentGroupName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The outdated_instances_strategy attribute.
    /// </summary>
    [TerraformProperty("outdated_instances_strategy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OutdatedInstancesStrategy { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The service_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRoleArn is required")]
    [TerraformProperty("service_role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceRoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The termination_hook_enabled attribute.
    /// </summary>
    [TerraformProperty("termination_hook_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? TerminationHookEnabled { get; set; }

    /// <summary>
    /// Block for alarm_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AlarmConfiguration block(s) allowed")]
    [TerraformProperty("alarm_configuration")]
    public TerraformList<AwsCodedeployDeploymentGroupAlarmConfigurationBlock> AlarmConfiguration { get; set; } = new();

    /// <summary>
    /// Block for auto_rollback_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoRollbackConfiguration block(s) allowed")]
    [TerraformProperty("auto_rollback_configuration")]
    public TerraformList<AwsCodedeployDeploymentGroupAutoRollbackConfigurationBlock> AutoRollbackConfiguration { get; set; } = new();

    /// <summary>
    /// Block for blue_green_deployment_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlueGreenDeploymentConfig block(s) allowed")]
    [TerraformProperty("blue_green_deployment_config")]
    public TerraformList<AwsCodedeployDeploymentGroupBlueGreenDeploymentConfigBlock> BlueGreenDeploymentConfig { get; set; } = new();

    /// <summary>
    /// Block for deployment_style.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentStyle block(s) allowed")]
    [TerraformProperty("deployment_style")]
    public TerraformList<AwsCodedeployDeploymentGroupDeploymentStyleBlock> DeploymentStyle { get; set; } = new();

    /// <summary>
    /// Block for ec2_tag_filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("ec2_tag_filter")]
    public TerraformSet<AwsCodedeployDeploymentGroupEc2TagFilterBlock> Ec2TagFilter { get; set; } = new();

    /// <summary>
    /// Block for ec2_tag_set.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("ec2_tag_set")]
    public TerraformSet<AwsCodedeployDeploymentGroupEc2TagSetBlock> Ec2TagSet { get; set; } = new();

    /// <summary>
    /// Block for ecs_service.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EcsService block(s) allowed")]
    [TerraformProperty("ecs_service")]
    public TerraformList<AwsCodedeployDeploymentGroupEcsServiceBlock> EcsService { get; set; } = new();

    /// <summary>
    /// Block for load_balancer_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancerInfo block(s) allowed")]
    [TerraformProperty("load_balancer_info")]
    public TerraformList<AwsCodedeployDeploymentGroupLoadBalancerInfoBlock> LoadBalancerInfo { get; set; } = new();

    /// <summary>
    /// Block for on_premises_instance_tag_filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("on_premises_instance_tag_filter")]
    public TerraformSet<AwsCodedeployDeploymentGroupOnPremisesInstanceTagFilterBlock> OnPremisesInstanceTagFilter { get; set; } = new();

    /// <summary>
    /// Block for trigger_configuration.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("trigger_configuration")]
    public TerraformSet<AwsCodedeployDeploymentGroupTriggerConfigurationBlock> TriggerConfiguration { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The compute_platform attribute.
    /// </summary>
    [TerraformProperty("compute_platform")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ComputePlatform { get; }

    /// <summary>
    /// The deployment_group_id attribute.
    /// </summary>
    [TerraformProperty("deployment_group_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeploymentGroupId { get; }

}
