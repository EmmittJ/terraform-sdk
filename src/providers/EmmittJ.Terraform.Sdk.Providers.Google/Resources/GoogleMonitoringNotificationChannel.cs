using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for sensitive_labels in .
/// Nesting mode: list
/// </summary>
public partial class GoogleMonitoringNotificationChannelSensitiveLabelsBlock : TerraformBlockBase
{
    /// <summary>
    /// An authorization token for a notification channel. Channel types that support this field include: slack
    /// </summary>
    [TerraformProperty("auth_token")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthToken { get; set; }

    /// <summary>
    /// An password for a notification channel. Channel types that support this field include: webhook_basicauth
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// An servicekey token for a notification channel. Channel types that support this field include: pagerduty
    /// </summary>
    [TerraformProperty("service_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServiceKey { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleMonitoringNotificationChannelTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_monitoring_notification_channel resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleMonitoringNotificationChannel : TerraformResource
{
    public GoogleMonitoringNotificationChannel(string name) : base("google_monitoring_notification_channel", name)
    {
    }

    /// <summary>
    /// An optional human-readable description of this notification channel. This description may provide additional details, beyond the display name, for the channel. This may not exceed 1024 Unicode characters.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// An optional human-readable name for this notification channel. It is recommended that you specify a non-empty and unique name in order to make it easier to identify the channels in your project, though this is not enforced. The display name is limited to 512 Unicode characters.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// Whether notifications are forwarded to the described channel. This makes it possible to disable delivery of notifications to a particular channel without removing the channel from all alerting policies that reference the channel. This is a more convenient approach when the change is temporary and you want to receive notifications from the same set of alerting policies on the channel at some point in the future.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// If true, the notification channel will be deleted regardless
    /// of its use in alert policies (the policies will be updated
    /// to remove the channel). If false, channels that are still
    /// referenced by an existing alerting policy will fail to be
    /// deleted in a delete operation.
    /// </summary>
    [TerraformProperty("force_delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceDelete { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Configuration fields that define the channel and its behavior. The
    /// permissible and required labels are specified in the
    /// NotificationChannelDescriptor corresponding to the type field.
    /// 
    /// Labels with sensitive data are obfuscated by the API and therefore Terraform cannot
    /// determine if there are upstream changes to these fields. They can also be configured via
    /// the sensitive_labels block, but cannot be configured in both places.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The type of the notification channel. This field matches the value of the NotificationChannelDescriptor.type field. See https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.notificationChannelDescriptors/list to get the list of valid values such as &amp;quot;email&amp;quot;, &amp;quot;slack&amp;quot;, etc...
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// User-supplied key/value data that does not need to conform to the corresponding NotificationChannelDescriptor&#39;s schema, unlike the labels field. This field is intended to be used for organizing and identifying the NotificationChannel objects.The field can contain up to 64 entries. Each key and value is limited to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values can contain only lowercase letters, numerals, underscores, and dashes. Keys must begin with a letter.
    /// </summary>
    [TerraformProperty("user_labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? UserLabels { get; set; }

    /// <summary>
    /// Block for sensitive_labels.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SensitiveLabels block(s) allowed")]
    [TerraformProperty("sensitive_labels")]
    public partial TerraformList<TerraformBlock<GoogleMonitoringNotificationChannelSensitiveLabelsBlock>>? SensitiveLabels { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleMonitoringNotificationChannelTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The full REST resource name for this channel. The syntax is:
    /// projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]
    /// The [CHANNEL_ID] is automatically assigned by the server on creation.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Indicates whether this channel has been verified or not. On a ListNotificationChannels or GetNotificationChannel operation, this field is expected to be populated.If the value is UNVERIFIED, then it indicates that the channel is non-functioning (it both requires verification and lacks verification); otherwise, it is assumed that the channel works.If the channel is neither VERIFIED nor UNVERIFIED, it implies that the channel is of a type that does not require verification or that this specific channel has been exempted from verification because it was created prior to verification being required for channels of this type.This field cannot be modified using a standard UpdateNotificationChannel operation. To change the value of this field, you must call VerifyNotificationChannel.
    /// </summary>
    [TerraformProperty("verification_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VerificationStatus { get; }

}
