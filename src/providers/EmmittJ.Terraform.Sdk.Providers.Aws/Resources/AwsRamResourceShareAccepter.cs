using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsRamResourceShareAccepter.
/// Nesting mode: single
/// </summary>
public class AwsRamResourceShareAccepterTimeoutsBlock : TerraformBlock
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
/// Represents a aws_ram_resource_share_accepter Terraform resource.
/// Manages a aws_ram_resource_share_accepter resource.
/// </summary>
public partial class AwsRamResourceShareAccepter(string name) : TerraformResource("aws_ram_resource_share_accepter", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The share_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareArn is required")]
    public required TerraformValue<string> ShareArn
    {
        get => GetArgument<TerraformValue<string>>("share_arn");
        set => SetArgument("share_arn", value);
    }

    /// <summary>
    /// The invitation_arn attribute.
    /// </summary>
    public TerraformValue<string> InvitationArn
        => AsReference("invitation_arn");

    /// <summary>
    /// The receiver_account_id attribute.
    /// </summary>
    public TerraformValue<string> ReceiverAccountId
        => AsReference("receiver_account_id");

    /// <summary>
    /// The resources attribute.
    /// </summary>
    public TerraformList<string> Resources
        => AsReference("resources");

    /// <summary>
    /// The sender_account_id attribute.
    /// </summary>
    public TerraformValue<string> SenderAccountId
        => AsReference("sender_account_id");

    /// <summary>
    /// The share_id attribute.
    /// </summary>
    public TerraformValue<string> ShareId
        => AsReference("share_id");

    /// <summary>
    /// The share_name attribute.
    /// </summary>
    public TerraformValue<string> ShareName
        => AsReference("share_name");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRamResourceShareAccepterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRamResourceShareAccepterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
