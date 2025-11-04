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
    public string? BucketId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket_id")?.Value;
        set => this.WithProperty("bucket_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// An optional description for this bucket.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Enable log analytics for the bucket. Cannot be disabled once enabled.
    /// </summary>
    public bool? EnableAnalytics
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_analytics")?.Value;
        set => this.WithProperty("enable_analytics", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location of the bucket.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Whether the bucket is locked. The retention period on a locked bucket cannot be changed. Locked buckets may only be deleted if they are empty.
    /// </summary>
    public bool? Locked
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("locked")?.Value;
        set => this.WithProperty("locked", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The parent project that contains the logging bucket.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Logs will be retained by default for this amount of time, after which they will automatically be deleted. The minimum retention period is 1 day. If this value is set to zero at bucket creation time, the default time of 30 days will be used.
    /// </summary>
    public double? RetentionDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("retention_days")?.Value;
        set => this.WithProperty("retention_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
