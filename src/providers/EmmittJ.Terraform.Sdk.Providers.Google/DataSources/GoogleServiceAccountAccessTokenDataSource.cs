using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_service_account_access_token.
/// </summary>
public partial class GoogleServiceAccountAccessTokenDataSource : TerraformDataSource
{
    public GoogleServiceAccountAccessTokenDataSource(string name) : base("google_service_account_access_token", name)
    {
    }

    /// <summary>
    /// The delegates attribute.
    /// </summary>
    [TerraformProperty("delegates")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Delegates { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The lifetime attribute.
    /// </summary>
    [TerraformProperty("lifetime")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Lifetime { get; set; }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    [TerraformProperty("scopes")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Scopes { get; set; }

    /// <summary>
    /// The target_service_account attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetServiceAccount is required")]
    [TerraformProperty("target_service_account")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TargetServiceAccount { get; set; }

    /// <summary>
    /// The access_token attribute.
    /// </summary>
    [TerraformProperty("access_token")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AccessToken { get; }

}
