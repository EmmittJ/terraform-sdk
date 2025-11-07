using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_monitoring_notification_channel.
/// </summary>
public class GoogleMonitoringNotificationChannelDataSource : TerraformDataSource
{
    public GoogleMonitoringNotificationChannelDataSource(string name) : base("google_monitoring_notification_channel", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("description");
        this.DeclareOutput("enabled");
        this.DeclareOutput("force_delete");
        this.DeclareOutput("name");
        this.DeclareOutput("sensitive_labels");
        this.DeclareOutput("verification_status");
    }

    /// <summary>
    /// An optional human-readable name for this notification channel. It is recommended that you specify a non-empty and unique name in order to make it easier to identify the channels in your project, though this is not enforced. The display name is limited to 512 Unicode characters.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// Configuration fields that define the channel and its behavior. The
    /// permissible and required labels are specified in the
    /// NotificationChannelDescriptor corresponding to the type field.
    /// 
    /// Labels with sensitive data are obfuscated by the API and therefore Terraform cannot
    /// determine if there are upstream changes to these fields. They can also be configured via
    /// the sensitive_labels block, but cannot be configured in both places.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Labels
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The type of the notification channel. This field matches the value of the NotificationChannelDescriptor.type field. See https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.notificationChannelDescriptors/list to get the list of valid values such as &amp;quot;email&amp;quot;, &amp;quot;slack&amp;quot;, etc...
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// User-supplied key/value data that does not need to conform to the corresponding NotificationChannelDescriptor&#39;s schema, unlike the labels field. This field is intended to be used for organizing and identifying the NotificationChannel objects.The field can contain up to 64 entries. Each key and value is limited to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values can contain only lowercase letters, numerals, underscores, and dashes. Keys must begin with a letter.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? UserLabels
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("user_labels");
        set => this.WithProperty("user_labels", value);
    }

    /// <summary>
    /// An optional human-readable description of this notification channel. This description may provide additional details, beyond the display name, for the channel. This may not exceed 1024 Unicode characters.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// Whether notifications are forwarded to the described channel. This makes it possible to disable delivery of notifications to a particular channel without removing the channel from all alerting policies that reference the channel. This is a more convenient approach when the change is temporary and you want to receive notifications from the same set of alerting policies on the channel at some point in the future.
    /// </summary>
    public TerraformExpression Enabled => this["enabled"];

    /// <summary>
    /// If true, the notification channel will be deleted regardless
    /// of its use in alert policies (the policies will be updated
    /// to remove the channel). If false, channels that are still
    /// referenced by an existing alerting policy will fail to be
    /// deleted in a delete operation.
    /// </summary>
    public TerraformExpression ForceDelete => this["force_delete"];

    /// <summary>
    /// The full REST resource name for this channel. The syntax is:
    /// projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]
    /// The [CHANNEL_ID] is automatically assigned by the server on creation.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Different notification type behaviors are configured primarily using the the &#39;labels&#39; field on this
    /// resource. This block contains the labels which contain secrets or passwords so that they can be marked
    /// sensitive and hidden from plan output. The name of the field, eg: password, will be the key
    /// in the &#39;labels&#39; map in the api request.
    /// 
    /// Credentials may not be specified in both locations and will cause an error. Changing from one location
    /// to a different credential configuration in the config will require an apply to update state.
    /// </summary>
    public TerraformExpression SensitiveLabels => this["sensitive_labels"];

    /// <summary>
    /// Indicates whether this channel has been verified or not. On a ListNotificationChannels or GetNotificationChannel operation, this field is expected to be populated.If the value is UNVERIFIED, then it indicates that the channel is non-functioning (it both requires verification and lacks verification); otherwise, it is assumed that the channel works.If the channel is neither VERIFIED nor UNVERIFIED, it implies that the channel is of a type that does not require verification or that this specific channel has been exempted from verification because it was created prior to verification being required for channels of this type.This field cannot be modified using a standard UpdateNotificationChannel operation. To change the value of this field, you must call VerifyNotificationChannel.
    /// </summary>
    public TerraformExpression VerificationStatus => this["verification_status"];

}
