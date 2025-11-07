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
    public TerraformProperty<string>? AutoscalingGroupName
    {
        get => GetProperty<TerraformProperty<string>>("autoscaling_group_name");
        set => this.WithProperty("autoscaling_group_name", value);
    }

    /// <summary>
    /// The elb attribute.
    /// </summary>
    public TerraformProperty<string>? Elb
    {
        get => GetProperty<TerraformProperty<string>>("elb");
        set => this.WithProperty("elb", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The lb_target_group_arn attribute.
    /// </summary>
    public TerraformProperty<string>? LbTargetGroupArn
    {
        get => GetProperty<TerraformProperty<string>>("lb_target_group_arn");
        set => this.WithProperty("lb_target_group_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
