using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for message in .
/// Nesting mode: list
/// </summary>
public class AzureadInvitationMessageBlock
{
    /// <summary>
    /// Email addresses of additional recipients the invitation message should be sent to
    /// </summary>
    [TerraformPropertyName("additional_recipients")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Customized message body you want to send if you don&#39;t want to send the default message
    /// </summary>
    [TerraformPropertyName("body")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Body { get; set; }

    /// <summary>
    /// The language you want to send the default message in
    /// </summary>
    [TerraformPropertyName("language")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Language { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadInvitationTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a azuread_invitation resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzureadInvitation : TerraformResource
{
    public AzureadInvitation(string name) : base("azuread_invitation", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The URL that the user should be redirected to once the invitation is redeemed
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedirectUrl is required")]
    [TerraformPropertyName("redirect_url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RedirectUrl { get; set; }

    /// <summary>
    /// The display name of the user being invited
    /// </summary>
    [TerraformPropertyName("user_display_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UserDisplayName { get; set; }

    /// <summary>
    /// The email address of the user being invited
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserEmailAddress is required")]
    [TerraformPropertyName("user_email_address")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> UserEmailAddress { get; set; }

    /// <summary>
    /// The user type of the user being invited
    /// </summary>
    [TerraformPropertyName("user_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UserType { get; set; }

    /// <summary>
    /// Block for message.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Message block(s) allowed")]
    [TerraformPropertyName("message")]
    public TerraformList<TerraformBlock<AzureadInvitationMessageBlock>>? Message { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadInvitationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The URL the user can use to redeem their invitation
    /// </summary>
    [TerraformPropertyName("redeem_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RedeemUrl => new TerraformReference(this, "redeem_url");

    /// <summary>
    /// Object ID of the invited user
    /// </summary>
    [TerraformPropertyName("user_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UserId => new TerraformReference(this, "user_id");

}
