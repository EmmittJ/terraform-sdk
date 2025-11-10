using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for message in .
/// Nesting mode: list
/// </summary>
public class AzureadInvitationMessageBlock : ITerraformBlock
{
    /// <summary>
    /// Email addresses of additional recipients the invitation message should be sent to
    /// </summary>
    [TerraformPropertyName("additional_recipients")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Customized message body you want to send if you don&#39;t want to send the default message
    /// </summary>
    [TerraformPropertyName("body")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Body { get; set; }

    /// <summary>
    /// The language you want to send the default message in
    /// </summary>
    [TerraformPropertyName("language")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Language { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadInvitationTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The URL that the user should be redirected to once the invitation is redeemed
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedirectUrl is required")]
    [TerraformPropertyName("redirect_url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RedirectUrl { get; set; }

    /// <summary>
    /// The display name of the user being invited
    /// </summary>
    [TerraformPropertyName("user_display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserDisplayName { get; set; }

    /// <summary>
    /// The email address of the user being invited
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserEmailAddress is required")]
    [TerraformPropertyName("user_email_address")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> UserEmailAddress { get; set; }

    /// <summary>
    /// The user type of the user being invited
    /// </summary>
    [TerraformPropertyName("user_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserType { get; set; }

    /// <summary>
    /// Block for message.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Message block(s) allowed")]
    [TerraformPropertyName("message")]
    public TerraformList<TerraformBlock<AzureadInvitationMessageBlock>>? Message { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadInvitationTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The URL the user can use to redeem their invitation
    /// </summary>
    [TerraformPropertyName("redeem_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RedeemUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "redeem_url");

    /// <summary>
    /// Object ID of the invited user
    /// </summary>
    [TerraformPropertyName("user_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UserId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_id");

}
