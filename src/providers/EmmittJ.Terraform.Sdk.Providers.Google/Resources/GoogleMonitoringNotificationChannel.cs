using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for sensitive_labels in GoogleMonitoringNotificationChannel.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringNotificationChannelSensitiveLabelsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sensitive_labels";

    /// <summary>
    /// An authorization token for a notification channel. Channel types that support this field include: slack
    /// </summary>
    public TerraformValue<string>? AuthToken
    {
        get => new TerraformReference<string>(this, "auth_token");
        set => SetArgument("auth_token", value);
    }

    /// <summary>
    /// An password for a notification channel. Channel types that support this field include: webhook_basicauth
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// An servicekey token for a notification channel. Channel types that support this field include: pagerduty
    /// </summary>
    public TerraformValue<string>? ServiceKey
    {
        get => new TerraformReference<string>(this, "service_key");
        set => SetArgument("service_key", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleMonitoringNotificationChannel.
/// Nesting mode: single
/// </summary>
public class GoogleMonitoringNotificationChannelTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_monitoring_notification_channel Terraform resource.
/// Manages a google_monitoring_notification_channel resource.
/// </summary>
public partial class GoogleMonitoringNotificationChannel(string name) : TerraformResource("google_monitoring_notification_channel", name)
{
    /// <summary>
    /// An optional human-readable description of this notification channel. This description may provide additional details, beyond the display name, for the channel. This may not exceed 1024 Unicode characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// An optional human-readable name for this notification channel. It is recommended that you specify a non-empty and unique name in order to make it easier to identify the channels in your project, though this is not enforced. The display name is limited to 512 Unicode characters.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Whether notifications are forwarded to the described channel. This makes it possible to disable delivery of notifications to a particular channel without removing the channel from all alerting policies that reference the channel. This is a more convenient approach when the change is temporary and you want to receive notifications from the same set of alerting policies on the channel at some point in the future.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// If true, the notification channel will be deleted regardless
    /// of its use in alert policies (the policies will be updated
    /// to remove the channel). If false, channels that are still
    /// referenced by an existing alerting policy will fail to be
    /// deleted in a delete operation.
    /// </summary>
    public TerraformValue<bool>? ForceDelete
    {
        get => new TerraformReference<bool>(this, "force_delete");
        set => SetArgument("force_delete", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Configuration fields that define the channel and its behavior. The
    /// permissible and required labels are specified in the
    /// NotificationChannelDescriptor corresponding to the type field.
    /// 
    /// Labels with sensitive data are obfuscated by the API and therefore Terraform cannot
    /// determine if there are upstream changes to these fields. They can also be configured via
    /// the sensitive_labels block, but cannot be configured in both places.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The type of the notification channel. This field matches the value of the NotificationChannelDescriptor.type field. See https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.notificationChannelDescriptors/list to get the list of valid values such as &amp;quot;email&amp;quot;, &amp;quot;slack&amp;quot;, etc...
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// User-supplied key/value data that does not need to conform to the corresponding NotificationChannelDescriptor&#39;s schema, unlike the labels field. This field is intended to be used for organizing and identifying the NotificationChannel objects.The field can contain up to 64 entries. Each key and value is limited to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values can contain only lowercase letters, numerals, underscores, and dashes. Keys must begin with a letter.
    /// </summary>
    public TerraformMap<string>? UserLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "user_labels").ResolveNodes(ctx));
        set => SetArgument("user_labels", value);
    }

    /// <summary>
    /// The full REST resource name for this channel. The syntax is:
    /// projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]
    /// The [CHANNEL_ID] is automatically assigned by the server on creation.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Indicates whether this channel has been verified or not. On a ListNotificationChannels or GetNotificationChannel operation, this field is expected to be populated.If the value is UNVERIFIED, then it indicates that the channel is non-functioning (it both requires verification and lacks verification); otherwise, it is assumed that the channel works.If the channel is neither VERIFIED nor UNVERIFIED, it implies that the channel is of a type that does not require verification or that this specific channel has been exempted from verification because it was created prior to verification being required for channels of this type.This field cannot be modified using a standard UpdateNotificationChannel operation. To change the value of this field, you must call VerifyNotificationChannel.
    /// </summary>
    public TerraformValue<string> VerificationStatus
    {
        get => new TerraformReference<string>(this, "verification_status");
    }

    /// <summary>
    /// SensitiveLabels block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SensitiveLabels block(s) allowed")]
    public TerraformList<GoogleMonitoringNotificationChannelSensitiveLabelsBlock>? SensitiveLabels
    {
        get => GetArgument<TerraformList<GoogleMonitoringNotificationChannelSensitiveLabelsBlock>>("sensitive_labels");
        set => SetArgument("sensitive_labels", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleMonitoringNotificationChannelTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleMonitoringNotificationChannelTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
