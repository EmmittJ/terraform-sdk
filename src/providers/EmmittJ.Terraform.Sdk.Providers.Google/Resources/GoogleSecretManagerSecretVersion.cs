using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleSecretManagerSecretVersionTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_secret_manager_secret_version resource.
/// </summary>
public partial class GoogleSecretManagerSecretVersion : TerraformResource
{
    public GoogleSecretManagerSecretVersion(string name) : base("google_secret_manager_secret_version", name)
    {
    }

    /// <summary>
    /// The deletion policy for the secret version. Setting &#39;ABANDON&#39; allows the resource
    /// to be abandoned rather than deleted. Setting &#39;DISABLE&#39; allows the resource to be
    /// disabled rather than deleted. Default is &#39;DELETE&#39;. Possible values are:
    ///   * DELETE
    ///   * DISABLE
    ///   * ABANDON
    /// </summary>
    [TerraformProperty("deletion_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeletionPolicy { get; set; }

    /// <summary>
    /// The current state of the SecretVersion.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// If set to &#39;true&#39;, the secret data is expected to be base64-encoded string and would be sent as is.
    /// </summary>
    [TerraformProperty("is_secret_data_base64")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IsSecretDataBase64 { get; set; }

    /// <summary>
    /// Secret Manager secret resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    [TerraformProperty("secret")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Secret { get; set; }

    /// <summary>
    /// The secret data. Must be no larger than 64KiB.
    /// </summary>
    [TerraformProperty("secret_data")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecretData { get; set; }

    /// <summary>
    /// The secret data. Must be no larger than 64KiB. For more info see [updating write-only attributes](/docs/providers/google/guides/using_write_only_attributes.html#updating-write-only-attributes)
    /// </summary>
    [TerraformProperty("secret_data_wo")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecretDataWo { get; set; }

    /// <summary>
    /// Triggers update of secret data write-only. For more info see [updating write-only attributes](/docs/providers/google/guides/using_write_only_attributes.html#updating-write-only-attributes)
    /// </summary>
    [TerraformProperty("secret_data_wo_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SecretDataWoVersion { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleSecretManagerSecretVersionTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The time at which the Secret was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The time at which the Secret was destroyed. Only present if state is DESTROYED.
    /// </summary>
    [TerraformProperty("destroy_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DestroyTime { get; }

    /// <summary>
    /// The resource name of the SecretVersion. Format:
    /// &#39;projects/{{project}}/secrets/{{secret_id}}/versions/{{version}}&#39;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The version of the Secret.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Version { get; }

}
