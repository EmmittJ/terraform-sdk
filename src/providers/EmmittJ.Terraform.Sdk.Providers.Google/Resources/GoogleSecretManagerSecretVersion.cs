using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSecretManagerSecretVersionTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_secret_manager_secret_version resource.
/// </summary>
public class GoogleSecretManagerSecretVersion : TerraformResource
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
    [TerraformPropertyName("deletion_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeletionPolicy { get; set; }

    /// <summary>
    /// The current state of the SecretVersion.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// If set to &#39;true&#39;, the secret data is expected to be base64-encoded string and would be sent as is.
    /// </summary>
    [TerraformPropertyName("is_secret_data_base64")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IsSecretDataBase64 { get; set; }

    /// <summary>
    /// Secret Manager secret resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    [TerraformPropertyName("secret")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Secret { get; set; }

    /// <summary>
    /// The secret data. Must be no larger than 64KiB.
    /// </summary>
    [TerraformPropertyName("secret_data")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SecretData { get; set; }

    /// <summary>
    /// The secret data. Must be no larger than 64KiB. For more info see [updating write-only attributes](/docs/providers/google/guides/using_write_only_attributes.html#updating-write-only-attributes)
    /// </summary>
    [TerraformPropertyName("secret_data_wo")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SecretDataWo { get; set; }

    /// <summary>
    /// Triggers update of secret data write-only. For more info see [updating write-only attributes](/docs/providers/google/guides/using_write_only_attributes.html#updating-write-only-attributes)
    /// </summary>
    [TerraformPropertyName("secret_data_wo_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? SecretDataWoVersion { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleSecretManagerSecretVersionTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The time at which the Secret was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The time at which the Secret was destroyed. Only present if state is DESTROYED.
    /// </summary>
    [TerraformPropertyName("destroy_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DestroyTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "destroy_time");

    /// <summary>
    /// The resource name of the SecretVersion. Format:
    /// &#39;projects/{{project}}/secrets/{{secret_id}}/versions/{{version}}&#39;
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The version of the Secret.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Version => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

}
