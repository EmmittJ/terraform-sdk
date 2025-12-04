using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsMacie2InvitationAccepter.
/// Nesting mode: single
/// </summary>
public class AwsMacie2InvitationAccepterTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a aws_macie2_invitation_accepter Terraform resource.
/// Manages a aws_macie2_invitation_accepter resource.
/// </summary>
public partial class AwsMacie2InvitationAccepter(string name) : TerraformResource("aws_macie2_invitation_accepter", name)
{
    /// <summary>
    /// The administrator_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdministratorAccountId is required")]
    public required TerraformValue<string> AdministratorAccountId
    {
        get => GetRequiredArgument<TerraformValue<string>>("administrator_account_id");
        set => SetArgument("administrator_account_id", value);
    }

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
    /// The invitation_id attribute.
    /// </summary>
    public TerraformValue<string> InvitationId
        => AsReference("invitation_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsMacie2InvitationAccepterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsMacie2InvitationAccepterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
