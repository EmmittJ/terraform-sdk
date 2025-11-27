using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_service_account_id_token Terraform data source.
/// Retrieves information about a google_service_account_id_token.
/// </summary>
public partial class GoogleServiceAccountIdTokenDataSource(string name) : TerraformDataSource("google_service_account_id_token", name)
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
    /// The include_email attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeEmail
    {
        get => new TerraformReference<bool>(this, "include_email");
        set => SetArgument("include_email", value);
    }

    /// <summary>
    /// The target_audience attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetAudience is required")]
    public required TerraformValue<string> TargetAudience
    {
        get => new TerraformReference<string>(this, "target_audience");
        set => SetArgument("target_audience", value);
    }

    /// <summary>
    /// The target_service_account attribute.
    /// </summary>
    public TerraformValue<string>? TargetServiceAccount
    {
        get => new TerraformReference<string>(this, "target_service_account");
        set => SetArgument("target_service_account", value);
    }

    /// <summary>
    /// The id_token attribute.
    /// </summary>
    public TerraformValue<string> IdToken
    {
        get => new TerraformReference<string>(this, "id_token");
    }

}
