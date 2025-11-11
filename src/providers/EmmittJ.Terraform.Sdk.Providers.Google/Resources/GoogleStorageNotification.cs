using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Creates a new notification configuration on a specified bucket, establishing a flow of event notifications from GCS to a Cloud Pub/Sub topic.
/// </summary>
public class GoogleStorageNotification : TerraformResource
{
    public GoogleStorageNotification(string name) : base("google_storage_notification", name)
    {
    }

    /// <summary>
    /// The name of the bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// A set of key/value attribute pairs to attach to each Cloud Pub/Sub message published for this notification subscription.
    /// </summary>
    [TerraformPropertyName("custom_attributes")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? CustomAttributes { get; set; }

    /// <summary>
    /// List of event type filters for this notification config. If not specified, Cloud Storage will send notifications for all event types. The valid types are: &amp;quot;OBJECT_FINALIZE&amp;quot;, &amp;quot;OBJECT_METADATA_UPDATE&amp;quot;, &amp;quot;OBJECT_DELETE&amp;quot;, &amp;quot;OBJECT_ARCHIVE&amp;quot;
    /// </summary>
    [TerraformPropertyName("event_types")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? EventTypes { get; set; }

    /// <summary>
    /// Specifies a prefix path filter for this notification config. Cloud Storage will only send notifications for objects in this bucket whose names begin with the specified prefix.
    /// </summary>
    [TerraformPropertyName("object_name_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ObjectNamePrefix { get; set; }

    /// <summary>
    /// The desired content of the Payload. One of &amp;quot;JSON_API_V1&amp;quot; or &amp;quot;NONE&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PayloadFormat is required")]
    [TerraformPropertyName("payload_format")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PayloadFormat { get; set; }

    /// <summary>
    /// The Cloud Pub/Sub topic to which this subscription publishes.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    [TerraformPropertyName("topic")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Topic { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The ID of the created notification.
    /// </summary>
    [TerraformPropertyName("notification_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NotificationId => new TerraformReference(this, "notification_id");

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

}
