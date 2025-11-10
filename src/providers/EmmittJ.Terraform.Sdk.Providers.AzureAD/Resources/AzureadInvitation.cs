using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for message in .
/// Nesting mode: list
/// </summary>
public class AzureadInvitationMessageBlock : TerraformBlock
{
    /// <summary>
    /// Email addresses of additional recipients the invitation message should be sent to
    /// </summary>
    public List<TerraformProperty<string>>? AdditionalRecipients
    {
        set => SetProperty("additional_recipients", value);
    }

    /// <summary>
    /// Customized message body you want to send if you don&#39;t want to send the default message
    /// </summary>
    public TerraformProperty<string>? Body
    {
        set => SetProperty("body", value);
    }

    /// <summary>
    /// The language you want to send the default message in
    /// </summary>
    public TerraformProperty<string>? Language
    {
        set => SetProperty("language", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadInvitationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Manages a azuread_invitation resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzureadInvitation : TerraformResource
{
    public AzureadInvitation(string name) : base("azuread_invitation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("redeem_url");
        SetOutput("user_id");
        SetOutput("id");
        SetOutput("redirect_url");
        SetOutput("user_display_name");
        SetOutput("user_email_address");
        SetOutput("user_type");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The URL that the user should be redirected to once the invitation is redeemed
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedirectUrl is required")]
    public required TerraformProperty<string> RedirectUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("redirect_url");
        set => SetProperty("redirect_url", value);
    }

    /// <summary>
    /// The display name of the user being invited
    /// </summary>
    public TerraformProperty<string> UserDisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_display_name");
        set => SetProperty("user_display_name", value);
    }

    /// <summary>
    /// The email address of the user being invited
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserEmailAddress is required")]
    public required TerraformProperty<string> UserEmailAddress
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_email_address");
        set => SetProperty("user_email_address", value);
    }

    /// <summary>
    /// The user type of the user being invited
    /// </summary>
    public TerraformProperty<string> UserType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_type");
        set => SetProperty("user_type", value);
    }

    /// <summary>
    /// Block for message.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Message block(s) allowed")]
    public List<AzureadInvitationMessageBlock>? Message
    {
        set => SetProperty("message", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadInvitationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The URL the user can use to redeem their invitation
    /// </summary>
    public TerraformExpression RedeemUrl => this["redeem_url"];

    /// <summary>
    /// Object ID of the invited user
    /// </summary>
    public TerraformExpression UserId => this["user_id"];

}
