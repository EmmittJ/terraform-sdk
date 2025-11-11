using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for audio_export_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxSecuritySettingsAudioExportSettingsBlock
{
    /// <summary>
    /// Filename pattern for exported audio.
    /// </summary>
    [TerraformPropertyName("audio_export_pattern")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AudioExportPattern { get; set; }

    /// <summary>
    /// File format for exported audio file. Currently only in telephony recordings.
    /// * MULAW: G.711 mu-law PCM with 8kHz sample rate.
    /// * MP3: MP3 file format.
    /// * OGG: OGG Vorbis. Possible values: [&amp;quot;MULAW&amp;quot;, &amp;quot;MP3&amp;quot;, &amp;quot;OGG&amp;quot;]
    /// </summary>
    [TerraformPropertyName("audio_format")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AudioFormat { get; set; }

    /// <summary>
    /// Enable audio redaction if it is true.
    /// </summary>
    [TerraformPropertyName("enable_audio_redaction")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableAudioRedaction { get; set; }

    /// <summary>
    /// Cloud Storage bucket to export audio record to. Setting this field would grant the Storage Object Creator role to the Dialogflow Service Agent. API caller that tries to modify this field should have the permission of storage.buckets.setIamPolicy.
    /// </summary>
    [TerraformPropertyName("gcs_bucket")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GcsBucket { get; set; }

}

/// <summary>
/// Block type for insights_export_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxSecuritySettingsInsightsExportSettingsBlock
{
    /// <summary>
    /// If enabled, we will automatically exports conversations to Insights and Insights runs its analyzers.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableInsightsExport is required")]
    [TerraformPropertyName("enable_insights_export")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> EnableInsightsExport { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxSecuritySettingsTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_dialogflow_cx_security_settings resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDialogflowCxSecuritySettings : TerraformResource
{
    public GoogleDialogflowCxSecuritySettings(string name) : base("google_dialogflow_cx_security_settings", name)
    {
    }

    /// <summary>
    /// [DLP](https://cloud.google.com/dlp/docs) deidentify template name. Use this template to define de-identification configuration for the content. If empty, Dialogflow replaces sensitive info with [redacted] text.
    /// Note: deidentifyTemplate must be located in the same region as the SecuritySettings.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/deidentifyTemplates/&amp;lt;Template ID&amp;gt; OR organizations/&amp;lt;Organization ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/deidentifyTemplates/&amp;lt;Template ID&amp;gt;
    /// </summary>
    [TerraformPropertyName("deidentify_template")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DeidentifyTemplate { get; set; }

    /// <summary>
    /// The human-readable name of the security settings, unique within the location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// [DLP](https://cloud.google.com/dlp/docs) inspect template name. Use this template to define inspect base settings. If empty, we use the default DLP inspect config.
    /// Note: inspectTemplate must be located in the same region as the SecuritySettings.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/inspectTemplates/&amp;lt;Template ID&amp;gt; OR organizations/&amp;lt;Organization ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/inspectTemplates/&amp;lt;Template ID&amp;gt;
    /// </summary>
    [TerraformPropertyName("inspect_template")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InspectTemplate { get; set; }

    /// <summary>
    /// The location these settings are located in. Settings can only be applied to an agent in the same location.
    /// See [Available Regions](https://cloud.google.com/dialogflow/cx/docs/concept/region#avail) for a list of supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// List of types of data to remove when retention settings triggers purge. Possible values: [&amp;quot;DIALOGFLOW_HISTORY&amp;quot;]
    /// </summary>
    [TerraformPropertyName("purge_data_types")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? PurgeDataTypes { get; set; }

    /// <summary>
    /// Defines what types of data to redact. If not set, defaults to not redacting any kind of data.
    /// * REDACT_DISK_STORAGE: On data to be written to disk or similar devices that are capable of holding data even if power is disconnected. This includes data that are temporarily saved on disk. Possible values: [&amp;quot;REDACT_DISK_STORAGE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("redaction_scope")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RedactionScope { get; set; }

    /// <summary>
    /// Defines how we redact data. If not set, defaults to not redacting.
    /// * REDACT_WITH_SERVICE: Call redaction service to clean up the data to be persisted. Possible values: [&amp;quot;REDACT_WITH_SERVICE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("redaction_strategy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RedactionStrategy { get; set; }

    /// <summary>
    /// Defines how long we retain persisted data that contains sensitive info. Only one of &#39;retention_window_days&#39; and &#39;retention_strategy&#39; may be set.
    /// * REMOVE_AFTER_CONVERSATION: Removes data when the conversation ends. If there is no conversation explicitly established, a default conversation ends when the corresponding Dialogflow session ends. Possible values: [&amp;quot;REMOVE_AFTER_CONVERSATION&amp;quot;]
    /// </summary>
    [TerraformPropertyName("retention_strategy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RetentionStrategy { get; set; }

    /// <summary>
    /// Retains the data for the specified number of days. User must set a value lower than Dialogflow&#39;s default 365d TTL (30 days for Agent Assist traffic), higher value will be ignored and use default. Setting a value higher than that has no effect. A missing value or setting to 0 also means we use default TTL.
    /// Only one of &#39;retention_window_days&#39; and &#39;retention_strategy&#39; may be set.
    /// </summary>
    [TerraformPropertyName("retention_window_days")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RetentionWindowDays { get; set; }

    /// <summary>
    /// Block for audio_export_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AudioExportSettings block(s) allowed")]
    [TerraformPropertyName("audio_export_settings")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxSecuritySettingsAudioExportSettingsBlock>>? AudioExportSettings { get; set; }

    /// <summary>
    /// Block for insights_export_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InsightsExportSettings block(s) allowed")]
    [TerraformPropertyName("insights_export_settings")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxSecuritySettingsInsightsExportSettingsBlock>>? InsightsExportSettings { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDialogflowCxSecuritySettingsTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The unique identifier of the settings.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/securitySettings/&amp;lt;Security Settings ID&amp;gt;.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

}
