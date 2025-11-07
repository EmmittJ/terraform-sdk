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
        this.DeclareOutput("id");
        this.DeclareOutput("notification_id");
        this.DeclareOutput("self_link");
    }

    /// <summary>
    /// The name of the bucket.
    /// </summary>
    public TerraformLiteralProperty<string>? Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket");
        set => this.WithProperty("bucket", value);
    }

    /// <summary>
    /// A set of key/value attribute pairs to attach to each Cloud Pub/Sub message published for this notification subscription.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? CustomAttributes
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("custom_attributes");
        set => this.WithProperty("custom_attributes", value);
    }

    /// <summary>
    /// List of event type filters for this notification config. If not specified, Cloud Storage will send notifications for all event types. The valid types are: &amp;quot;OBJECT_FINALIZE&amp;quot;, &amp;quot;OBJECT_METADATA_UPDATE&amp;quot;, &amp;quot;OBJECT_DELETE&amp;quot;, &amp;quot;OBJECT_ARCHIVE&amp;quot;
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? EventTypes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("event_types");
        set => this.WithProperty("event_types", value);
    }

    /// <summary>
    /// Specifies a prefix path filter for this notification config. Cloud Storage will only send notifications for objects in this bucket whose names begin with the specified prefix.
    /// </summary>
    public TerraformLiteralProperty<string>? ObjectNamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("object_name_prefix");
        set => this.WithProperty("object_name_prefix", value);
    }

    /// <summary>
    /// The desired content of the Payload. One of &amp;quot;JSON_API_V1&amp;quot; or &amp;quot;NONE&amp;quot;.
    /// </summary>
    public TerraformLiteralProperty<string>? PayloadFormat
    {
        get => GetProperty<TerraformLiteralProperty<string>>("payload_format");
        set => this.WithProperty("payload_format", value);
    }

    /// <summary>
    /// The Cloud Pub/Sub topic to which this subscription publishes.
    /// </summary>
    public TerraformLiteralProperty<string>? Topic
    {
        get => GetProperty<TerraformLiteralProperty<string>>("topic");
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
