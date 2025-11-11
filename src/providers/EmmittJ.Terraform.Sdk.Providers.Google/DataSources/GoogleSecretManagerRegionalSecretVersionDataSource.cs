using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_secret_manager_regional_secret_version.
/// </summary>
public class GoogleSecretManagerRegionalSecretVersionDataSource : TerraformDataSource
{
    public GoogleSecretManagerRegionalSecretVersionDataSource(string name) : base("google_secret_manager_regional_secret_version", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The is_secret_data_base64 attribute.
    /// </summary>
    [TerraformPropertyName("is_secret_data_base64")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IsSecretDataBase64 { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Location { get; set; } = default!;

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    [TerraformPropertyName("secret")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Secret { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Version { get; set; } = default!;

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// The customer_managed_encryption attribute.
    /// </summary>
    [TerraformPropertyName("customer_managed_encryption")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CustomerManagedEncryption => new TerraformReference(this, "customer_managed_encryption");

    /// <summary>
    /// The destroy_time attribute.
    /// </summary>
    [TerraformPropertyName("destroy_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DestroyTime => new TerraformReference(this, "destroy_time");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Enabled => new TerraformReference(this, "enabled");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The secret_data attribute.
    /// </summary>
    [TerraformPropertyName("secret_data")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecretData => new TerraformReference(this, "secret_data");

}
