using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_service_account_id_token.
/// </summary>
public partial class GoogleServiceAccountIdTokenDataSource : TerraformDataSource
{
    public GoogleServiceAccountIdTokenDataSource(string name) : base("google_service_account_id_token", name)
    {
    }

    /// <summary>
    /// The delegates attribute.
    /// </summary>
    [TerraformProperty("delegates")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Delegates { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The include_email attribute.
    /// </summary>
    [TerraformProperty("include_email")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeEmail { get; set; }

    /// <summary>
    /// The target_audience attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetAudience is required")]
    [TerraformProperty("target_audience")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetAudience { get; set; }

    /// <summary>
    /// The target_service_account attribute.
    /// </summary>
    [TerraformProperty("target_service_account")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetServiceAccount { get; set; }

    /// <summary>
    /// The id_token attribute.
    /// </summary>
    [TerraformProperty("id_token")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IdToken { get; }

}
