using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleStorageAnywhereCacheTimeoutsBlock : ITerraformBlock
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
/// Manages a google_storage_anywhere_cache resource.
/// </summary>
public class GoogleStorageAnywhereCache : TerraformResource
{
    public GoogleStorageAnywhereCache(string name) : base("google_storage_anywhere_cache", name)
    {
    }

    /// <summary>
    /// The cache admission policy dictates whether a block should be inserted upon a cache miss. Default value: &amp;quot;admit-on-first-miss&amp;quot; Possible values: [&amp;quot;admit-on-first-miss&amp;quot;, &amp;quot;admit-on-second-miss&amp;quot;]
    /// </summary>
    [TerraformPropertyName("admission_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AdmissionPolicy { get; set; }

    /// <summary>
    /// A reference to Bucket resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Bucket { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The TTL of all cache entries in whole seconds. e.g., &amp;quot;7200s&amp;quot;. It defaults to &#39;86400s&#39;
    /// </summary>
    [TerraformPropertyName("ttl")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Ttl { get; set; }

    /// <summary>
    /// The zone in which the cache instance needs to be created. For example, &#39;us-central1-a.&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zone is required")]
    [TerraformPropertyName("zone")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Zone { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleStorageAnywhereCacheTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The ID of the Anywhere cache instance.
    /// </summary>
    [TerraformPropertyName("anywhere_cache_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AnywhereCacheId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "anywhere_cache_id");

    /// <summary>
    /// The creation time of the cache instance in RFC 3339 format.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// True if the cache instance has an active Update long-running operation.
    /// </summary>
    [TerraformPropertyName("pending_update")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PendingUpdate => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "pending_update");

    /// <summary>
    /// The current state of the cache instance.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The modification time of the cache instance metadata in RFC 3339 format.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
