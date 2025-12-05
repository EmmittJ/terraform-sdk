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
        get => GetArgument<TerraformSet<string>>("delegates");
        set => SetArgument("delegates", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The lifetime attribute.
    /// </summary>
    public TerraformValue<string>? Lifetime
    {
        get => GetArgument<TerraformValue<string>>("lifetime");
        set => SetArgument("lifetime", value);
    }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    public required TerraformSet<string> Scopes
    {
        get => GetRequiredArgument<TerraformSet<string>>("scopes");
        set => SetArgument("scopes", value);
    }

    /// <summary>
    /// The target_service_account attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetServiceAccount is required")]
    public required TerraformValue<string> TargetServiceAccount
    {
        get => GetRequiredArgument<TerraformValue<string>>("target_service_account");
        set => SetArgument("target_service_account", value);
    }

    /// <summary>
    /// The access_token attribute.
    /// </summary>
    public TerraformValue<string> AccessToken
        => CreateReference("access_token");

}
