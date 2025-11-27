using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleStorageAnywhereCache.
/// Nesting mode: single
/// </summary>
public class GoogleStorageAnywhereCacheTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_storage_anywhere_cache Terraform resource.
/// Manages a google_storage_anywhere_cache resource.
/// </summary>
public partial class GoogleStorageAnywhereCache(string name) : TerraformResource("google_storage_anywhere_cache", name)
{
    /// <summary>
    /// The cache admission policy dictates whether a block should be inserted upon a cache miss. Default value: &amp;quot;admit-on-first-miss&amp;quot; Possible values: [&amp;quot;admit-on-first-miss&amp;quot;, &amp;quot;admit-on-second-miss&amp;quot;]
    /// </summary>
    public TerraformValue<string>? AdmissionPolicy
    {
        get => new TerraformReference<string>(this, "admission_policy");
        set => SetArgument("admission_policy", value);
    }

    /// <summary>
    /// A reference to Bucket resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The TTL of all cache entries in whole seconds. e.g., &amp;quot;7200s&amp;quot;. It defaults to &#39;86400s&#39;
    /// </summary>
    public TerraformValue<string>? Ttl
    {
        get => new TerraformReference<string>(this, "ttl");
        set => SetArgument("ttl", value);
    }

    /// <summary>
    /// The zone in which the cache instance needs to be created. For example, &#39;us-central1-a.&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zone is required")]
    public required TerraformValue<string> Zone
    {
        get => new TerraformReference<string>(this, "zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// The ID of the Anywhere cache instance.
    /// </summary>
    public TerraformValue<string> AnywhereCacheId
    {
        get => new TerraformReference<string>(this, "anywhere_cache_id");
    }

    /// <summary>
    /// The creation time of the cache instance in RFC 3339 format.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// True if the cache instance has an active Update long-running operation.
    /// </summary>
    public TerraformValue<bool> PendingUpdate
    {
        get => new TerraformReference<bool>(this, "pending_update");
    }

    /// <summary>
    /// The current state of the cache instance.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// The modification time of the cache instance metadata in RFC 3339 format.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleStorageAnywhereCacheTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleStorageAnywhereCacheTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
