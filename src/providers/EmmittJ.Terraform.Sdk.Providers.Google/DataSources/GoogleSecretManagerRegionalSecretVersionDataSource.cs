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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The is_secret_data_base64 attribute.
    /// </summary>
    [TerraformPropertyName("is_secret_data_base64")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IsSecretDataBase64 { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Location { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    [TerraformPropertyName("secret")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Secret { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Version { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The customer_managed_encryption attribute.
    /// </summary>
    [TerraformPropertyName("customer_managed_encryption")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CustomerManagedEncryption => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "customer_managed_encryption");

    /// <summary>
    /// The destroy_time attribute.
    /// </summary>
    [TerraformPropertyName("destroy_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DestroyTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "destroy_time");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Enabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enabled");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The secret_data attribute.
    /// </summary>
    [TerraformPropertyName("secret_data")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecretData => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secret_data");

}
