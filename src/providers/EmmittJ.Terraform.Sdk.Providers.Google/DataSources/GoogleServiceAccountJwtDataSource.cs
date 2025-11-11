using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_service_account_jwt.
/// </summary>
public class GoogleServiceAccountJwtDataSource : TerraformDataSource
{
    public GoogleServiceAccountJwtDataSource(string name) : base("google_service_account_jwt", name)
    {
    }

    /// <summary>
    /// The delegates attribute.
    /// </summary>
    [TerraformPropertyName("delegates")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Delegates { get; set; }

    /// <summary>
    /// Number of seconds until the JWT expires. If set and non-zero an `exp` claim will be added to the payload derived from the current timestamp plus expires_in seconds.
    /// </summary>
    [TerraformPropertyName("expires_in")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ExpiresIn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// A JSON-encoded JWT claims set that will be included in the signed JWT.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Payload is required")]
    [TerraformPropertyName("payload")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Payload { get; set; }

    /// <summary>
    /// The target_service_account attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetServiceAccount is required")]
    [TerraformPropertyName("target_service_account")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TargetServiceAccount { get; set; }

    /// <summary>
    /// The jwt attribute.
    /// </summary>
    [TerraformPropertyName("jwt")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Jwt => new TerraformReference(this, "jwt");

}
