using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_secret_manager_regional_secret_version.
/// </summary>
public partial class GoogleSecretManagerRegionalSecretVersionDataSource : TerraformDataSource
{
    public GoogleSecretManagerRegionalSecretVersionDataSource(string name) : base("google_secret_manager_regional_secret_version", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The is_secret_data_base64 attribute.
    /// </summary>
    [TerraformProperty("is_secret_data_base64")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IsSecretDataBase64 { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    [TerraformProperty("secret")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Secret { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Version { get; set; }

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The customer_managed_encryption attribute.
    /// </summary>
    [TerraformProperty("customer_managed_encryption")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> CustomerManagedEncryption { get; }

    /// <summary>
    /// The destroy_time attribute.
    /// </summary>
    [TerraformProperty("destroy_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DestroyTime { get; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Enabled { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The secret_data attribute.
    /// </summary>
    [TerraformProperty("secret_data")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecretData { get; }

}
