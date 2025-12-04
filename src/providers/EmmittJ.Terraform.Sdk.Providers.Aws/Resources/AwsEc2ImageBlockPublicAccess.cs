using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsEc2ImageBlockPublicAccess.
/// Nesting mode: single
/// </summary>
public class AwsEc2ImageBlockPublicAccessTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_ec2_image_block_public_access Terraform resource.
/// Manages a aws_ec2_image_block_public_access resource.
/// </summary>
public partial class AwsEc2ImageBlockPublicAccess(string name) : TerraformResource("aws_ec2_image_block_public_access", name)
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
    /// The state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    public required TerraformValue<string> State
    {
        get => GetRequiredArgument<TerraformValue<string>>("state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEc2ImageBlockPublicAccessTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEc2ImageBlockPublicAccessTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
