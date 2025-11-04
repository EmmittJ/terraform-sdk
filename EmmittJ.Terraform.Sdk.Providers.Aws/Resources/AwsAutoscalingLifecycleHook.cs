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
    public string? AutoscalingGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("autoscaling_group_name")?.Value;
        set => this.WithProperty("autoscaling_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_result attribute.
    /// </summary>
    public string? DefaultResult
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_result")?.Value;
        set => this.WithProperty("default_result", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The heartbeat_timeout attribute.
    /// </summary>
    public double? HeartbeatTimeout
    {
        get => GetProperty<TerraformLiteralProperty<double>>("heartbeat_timeout")?.Value;
        set => this.WithProperty("heartbeat_timeout", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The lifecycle_transition attribute.
    /// </summary>
    public string? LifecycleTransition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lifecycle_transition")?.Value;
        set => this.WithProperty("lifecycle_transition", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The notification_metadata attribute.
    /// </summary>
    public string? NotificationMetadata
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notification_metadata")?.Value;
        set => this.WithProperty("notification_metadata", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The notification_target_arn attribute.
    /// </summary>
    public string? NotificationTargetArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notification_target_arn")?.Value;
        set => this.WithProperty("notification_target_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public string? RoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn")?.Value;
        set => this.WithProperty("role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
