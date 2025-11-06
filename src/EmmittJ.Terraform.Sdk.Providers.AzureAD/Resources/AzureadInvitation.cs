using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Manages a azuread_invitation resource.
/// </summary>
public class AzureadInvitation : TerraformResource
{
    public AzureadInvitation(string name) : base("azuread_invitation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("redeem_url");
        this.DeclareOutput("user_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The URL that the user should be redirected to once the invitation is redeemed
    /// </summary>
    public string? RedirectUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("redirect_url")?.Value;
        set => this.WithProperty("redirect_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display name of the user being invited
    /// </summary>
    public string? UserDisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_display_name")?.Value;
        set => this.WithProperty("user_display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The email address of the user being invited
    /// </summary>
    public string? UserEmailAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_email_address")?.Value;
        set => this.WithProperty("user_email_address", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user type of the user being invited
    /// </summary>
    public string? UserType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_type")?.Value;
        set => this.WithProperty("user_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
