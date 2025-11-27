using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_service_account_access_token Terraform data source.
/// Retrieves information about a google_service_account_access_token.
/// </summary>
public partial class GoogleServiceAccountAccessTokenDataSource(string name) : TerraformDataSource("google_service_account_access_token", name)
{
    /// <summary>
    /// The delegates attribute.
    /// </summary>
    public TerraformSet<string>? Delegates
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "delegates").ResolveNodes(ctx));
        set => SetArgument("delegates", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The lifetime attribute.
    /// </summary>
    public TerraformValue<string>? Lifetime
    {
        get => new TerraformReference<string>(this, "lifetime");
        set => SetArgument("lifetime", value);
    }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    public required TerraformSet<string> Scopes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "scopes").ResolveNodes(ctx));
        set => SetArgument("scopes", value);
    }

    /// <summary>
    /// The target_service_account attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetServiceAccount is required")]
    public required TerraformValue<string> TargetServiceAccount
    {
        get => new TerraformReference<string>(this, "target_service_account");
        set => SetArgument("target_service_account", value);
    }

    /// <summary>
    /// The access_token attribute.
    /// </summary>
    public TerraformValue<string> AccessToken
    {
        get => new TerraformReference<string>(this, "access_token");
    }

}
