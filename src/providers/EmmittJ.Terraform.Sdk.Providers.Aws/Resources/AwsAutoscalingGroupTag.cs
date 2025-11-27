using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for tag in AwsAutoscalingGroupTag.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingGroupTagTagBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tag";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The propagate_at_launch attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PropagateAtLaunch is required")]
    public required TerraformValue<bool> PropagateAtLaunch
    {
        get => new TerraformReference<bool>(this, "propagate_at_launch");
        set => SetArgument("propagate_at_launch", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_autoscaling_group_tag Terraform resource.
/// Manages a aws_autoscaling_group_tag resource.
/// </summary>
public partial class AwsAutoscalingGroupTag(string name) : TerraformResource("aws_autoscaling_group_tag", name)
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// Tag block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tag is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Tag block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tag block(s) allowed")]
    public required TerraformList<AwsAutoscalingGroupTagTagBlock> Tag
    {
        get => GetRequiredArgument<TerraformList<AwsAutoscalingGroupTagTagBlock>>("tag");
        set => SetArgument("tag", value);
    }

}
