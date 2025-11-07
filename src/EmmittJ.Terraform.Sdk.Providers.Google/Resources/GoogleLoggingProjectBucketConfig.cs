using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_logging_project_bucket_config resource.
/// </summary>
public class GoogleLoggingProjectBucketConfig : TerraformResource
{
    public GoogleLoggingProjectBucketConfig(string name) : base("google_logging_project_bucket_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("lifecycle_state");
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The name of the logging bucket. Logging automatically creates two log buckets: _Required and _Default.
    /// </summary>
    public TerraformProperty<string>? BucketId
    {
        get => GetProperty<TerraformProperty<string>>("bucket_id");
        set => this.WithProperty("bucket_id", value);
    }

    /// <summary>
    /// An optional description for this bucket.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Enable log analytics for the bucket. Cannot be disabled once enabled.
    /// </summary>
    public TerraformProperty<bool>? EnableAnalytics
    {
        get => GetProperty<TerraformProperty<bool>>("enable_analytics");
        set => this.WithProperty("enable_analytics", value);
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
    /// The location of the bucket.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Whether the bucket is locked. The retention period on a locked bucket cannot be changed. Locked buckets may only be deleted if they are empty.
    /// </summary>
    public TerraformProperty<bool>? Locked
    {
        get => GetProperty<TerraformProperty<bool>>("locked");
        set => this.WithProperty("locked", value);
    }

    /// <summary>
    /// The parent project that contains the logging bucket.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Logs will be retained by default for this amount of time, after which they will automatically be deleted. The minimum retention period is 1 day. If this value is set to zero at bucket creation time, the default time of 30 days will be used.
    /// </summary>
    public TerraformProperty<double>? RetentionDays
    {
        get => GetProperty<TerraformProperty<double>>("retention_days");
        set => this.WithProperty("retention_days", value);
    }

    /// <summary>
    /// The bucket&#39;s lifecycle such as active or deleted.
    /// </summary>
    public TerraformExpression LifecycleState => this["lifecycle_state"];

    /// <summary>
    /// The resource name of the bucket
    /// </summary>
    public TerraformExpression Name => this["name"];

}
