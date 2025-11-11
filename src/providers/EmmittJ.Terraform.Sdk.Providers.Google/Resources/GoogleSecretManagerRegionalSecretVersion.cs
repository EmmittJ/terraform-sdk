using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleSecretManagerRegionalSecretVersionTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_secret_manager_regional_secret_version resource.
/// </summary>
public partial class GoogleSecretManagerRegionalSecretVersion : TerraformResource
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
    [TerraformProperty("deletion_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DeletionPolicy { get; set; }

    /// <summary>
    /// The current state of the regional secret version.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// If set to &#39;true&#39;, the secret data is expected to be base64-encoded string and would be sent as is.
    /// </summary>
    [TerraformProperty("is_secret_data_base64")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IsSecretDataBase64 { get; set; }

    /// <summary>
    /// Secret Manager regional secret resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    [TerraformProperty("secret")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Secret { get; set; }

    /// <summary>
    /// The secret data. Must be no larger than 64KiB.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretData is required")]
    [TerraformProperty("secret_data")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SecretData { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleSecretManagerRegionalSecretVersionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The time at which the regional secret version was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The customer-managed encryption configuration of the regional secret.
    /// </summary>
    [TerraformProperty("customer_managed_encryption")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> CustomerManagedEncryption { get; }

    /// <summary>
    /// The time at which the regional secret version was destroyed. Only present if state is DESTROYED.
    /// </summary>
    [TerraformProperty("destroy_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DestroyTime { get; }

    /// <summary>
    /// Location of Secret Manager regional secret resource.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The resource name of the regional secret version. Format:
    /// &#39;projects/{{project}}/locations/{{location}}/secrets/{{secret_id}}/versions/{{version}}&#39;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The version of the Regional Secret.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Version { get; }

}
