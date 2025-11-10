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
        get => GetProperty<List<TerraformProperty<string>>>("additional_recipients");
        set => WithProperty("additional_recipients", value);
    }

    /// <summary>
    /// Customized message body you want to send if you don&#39;t want to send the default message
    /// </summary>
    public TerraformProperty<string>? Body
    {
        get => GetProperty<TerraformProperty<string>>("body");
        set => WithProperty("body", value);
    }

    /// <summary>
    /// The language you want to send the default message in
    /// </summary>
    public TerraformProperty<string>? Language
    {
        get => GetProperty<TerraformProperty<string>>("language");
        set => WithProperty("language", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
        this.WithOutput("redeem_url");
        this.WithOutput("user_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The URL that the user should be redirected to once the invitation is redeemed
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedirectUrl is required")]
    public required TerraformProperty<string> RedirectUrl
    {
        get => GetRequiredProperty<TerraformProperty<string>>("redirect_url");
        set => this.WithProperty("redirect_url", value);
    }

    /// <summary>
    /// The display name of the user being invited
    /// </summary>
    public TerraformProperty<string>? UserDisplayName
    {
        get => GetProperty<TerraformProperty<string>>("user_display_name");
        set => this.WithProperty("user_display_name", value);
    }

    /// <summary>
    /// The email address of the user being invited
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserEmailAddress is required")]
    public required TerraformProperty<string> UserEmailAddress
    {
        get => GetRequiredProperty<TerraformProperty<string>>("user_email_address");
        set => this.WithProperty("user_email_address", value);
    }

    /// <summary>
    /// The user type of the user being invited
    /// </summary>
    public TerraformProperty<string>? UserType
    {
        get => GetProperty<TerraformProperty<string>>("user_type");
        set => this.WithProperty("user_type", value);
    }

    /// <summary>
    /// Block for message.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Message block(s) allowed")]
    public List<AzureadInvitationMessageBlock>? Message
    {
        get => GetProperty<List<AzureadInvitationMessageBlock>>("message");
        set => this.WithProperty("message", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadInvitationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadInvitationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
