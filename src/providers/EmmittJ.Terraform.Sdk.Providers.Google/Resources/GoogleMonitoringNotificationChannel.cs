using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for sensitive_labels in .
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringNotificationChannelSensitiveLabelsBlock : TerraformBlock
{
    /// <summary>
    /// An authorization token for a notification channel. Channel types that support this field include: slack
    /// </summary>
    public TerraformProperty<string>? AuthToken
    {
        set => SetProperty("auth_token", value);
    }

    /// <summary>
    /// An password for a notification channel. Channel types that support this field include: webhook_basicauth
    /// </summary>
    public TerraformProperty<string>? Password
    {
        set => SetProperty("password", value);
    }

    /// <summary>
    /// An servicekey token for a notification channel. Channel types that support this field include: pagerduty
    /// </summary>
    public TerraformProperty<string>? ServiceKey
    {
        set => SetProperty("service_key", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleMonitoringNotificationChannelTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_monitoring_notification_channel resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleMonitoringNotificationChannel : TerraformResource
{
    public GoogleMonitoringNotificationChannel(string name) : base("google_monitoring_notification_channel", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("name");
        SetOutput("verification_status");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("enabled");
        SetOutput("force_delete");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("project");
        SetOutput("type");
        SetOutput("user_labels");
    }

    /// <summary>
    /// An optional human-readable description of this notification channel. This description may provide additional details, beyond the display name, for the channel. This may not exceed 1024 Unicode characters.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// An optional human-readable name for this notification channel. It is recommended that you specify a non-empty and unique name in order to make it easier to identify the channels in your project, though this is not enforced. The display name is limited to 512 Unicode characters.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// Whether notifications are forwarded to the described channel. This makes it possible to disable delivery of notifications to a particular channel without removing the channel from all alerting policies that reference the channel. This is a more convenient approach when the change is temporary and you want to receive notifications from the same set of alerting policies on the channel at some point in the future.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// If true, the notification channel will be deleted regardless
    /// of its use in alert policies (the policies will be updated
    /// to remove the channel). If false, channels that are still
    /// referenced by an existing alerting policy will fail to be
    /// deleted in a delete operation.
    /// </summary>
    public TerraformProperty<bool> ForceDelete
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_delete");
        set => SetProperty("force_delete", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The type of the notification channel. This field matches the value of the NotificationChannelDescriptor.type field. See https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.notificationChannelDescriptors/list to get the list of valid values such as &amp;quot;email&amp;quot;, &amp;quot;slack&amp;quot;, etc...
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// User-supplied key/value data that does not need to conform to the corresponding NotificationChannelDescriptor&#39;s schema, unlike the labels field. This field is intended to be used for organizing and identifying the NotificationChannel objects.The field can contain up to 64 entries. Each key and value is limited to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values can contain only lowercase letters, numerals, underscores, and dashes. Keys must begin with a letter.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> UserLabels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("user_labels");
        set => SetProperty("user_labels", value);
    }

    /// <summary>
    /// Block for sensitive_labels.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SensitiveLabels block(s) allowed")]
    public List<GoogleMonitoringNotificationChannelSensitiveLabelsBlock>? SensitiveLabels
    {
        set => SetProperty("sensitive_labels", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleMonitoringNotificationChannelTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The full REST resource name for this channel. The syntax is:
    /// projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]
    /// The [CHANNEL_ID] is automatically assigned by the server on creation.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Indicates whether this channel has been verified or not. On a ListNotificationChannels or GetNotificationChannel operation, this field is expected to be populated.If the value is UNVERIFIED, then it indicates that the channel is non-functioning (it both requires verification and lacks verification); otherwise, it is assumed that the channel works.If the channel is neither VERIFIED nor UNVERIFIED, it implies that the channel is of a type that does not require verification or that this specific channel has been exempted from verification because it was created prior to verification being required for channels of this type.This field cannot be modified using a standard UpdateNotificationChannel operation. To change the value of this field, you must call VerifyNotificationChannel.
    /// </summary>
    public TerraformExpression VerificationStatus => this["verification_status"];

}
