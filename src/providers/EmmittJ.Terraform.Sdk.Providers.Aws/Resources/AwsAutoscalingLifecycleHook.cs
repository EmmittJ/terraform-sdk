using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_autoscaling_lifecycle_hook resource.
/// </summary>
public class AwsAutoscalingLifecycleHook : TerraformResource
{
    public AwsAutoscalingLifecycleHook(string name) : base("aws_autoscaling_lifecycle_hook", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("autoscaling_group_name");
        SetOutput("default_result");
        SetOutput("heartbeat_timeout");
        SetOutput("id");
        SetOutput("lifecycle_transition");
        SetOutput("name");
        SetOutput("notification_metadata");
        SetOutput("notification_target_arn");
        SetOutput("region");
        SetOutput("role_arn");
    }

    /// <summary>
    /// The autoscaling_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoscalingGroupName is required")]
    public required TerraformProperty<string> AutoscalingGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("autoscaling_group_name");
        set => SetProperty("autoscaling_group_name", value);
    }

    /// <summary>
    /// The default_result attribute.
    /// </summary>
    public TerraformProperty<string> DefaultResult
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_result");
        set => SetProperty("default_result", value);
    }

    /// <summary>
    /// The heartbeat_timeout attribute.
    /// </summary>
    public TerraformProperty<double> HeartbeatTimeout
    {
        get => GetRequiredOutput<TerraformProperty<double>>("heartbeat_timeout");
        set => SetProperty("heartbeat_timeout", value);
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
    /// The lifecycle_transition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LifecycleTransition is required")]
    public required TerraformProperty<string> LifecycleTransition
    {
        get => GetRequiredOutput<TerraformProperty<string>>("lifecycle_transition");
        set => SetProperty("lifecycle_transition", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The notification_metadata attribute.
    /// </summary>
    public TerraformProperty<string> NotificationMetadata
    {
        get => GetRequiredOutput<TerraformProperty<string>>("notification_metadata");
        set => SetProperty("notification_metadata", value);
    }

    /// <summary>
    /// The notification_target_arn attribute.
    /// </summary>
    public TerraformProperty<string> NotificationTargetArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("notification_target_arn");
        set => SetProperty("notification_target_arn", value);
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
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string> RoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn");
        set => SetProperty("role_arn", value);
    }

}
