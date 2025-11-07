using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_logging_billing_account_bucket_config resource.
/// </summary>
public class GoogleLoggingBillingAccountBucketConfig : TerraformResource
{
    public GoogleLoggingBillingAccountBucketConfig(string name) : base("google_logging_billing_account_bucket_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("lifecycle_state");
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The parent resource that contains the logging bucket.
    /// </summary>
    public TerraformProperty<string>? BillingAccount
    {
        get => GetProperty<TerraformProperty<string>>("billing_account");
        set => this.WithProperty("billing_account", value);
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
