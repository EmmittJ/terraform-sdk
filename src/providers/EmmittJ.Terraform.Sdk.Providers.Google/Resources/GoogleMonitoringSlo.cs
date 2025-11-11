using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for basic_sli in .
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringSloBasicSliBlock
{
    /// <summary>
    /// An optional set of locations to which this SLI is relevant.
    /// Telemetry from other locations will not be used to calculate
    /// performance for this SLI. If omitted, this SLI applies to all
    /// locations in which the Service has activity. For service types
    /// that don&#39;t support breaking down by location, setting this
    /// field will result in an error.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Location { get; set; }

    /// <summary>
    /// An optional set of RPCs to which this SLI is relevant.
    /// Telemetry from other methods will not be used to calculate
    /// performance for this SLI. If omitted, this SLI applies to all
    /// the Service&#39;s methods. For service types that don&#39;t support
    /// breaking down by method, setting this field will result in an
    /// error.
    /// </summary>
    [TerraformPropertyName("method")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Method { get; set; }

    /// <summary>
    /// The set of API versions to which this SLI is relevant.
    /// Telemetry from other API versions will not be used to
    /// calculate performance for this SLI. If omitted,
    /// this SLI applies to all API versions. For service types
    /// that don&#39;t support breaking down by version, setting this
    /// field will result in an error.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Version { get; set; }

}

/// <summary>
/// Block type for request_based_sli in .
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringSloRequestBasedSliBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleMonitoringSloTimeoutsBlock
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
/// Block type for windows_based_sli in .
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringSloWindowsBasedSliBlock
{
    /// <summary>
    /// A TimeSeries [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters)
    /// with ValueType = BOOL. The window is good if any true values
    /// appear in the window. One of &#39;good_bad_metric_filter&#39;,
    /// &#39;good_total_ratio_threshold&#39;, &#39;metric_mean_in_range&#39;,
    /// &#39;metric_sum_in_range&#39; must be set for &#39;windows_based_sli&#39;.
    /// </summary>
    [TerraformPropertyName("good_bad_metric_filter")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GoodBadMetricFilter { get; set; }

    /// <summary>
    /// Duration over which window quality is evaluated, given as a
    /// duration string &amp;quot;{X}s&amp;quot; representing X seconds. Must be an
    /// integer fraction of a day and at least 60s.
    /// </summary>
    [TerraformPropertyName("window_period")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? WindowPeriod { get; set; }

}

/// <summary>
/// Manages a google_monitoring_slo resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleMonitoringSlo : TerraformResource
{
    public GoogleMonitoringSlo(string name) : base("google_monitoring_slo", name)
    {
    }

    /// <summary>
    /// A calendar period, semantically &amp;quot;since the start of the current
    /// &amp;lt;calendarPeriod&amp;gt;&amp;quot;. Possible values: [&amp;quot;DAY&amp;quot;, &amp;quot;WEEK&amp;quot;, &amp;quot;FORTNIGHT&amp;quot;, &amp;quot;MONTH&amp;quot;]
    /// </summary>
    [TerraformPropertyName("calendar_period")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CalendarPeriod { get; set; }

    /// <summary>
    /// Name used for UI elements listing this SLO.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The fraction of service that must be good in order for this objective
    /// to be met. 0 &amp;lt; goal &amp;lt;= 0.999
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Goal is required")]
    [TerraformPropertyName("goal")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Goal { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// A rolling time period, semantically &amp;quot;in the past X days&amp;quot;.
    /// Must be between 1 to 30 days, inclusive.
    /// </summary>
    [TerraformPropertyName("rolling_period_days")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RollingPeriodDays { get; set; }

    /// <summary>
    /// ID of the service to which this SLO belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformPropertyName("service")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Service { get; set; }

    /// <summary>
    /// The id to use for this ServiceLevelObjective. If omitted, an id will be generated instead.
    /// </summary>
    [TerraformPropertyName("slo_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SloId { get; set; } = default!;

    /// <summary>
    /// This field is intended to be used for organizing and identifying the AlertPolicy
    /// objects.The field can contain up to 64 entries. Each key and value is limited
    /// to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values
    /// can contain only lowercase letters, numerals, underscores, and dashes. Keys
    /// must begin with a letter.
    /// </summary>
    [TerraformPropertyName("user_labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? UserLabels { get; set; }

    /// <summary>
    /// Block for basic_sli.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BasicSli block(s) allowed")]
    [TerraformPropertyName("basic_sli")]
    public TerraformList<TerraformBlock<GoogleMonitoringSloBasicSliBlock>>? BasicSli { get; set; }

    /// <summary>
    /// Block for request_based_sli.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RequestBasedSli block(s) allowed")]
    [TerraformPropertyName("request_based_sli")]
    public TerraformList<TerraformBlock<GoogleMonitoringSloRequestBasedSliBlock>>? RequestBasedSli { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleMonitoringSloTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for windows_based_sli.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WindowsBasedSli block(s) allowed")]
    [TerraformPropertyName("windows_based_sli")]
    public TerraformList<TerraformBlock<GoogleMonitoringSloWindowsBasedSliBlock>>? WindowsBasedSli { get; set; }

    /// <summary>
    /// The full resource name for this service. The syntax is:
    /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

}
