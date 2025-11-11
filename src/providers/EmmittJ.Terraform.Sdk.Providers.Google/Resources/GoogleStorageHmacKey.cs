using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleStorageHmacKeyTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_storage_hmac_key resource.
/// </summary>
public partial class GoogleStorageHmacKey : TerraformResource
{
    public GoogleStorageHmacKey(string name) : base("google_storage_hmac_key", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The email address of the key&#39;s associated service account.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccountEmail is required")]
    [TerraformProperty("service_account_email")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServiceAccountEmail { get; set; }

    /// <summary>
    /// The state of the key. Can be set to one of ACTIVE, INACTIVE. Default value: &amp;quot;ACTIVE&amp;quot; Possible values: [&amp;quot;ACTIVE&amp;quot;, &amp;quot;INACTIVE&amp;quot;]
    /// </summary>
    [TerraformProperty("state")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? State { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleStorageHmacKeyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The access ID of the HMAC Key.
    /// </summary>
    [TerraformProperty("access_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AccessId { get; }

    /// <summary>
    /// HMAC secret key material.
    /// </summary>
    [TerraformProperty("secret")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Secret { get; }

    /// <summary>
    /// &#39;The creation time of the HMAC key in RFC 3339 format. &#39;
    /// </summary>
    [TerraformProperty("time_created")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TimeCreated { get; }

    /// <summary>
    /// &#39;The last modification time of the HMAC key metadata in RFC 3339 format.&#39;
    /// </summary>
    [TerraformProperty("updated")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Updated { get; }

}
