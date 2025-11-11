using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_service_account_key.
/// </summary>
public partial class GoogleServiceAccountKeyDataSource : TerraformDataSource
{
    public GoogleServiceAccountKeyDataSource(string name) : base("google_service_account_key", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public_key_type attribute.
    /// </summary>
    [TerraformProperty("public_key_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PublicKeyType { get; set; }

    /// <summary>
    /// The key_algorithm attribute.
    /// </summary>
    [TerraformProperty("key_algorithm")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KeyAlgorithm { get; }

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [TerraformProperty("public_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PublicKey { get; }

}
