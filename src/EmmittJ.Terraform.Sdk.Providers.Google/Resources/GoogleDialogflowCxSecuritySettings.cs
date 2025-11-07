using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_dialogflow_cx_security_settings resource.
/// </summary>
public class GoogleDialogflowCxSecuritySettings : TerraformResource
{
    public GoogleDialogflowCxSecuritySettings(string name) : base("google_dialogflow_cx_security_settings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// [DLP](https://cloud.google.com/dlp/docs) deidentify template name. Use this template to define de-identification configuration for the content. If empty, Dialogflow replaces sensitive info with [redacted] text.
    /// Note: deidentifyTemplate must be located in the same region as the SecuritySettings.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/deidentifyTemplates/&amp;lt;Template ID&amp;gt; OR organizations/&amp;lt;Organization ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/deidentifyTemplates/&amp;lt;Template ID&amp;gt;
    /// </summary>
    public TerraformProperty<string>? DeidentifyTemplate
    {
        get => GetProperty<TerraformProperty<string>>("deidentify_template");
        set => this.WithProperty("deidentify_template", value);
    }

    /// <summary>
    /// The human-readable name of the security settings, unique within the location.
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
    /// [DLP](https://cloud.google.com/dlp/docs) inspect template name. Use this template to define inspect base settings. If empty, we use the default DLP inspect config.
    /// Note: inspectTemplate must be located in the same region as the SecuritySettings.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/inspectTemplates/&amp;lt;Template ID&amp;gt; OR organizations/&amp;lt;Organization ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/inspectTemplates/&amp;lt;Template ID&amp;gt;
    /// </summary>
    public TerraformProperty<string>? InspectTemplate
    {
        get => GetProperty<TerraformProperty<string>>("inspect_template");
        set => this.WithProperty("inspect_template", value);
    }

    /// <summary>
    /// The location these settings are located in. Settings can only be applied to an agent in the same location.
    /// See [Available Regions](https://cloud.google.com/dialogflow/cx/docs/concept/region#avail) for a list of supported locations.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// List of types of data to remove when retention settings triggers purge. Possible values: [&amp;quot;DIALOGFLOW_HISTORY&amp;quot;]
    /// </summary>
    public TerraformProperty<List<string>>? PurgeDataTypes
    {
        get => GetProperty<TerraformProperty<List<string>>>("purge_data_types");
        set => this.WithProperty("purge_data_types", value);
    }

    /// <summary>
    /// Defines what types of data to redact. If not set, defaults to not redacting any kind of data.
    /// * REDACT_DISK_STORAGE: On data to be written to disk or similar devices that are capable of holding data even if power is disconnected. This includes data that are temporarily saved on disk. Possible values: [&amp;quot;REDACT_DISK_STORAGE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? RedactionScope
    {
        get => GetProperty<TerraformProperty<string>>("redaction_scope");
        set => this.WithProperty("redaction_scope", value);
    }

    /// <summary>
    /// Defines how we redact data. If not set, defaults to not redacting.
    /// * REDACT_WITH_SERVICE: Call redaction service to clean up the data to be persisted. Possible values: [&amp;quot;REDACT_WITH_SERVICE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? RedactionStrategy
    {
        get => GetProperty<TerraformProperty<string>>("redaction_strategy");
        set => this.WithProperty("redaction_strategy", value);
    }

    /// <summary>
    /// Defines how long we retain persisted data that contains sensitive info. Only one of &#39;retention_window_days&#39; and &#39;retention_strategy&#39; may be set.
    /// * REMOVE_AFTER_CONVERSATION: Removes data when the conversation ends. If there is no conversation explicitly established, a default conversation ends when the corresponding Dialogflow session ends. Possible values: [&amp;quot;REMOVE_AFTER_CONVERSATION&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? RetentionStrategy
    {
        get => GetProperty<TerraformProperty<string>>("retention_strategy");
        set => this.WithProperty("retention_strategy", value);
    }

    /// <summary>
    /// Retains the data for the specified number of days. User must set a value lower than Dialogflow&#39;s default 365d TTL (30 days for Agent Assist traffic), higher value will be ignored and use default. Setting a value higher than that has no effect. A missing value or setting to 0 also means we use default TTL.
    /// Only one of &#39;retention_window_days&#39; and &#39;retention_strategy&#39; may be set.
    /// </summary>
    public TerraformProperty<double>? RetentionWindowDays
    {
        get => GetProperty<TerraformProperty<double>>("retention_window_days");
        set => this.WithProperty("retention_window_days", value);
    }

    /// <summary>
    /// The unique identifier of the settings.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/securitySettings/&amp;lt;Security Settings ID&amp;gt;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
