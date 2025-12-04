using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for message in AzureadInvitation.
/// Nesting mode: list
/// </summary>
public class AzureadInvitationMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "message";

    /// <summary>
    /// Email addresses of additional recipients the invitation message should be sent to
    /// </summary>
    public TerraformList<string>? AdditionalRecipients
    {
        get => GetArgument<TerraformList<string>>("additional_recipients");
        set => SetArgument("additional_recipients", value);
    }

    /// <summary>
    /// Customized message body you want to send if you don&#39;t want to send the default message
    /// </summary>
    public TerraformValue<string>? Body
    {
        get => GetArgument<TerraformValue<string>>("body");
        set => SetArgument("body", value);
    }

    /// <summary>
    /// The language you want to send the default message in
    /// </summary>
    public TerraformValue<string>? Language
    {
        get => GetArgument<TerraformValue<string>>("language");
        set => SetArgument("language", value);
    }

}


/// <summary>
/// Block type for timeouts in AzureadInvitation.
/// Nesting mode: single
/// </summary>
public class AzureadInvitationTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azuread_invitation Terraform resource.
/// Manages a azuread_invitation resource.
/// </summary>
public partial class AzureadInvitation(string name) : TerraformResource("azuread_invitation", name)
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
    /// The URL that the user should be redirected to once the invitation is redeemed
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedirectUrl is required")]
    public required TerraformValue<string> RedirectUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("redirect_url");
        set => SetArgument("redirect_url", value);
    }

    /// <summary>
    /// The display name of the user being invited
    /// </summary>
    public TerraformValue<string>? UserDisplayName
    {
        get => GetArgument<TerraformValue<string>>("user_display_name");
        set => SetArgument("user_display_name", value);
    }

    /// <summary>
    /// The email address of the user being invited
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserEmailAddress is required")]
    public required TerraformValue<string> UserEmailAddress
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_email_address");
        set => SetArgument("user_email_address", value);
    }

    /// <summary>
    /// The user type of the user being invited
    /// </summary>
    public TerraformValue<string>? UserType
    {
        get => GetArgument<TerraformValue<string>>("user_type");
        set => SetArgument("user_type", value);
    }

    /// <summary>
    /// The URL the user can use to redeem their invitation
    /// </summary>
    public TerraformValue<string> RedeemUrl
        => AsReference("redeem_url");

    /// <summary>
    /// Object ID of the invited user
    /// </summary>
    public TerraformValue<string> UserId
        => AsReference("user_id");

    /// <summary>
    /// Message block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Message block(s) allowed")]
    public TerraformList<AzureadInvitationMessageBlock>? Message
    {
        get => GetArgument<TerraformList<AzureadInvitationMessageBlock>>("message");
        set => SetArgument("message", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadInvitationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadInvitationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
