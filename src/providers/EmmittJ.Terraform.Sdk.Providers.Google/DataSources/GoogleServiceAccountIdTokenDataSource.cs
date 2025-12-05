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
    /// The include_email attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeEmail
    {
        get => GetArgument<TerraformValue<bool>>("include_email");
        set => SetArgument("include_email", value);
    }

    /// <summary>
    /// The target_audience attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetAudience is required")]
    public required TerraformValue<string> TargetAudience
    {
        get => GetRequiredArgument<TerraformValue<string>>("target_audience");
        set => SetArgument("target_audience", value);
    }

    /// <summary>
    /// The target_service_account attribute.
    /// </summary>
    public TerraformValue<string>? TargetServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("target_service_account");
        set => SetArgument("target_service_account", value);
    }

    /// <summary>
    /// The id_token attribute.
    /// </summary>
    public TerraformValue<string> IdToken
        => CreateReference("id_token");

}
