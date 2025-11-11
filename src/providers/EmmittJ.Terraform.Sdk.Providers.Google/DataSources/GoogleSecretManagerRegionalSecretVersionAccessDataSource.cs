using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_secret_manager_regional_secret_version_access.
/// </summary>
public partial class GoogleSecretManagerRegionalSecretVersionAccessDataSource : TerraformDataSource
{
    public GoogleSecretManagerRegionalSecretVersionAccessDataSource(string name) : base("google_secret_manager_regional_secret_version_access", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The is_secret_data_base64 attribute.
    /// </summary>
    [TerraformProperty("is_secret_data_base64")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IsSecretDataBase64 { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    [TerraformProperty("secret")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Secret { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Version { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The secret_data attribute.
    /// </summary>
    [TerraformProperty("secret_data")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecretData { get; }

}
