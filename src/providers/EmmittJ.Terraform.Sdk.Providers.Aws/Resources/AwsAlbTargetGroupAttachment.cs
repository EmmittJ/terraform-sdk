using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_alb_target_group_attachment Terraform resource.
/// Manages a aws_alb_target_group_attachment resource.
/// </summary>
public partial class AwsAlbTargetGroupAttachment(string name) : TerraformResource("aws_alb_target_group_attachment", name)
{
    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string>? AvailabilityZone
    {
        get => new TerraformReference<string>(this, "availability_zone");
        set => SetArgument("availability_zone", value);
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
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
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
    /// The target_group_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetGroupArn is required")]
    public required TerraformValue<string> TargetGroupArn
    {
        get => new TerraformReference<string>(this, "target_group_arn");
        set => SetArgument("target_group_arn", value);
    }

    /// <summary>
    /// The target_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetId is required")]
    public required TerraformValue<string> TargetId
    {
        get => new TerraformReference<string>(this, "target_id");
        set => SetArgument("target_id", value);
    }

}
