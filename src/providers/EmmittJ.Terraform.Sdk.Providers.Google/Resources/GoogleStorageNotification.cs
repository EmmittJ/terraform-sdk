using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Creates a new notification configuration on a specified bucket, establishing a flow of event notifications from GCS to a Cloud Pub/Sub topic.
/// </summary>
public class GoogleStorageNotification : TerraformResource
{
    public GoogleStorageNotification(string name) : base("google_storage_notification", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("id");
        this.WithOutput("notification_id");
        this.WithOutput("self_link");
    }

    /// <summary>
    /// The name of the bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        get => GetRequiredProperty<TerraformProperty<string>>("bucket");
        set => this.WithProperty("bucket", value);
    }

    /// <summary>
    /// A set of key/value attribute pairs to attach to each Cloud Pub/Sub message published for this notification subscription.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? CustomAttributes
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("custom_attributes");
        set => this.WithProperty("custom_attributes", value);
    }

    /// <summary>
    /// List of event type filters for this notification config. If not specified, Cloud Storage will send notifications for all event types. The valid types are: &amp;quot;OBJECT_FINALIZE&amp;quot;, &amp;quot;OBJECT_METADATA_UPDATE&amp;quot;, &amp;quot;OBJECT_DELETE&amp;quot;, &amp;quot;OBJECT_ARCHIVE&amp;quot;
    /// </summary>
    public HashSet<TerraformProperty<string>>? EventTypes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("event_types");
        set => this.WithProperty("event_types", value);
    }

    /// <summary>
    /// Specifies a prefix path filter for this notification config. Cloud Storage will only send notifications for objects in this bucket whose names begin with the specified prefix.
    /// </summary>
    public TerraformProperty<string>? ObjectNamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("object_name_prefix");
        set => this.WithProperty("object_name_prefix", value);
    }

    /// <summary>
    /// The desired content of the Payload. One of &amp;quot;JSON_API_V1&amp;quot; or &amp;quot;NONE&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PayloadFormat is required")]
    public required TerraformProperty<string> PayloadFormat
    {
        get => GetRequiredProperty<TerraformProperty<string>>("payload_format");
        set => this.WithProperty("payload_format", value);
    }

    /// <summary>
    /// The Cloud Pub/Sub topic to which this subscription publishes.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    public required TerraformProperty<string> Topic
    {
        get => GetRequiredProperty<TerraformProperty<string>>("topic");
        set => this.WithProperty("topic", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The ID of the created notification.
    /// </summary>
    public TerraformExpression NotificationId => this["notification_id"];

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

}
