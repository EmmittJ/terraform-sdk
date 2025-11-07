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
    }

    /// <summary>
    /// The autoscaling_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AutoscalingGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("autoscaling_group_name");
        set => this.WithProperty("autoscaling_group_name", value);
    }

    /// <summary>
    /// The default_result attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DefaultResult
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_result");
        set => this.WithProperty("default_result", value);
    }

    /// <summary>
    /// The heartbeat_timeout attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? HeartbeatTimeout
    {
        get => GetProperty<TerraformLiteralProperty<double>>("heartbeat_timeout");
        set => this.WithProperty("heartbeat_timeout", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The lifecycle_transition attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LifecycleTransition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lifecycle_transition");
        set => this.WithProperty("lifecycle_transition", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The notification_metadata attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NotificationMetadata
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notification_metadata");
        set => this.WithProperty("notification_metadata", value);
    }

    /// <summary>
    /// The notification_target_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NotificationTargetArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notification_target_arn");
        set => this.WithProperty("notification_target_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

}
