using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Creates a new notification configuration on a specified bucket, establishing a flow of event notifications from GCS to a Cloud Pub/Sub topic.
/// </summary>
public partial class GoogleStorageNotification : TerraformResource
{
    public GoogleStorageNotification(string name) : base("google_storage_notification", name)
    {
    }

    /// <summary>
    /// The name of the bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// A set of key/value attribute pairs to attach to each Cloud Pub/Sub message published for this notification subscription.
    /// </summary>
    [TerraformProperty("custom_attributes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? CustomAttributes { get; set; }

    /// <summary>
    /// List of event type filters for this notification config. If not specified, Cloud Storage will send notifications for all event types. The valid types are: &amp;quot;OBJECT_FINALIZE&amp;quot;, &amp;quot;OBJECT_METADATA_UPDATE&amp;quot;, &amp;quot;OBJECT_DELETE&amp;quot;, &amp;quot;OBJECT_ARCHIVE&amp;quot;
    /// </summary>
    [TerraformProperty("event_types")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? EventTypes { get; set; }

    /// <summary>
    /// Specifies a prefix path filter for this notification config. Cloud Storage will only send notifications for objects in this bucket whose names begin with the specified prefix.
    /// </summary>
    [TerraformProperty("object_name_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ObjectNamePrefix { get; set; }

    /// <summary>
    /// The desired content of the Payload. One of &amp;quot;JSON_API_V1&amp;quot; or &amp;quot;NONE&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PayloadFormat is required")]
    [TerraformProperty("payload_format")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PayloadFormat { get; set; }

    /// <summary>
    /// The Cloud Pub/Sub topic to which this subscription publishes.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    [TerraformProperty("topic")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Topic { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The ID of the created notification.
    /// </summary>
    [TerraformProperty("notification_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NotificationId { get; }

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLink { get; }

}
