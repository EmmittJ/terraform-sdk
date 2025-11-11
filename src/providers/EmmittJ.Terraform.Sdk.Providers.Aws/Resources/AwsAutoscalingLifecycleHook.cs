using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_autoscaling_lifecycle_hook resource.
/// </summary>
public partial class AwsAutoscalingLifecycleHook : TerraformResource
{
    public AwsAutoscalingLifecycleHook(string name) : base("aws_autoscaling_lifecycle_hook", name)
    {
    }

    /// <summary>
    /// The autoscaling_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoscalingGroupName is required")]
    [TerraformProperty("autoscaling_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AutoscalingGroupName { get; set; }

    /// <summary>
    /// The default_result attribute.
    /// </summary>
    [TerraformProperty("default_result")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DefaultResult { get; set; }

    /// <summary>
    /// The heartbeat_timeout attribute.
    /// </summary>
    [TerraformProperty("heartbeat_timeout")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? HeartbeatTimeout { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The lifecycle_transition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LifecycleTransition is required")]
    [TerraformProperty("lifecycle_transition")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LifecycleTransition { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The notification_metadata attribute.
    /// </summary>
    [TerraformProperty("notification_metadata")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NotificationMetadata { get; set; }

    /// <summary>
    /// The notification_target_arn attribute.
    /// </summary>
    [TerraformProperty("notification_target_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NotificationTargetArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformProperty("role_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RoleArn { get; set; }

}
