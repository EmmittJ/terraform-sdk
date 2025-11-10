using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleStorageHmacKeyTimeoutsBlock : ITerraformBlock
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
/// Manages a google_storage_hmac_key resource.
/// </summary>
public class GoogleStorageHmacKey : TerraformResource
{
    public GoogleStorageHmacKey(string name) : base("google_storage_hmac_key", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The email address of the key&#39;s associated service account.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccountEmail is required")]
    [TerraformPropertyName("service_account_email")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServiceAccountEmail { get; set; }

    /// <summary>
    /// The state of the key. Can be set to one of ACTIVE, INACTIVE. Default value: &amp;quot;ACTIVE&amp;quot; Possible values: [&amp;quot;ACTIVE&amp;quot;, &amp;quot;INACTIVE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? State { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleStorageHmacKeyTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The access ID of the HMAC Key.
    /// </summary>
    [TerraformPropertyName("access_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AccessId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "access_id");

    /// <summary>
    /// HMAC secret key material.
    /// </summary>
    [TerraformPropertyName("secret")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Secret => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secret");

    /// <summary>
    /// &#39;The creation time of the HMAC key in RFC 3339 format. &#39;
    /// </summary>
    [TerraformPropertyName("time_created")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeCreated => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_created");

    /// <summary>
    /// &#39;The last modification time of the HMAC key metadata in RFC 3339 format.&#39;
    /// </summary>
    [TerraformPropertyName("updated")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Updated => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "updated");

}
