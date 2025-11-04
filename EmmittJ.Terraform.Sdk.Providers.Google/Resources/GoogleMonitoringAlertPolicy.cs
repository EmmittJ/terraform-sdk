using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_monitoring_alert_policy resource.
/// </summary>
public class GoogleMonitoringAlertPolicy : TerraformResource
{
    public GoogleMonitoringAlertPolicy(string name) : base("google_monitoring_alert_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_record");
        this.DeclareOutput("name");
    }

    /// <summary>
    /// How to combine the results of multiple conditions to
    /// determine if an incident should be opened. Possible values: [&amp;quot;AND&amp;quot;, &amp;quot;OR&amp;quot;, &amp;quot;AND_WITH_MATCHING_RESOURCE&amp;quot;]
    /// </summary>
    public string? Combiner
    {
        get => GetProperty<TerraformLiteralProperty<string>>("combiner")?.Value;
        set => this.WithProperty("combiner", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A short name or phrase used to identify the policy in
    /// dashboards, notifications, and incidents. To avoid confusion, don&#39;t use
    /// the same display name for multiple policies in the same project. The
    /// name is limited to 512 Unicode characters.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Whether or not the policy is enabled. The default is true.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Identifies the notification channels to which notifications should be
    /// sent when incidents are opened or closed or when new violations occur
    /// on an already opened incident. Each element of this array corresponds
    /// to the name field in each of the NotificationChannel objects that are
    /// returned from the notificationChannels.list method. The syntax of the
    /// entries in this field is
    /// &#39;projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]&#39;
    /// </summary>
    public List<string>? NotificationChannels
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("notification_channels")?.Value;
        set => this.WithProperty("notification_channels", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The severity of an alert policy indicates how important incidents generated
    /// by that policy are. The severity level will be displayed on the Incident
    /// detail page and in notifications. Possible values: [&amp;quot;CRITICAL&amp;quot;, &amp;quot;ERROR&amp;quot;, &amp;quot;WARNING&amp;quot;]
    /// </summary>
    public string? Severity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("severity")?.Value;
        set => this.WithProperty("severity", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// This field is intended to be used for organizing and identifying the AlertPolicy
    /// objects.The field can contain up to 64 entries. Each key and value is limited
    /// to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values
    /// can contain only lowercase letters, numerals, underscores, and dashes. Keys
    /// must begin with a letter.
    /// </summary>
    public Dictionary<string, string>? UserLabels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("user_labels")?.Value;
        set => this.WithProperty("user_labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// A read-only record of the creation of the alerting policy.
    /// If provided in a call to create or update, this field will
    /// be ignored.
    /// </summary>
    public TerraformExpression CreationRecord => this["creation_record"];

    /// <summary>
    /// The unique resource name for this policy.
    /// Its syntax is: projects/[PROJECT_ID]/alertPolicies/[ALERT_POLICY_ID]
    /// </summary>
    public TerraformExpression Name => this["name"];

}
