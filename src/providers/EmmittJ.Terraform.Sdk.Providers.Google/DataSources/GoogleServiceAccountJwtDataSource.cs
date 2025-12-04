using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_service_account_jwt Terraform data source.
/// Retrieves information about a google_service_account_jwt.
/// </summary>
public partial class GoogleServiceAccountJwtDataSource(string name) : TerraformDataSource("google_service_account_jwt", name)
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
    /// Number of seconds until the JWT expires. If set and non-zero an `exp` claim will be added to the payload derived from the current timestamp plus expires_in seconds.
    /// </summary>
    public TerraformValue<double>? ExpiresIn
    {
        get => GetArgument<TerraformValue<double>>("expires_in");
        set => SetArgument("expires_in", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// A JSON-encoded JWT claims set that will be included in the signed JWT.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Payload is required")]
    public required TerraformValue<string> Payload
    {
        get => GetRequiredArgument<TerraformValue<string>>("payload");
        set => SetArgument("payload", value);
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
    /// The jwt attribute.
    /// </summary>
    public TerraformValue<string> Jwt
        => AsReference("jwt");

}
