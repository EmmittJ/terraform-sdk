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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The URL that the user should be redirected to once the invitation is redeemed
    /// </summary>
    public TerraformProperty<string>? RedirectUrl
    {
        get => GetProperty<TerraformProperty<string>>("redirect_url");
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
    public TerraformProperty<string>? UserEmailAddress
    {
        get => GetProperty<TerraformProperty<string>>("user_email_address");
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
    /// The URL the user can use to redeem their invitation
    /// </summary>
    public TerraformExpression RedeemUrl => this["redeem_url"];

    /// <summary>
    /// Object ID of the invited user
    /// </summary>
    public TerraformExpression UserId => this["user_id"];

}
