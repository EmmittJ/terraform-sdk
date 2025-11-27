using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_autoscaling_lifecycle_hook Terraform resource.
/// Manages a aws_autoscaling_lifecycle_hook resource.
/// </summary>
public partial class AwsAutoscalingLifecycleHook(string name) : TerraformResource("aws_autoscaling_lifecycle_hook", name)
{
    /// <summary>
    /// The autoscaling_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoscalingGroupName is required")]
    public required TerraformValue<string> AutoscalingGroupName
    {
        get => new TerraformReference<string>(this, "autoscaling_group_name");
        set => SetArgument("autoscaling_group_name", value);
    }

    /// <summary>
    /// The default_result attribute.
    /// </summary>
    public TerraformValue<string> DefaultResult
    {
        get => new TerraformReference<string>(this, "default_result");
        set => SetArgument("default_result", value);
    }

    /// <summary>
    /// The heartbeat_timeout attribute.
    /// </summary>
    public TerraformValue<double>? HeartbeatTimeout
    {
        get => new TerraformReference<double>(this, "heartbeat_timeout");
        set => SetArgument("heartbeat_timeout", value);
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
    /// The lifecycle_transition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LifecycleTransition is required")]
    public required TerraformValue<string> LifecycleTransition
    {
        get => new TerraformReference<string>(this, "lifecycle_transition");
        set => SetArgument("lifecycle_transition", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The notification_metadata attribute.
    /// </summary>
    public TerraformValue<string>? NotificationMetadata
    {
        get => new TerraformReference<string>(this, "notification_metadata");
        set => SetArgument("notification_metadata", value);
    }

    /// <summary>
    /// The notification_target_arn attribute.
    /// </summary>
    public TerraformValue<string>? NotificationTargetArn
    {
        get => new TerraformReference<string>(this, "notification_target_arn");
        set => SetArgument("notification_target_arn", value);
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
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

}
