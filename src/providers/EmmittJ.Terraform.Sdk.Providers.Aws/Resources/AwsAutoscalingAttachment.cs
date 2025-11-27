using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_autoscaling_attachment Terraform resource.
/// Manages a aws_autoscaling_attachment resource.
/// </summary>
public partial class AwsAutoscalingAttachment(string name) : TerraformResource("aws_autoscaling_attachment", name)
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
    /// The elb attribute.
    /// </summary>
    public TerraformValue<string>? Elb
    {
        get => new TerraformReference<string>(this, "elb");
        set => SetArgument("elb", value);
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
    /// The lb_target_group_arn attribute.
    /// </summary>
    public TerraformValue<string>? LbTargetGroupArn
    {
        get => new TerraformReference<string>(this, "lb_target_group_arn");
        set => SetArgument("lb_target_group_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

}
