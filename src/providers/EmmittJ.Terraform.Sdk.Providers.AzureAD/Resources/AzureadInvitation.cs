using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for message in .
/// Nesting mode: list
/// </summary>
public partial class AzureadInvitationMessageBlock() : TerraformBlock("message")
{
    /// <summary>
    /// Email addresses of additional recipients the invitation message should be sent to
    /// </summary>
    [TerraformProperty("additional_recipients")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Customized message body you want to send if you don&#39;t want to send the default message
    /// </summary>
    [TerraformProperty("body")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Body { get; set; }

    /// <summary>
    /// The language you want to send the default message in
    /// </summary>
    [TerraformProperty("language")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Language { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadInvitationTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a azuread_invitation resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzureadInvitation : TerraformResource
{
    public AzureadInvitation(string name) : base("azuread_invitation", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The URL that the user should be redirected to once the invitation is redeemed
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedirectUrl is required")]
    [TerraformProperty("redirect_url")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RedirectUrl { get; set; }

    /// <summary>
    /// The display name of the user being invited
    /// </summary>
    [TerraformProperty("user_display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserDisplayName { get; set; }

    /// <summary>
    /// The email address of the user being invited
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserEmailAddress is required")]
    [TerraformProperty("user_email_address")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> UserEmailAddress { get; set; }

    /// <summary>
    /// The user type of the user being invited
    /// </summary>
    [TerraformProperty("user_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserType { get; set; }

    /// <summary>
    /// Block for message.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Message block(s) allowed")]
    [TerraformProperty("message")]
    public TerraformList<AzureadInvitationMessageBlock> Message { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzureadInvitationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The URL the user can use to redeem their invitation
    /// </summary>
    [TerraformProperty("redeem_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RedeemUrl { get; }

    /// <summary>
    /// Object ID of the invited user
    /// </summary>
    [TerraformProperty("user_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UserId { get; }

}
