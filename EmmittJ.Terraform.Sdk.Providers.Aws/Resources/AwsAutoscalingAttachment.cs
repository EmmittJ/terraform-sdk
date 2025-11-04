using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_autoscaling_attachment resource.
/// </summary>
public class AwsAutoscalingAttachment : TerraformResource
{
    public AwsAutoscalingAttachment(string name) : base("aws_autoscaling_attachment", name)
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
    /// The elb attribute.
    /// </summary>
    public string? Elb
    {
        get => GetProperty<TerraformLiteralProperty<string>>("elb")?.Value;
        set => this.WithProperty("elb", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The lb_target_group_arn attribute.
    /// </summary>
    public string? LbTargetGroupArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lb_target_group_arn")?.Value;
        set => this.WithProperty("lb_target_group_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
