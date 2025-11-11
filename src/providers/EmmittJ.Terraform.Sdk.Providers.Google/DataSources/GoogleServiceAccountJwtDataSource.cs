using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_service_account_jwt.
/// </summary>
public partial class GoogleServiceAccountJwtDataSource : TerraformDataSource
{
    public GoogleServiceAccountJwtDataSource(string name) : base("google_service_account_jwt", name)
    {
    }

    /// <summary>
    /// The delegates attribute.
    /// </summary>
    [TerraformProperty("delegates")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Delegates { get; set; }

    /// <summary>
    /// Number of seconds until the JWT expires. If set and non-zero an `exp` claim will be added to the payload derived from the current timestamp plus expires_in seconds.
    /// </summary>
    [TerraformProperty("expires_in")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ExpiresIn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// A JSON-encoded JWT claims set that will be included in the signed JWT.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Payload is required")]
    [TerraformProperty("payload")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Payload { get; set; }

    /// <summary>
    /// The target_service_account attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetServiceAccount is required")]
    [TerraformProperty("target_service_account")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TargetServiceAccount { get; set; }

    /// <summary>
    /// The jwt attribute.
    /// </summary>
    [TerraformProperty("jwt")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Jwt { get; }

}
