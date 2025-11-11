using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSecretManagerRegionalSecretVersionTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_secret_manager_regional_secret_version resource.
/// </summary>
public class GoogleSecretManagerRegionalSecretVersion : TerraformResource
{
    public GoogleSecretManagerRegionalSecretVersion(string name) : base("google_secret_manager_regional_secret_version", name)
    {
    }

    /// <summary>
    /// The deletion policy for the regional secret version. Setting &#39;ABANDON&#39; allows the resource
    /// to be abandoned rather than deleted. Setting &#39;DISABLE&#39; allows the resource to be
    /// disabled rather than deleted. Default is &#39;DELETE&#39;. Possible values are:
    ///   * DELETE
    ///   * DISABLE
    ///   * ABANDON
    /// </summary>
    [TerraformPropertyName("deletion_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DeletionPolicy { get; set; }

    /// <summary>
    /// The current state of the regional secret version.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// If set to &#39;true&#39;, the secret data is expected to be base64-encoded string and would be sent as is.
    /// </summary>
    [TerraformPropertyName("is_secret_data_base64")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IsSecretDataBase64 { get; set; }

    /// <summary>
    /// Secret Manager regional secret resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    [TerraformPropertyName("secret")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Secret { get; set; }

    /// <summary>
    /// The secret data. Must be no larger than 64KiB.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretData is required")]
    [TerraformPropertyName("secret_data")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SecretData { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleSecretManagerRegionalSecretVersionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The time at which the regional secret version was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// The customer-managed encryption configuration of the regional secret.
    /// </summary>
    [TerraformPropertyName("customer_managed_encryption")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CustomerManagedEncryption => new TerraformReference(this, "customer_managed_encryption");

    /// <summary>
    /// The time at which the regional secret version was destroyed. Only present if state is DESTROYED.
    /// </summary>
    [TerraformPropertyName("destroy_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DestroyTime => new TerraformReference(this, "destroy_time");

    /// <summary>
    /// Location of Secret Manager regional secret resource.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The resource name of the regional secret version. Format:
    /// &#39;projects/{{project}}/locations/{{location}}/secrets/{{secret_id}}/versions/{{version}}&#39;
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The version of the Regional Secret.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Version => new TerraformReference(this, "version");

}
