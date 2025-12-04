using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsGuarddutyInviteAccepter.
/// Nesting mode: single
/// </summary>
public class AwsGuarddutyInviteAccepterTimeoutsBlock : TerraformBlock
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
/// Represents a aws_guardduty_invite_accepter Terraform resource.
/// Manages a aws_guardduty_invite_accepter resource.
/// </summary>
public partial class AwsGuarddutyInviteAccepter(string name) : TerraformResource("aws_guardduty_invite_accepter", name)
{
    /// <summary>
    /// The detector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DetectorId is required")]
    public required TerraformValue<string> DetectorId
    {
        get => GetRequiredArgument<TerraformValue<string>>("detector_id");
        set => SetArgument("detector_id", value);
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
    /// The master_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MasterAccountId is required")]
    public required TerraformValue<string> MasterAccountId
    {
        get => GetRequiredArgument<TerraformValue<string>>("master_account_id");
        set => SetArgument("master_account_id", value);
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsGuarddutyInviteAccepterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsGuarddutyInviteAccepterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
