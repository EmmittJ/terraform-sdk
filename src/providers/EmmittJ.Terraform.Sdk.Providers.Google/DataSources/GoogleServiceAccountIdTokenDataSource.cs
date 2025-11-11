using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_service_account_id_token.
/// </summary>
public class GoogleServiceAccountIdTokenDataSource : TerraformDataSource
{
    public GoogleServiceAccountIdTokenDataSource(string name) : base("google_service_account_id_token", name)
    {
    }

    /// <summary>
    /// The delegates attribute.
    /// </summary>
    [TerraformPropertyName("delegates")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Delegates { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The include_email attribute.
    /// </summary>
    [TerraformPropertyName("include_email")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeEmail { get; set; }

    /// <summary>
    /// The target_audience attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetAudience is required")]
    [TerraformPropertyName("target_audience")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TargetAudience { get; set; }

    /// <summary>
    /// The target_service_account attribute.
    /// </summary>
    [TerraformPropertyName("target_service_account")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetServiceAccount { get; set; }

    /// <summary>
    /// The id_token attribute.
    /// </summary>
    [TerraformPropertyName("id_token")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IdToken => new TerraformReference(this, "id_token");

}
