using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for audio_export_settings in GoogleDialogflowCxSecuritySettings.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxSecuritySettingsAudioExportSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "audio_export_settings";

    /// <summary>
    /// Filename pattern for exported audio.
    /// </summary>
    public TerraformValue<string>? AudioExportPattern
    {
        get => GetArgument<TerraformValue<string>>("audio_export_pattern");
        set => SetArgument("audio_export_pattern", value);
    }

    /// <summary>
    /// File format for exported audio file. Currently only in telephony recordings.
    /// * MULAW: G.711 mu-law PCM with 8kHz sample rate.
    /// * MP3: MP3 file format.
    /// * OGG: OGG Vorbis. Possible values: [&amp;quot;MULAW&amp;quot;, &amp;quot;MP3&amp;quot;, &amp;quot;OGG&amp;quot;]
    /// </summary>
    public TerraformValue<string>? AudioFormat
    {
        get => GetArgument<TerraformValue<string>>("audio_format");
        set => SetArgument("audio_format", value);
    }

    /// <summary>
    /// Enable audio redaction if it is true.
    /// </summary>
    public TerraformValue<bool>? EnableAudioRedaction
    {
        get => GetArgument<TerraformValue<bool>>("enable_audio_redaction");
        set => SetArgument("enable_audio_redaction", value);
    }

    /// <summary>
    /// Cloud Storage bucket to export audio record to. Setting this field would grant the Storage Object Creator role to the Dialogflow Service Agent. API caller that tries to modify this field should have the permission of storage.buckets.setIamPolicy.
    /// </summary>
    public TerraformValue<string>? GcsBucket
    {
        get => GetArgument<TerraformValue<string>>("gcs_bucket");
        set => SetArgument("gcs_bucket", value);
    }

}


/// <summary>
/// Block type for insights_export_settings in GoogleDialogflowCxSecuritySettings.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxSecuritySettingsInsightsExportSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "insights_export_settings";

    /// <summary>
    /// If enabled, we will automatically exports conversations to Insights and Insights runs its analyzers.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableInsightsExport is required")]
    public required TerraformValue<bool> EnableInsightsExport
    {
        get => GetArgument<TerraformValue<bool>>("enable_insights_export");
        set => SetArgument("enable_insights_export", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDialogflowCxSecuritySettings.
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxSecuritySettingsTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_dialogflow_cx_security_settings Terraform resource.
/// Manages a google_dialogflow_cx_security_settings resource.
/// </summary>
public partial class GoogleDialogflowCxSecuritySettings(string name) : TerraformResource("google_dialogflow_cx_security_settings", name)
{
    /// <summary>
    /// [DLP](https://cloud.google.com/dlp/docs) deidentify template name. Use this template to define de-identification configuration for the content. If empty, Dialogflow replaces sensitive info with [redacted] text.
    /// Note: deidentifyTemplate must be located in the same region as the SecuritySettings.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/deidentifyTemplates/&amp;lt;Template ID&amp;gt; OR organizations/&amp;lt;Organization ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/deidentifyTemplates/&amp;lt;Template ID&amp;gt;
    /// </summary>
    public TerraformValue<string>? DeidentifyTemplate
    {
        get => GetArgument<TerraformValue<string>>("deidentify_template");
        set => SetArgument("deidentify_template", value);
    }

    /// <summary>
    /// The human-readable name of the security settings, unique within the location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// [DLP](https://cloud.google.com/dlp/docs) inspect template name. Use this template to define inspect base settings. If empty, we use the default DLP inspect config.
    /// Note: inspectTemplate must be located in the same region as the SecuritySettings.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/inspectTemplates/&amp;lt;Template ID&amp;gt; OR organizations/&amp;lt;Organization ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/inspectTemplates/&amp;lt;Template ID&amp;gt;
    /// </summary>
    public TerraformValue<string>? InspectTemplate
    {
        get => GetArgument<TerraformValue<string>>("inspect_template");
        set => SetArgument("inspect_template", value);
    }

    /// <summary>
    /// The location these settings are located in. Settings can only be applied to an agent in the same location.
    /// See [Available Regions](https://cloud.google.com/dialogflow/cx/docs/concept/region#avail) for a list of supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// List of types of data to remove when retention settings triggers purge. Possible values: [&amp;quot;DIALOGFLOW_HISTORY&amp;quot;]
    /// </summary>
    public TerraformList<string>? PurgeDataTypes
    {
        get => GetArgument<TerraformList<string>>("purge_data_types");
        set => SetArgument("purge_data_types", value);
    }

    /// <summary>
    /// Defines what types of data to redact. If not set, defaults to not redacting any kind of data.
    /// * REDACT_DISK_STORAGE: On data to be written to disk or similar devices that are capable of holding data even if power is disconnected. This includes data that are temporarily saved on disk. Possible values: [&amp;quot;REDACT_DISK_STORAGE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? RedactionScope
    {
        get => GetArgument<TerraformValue<string>>("redaction_scope");
        set => SetArgument("redaction_scope", value);
    }

    /// <summary>
    /// Defines how we redact data. If not set, defaults to not redacting.
    /// * REDACT_WITH_SERVICE: Call redaction service to clean up the data to be persisted. Possible values: [&amp;quot;REDACT_WITH_SERVICE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? RedactionStrategy
    {
        get => GetArgument<TerraformValue<string>>("redaction_strategy");
        set => SetArgument("redaction_strategy", value);
    }

    /// <summary>
    /// Defines how long we retain persisted data that contains sensitive info. Only one of &#39;retention_window_days&#39; and &#39;retention_strategy&#39; may be set.
    /// * REMOVE_AFTER_CONVERSATION: Removes data when the conversation ends. If there is no conversation explicitly established, a default conversation ends when the corresponding Dialogflow session ends. Possible values: [&amp;quot;REMOVE_AFTER_CONVERSATION&amp;quot;]
    /// </summary>
    public TerraformValue<string>? RetentionStrategy
    {
        get => GetArgument<TerraformValue<string>>("retention_strategy");
        set => SetArgument("retention_strategy", value);
    }

    /// <summary>
    /// Retains the data for the specified number of days. User must set a value lower than Dialogflow&#39;s default 365d TTL (30 days for Agent Assist traffic), higher value will be ignored and use default. Setting a value higher than that has no effect. A missing value or setting to 0 also means we use default TTL.
    /// Only one of &#39;retention_window_days&#39; and &#39;retention_strategy&#39; may be set.
    /// </summary>
    public TerraformValue<double>? RetentionWindowDays
    {
        get => GetArgument<TerraformValue<double>>("retention_window_days");
        set => SetArgument("retention_window_days", value);
    }

    /// <summary>
    /// The unique identifier of the settings.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/securitySettings/&amp;lt;Security Settings ID&amp;gt;.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// AudioExportSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AudioExportSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxSecuritySettingsAudioExportSettingsBlock>? AudioExportSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxSecuritySettingsAudioExportSettingsBlock>>("audio_export_settings");
        set => SetArgument("audio_export_settings", value);
    }

    /// <summary>
    /// InsightsExportSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InsightsExportSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxSecuritySettingsInsightsExportSettingsBlock>? InsightsExportSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxSecuritySettingsInsightsExportSettingsBlock>>("insights_export_settings");
        set => SetArgument("insights_export_settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDialogflowCxSecuritySettingsTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDialogflowCxSecuritySettingsTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
