using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_storage_notification Terraform resource.
/// Creates a new notification configuration on a specified bucket, establishing a flow of event notifications from GCS to a Cloud Pub/Sub topic.
/// </summary>
public partial class GoogleStorageNotification(string name) : TerraformResource("google_storage_notification", name)
{
    /// <summary>
    /// The name of the bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// A set of key/value attribute pairs to attach to each Cloud Pub/Sub message published for this notification subscription.
    /// </summary>
    public TerraformMap<string>? CustomAttributes
    {
        get => GetArgument<TerraformMap<string>>("custom_attributes");
        set => SetArgument("custom_attributes", value);
    }

    /// <summary>
    /// List of event type filters for this notification config. If not specified, Cloud Storage will send notifications for all event types. The valid types are: &amp;quot;OBJECT_FINALIZE&amp;quot;, &amp;quot;OBJECT_METADATA_UPDATE&amp;quot;, &amp;quot;OBJECT_DELETE&amp;quot;, &amp;quot;OBJECT_ARCHIVE&amp;quot;
    /// </summary>
    public TerraformSet<string>? EventTypes
    {
        get => GetArgument<TerraformSet<string>>("event_types");
        set => SetArgument("event_types", value);
    }

    /// <summary>
    /// Specifies a prefix path filter for this notification config. Cloud Storage will only send notifications for objects in this bucket whose names begin with the specified prefix.
    /// </summary>
    public TerraformValue<string>? ObjectNamePrefix
    {
        get => GetArgument<TerraformValue<string>>("object_name_prefix");
        set => SetArgument("object_name_prefix", value);
    }

    /// <summary>
    /// The desired content of the Payload. One of &amp;quot;JSON_API_V1&amp;quot; or &amp;quot;NONE&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PayloadFormat is required")]
    public required TerraformValue<string> PayloadFormat
    {
        get => GetRequiredArgument<TerraformValue<string>>("payload_format");
        set => SetArgument("payload_format", value);
    }

    /// <summary>
    /// The Cloud Pub/Sub topic to which this subscription publishes.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    public required TerraformValue<string> Topic
    {
        get => GetRequiredArgument<TerraformValue<string>>("topic");
        set => SetArgument("topic", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The ID of the created notification.
    /// </summary>
    public TerraformValue<string> NotificationId
        => CreateReference("notification_id");

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformValue<string> SelfLink
        => CreateReference("self_link");

}
