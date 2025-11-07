using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_storage_anywhere_cache resource.
/// </summary>
public class GoogleStorageAnywhereCache : TerraformResource
{
    public GoogleStorageAnywhereCache(string name) : base("google_storage_anywhere_cache", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("anywhere_cache_id");
        this.DeclareOutput("create_time");
        this.DeclareOutput("pending_update");
        this.DeclareOutput("state");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The cache admission policy dictates whether a block should be inserted upon a cache miss. Default value: &amp;quot;admit-on-first-miss&amp;quot; Possible values: [&amp;quot;admit-on-first-miss&amp;quot;, &amp;quot;admit-on-second-miss&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? AdmissionPolicy
    {
        get => GetProperty<TerraformProperty<string>>("admission_policy");
        set => this.WithProperty("admission_policy", value);
    }

    /// <summary>
    /// A reference to Bucket resource
    /// </summary>
    public TerraformProperty<string>? Bucket
    {
        get => GetProperty<TerraformProperty<string>>("bucket");
        set => this.WithProperty("bucket", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The TTL of all cache entries in whole seconds. e.g., &amp;quot;7200s&amp;quot;. It defaults to &#39;86400s&#39;
    /// </summary>
    public TerraformProperty<string>? Ttl
    {
        get => GetProperty<TerraformProperty<string>>("ttl");
        set => this.WithProperty("ttl", value);
    }

    /// <summary>
    /// The zone in which the cache instance needs to be created. For example, &#39;us-central1-a.&#39;
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

    /// <summary>
    /// The ID of the Anywhere cache instance.
    /// </summary>
    public TerraformExpression AnywhereCacheId => this["anywhere_cache_id"];

    /// <summary>
    /// The creation time of the cache instance in RFC 3339 format.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// True if the cache instance has an active Update long-running operation.
    /// </summary>
    public TerraformExpression PendingUpdate => this["pending_update"];

    /// <summary>
    /// The current state of the cache instance.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The modification time of the cache instance metadata in RFC 3339 format.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
