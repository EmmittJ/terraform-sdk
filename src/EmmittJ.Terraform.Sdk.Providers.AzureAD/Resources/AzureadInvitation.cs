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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The URL that the user should be redirected to once the invitation is redeemed
    /// </summary>
    public TerraformLiteralProperty<string>? RedirectUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("redirect_url");
        set => this.WithProperty("redirect_url", value);
    }

    /// <summary>
    /// The display name of the user being invited
    /// </summary>
    public TerraformLiteralProperty<string>? UserDisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_display_name");
        set => this.WithProperty("user_display_name", value);
    }

    /// <summary>
    /// The email address of the user being invited
    /// </summary>
    public TerraformLiteralProperty<string>? UserEmailAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_email_address");
        set => this.WithProperty("user_email_address", value);
    }

    /// <summary>
    /// The user type of the user being invited
    /// </summary>
    public TerraformLiteralProperty<string>? UserType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_type");
        set => this.WithProperty("user_type", value);
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
