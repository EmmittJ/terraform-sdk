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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
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
    /// The share_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareArn is required")]
    public required TerraformValue<string> ShareArn
    {
        get => new TerraformReference<string>(this, "share_arn");
        set => SetArgument("share_arn", value);
    }

    /// <summary>
    /// The invitation_arn attribute.
    /// </summary>
    public TerraformValue<string> InvitationArn
    {
        get => new TerraformReference<string>(this, "invitation_arn");
    }

    /// <summary>
    /// The receiver_account_id attribute.
    /// </summary>
    public TerraformValue<string> ReceiverAccountId
    {
        get => new TerraformReference<string>(this, "receiver_account_id");
    }

    /// <summary>
    /// The resources attribute.
    /// </summary>
    public TerraformList<string> Resources
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "resources").ResolveNodes(ctx));
    }

    /// <summary>
    /// The sender_account_id attribute.
    /// </summary>
    public TerraformValue<string> SenderAccountId
    {
        get => new TerraformReference<string>(this, "sender_account_id");
    }

    /// <summary>
    /// The share_id attribute.
    /// </summary>
    public TerraformValue<string> ShareId
    {
        get => new TerraformReference<string>(this, "share_id");
    }

    /// <summary>
    /// The share_name attribute.
    /// </summary>
    public TerraformValue<string> ShareName
    {
        get => new TerraformReference<string>(this, "share_name");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRamResourceShareAccepterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRamResourceShareAccepterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
