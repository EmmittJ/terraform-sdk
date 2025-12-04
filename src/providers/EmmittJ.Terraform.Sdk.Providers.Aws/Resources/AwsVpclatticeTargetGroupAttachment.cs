using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for target in AwsVpclatticeTargetGroupAttachment.
/// Nesting mode: list
/// </summary>
public class AwsVpclatticeTargetGroupAttachmentTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target";

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port") ?? AsReference("port");
        set => SetArgument("port", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsVpclatticeTargetGroupAttachment.
/// Nesting mode: single
/// </summary>
public class AwsVpclatticeTargetGroupAttachmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_vpclattice_target_group_attachment Terraform resource.
/// Manages a aws_vpclattice_target_group_attachment resource.
/// </summary>
public partial class AwsVpclatticeTargetGroupAttachment(string name) : TerraformResource("aws_vpclattice_target_group_attachment", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The target_group_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetGroupIdentifier is required")]
    public required TerraformValue<string> TargetGroupIdentifier
    {
        get => GetRequiredArgument<TerraformValue<string>>("target_group_identifier");
        set => SetArgument("target_group_identifier", value);
    }

    /// <summary>
    /// Target block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Target block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    public required TerraformList<AwsVpclatticeTargetGroupAttachmentTargetBlock> Target
    {
        get => GetRequiredArgument<TerraformList<AwsVpclatticeTargetGroupAttachmentTargetBlock>>("target");
        set => SetArgument("target", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVpclatticeTargetGroupAttachmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVpclatticeTargetGroupAttachmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
